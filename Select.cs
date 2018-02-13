using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Select : Form
    {
        public static int row;
        public Select()
        {
            InitializeComponent();
        }

        private void Select_Load(object sender, EventArgs e)
        {
            string req = "select distinct Code, Caption as Design, ID from MM_TIERS";
            DataTable dt = Conexion.execute_dt(req, "tb");
            dataGridView1.DataSource = dt;
           if (dataGridView1.Columns["ID"] != null)
                dataGridView1.Columns["ID"].Visible = false;

        }

      

       /* private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           // int column = e.ColumnIndex;
             row = e.RowIndex;

            
            //string code = dataGridView1.Rows[row].Cells[0].Value.ToString();
            //string caption = dataGridView1.Rows[row].Cells[1].Value.ToString();
            //Tiers tier = new Tiers(code, caption);
            //tier.Show();
            //this.Close();

        }
        */
       
    

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            TextBox code = new TextBox();
            TextBox caption = new TextBox();
            string id;
            row = e.RowIndex;
            code.Text = dataGridView1.Rows[row].Cells[0].Value.ToString();
            caption.Text = dataGridView1.Rows[row].Cells[1].Value.ToString();
            id = dataGridView1.Rows[row].Cells[2].Value.ToString();
            Tiers tier = new Tiers(code, caption,id);
            tier.Show();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string req = "select Code, Caption as Design, ID from MM_TIERS where Code like '" + textBox1.Text +"%'" ;
            DataTable dt = Conexion.execute_dt(req, "tb");
            dataGridView1.DataSource = dt;
            if (dataGridView1.Columns["ID"] != null)
                dataGridView1.Columns["ID"].Visible = false;
        }
    }
}
