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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
           
            if (textBox1.Text == "mimo" && textBox2.Text == "1992")        
            {    
                Form1 frm = new Form1();
                
                frm.Show();
                this.Visible = false;
              
        }
            else
                MessageBox.Show("Verifier vos paramettre de connexion","Erreur",MessageBoxButtons.OK,MessageBoxIcon.Error);
            
           
        }
    }
}
