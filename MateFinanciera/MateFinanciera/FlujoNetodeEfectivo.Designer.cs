namespace MateFinanciera
{
    partial class FlujoNetodeEfectivo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inversionfijtotal = new System.Windows.Forms.MaskedTextBox();
            this.ingreanuales = new System.Windows.Forms.MaskedTextBox();
            this.cbcrecimientoingre = new System.Windows.Forms.ComboBox();
            this.costoanuales = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.creingrecan = new System.Windows.Forms.MaskedTextBox();
            this.cbcrecimientocos = new System.Windows.Forms.ComboBox();
            this.crecoscan = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.inversiondiftotal = new System.Windows.Forms.MaskedTextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.Restoinversion = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.inversiontotal = new System.Windows.Forms.TextBox();
            this.creingrepor = new System.Windows.Forms.MaskedTextBox();
            this.crecospor = new System.Windows.Forms.MaskedTextBox();
            this.depreciacion = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valorresidual = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresos anuales =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Crecimiento de los ingresos =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costos Anuales =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Inversion fija Total =";
            // 
            // inversionfijtotal
            // 
            this.inversionfijtotal.Location = new System.Drawing.Point(208, 179);
            this.inversionfijtotal.Mask = "0000000000000000";
            this.inversionfijtotal.Name = "inversionfijtotal";
            this.inversionfijtotal.Size = new System.Drawing.Size(109, 20);
            this.inversionfijtotal.TabIndex = 4;
            // 
            // ingreanuales
            // 
            this.ingreanuales.Location = new System.Drawing.Point(208, 42);
            this.ingreanuales.Mask = "000000000000000";
            this.ingreanuales.Name = "ingreanuales";
            this.ingreanuales.Size = new System.Drawing.Size(108, 20);
            this.ingreanuales.TabIndex = 5;
            // 
            // cbcrecimientoingre
            // 
            this.cbcrecimientoingre.FormattingEnabled = true;
            this.cbcrecimientoingre.Items.AddRange(new object[] {
            "Cantidad",
            "Porcentual"});
            this.cbcrecimientoingre.Location = new System.Drawing.Point(208, 75);
            this.cbcrecimientoingre.Name = "cbcrecimientoingre";
            this.cbcrecimientoingre.Size = new System.Drawing.Size(109, 21);
            this.cbcrecimientoingre.TabIndex = 6;
            this.cbcrecimientoingre.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // costoanuales
            // 
            this.costoanuales.Location = new System.Drawing.Point(208, 108);
            this.costoanuales.Mask = "00000000000000";
            this.costoanuales.Name = "costoanuales";
            this.costoanuales.Size = new System.Drawing.Size(109, 20);
            this.costoanuales.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(55, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Crecimiento de los costos =";
            // 
            // creingrecan
            // 
            this.creingrecan.Enabled = false;
            this.creingrecan.Location = new System.Drawing.Point(333, 75);
            this.creingrecan.Mask = "000000000000";
            this.creingrecan.Name = "creingrecan";
            this.creingrecan.Size = new System.Drawing.Size(61, 20);
            this.creingrecan.TabIndex = 9;
            // 
            // cbcrecimientocos
            // 
            this.cbcrecimientocos.FormattingEnabled = true;
            this.cbcrecimientocos.Items.AddRange(new object[] {
            "Cantidad",
            "Porcentual"});
            this.cbcrecimientocos.Location = new System.Drawing.Point(208, 145);
            this.cbcrecimientocos.Name = "cbcrecimientocos";
            this.cbcrecimientocos.Size = new System.Drawing.Size(108, 21);
            this.cbcrecimientocos.TabIndex = 10;
            this.cbcrecimientocos.SelectedIndexChanged += new System.EventHandler(this.cbcrecimientocos_SelectedIndexChanged);
            // 
            // crecoscan
            // 
            this.crecoscan.Enabled = false;
            this.crecoscan.Location = new System.Drawing.Point(333, 145);
            this.crecoscan.Mask = "0000000000000";
            this.crecoscan.Name = "crecoscan";
            this.crecoscan.Size = new System.Drawing.Size(61, 20);
            this.crecoscan.TabIndex = 11;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(333, 182);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(113, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "+ Distribuir la Inversion";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Inversion Diferida =";
            // 
            // inversiondiftotal
            // 
            this.inversiondiftotal.Location = new System.Drawing.Point(208, 211);
            this.inversiondiftotal.Mask = "000000000000000";
            this.inversiondiftotal.Name = "inversiondiftotal";
            this.inversiondiftotal.Size = new System.Drawing.Size(108, 20);
            this.inversiondiftotal.TabIndex = 14;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(334, 218);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(112, 13);
            this.linkLabel2.TabIndex = 15;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "+ Distribuir la inversion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Resto de la inversion =";
            // 
            // Restoinversion
            // 
            this.Restoinversion.Location = new System.Drawing.Point(208, 255);
            this.Restoinversion.Mask = "000000000000000";
            this.Restoinversion.Name = "Restoinversion";
            this.Restoinversion.Size = new System.Drawing.Size(108, 20);
            this.Restoinversion.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(373, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(477, 290);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 19;
            this.button2.Text = "CANCELAR";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(102, 321);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Inversion Total =";
            // 
            // inversiontotal
            // 
            this.inversiontotal.Location = new System.Drawing.Point(194, 318);
            this.inversiontotal.Name = "inversiontotal";
            this.inversiontotal.ReadOnly = true;
            this.inversiontotal.Size = new System.Drawing.Size(146, 20);
            this.inversiontotal.TabIndex = 21;
            // 
            // creingrepor
            // 
            this.creingrepor.Enabled = false;
            this.creingrepor.Location = new System.Drawing.Point(401, 75);
            this.creingrepor.Mask = "00.00";
            this.creingrepor.Name = "creingrepor";
            this.creingrepor.Size = new System.Drawing.Size(45, 20);
            this.creingrepor.TabIndex = 22;
            // 
            // crecospor
            // 
            this.crecospor.Enabled = false;
            this.crecospor.Location = new System.Drawing.Point(401, 145);
            this.crecospor.Mask = "00.00";
            this.crecospor.Name = "crecospor";
            this.crecospor.Size = new System.Drawing.Size(47, 20);
            this.crecospor.TabIndex = 23;
            // 
            // depreciacion
            // 
            this.depreciacion.Enabled = false;
            this.depreciacion.Location = new System.Drawing.Point(477, 179);
            this.depreciacion.Name = "depreciacion";
            this.depreciacion.Size = new System.Drawing.Size(100, 20);
            this.depreciacion.TabIndex = 24;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dataGridView1.Location = new System.Drawing.Point(12, 426);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(622, 227);
            this.dataGridView1.TabIndex = 25;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Concepto";
            this.Column1.Name = "Column1";
            // 
            // Valorresidual
            // 
            this.Valorresidual.Enabled = false;
            this.Valorresidual.Location = new System.Drawing.Point(477, 141);
            this.Valorresidual.Name = "Valorresidual";
            this.Valorresidual.Size = new System.Drawing.Size(100, 20);
            this.Valorresidual.TabIndex = 26;
            // 
            // FlujoNetodeEfectivo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 665);
            this.Controls.Add(this.Valorresidual);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.depreciacion);
            this.Controls.Add(this.crecospor);
            this.Controls.Add(this.creingrepor);
            this.Controls.Add(this.inversiontotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Restoinversion);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.inversiondiftotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.crecoscan);
            this.Controls.Add(this.cbcrecimientocos);
            this.Controls.Add(this.creingrecan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.costoanuales);
            this.Controls.Add(this.cbcrecimientoingre);
            this.Controls.Add(this.ingreanuales);
            this.Controls.Add(this.inversionfijtotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FlujoNetodeEfectivo";
            this.Text = "FlujoNetodeEfectivo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.MaskedTextBox inversionfijtotal;
        private System.Windows.Forms.MaskedTextBox ingreanuales;
        private System.Windows.Forms.ComboBox cbcrecimientoingre;
        private System.Windows.Forms.MaskedTextBox costoanuales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox creingrecan;
        private System.Windows.Forms.ComboBox cbcrecimientocos;
        private System.Windows.Forms.MaskedTextBox crecoscan;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.MaskedTextBox inversiondiftotal;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox Restoinversion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox inversiontotal;
        private System.Windows.Forms.MaskedTextBox creingrepor;
        private System.Windows.Forms.MaskedTextBox crecospor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        public System.Windows.Forms.TextBox depreciacion;
        public System.Windows.Forms.TextBox Valorresidual;
    }
}