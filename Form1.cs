using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Controls;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Reflection;
using Excel = Microsoft.Office.Interop.Excel;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.IO;




namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        int nbart_click = 1;
        int nbtir_click = 1;
        int nbfact_click = 1;
        string id;
        bool btn_fact_clic = false;
        string id_fact;

        private void Client_Click(object sender, EventArgs e)
        {
            if (!tabControl3.TabPages.Contains(tabPage6))
            
                tabControl3.TabPages.Add(tabPage6);
               
            
            tabControl3.SelectTab(tabPage6);
            remplir_grid();
            if (DGV_Client.Columns["ID"] != null)
                DGV_Client.Columns["ID"].Visible = false;
        }

     

        private void tabControl2_MouseLeave(object sender, EventArgs e)
        {
            
        }

        public void remplir_grid()
        {

            DataTable dt = Conexion.execute_dt("select ID, Code, Caption, Adresse, Qualite, eMail "+
   " from MM_TIERS where Type=1", "tb");
            DGV_Client.DataSource = dt;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
           
            //this.mM_TIERSTableAdapter1.Fill(this.mM_DataBaseDataSet1.MM_TIERS);
           
           
         
           
            splitContainer1.Panel1.ResetText();
            splitContainer1.Panel2.ResetText();
            groupBox1.Hide();
            groupBox.Hide();
            groupBox2.Hide();
            remove();
            

           
        }
        public void remove()
        {

            tabControl3.TabPages.Remove(tabPage6);
            tabControl3.TabPages.Remove(tabPage7);

            tabControl3.TabPages.Remove(ArticlePage);
            tabControl3.TabPages.Remove(ArtPage);
            tabControl3.TabPages.Remove(tabPageFacture);
            tabControl3.TabPages.Remove(tabPageTVA);
tabControl3.TabPages.Remove(tabPage_DEPOT);
        
        }
        private void btn_article_Click(object sender, EventArgs e)
        {
            if (nbart_click == 1)
            {

                groupBox.Show();
            nbart_click= 2;
            }
            else
            {

                groupBox.Hide();
             nbart_click = 1;
            }
       
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      

        private void btn_Tires_Click(object sender, EventArgs e)
        {
          
            if (nbtir_click == 1)
            {
                groupBox1.Show();
                nbtir_click = 2;}
            else
           
            {
                groupBox1.Hide();
                nbtir_click = 1;
            }
          

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (nbfact_click == 1)
            {
                groupBox2.Show();
                nbfact_click = 2;
            }
            else
            {
                groupBox2.Hide();
                nbfact_click = 1;
            }

        }

        private void Four_Btn_Click(object sender, EventArgs e)
        {
            if (!tabControl3.TabPages.Contains(tabPage7))
               
            
            
                tabControl3.TabPages.Add(tabPage7);
                tabControl3.SelectTab(tabPage7);

                DataTable dt = Conexion.execute_dt("select Code, Caption, Adresse, Qualite, eMail from MM_TIERS where Type=2", "tb");
                    
                DGV_Four.DataSource = dt;
               
         
           
            
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Tiers TR = new Tiers();
            TR.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Facture fct = new Facture();
           
            fct.Show();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Tiers TR = new Tiers();
            TR.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Tiers TR = new Tiers();
            TR.Show();
        }

        

        private void Famil_art_btn_Click(object sender, EventArgs e)
        {
            string req = "select CodeFamille as Code, Design as Designation from MM_Famille";
           
            if (!tabControl3.TabPages.Contains(ArtPage))
            tabControl3.TabPages.Add(ArtPage);

            
            tabControl3.SelectTab(ArtPage);
            DataTable dt = Conexion.execute_dt(req, "tb");
            GV_Famille.DataSource = dt;
                
                
            
        }
        void rempir_DGV_Art()
        {
            string req = "select ar.ID, ar.AR_Ref as Ref, ar.AR_Design as Designation, f.Design as Famille,  d.CAPTION as Depot from MM_ARTICLE ar, MM_Famille f, MM_DEPOT d " +
                   "where ar.ID_FAMILLE= f.ID and ar.ID_DEPOT=d.ID ";
            DataTable dt = Conexion.execute_dt(req, "tb");
            DGV_ART.DataSource = dt;
            
        }
        private void Article_Btn_Click(object sender, EventArgs e)
        {
           
            if (!tabControl3.TabPages.Contains(ArticlePage))
            
                tabControl3.TabPages.Add(ArticlePage);
                tabControl3.SelectTab(ArticlePage);

                rempir_DGV_Art();
         
                
                if (DGV_ART.Columns["ID"]!=null)
                DGV_ART.Columns["ID"].Visible = false;
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            Tiers tr = new Tiers();
            tr.Show();
        }

        private void TVA_BTN_Click(object sender, EventArgs e)
        {
            string req = "select * from TVA";
            if (!tabControl3.TabPages.Contains(tabPageTVA))
                tabControl3.TabPages.Add(tabPageTVA);
            tabControl3.SelectTab(tabPageTVA);
            DataTable dt = Conexion.execute_dt(req, "tb");
            DGV_TVA.DataSource = dt;


        }

        private void btn_Fact_Click(object sender, EventArgs e)
        {
            remove();
            string req2 = "select distinct Code+'-'+Caption as caption, T.ID from MM_TIERS T, MM_Facture M where T.ID=M.ID_Tiers";
            DataTable dtable = Conexion.execute_dt(req2, "tb");

            if (btn_fact_clic==false)
            {
                comboBox1.DataSource = dtable;
                comboBox1.DisplayMember = "caption";
                comboBox1.ValueMember = "ID";
           
                btn_fact_clic = true;
            }
            if (!tabControl3.TabPages.Contains(tabPageFacture))
                tabControl3.TabPages.Add(tabPageFacture);
            tabControl3.SelectTab(tabPageFacture);
            remplir_DGV1();
        }

        private void button16_Click(object sender, EventArgs e)
        {
       
            Famille fm = new Famille();
      
              fm.Show();
      
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            remplir_grid();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string req = "delete from MM_TIERS where ID=" + id;
            SqlConnection con;
            con = Conexion.getConexion();
            con.Open();
            SqlCommand cmd = new SqlCommand(req, con);

            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Tiers supprimer avec succée");
                remplir_grid();
            }
            else
                MessageBox.Show("ereeeeeeuuuuuuur");

            
        }
        public void remplir_DGV1()
        {
            string req = "select T.ID ,Ref as Reference,t.Code +'-'+ Caption as Tiers, PrixHT as PrixHT, PrixTTC as PrixTTc, M.DateCreation as Date from MM_Facture M , MM_TIERS T WHERE T.ID=M.ID_Tiers";
            DataTable dt = Conexion.execute_dt(req, "tb");
            DGV_Fact.DataSource = dt;
            if (DGV_Fact.Columns["ID"] != null)
                DGV_Fact.Columns["ID"].Visible = false;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                comboBox1.Enabled = true;
            else
            {
                remplir_DGV1();
            
            comboBox1.Enabled = false;}
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


            string req = "select T.ID, Ref as Reference,Caption, PrixHT, PrixTTC, M.DateCreation from MM_Facture M , MM_TIERS T WHERE T.ID=M.ID_Tiers and T.ID=" + comboBox1.SelectedValue + "";
            DataTable dt = Conexion.execute_dt(req, "tb");
            DGV_Fact.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = DGV_Client.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

      

        private void DGV_Fact_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            id_fact = DGV_Fact.Rows[e.RowIndex].Cells["ID"].Value.ToString();
          
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string req = "delete from MM_Facture where Code='"+ id_fact+"'";
            Conexion.executer_cmd(req);
        }

        private void DGV_Fact_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
             
            string var = DGV_Fact.Rows[e.RowIndex].Cells["ID"].Value.ToString();
            string ref_fact = DGV_Fact.Rows[e.RowIndex].Cells["Reference"].Value.ToString();
            Facture fact = new Facture(var,ref_fact);
            fact.Show();
           // this.Enabled = false;
           
       
           
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void Depot_btn_Click(object sender, EventArgs e)
        {
            remove();
            string req2 = "select ID, CODE, CAPTION, DATE_CREATION, DATE_MODIFICATION FROM MM_DEPOT";        
           
            if (!tabControl3.TabPages.Contains(tabPage_DEPOT))
                tabControl3.TabPages.Add(tabPage_DEPOT);
            tabControl3.SelectTab(tabPage_DEPOT);
            DataTable dt = Conexion.execute_dt(req2, "tb");
            DGV_DEPOT.DataSource = dt;
            if (DGV_DEPOT.Columns["ID"] != null)
                DGV_DEPOT.Columns["ID"].Visible = false;

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Depot dep = new Depot();
            dep.Show();
        }

        private void DGV_DEPOT_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cod = null;
            string cap = null;
           string id = DGV_DEPOT.Rows[e.RowIndex].Cells["ID"].Value.ToString();
           string req = "select CODE, CAPTION from MM_DEPOT where ID='" + id+ "'";
            DataTable dt = Conexion.execute_dt(req, "tb");
            if (dt.Rows.Count > 0)
            {
           cod =dt.Rows[0]["CODE"].ToString();
              cap  =dt.Rows[0]["CAPTION"].ToString();
            
                Depot dept = new Depot(cod,cap);
                dept.Show();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            rempir_DGV_Art();
        }

        private void btn_new_Art_Click(object sender, EventArgs e)
        {
            Article ar = new Article();
            ar.Show();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Article ar = new Article();
            ar.Show();

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rapport rp = new Rapport();
            rp.Show();

        }

        private void button20_Click(object sender, EventArgs e)
        {
            Facture fct = new Facture();
            fct.Show();
         
        }
        string id_Article;
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id_Article = DGV_ART.Rows[e.RowIndex].Cells["ID"].Value.ToString(); 
        }

        private void btn_Sup_Art_Click(object sender, EventArgs e)
        {
            string req = "delete from MM_ARTICLE where ID='"+id_Article+"'";
            SqlConnection con = Conexion.getConexion();
            con.Open();
            SqlCommand cmd = new SqlCommand(req, con);
            if (cmd.ExecuteNonQuery() != 0)
            {
                MessageBox.Show("Article supprimer avec succée");
                rempir_DGV_Art();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string req = "select ID, Code, Caption, Adresse, Qualite, eMail from MM_TIERS where Type=1 and Caption like'" + textBox1.Text + "%'";
            DataTable tb = Conexion.execute_dt(req, "tb");
            DGV_Client.DataSource = tb;
        }
        
        private void button3_Click(object sender, EventArgs e)
        {

          /*  statestique st = new statestique();
           
            st.Show();*/
        }

        private void Import_Excel_Click(object sender, EventArgs e)
        {
             Excel.Application xlApp= new Excel.Application();
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            Int16 i, j;

           // xlApp = new Excel.ApplicationClass();
            xlWorkBook = xlApp.Workbooks.Add(misValue);

            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            for (i = 0; i <= DGV_ART.RowCount - 2; i++)
            {
                for (j = 0; j <= DGV_ART.ColumnCount - 1; j++)
                {
                    xlWorkSheet.Cells[i + 1, j + 1] = DGV_ART[j, i].Value.ToString();
                }
            }

            xlWorkBook.SaveAs(@"E:\Liste des articles.xls", Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
            xlWorkBook.Close(true, misValue, misValue);
            xlApp.Quit();

            releaseObject(xlWorkSheet);
            releaseObject(xlWorkBook);
            releaseObject(xlApp);
            MessageBox.Show("importation fait avec succée");
        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void btnNew_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(this.btnNew, "Nouveau");
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.ToolTip ToolTip1 = new System.Windows.Forms.ToolTip();
            ToolTip1.SetToolTip(btnRefresh, "Refresh");
        }

        private void About_btn_Click(object sender, EventArgs e)
        {
            AboutBox1 ab = new AboutBox1();
            ab.Show();
        }
        
       
        private void btn_modif_art_Click(object sender, EventArgs e)
        {

        }

        private void btnEXPORTPDF_Click(object sender, EventArgs e)
        {
            }
        
        
   

      

       

       

        
        

      

        

      

      

      
       
       

       
    }
}
