using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Collections;
using System.Drawing.Printing;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;
using System.Reflection;
namespace WindowsFormsApplication1
{
    public partial class Facture : Form
    {
        string var;
        int id;
        string re;
        public string ref_fact;
        public bool btn_fact_clic = false;
        public bool bt_modif_click = false;
        public Facture()
        {
            InitializeComponent();
           creer_cols();
           comboArticle.SelectedIndexChanged -= new EventHandler(comboArticle_SelectedIndexChanged);
           if (btn_fact_clic == false)
           {
               remplir_combo_article();
               btn_fact_clic = true;
           }
           comboArticle.SelectedIndexChanged += new EventHandler(comboArticle_SelectedIndexChanged);
           select_id_fact();
           comboBox1.SelectedIndexChanged -= new EventHandler(comboBox1_SelectedIndexChanged);
           remplir_combo_client();
           comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }
   
        public Facture(string var, string ref_fact) : this()
        {

            this.var = var;
            this.ref_fact = ref_fact;
            remplir_GVD();
            txtRef.Text = ref_fact;
            btnAjout.Enabled = false;
            comboArticle.SelectedIndexChanged -= new EventHandler(comboArticle_SelectedIndexChanged);
            if (btn_fact_clic == false)
            {
                remplir_combo_art(dataGridView1.Rows[0].Cells["ID"].Value.ToString());
                btn_fact_clic = true;
            }
            comboArticle.SelectedIndexChanged += new EventHandler(comboArticle_SelectedIndexChanged);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (bt_modif_click == true)
            {
                string id_lf = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["id_LF"].Value.ToString();
                string remise = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Remise"].Value.ToString();
                string qte = dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells["Quantite"].Value.ToString();

                string req = "UPDATE LIGNES_FACTURE SET Quantite=" + qte + ", Taux_Remise=" + remise + " WHERE ID=" + id_lf;
                Conexion.executer_cmd(req);
                MessageBox.Show("modification fait avec succé");
            }
            else if(ref_fact==null)
            {
                id++;
                string idd = Convert.ToString("FA-0000" + Convert.ToString(id));
                if (dataGridView1.Rows[0].Cells[0].Value != null)
                {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        SqlConnection con = Conexion.getConexion();
                        SqlCommand cmd = new SqlCommand();
                        con.Open();
                        cmd.Connection = con;
                        cmd.CommandType = CommandType.StoredProcedure; cmd.CommandText = "Ajout_Facture";

                        cmd.Parameters.AddWithValue("@ref", dataGridView1.Rows[i].Cells[1].Value);

                        cmd.Parameters.AddWithValue("@prixht", dataGridView1.Rows[i].Cells["col7"].Value);
                        cmd.Parameters.AddWithValue("@prixttc", dataGridView1.Rows[i].Cells["col8"].Value);
                        cmd.Parameters.AddWithValue("@Tremise", dataGridView1.Rows[i].Cells["col5"].Value);
                        cmd.Parameters.AddWithValue("@id_tva", dataGridView1.Rows[i].Cells["col4"].Value);
                     cmd.Parameters.AddWithValue("@id_tiers", dataGridView1.Rows[i].Cells["col0"].Value);
                        cmd.Parameters.AddWithValue("@date", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        con.Close();
                    }
                }
                MessageBox.Show("Ajout nouvelle facture fait avec succé");
            }
        }
        public void remplir_GVD()
        {
            remove_col();
            string req = "select ar.ID, Ar.AR_REF as Reference, Ar.AR_Design as Designation, Ar.AR_PrixVente as Prix_Vente,TV.Taux as TVA,LF.Taux_Remise as Remise, LF.Quantite , LF.Prix_HT as PrixHT,LF.Prix_TTC as PixHTT, LF.ID as id_LF "+
                "from MM_Tiers T, LIGNES_FACTURE LF, MM_Facture F, MM_ARTICLE Ar, TVA TV"+
                " WHERE LF.ID_Article=Ar.ID and LF.ID_Facture=F.ID and LF.ID_TVA=TV.ID and F.ID_Tiers=T.ID and T.ID='" + var + "'"; 
     
            DataTable dt = Conexion.execute_dt(req, "table");

            dataGridView1.DataSource = dt;
            if (dataGridView1.Columns["ID"] != null && dataGridView1.Columns["id_LF"] != null)
            {
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["id_LF"].Visible = false;
            }
        }
       public void remplir_combo_article()
        {
          //  string req = "select T.ID ,Ref as Reference,t.Code +'-'+ Caption as Tiers, PrixHT, PrixTTC, M.DateCreation as Date from MM_Facture M , MM_TIERS T WHERE T.ID=M.ID_Tiers";
            string req = "select distinct m.AR_Ref+'-'+m.AR_Design as Design , m.ID  from MM_Article m ";//LIGNES_FACTURE lf, MM_Facture f, MM_DEPOT d where m.ID=lf.ID_Article and lf.ID_Facture=f.ID and lf.ID_Facture=f.ID and m.ID_DEPOT=d.ID";
            DataTable dt = Conexion.execute_dt(req, "tb");

           
                comboArticle.DataSource = dt;
                comboArticle.DisplayMember = "Design";
                comboArticle.ValueMember = "ID";
              
            
        }
        void remplir_combo_TVA( string id)
        {
            string req = "select t.ID, t.Code from TVA t, MM_ARTICLE ar where ar.ID_TVA=t.ID and ar.ID="+id;
            DataTable dt = Conexion.rempli_cobo(req, cmbTva);
            cmbTva.DataSource = dt;
            cmbTva.DisplayMember = "Code";
            cmbTva.ValueMember = "ID";



        }
        public void select_id_fact()
        { 
        string req="Select max(Ref) as ref from MM_Facture";
        DataTable dt = Conexion.execute_dt(req, "tb");
       re = dt.Rows[0][0].ToString();
       txtRef.Text = re;
    id = Convert.ToInt32(re.Substring(7));
            
        }
        public void creer_cols()
        {
            dataGridView1.Columns.Add("col0", "Id");
            dataGridView1.Columns.Add("col1", "Reference");
            dataGridView1.Columns.Add("col2", "Designation");
            dataGridView1.Columns.Add("col3", "Prix_Vente");
            dataGridView1.Columns.Add("col4", "TVA");
            dataGridView1.Columns.Add("col5", "Remise");
            dataGridView1.Columns.Add("col6", "Quantité");
            dataGridView1.Columns.Add("col7", "PrixHT");
            dataGridView1.Columns.Add("col8", "PrixTTC");
          
            dataGridView1.Columns[0].Visible = false;
          
        }
        public void remove_col()
        {
            dataGridView1.Columns.Remove("col0");
            dataGridView1.Columns.Remove("col1");
            dataGridView1.Columns.Remove("col2");
            dataGridView1.Columns.Remove("col3");
            dataGridView1.Columns.Remove("col4");
            dataGridView1.Columns.Remove("col5");
            dataGridView1.Columns.Remove("col6");
            dataGridView1.Columns.Remove("col7");
            dataGridView1.Columns.Remove("col8");
     
        }
        public void remplir_combo_client()
        {
            comboBox1.SelectedIndexChanged -= new EventHandler(comboBox1_SelectedIndexChanged);
            string req2 = "select distinct Caption, ID from MM_TIERS ";//T, MM_Facture M where T.ID=M.ID_Tiers";
            DataTable dtable = Conexion.rempli_cobo(req2, comboBox1);
            comboBox1.DataSource = dtable;
            comboBox1.DisplayMember = "Caption";
            comboBox1.ValueMember = "ID";
            comboBox1.SelectedIndexChanged += new EventHandler(comboBox1_SelectedIndexChanged);
        }
        private void Facture_Load(object sender, EventArgs e)
        { 
            
            txtDate.Text = DateTime.Now.ToShortDateString();


          
                 comboBox1.SelectedItem = var;
             
           
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        public void remplir_combo_art(string idd)
        {
            string req = "select distinct ID, AR_Ref+'-'+AR_Design as Des from MM_ARTICLE where ID=" + idd;
            DataTable dt = Conexion.execute_dt(req, "tb");
            comboArticle.DataSource = dt;
            comboArticle.DisplayMember = "Des";
            comboArticle.ValueMember = "ID";

        
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            remplir_combo_art(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
        
            string res = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            
            comboArticle.DisplayMember = res;
            txtPrix.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
           string com2=dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
         
           
        //    remplir_combo_TVA();
            txtRemise.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtQte.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
           // txtPrix.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();

        }

        double ttc;
        double ht;
        private void btnAjout_Click(object sender, EventArgs e)
        {

            id++;
            string req = "select AR_Ref+'-'+AR_Design as Design ,ID  from MM_Article where ID=" + comboArticle.SelectedValue+"";
            DataTable dt = Conexion.execute_dt(req, "tb");

             ht = Convert.ToDouble(txtPrix.Text) * Convert.ToDouble(txtQte.Text);
            int tv = Convert.ToInt16(cmbTva.SelectedValue);
            if (tv == 1)
                ttc = ht + (ht * 18) / 100 ;
            else
                ttc = ht + (ht * 12) / 100;
            dataGridView1.Rows.Add(comboBox1.SelectedValue, "FA-0000" + id, dt.Rows[0][0].ToString(), txtPrix.Text, cmbTva.SelectedValue, txtRemise.Text, txtQte.Text, ht, ttc);
         
            if (txtTotalHt.Text == "" || txtTotalTTC.Text == "")
            {
                txtTotalHt.Text = ht.ToString();
                txtTotalTTC.Text = ttc.ToString();
            }
            else
            {
                double v = Convert.ToDouble(txtTotalHt.Text);
                double v1 = Convert.ToDouble(txtTotalTTC.Text);
                txtTotalHt.Text = (ht + v).ToString();
                txtTotalTTC.Text = (ttc + v1).ToString();
               
            }
           
     
        }





        private void comboArticle_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            string req = "select m.ID, m.AR_Ref+'-'+m.AR_Design as descr, tv.Code, AR_PrixVente from MM_ARTICLE m,TVA tv  where m.ID=" + comboArticle.SelectedValue + " and tv.ID=m.ID_TVA";

            DataTable dt = Conexion.execute_dt(req, "Tb");
            if (dt.Rows.Count > 0)
            {
                txtPrix.Text = dt.Rows[0]["AR_PrixVente"].ToString();
               
            }
            else
                txtPrix.Text = "";
            remplir_combo_TVA(comboArticle.SelectedValue.ToString());
       
            //comboArticle.SelectionStart = 1;
      

        
    
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
          
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           // remplir_GVD();
         
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[5].Value = txtRemise.Text;
            dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[6].Value = txtQte.Text;
            bt_modif_click = true;

        }
        
        private void btnImp_Click(object sender, EventArgs e)
        {
            /*PrintPreviewDialog objPPdialog = new PrintPreviewDialog();
            objPPdialog.Document = printDocument1 ;
            objPPdialog.ShowDialog();*/
          //  printDocument1.Print();
            exportPDF();
        }
       
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {            
        }
      
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        { 
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new System.Drawing.Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height+400));
            e.Graphics.DrawImage(bm, 0, 0);



         
       
        }

