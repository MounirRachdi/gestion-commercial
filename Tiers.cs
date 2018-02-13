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
using System.Reflection;

namespace WindowsFormsApplication1
{
    public partial class Tiers : Form
    {
        int type;
        string id;
        public Tiers(TextBox code, TextBox caption, string id) : this()
        {
            txtCode.Text = code.Text;
            txt_caption.Text = caption.Text;
           this.id=id;
          
       //    InitializeComponent();
        }
        public Tiers()
        {

            InitializeComponent();
        }
        public bool test()
        {
            if (txtCode.Text == "" || txt_caption.Text == "")
                return false;
            else
                return true;
        }
        private void button1_Click(object sender, EventArgs e)
        {

            if (!test())
                MessageBox.Show("le code est obligatoire");
            else
            {

                if (comboBox1.SelectedItem.ToString()== "Client")
                    type = 1;
                else
                    type = 2;
                SqlConnection con = new SqlConnection();
                con = Conexion.getConexion();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ajout_Tiers";
                cmd.Connection = con;
                cmd.Parameters.AddWithValue("@Caption", txt_caption.Text);
                cmd.Parameters.AddWithValue("@Code", txtCode.Text);
                cmd.Parameters.AddWithValue("@Type", type);
                cmd.Parameters.AddWithValue("@eMail", txtMail.Text);
                cmd.Parameters.AddWithValue("@Qualite", comboBox2.SelectedItem);
                cmd.Parameters.AddWithValue("@Adresse", txtAdresse.Text);
                cmd.Parameters.AddWithValue("@DateCreation", DateTime.Now);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    DialogResult res;
                    res = MessageBox.Show("Tiers ajouter avec succé", "Insert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (res == DialogResult.OK)
                    {
                        vider();
                        this.Close();


                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
                finally
                {
                    con.Dispose();
                    cmd.Dispose();
                    con.Close();
                }

            }
           // @Caption,@Code,@Type,@eMail,@Qualite,@Adresse,@DateCreation
           
        }
        public void vider()
        {
            txt_caption.Text = string.Empty;
            txtAdresse.Text = string.Empty;
            txtCode.Text = string.Empty;
            txtMail.Text = string.Empty;

        
        }
        private void btn_supp_Click(object sender, EventArgs e)
        {
            if (id != null)
            {
                string req = "delete from MM_TIERS where ID=" + id;
                Conexion.executer_cmd(req);
                MessageBox.Show("Tiers supprimer avec succé");
            }
           
        }

       

        private void btn_plus_Click(object sender, EventArgs e)
        {
            Select sl = new Select();
            sl.Show();
           this.Close();
         

        }

        private void Tiers_Load(object sender, EventArgs e)
        {
            if (txtCode.Text != "" && txt_caption.Text!= "")
                button1.Text = "Modifier";
           
           
        }

        private void btn_ajout_Click(object sender, EventArgs e)
        {

        }

        private void btn_ajout_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btn_ajout, "Nouvelle");
        }

        private void btn_supp_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.btn_supp, "Supprimer");
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            ToolTip ToolTip1 = new ToolTip();
            ToolTip1.SetToolTip(this.button1, "Enregistrer");
        }
        
        
    }
}
