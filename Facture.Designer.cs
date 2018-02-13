namespace WindowsFormsApplication1
{
    partial class Facture
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facture));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImp = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btn_supp = new System.Windows.Forms.Button();
            this.btn_ajout = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRef = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTotalTTC = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotalHt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAjout = new System.Windows.Forms.Button();
            this.btnSupp = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrix = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbTva = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtQte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRemise = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboArticle = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnImp);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.btn_supp);
            this.groupBox1.Controls.Add(this.btn_ajout);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtRef);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(833, 112);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Entête";
            // 
            // btnImp
            // 
            this.btnImp.Image = ((System.Drawing.Image)(resources.GetObject("btnImp.Image")));
            this.btnImp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImp.Location = new System.Drawing.Point(736, 51);
            this.btnImp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnImp.Name = "btnImp";
            this.btnImp.Size = new System.Drawing.Size(86, 35);
            this.btnImp.TabIndex = 9;
            this.btnImp.Text = "Imprimer";
            this.btnImp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImp.UseVisualStyleBackColor = true;
            this.btnImp.Click += new System.EventHandler(this.btnImp_Click);
            this.btnImp.MouseHover += new System.EventHandler(this.btnImp_MouseHover);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(736, 17);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(86, 29);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Enregistrer";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.btnSave.MouseHover += new System.EventHandler(this.btnSave_MouseHover);
            // 
            // btn_supp
            // 
            this.btn_supp.Image = ((System.Drawing.Image)(resources.GetObject("btn_supp.Image")));
            this.btn_supp.Location = new System.Drawing.Point(682, 17);
            this.btn_supp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_supp.Name = "btn_supp";
            this.btn_supp.Size = new System.Drawing.Size(35, 29);
            this.btn_supp.TabIndex = 7;
            this.btn_supp.UseVisualStyleBackColor = true;
            this.btn_supp.MouseHover += new System.EventHandler(this.btn_supp_MouseHover);
            // 
            // btn_ajout
            // 
            this.btn_ajout.Image = ((System.Drawing.Image)(resources.GetObject("btn_ajout.Image")));
            this.btn_ajout.Location = new System.Drawing.Point(628, 17);
            this.btn_ajout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_ajout.Name = "btn_ajout";
            this.btn_ajout.Size = new System.Drawing.Size(35, 29);
            this.btn_ajout.TabIndex = 6;
            this.btn_ajout.UseVisualStyleBackColor = true;
            this.btn_ajout.MouseHover += new System.EventHandler(this.btn_ajout_MouseHover);
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.ItemHeight = 13;
            this.comboBox1.Location = new System.Drawing.Point(43, 72);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tiers : ";
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.SystemColors.Window;
            this.txtDate.Location = new System.Drawing.Point(183, 35);
            this.txtDate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.Size = new System.Drawing.Size(112, 20);
            this.txtDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 37);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date : ";
            // 
            // txtRef
            // 
            this.txtRef.BackColor = System.Drawing.SystemColors.Window;
            this.txtRef.Location = new System.Drawing.Point(43, 35);
            this.txtRef.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRef.Name = "txtRef";
            this.txtRef.ReadOnly = true;
            this.txtRef.Size = new System.Drawing.Size(84, 20);
            this.txtRef.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ref : ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTotalTTC);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.txtTotalHt);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Controls.Add(this.btnModifier);
            this.groupBox2.Controls.Add(this.btnAjout);
            this.groupBox2.Controls.Add(this.btnSupp);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtPrix);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cmbTva);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtQte);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtRemise);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.comboArticle);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(10, 135);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(832, 365);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Details";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtTotalTTC
            // 
            this.txtTotalTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalTTC.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalTTC.Location = new System.Drawing.Point(735, 339);
            this.txtTotalTTC.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalTTC.Name = "txtTotalTTC";
            this.txtTotalTTC.Size = new System.Drawing.Size(87, 19);
            this.txtTotalTTC.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(665, 343);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 18;
            this.label12.Text = "Totale TTC : ";
            // 
            // txtTotalHt
            // 
            this.txtTotalHt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHt.ForeColor = System.Drawing.Color.Blue;
            this.txtTotalHt.Location = new System.Drawing.Point(735, 318);
            this.txtTotalHt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtTotalHt.Name = "txtTotalHt";
            this.txtTotalHt.Size = new System.Drawing.Size(87, 19);
            this.txtTotalHt.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(671, 318);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Totale HT : ";
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 134);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(817, 169);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnModifier
            // 
            this.btnModifier.Image = ((System.Drawing.Image)(resources.GetObject("btnModifier.Image")));
            this.btnModifier.Location = new System.Drawing.Point(720, 100);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(31, 29);
            this.btnModifier.TabIndex = 14;
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.Image = ((System.Drawing.Image)(resources.GetObject("btnAjout.Image")));
            this.btnAjout.Location = new System.Drawing.Point(792, 100);
            this.btnAjout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(29, 29);
            this.btnAjout.TabIndex = 13;
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // btnSupp
            // 
            this.btnSupp.Image = ((System.Drawing.Image)(resources.GetObject("btnSupp.Image")));
            this.btnSupp.Location = new System.Drawing.Point(755, 100);
            this.btnSupp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSupp.Name = "btnSupp";
            this.btnSupp.Size = new System.Drawing.Size(29, 29);
            this.btnSupp.TabIndex = 12;
            this.btnSupp.UseVisualStyleBackColor = true;
            this.btnSupp.Click += new System.EventHandler(this.btnSupp_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(568, 73);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Dt";
            // 
            // txtPrix
            // 
            this.txtPrix.BackColor = System.Drawing.SystemColors.Window;
            this.txtPrix.Location = new System.Drawing.Point(486, 74);
            this.txtPrix.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPrix.Name = "txtPrix";
            this.txtPrix.ReadOnly = true;
            this.txtPrix.Size = new System.Drawing.Size(76, 20);
            this.txtPrix.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(428, 73);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 9;
            this.label9.Text = "Prix Vente : ";
            // 
            // cmbTva
            // 
            this.cmbTva.FormattingEnabled = true;
            this.cmbTva.Location = new System.Drawing.Point(287, 73);
            this.cmbTva.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTva.Name = "cmbTva";
            this.cmbTva.Size = new System.Drawing.Size(92, 21);
            this.cmbTva.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 73);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "TVA :";
            // 
            // txtQte
            // 
            this.txtQte.Location = new System.Drawing.Point(172, 73);
            this.txtQte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtQte.Name = "txtQte";
            this.txtQte.Size = new System.Drawing.Size(66, 20);
            this.txtQte.TabIndex = 6;
            this.txtQte.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 73);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Qté :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 73);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "%";
            // 
            // txtRemise
            // 
            this.txtRemise.Location = new System.Drawing.Point(51, 73);
            this.txtRemise.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtRemise.Name = "txtRemise";
            this.txtRemise.Size = new System.Drawing.Size(61, 20);
            this.txtRemise.TabIndex = 3;
            this.txtRemise.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 73);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Remise : ";
            // 
            // comboArticle
            // 
            this.comboArticle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboArticle.FormattingEnabled = true;
            this.comboArticle.IntegralHeight = false;
            this.comboArticle.ItemHeight = 13;
            this.comboArticle.Location = new System.Drawing.Point(51, 35);
            this.comboArticle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboArticle.Name = "comboArticle";
            this.comboArticle.Size = new System.Drawing.Size(328, 21);
            this.comboArticle.TabIndex = 1;
            this.comboArticle.SelectedIndexChanged += new System.EventHandler(this.comboArticle_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 35);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Article : ";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // Facture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(865, 504);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "Facture";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facture";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Facture_FormClosed);
            this.Load += new System.EventHandler(this.Facture_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRef;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btn_supp;
        private System.Windows.Forms.Button btn_ajout;
        private System.Windows.Forms.Button btnImp;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cmbTva;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtQte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRemise;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSupp;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPrix;
        private System.Windows.Forms.Button btnModifier;
        private System.Windows.Forms.Button btnAjout;
        private System.Windows.Forms.TextBox txtTotalTTC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotalHt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox comboArticle;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}