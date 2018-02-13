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
    public partial class Depot : Form
    {
        public Depot()
        {
            InitializeComponent();
        }
        public Depot(string code, string caption) : this()
            
        {
            textBox1.Text = code;
            textBox2.Text = caption;
            button1.Text = "Modifier Depot";

        }
        public bool test()
        {

            if (textBox1.Text == "" || textBox2.Text == "")
                return false;
            else
                return
                    true;
        }
        public void insert()
        {
            if (test())
            {
                
                    string ch = textBox2.Text.Substring(0, 13);
                    string req = "select * from MM_DEPOT where CAPTION like '" + ch + "%'";
                    SqlConnection con = Conexion.getConexion();
                    con.Open();
                    SqlCommand cmd = new SqlCommand(req);
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = con;

                    SqlDataReader d = cmd.ExecuteReader();

                    if (d.HasRows)
                    {
                        MessageBox.Show("intitulé existe Déja");
                        
                        d.Close();

                    }
             
                else
                {

                    d.Close();
                    SqlCommand cmd2 = new SqlCommand();
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.CommandText = "ajout_depot";
                    cmd2.Parameters.AddWithValue("@code", textBox1.Text);
                    cmd2.Parameters.AddWithValue("@caption", textBox2.Text);
                    cmd2.Parameters.AddWithValue("@date_creation", DateTime.Now);

                    try
                    {
                        cmd2.Connection = con;
                        cmd2.ExecuteNonQuery();

                        DialogResult dr;
                        dr = MessageBox.Show("Depot ajouté avec succé", "INSERTION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (dr == DialogResult.OK)
                        {
                            textBox1.Text = string.Empty;
                            textBox2.Text = string.Empty;
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
                        cmd2.Dispose();
                        con.Dispose();
                        con.Close();
                    }
                }
            }
            else
                MessageBox.Show("tous les champs sont obligatoires", "TEST", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }


        public void modifer()
        {
            string req = "update MM_DEPOT set DATE_MODIFICATION='"+DateTime.Now+"', CAPTION ='" + textBox2.Text + "' where CODE='" + textBox1.Text + "'";
            SqlConnection cnx = Conexion.getConexion();
            cnx.Open();
            SqlCommand cmd = new SqlCommand(req, cnx);
            cmd.ExecuteNonQuery();
            cnx.Close();

            DialogResult dr;
            dr = MessageBox.Show("Depot Modifier avec succé", "Modification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (dr == DialogResult.OK)
            {
                textBox1.Text = string.Empty;
                textBox2.Text = string.Empty;
                this.Close();
            }
          
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
           
            if (button1.Text == "Ajouter Depot")
            {
                insert();
            }
            else
                modifer();

        }

        private void Depot_Load(object sender, EventArgs e)
        {

        }
    }
    }