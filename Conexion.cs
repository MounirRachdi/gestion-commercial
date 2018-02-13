using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
//using System.Windows.Controls;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    class Conexion
    { static BindingSource b1 = new BindingSource();
        public static SqlConnection  getConexion()
    {
        //string Strc = WindowsFormsApplication1.Properties.Settings.Default.Database1ConnectionString;
        string Strc = WindowsFormsApplication1.Properties.Settings.Default.MM_DataBaseConnectionString;
        SqlConnection con= new SqlConnection(Strc);
        return con;

    }
        
        public static DataTable execute_dt(string req, string table)
        {
            

            SqlConnection cnx = getConexion();
            SqlDataAdapter da = new SqlDataAdapter(req, cnx);
            DataSet ds = new DataSet();
            da.Fill(ds, table);
            DataTable dt=ds.Tables[table];
        
           
            return dt;

        }
        public static DataTable rempli_cobo(string req, ComboBox combo)
        {
            SqlConnection cn = getConexion();
            cn.Open();
            SqlDataAdapter da = new SqlDataAdapter(req, cn);
            //SqlCommand cmd = new SqlCommand(req2, cn);
            // SqlDataReader dr = cmd.ExecuteReader();
            // cb.DataSource = dr;
            DataSet ds = new DataSet();
            da.Fill(ds, "table");
            DataTable dtable = ds.Tables["table"];

            return dtable;
            
     
        
        }
        public static void executer_cmd(string sql)
        {
            SqlConnection cn = new SqlConnection();
            cn = getConexion();
          /* int nbligne;
            try
            {*/
                cn.Open();
                SqlCommand cmd = new SqlCommand(sql, cn);
              cmd.ExecuteNonQuery();
               
           /* }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }*/

        }
        public static void remplire_grid(string req, DataGridView gd)
        {

            SqlConnection cn = new SqlConnection();
            cn = getConexion();
            cn.Open();
            //SqlCommand cmd = new SqlCommand(req, cn);
            SqlDataAdapter da = new SqlDataAdapter(req, cn);
            DataSet ds = new DataSet();
            da.Fill(ds, "table");
            DataTable dtable = ds.Tables["table"];
        
            gd.DataSource = dtable;
            // gd.DataBind();
            //dr.Close();
            cn.Close();
          

        }
    }
  
}
