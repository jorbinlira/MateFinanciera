namespace MateFinanciera
{
    partial class InversionFija
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
            this.cbedificios = new System.Windows.Forms.ComboBox();
            this.cbtransporte = new System.Windows.Forms.ComboBox();
            this.cbmaquinaria = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.montoedificios = new System.Windows.Forms.MaskedTextBox();
            this.montotransporte = new System.Windows.Forms.MaskedTextBox();
            this.montomaquinaria = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.montoterreno = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.resiedificios = new System.Windows.Forms.MaskedTextBox();
            this.resitransporte = new System.Windows.Forms.MaskedTextBox();
            this.resimaquinaria = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "De Edificios  =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 160);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "De equipo y maquinaria =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "De equipo de transporte =";
            // 
            // cbedificios
            // 
            this.cbedificios.FormattingEnabled = true;
            this.cbedificios.Items.AddRange(new object[] {
            "Industriales",
            "Comerciales",
            "Residencia"});
            this.cbedificios.Location = new System.Drawing.Point(177, 45);
            this.cbedificios.Name = "cbedificios";
            this.cbedificios.Size = new System.Drawing.Size(153, 21);
            this.cbedificios.TabIndex = 3;
            // 
            // cbtransporte
            // 
            this.cbtransporte.FormattingEnabled = true;
            this.cbtransporte.Items.AddRange(new object[] {
            "Colectivo o de carga",
            "vehiculos de empresas",
            "otros equipos de transporte"});
            this.cbtransporte.Location = new System.Drawing.Point(177, 101);
            this.cbtransporte.Name = "cbtransporte";
            this.cbtransporte.Size = new System.Drawing.Size(153, 21);
            this.cbtransporte.TabIndex = 4;
            // 
            // cbmaquinaria
            // 
            this.cbmaquinaria.FormattingEnabled = true;
            this.cbmaquinaria.Items.AddRange(new object[] {
            "Industriales en general",
            "Agricolas",
            "otros bienes inmuebles"});
            this.cbmaquinaria.Location = new System.Drawing.Point(177, 157);
            this.cbmaquinaria.Name = "cbmaquinaria";
            this.cbmaquinaria.Size = new System.Drawing.Size(153, 21);
            this.cbmaquinaria.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(410, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(542, 300);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Cancelar ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // montoedificios
            // 
            this.montoedificios.Location = new System.Drawing.Point(353, 45);
            this.montoedificios.Mask = "00000000000000";
            this.montoedificios.Name = "montoedificios";
            this.montoedificios.Size = new System.Drawing.Size(121, 20);
            this.montoedificios.TabIndex = 9;
            // 
            // montotransporte
            // 
            this.montotransporte.Location = new System.Drawing.Point(353, 101);
            this.montotransporte.Mask = "0000000000000";
            this.montotransporte.Name = "montotransporte";
            this.montotransporte.Size = new System.Drawing.Size(121, 20);
            this.montotransporte.TabIndex = 10;
            // 
            // montomaquinaria
            // 
            this.montomaquinaria.Location = new System.Drawing.Point(353, 157);
            this.montomaquinaria.Mask = "00000000000";
            this.montomaquinaria.Name = "montomaquinaria";
            this.montomaquinaria.Size = new System.Drawing.Size(121, 20);
            this.montomaquinaria.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(387, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Monto";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(213, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Tipo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(118, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Terreno =";
            // 
            // montoterreno
            // 
            this.montoterreno.Location = new System.Drawing.Point(353, 209);
            this.montoterreno.Mask = "0000000000000000";
            this.montoterreno.Name = "montoterreno";
            this.montoterreno.Size = new System.Drawing.Size(121, 20);
            this.montoterreno.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "-/-/-/-/-/-/-";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(547, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Valor residual";
            // 
            // resiedificios
            // 
            this.resiedificios.Location = new System.Drawing.Point(525, 45);
            this.resiedificios.Mask = "000000000000000";
            this.resiedificios.Name = "resiedificios";
            this.resiedificios.Size = new System.Drawing.Size(120, 20);
            this.resiedificios.TabIndex = 18;
            // 
            // resitransporte
            // 
            this.resitransporte.Location = new System.Drawing.Point(525, 101);
            this.resitransporte.Mask = "00000000000000000";
            this.resitransporte.Name = "resitransporte";
            this.resitransporte.Size = new System.Drawing.Size(120, 20);
            this.resitransporte.TabIndex = 19;
            // 
            // resimaquinaria
            // 
            this.resimaquinaria.Location = new System.Drawing.Point(525, 157);
            this.resimaquinaria.Mask = "00000000000";
            this.resimaquinaria.Name = "resimaquinaria";
            this.resimaquinaria.Size = new System.Drawing.Size(120, 20);
            this.resimaquinaria.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(547, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "-/-/-/-/-/-/-/-/-";
            // 
            // InversionFija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 367);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.resimaquinaria);
            this.Controls.Add(this.resitransporte);
            this.Controls.Add(this.resiedificios);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.montoterreno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.montomaquinaria);
            this.Controls.Add(this.montotransporte);
            this.Controls.Add(this.montoedificios);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbmaquinaria);
            this.Controls.Add(this.cbtransporte);
            this.Controls.Add(this.cbedificios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "InversionFija";
            this.Text = "InversionFija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbedificios;
        private System.Windows.Forms.ComboBox cbtransporte;
        private System.Windows.Forms.ComboBox cbmaquinaria;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MaskedTextBox montoedificios;
        private System.Windows.Forms.MaskedTextBox montotransporte;
        private System.Windows.Forms.MaskedTextBox montomaquinaria;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox montoterreno;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox resiedificios;
        private System.Windows.Forms.MaskedTextBox resitransporte;
        private System.Windows.Forms.MaskedTextBox resimaquinaria;
        private System.Windows.Forms.Label label9;
    }
}