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
namespace WindowsFormsApplication1
{
    public partial class Article : Form
    {
        public Article()
        {
            InitializeComponent();
        }
        public void remplir_combo1()
        {
            string req = "select ID, Design from MM_Famille";
         
     DataTable tb=Conexion.rempli_cobo(req,comboFamille);
     comboFamille.DataSource = tb;
     comboFamille.DisplayMember = "Design";
     comboFamille.ValueMember = "ID";
           
        
        }
        public void remplir_combo2()
        {
            string req = "select * from MM_DEPOT";
            DataTable tb = Conexion.rempli_cobo(req, comboDepot);
            comboDepot.DataSource = tb;
            comboDepot.DisplayMember = "CAPTION";
            comboDepot.ValueMember = "ID";
        
        }
        public void rempli_comboTva()
        {
            string req = "select ID, Code from TVA";
            DataTable dt = Conexion.execute_dt(req, "tb");
            comboTVA.DataSource = dt;
            comboTVA.DisplayMember = "Code";
            comboTVA.ValueMember = "ID";

        }
        private void Ajout_Article_Load(object sender, EventArgs e)
        {
            remplir_combo1();
            remplir_combo2();
            rempli_comboTva();
        }
        public void ajout_art()
        {
            SqlConnection con = Conexion.getConexion();
            SqlCommand cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "Ajout_Article";
            cmd.Parameters.AddWithValue("@ref", txtRef.Text);
            cmd.Parameters.AddWithValue("@des", TxtInt.Text);
            cmd.Parameters.AddWithValue("@id_famille", comboFamille.SelectedValue);
            cmd.Parameters.AddWithValue("@id_depot", comboDepot.SelectedValue);
            cmd.Parameters.AddWithValue("@id_tva", comboTVA.SelectedValue);
            cmd.Parameters.AddWithValue("@prix_achat", txtPrix_Achat.Text);
            cmd.Parameters.AddWithValue("@prix_vente", txtPrix_Vente.Text);
            cmd.Parameters.AddWithValue("@Qte_stock", txtStock.Text);
            cmd.Parameters.AddWithValue("@date_creation", DateTime.Now);
            try
            {
                
                cmd.ExecuteNonQuery();
                DialogResult res;
                res = MessageBox.Show("Ajouter ajouter avec succé", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (res == DialogResult.OK)
                {
                   
                    this.Close();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur d'insertion des données " + ex.Message);
            }


            
        
        }
        public bool verif()
        {
            if (txtRef.Text == "" || TxtInt.Text == "" || txtStock.Text == "" || txtPrix_Achat.Text == "" || txtPrix_Vente.Text == "")
                return false;
            else
                return true;
        
        }
        private void button1_Click(object sender, EventArgs e)
        {
          //  MessageBox.Show("val1==="+comboFamille.SelectedValue +"val2="+comboDepot.SelectedValue);
            if (verif())
                ajout_art();
            else
                MessageBox.Show("Tous les champ sont obligatoires", "Verif", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