        private void btn_ajout_MouseHover(object sender, EventArgs e)
        
        {
          ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btn_ajout, "Nouvelle");
           
        }

        private void btn_supp_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(btn_supp, "Supprimer");
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(btnSave, "Enregistrer");
        }

      

        private void Facture_FormClosed(object sender, FormClosedEventArgs e)
        {
          
            
        }



        public void exportPDF()
        {
            PdfPTable pdfTable = new PdfPTable(dataGridView1.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;
            PdfString ps = new PdfString();
            Phrase PhraseContent = new Phrase("Facture a imprimer");
            PdfPCell cel;
            PdfPTable table = new PdfPTable(dataGridView1.ColumnCount);
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // pdfTable.AddCell(cell.Value.ToString());
                   // PhraseContent.Add(cell.Value.ToString());
                 
                    cel = new PdfPCell(new Phrase("aaaaaaaaaaaaaaaaa"));
                    cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
                    
              table.AddCell(cel);  }
            }
           
            table.WidthPercentage = 100;
          //  PdfPCell cel;

           // cel = new PdfPCell(new Phrase("aaaaaaaaaaaaaaaaa"));
          // cel.Border = iTextSharp.text.Rectangle.NO_BORDER;
           // table.AddCell(cel);
      
            string folderPath = "E:/PDFs/";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "FactureExport.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A2, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
               /* pdfPage myPage = myDoc.addPage();
                myPage.addText("Hello World!", 200, 450, predefinedFont.csHelvetica, 20);*/
               // pdfDoc.Close();
                stream.Close();
            }
        }

       

        private void btnImp_MouseHover(object sender, EventArgs e)
        {
            ToolTip tp = new ToolTip();
            tp.SetToolTip(btnImp, "Imprimer");
        }
       
    }
}
