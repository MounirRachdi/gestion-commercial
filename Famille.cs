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
    public partial class Famille : Form
    {
        public Famille()
        {
            InitializeComponent();
        }

        public bool tester()
        {
            if (textBox1.Text == "" || txtCode.Text == "")
            {
                
             
                return false;
            }
            else
                return
                    true;
        
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            if (tester())
            {
                DialogResult res;
                SqlConnection con = new SqlConnection();
                con = Conexion.getConexion();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = con;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Ajout_Famille";
                cmd.Parameters.AddWithValue("@code", txtCode.Text);
                cmd.Parameters.AddWithValue("@design", textBox1.Text);
                cmd.Parameters.AddWithValue("@date_creation", DateTime.Now);
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    res = MessageBox.Show("Ajout avec succé !", "Insertion", MessageBoxButtons.OK);
                    if (res == DialogResult.OK)
                    {
                        txtCode.Text = string.Empty;
                        textBox1.Text = string.Empty;
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    cmd.Dispose();
                    con.Dispose();
                    con.Close();
                }
            }
            else
                MessageBox.Show("Champ obligatoire ");
        }

        private void Famille_Load(object sender, EventArgs e)
        {

        }

       
       
    }
}
