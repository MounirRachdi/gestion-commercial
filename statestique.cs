using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using Microsoft.Reporting.WinForms.Internal.Soap.ReportingServices2005.Execution;
using System.IO;


namespace WindowsFormsApplication1
{
    public partial class statestique : Form
    {
        public statestique()
        {
            InitializeComponent();
        }
        string tempPath = "C:\\Users\\Rachdi\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication1\\WindowsFormsApplication1\\Documents";
        private void Mouvement_Stock_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        
          //  this.StatestiqueTableAdapter.Fill(this.MM_DataBaseDataSet.Statestique);
            this.Statestique_clientTableAdapter.Fill(this.MM_DataBaseDataSet.Statestique_client);

            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string filenameExtension;
           
            byte[] bytes = this.reportViewer1.LocalReport.Render( "PDF", null, out mimeType, out encoding, out filenameExtension,out streamids, out warnings);
              //  out streamids, out warnings);

           
            using (FileStream fs = new FileStream("output.pdf", FileMode.Create))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

            var saveAs = string.Format("{0}.pdf", Path.Combine(tempPath, "Rapport"));
           
            var idx = 0;
            while (File.Exists(saveAs))
            {  
                
                idx++;
                saveAs = string.Format("{0}.{1}.pdf", Path.Combine(tempPath,"Rapport"), idx);
            }

            using (var stream = new FileStream(saveAs, FileMode.Create, FileAccess.Write))
            {
                stream.Write(bytes, 0, bytes.Length);
                stream.Close();
            }

        //    lr.Dispose();

           
            
        }
        void ouvrirDocument()
        {
            System.Diagnostics.ProcessStartInfo psi = new System.Diagnostics.ProcessStartInfo("C:\\Users\\Rachdi\\Documents\\Visual Studio 2010\\Projects\\WindowsFormsApplication1\\WindowsFormsApplication1\\Documents\\Rapport.PDF", "");
            System.Diagnostics.Process.Start(psi);
        }
    }
}
