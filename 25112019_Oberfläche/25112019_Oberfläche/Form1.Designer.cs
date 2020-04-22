namespace _25112019_Oberfläche
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_inputheight = new System.Windows.Forms.Label();
            this.lbl_length = new System.Windows.Forms.Label();
            this.lbl_width = new System.Windows.Forms.Label();
            this.lbl_outoberfläche = new System.Windows.Forms.Label();
            this.lbl_oberfläche = new System.Windows.Forms.Label();
            this.lbl_outvolumen = new System.Windows.Forms.Label();
            this.lbl_volumen = new System.Windows.Forms.Label();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.txt_heigth = new System.Windows.Forms.TextBox();
            this.txt_width = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(27, 192);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(104, 33);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "Berechnen";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(137, 192);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(108, 33);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_inputheight
            // 
            this.lbl_inputheight.AutoSize = true;
            this.lbl_inputheight.Location = new System.Drawing.Point(38, 30);
            this.lbl_inputheight.Name = "lbl_inputheight";
            this.lbl_inputheight.Size = new System.Drawing.Size(70, 13);
            this.lbl_inputheight.TabIndex = 2;
            this.lbl_inputheight.Text = "Höhe (in cm):";
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(38, 53);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(74, 13);
            this.lbl_length.TabIndex = 3;
            this.lbl_length.Text = "Länge (in cm):";
            // 
            // lbl_width
            // 
            this.lbl_width.AutoSize = true;
            this.lbl_width.Location = new System.Drawing.Point(38, 76);
            this.lbl_width.Name = "lbl_width";
            this.lbl_width.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_width.Size = new System.Drawing.Size(71, 13);
            this.lbl_width.TabIndex = 4;
            this.lbl_width.Text = "Breite (in cm):";
            // 
            // lbl_outoberfläche
            // 
            this.lbl_outoberfläche.AutoSize = true;
            this.lbl_outoberfläche.Location = new System.Drawing.Point(38, 124);
            this.lbl_outoberfläche.Name = "lbl_outoberfläche";
            this.lbl_outoberfläche.Size = new System.Drawing.Size(62, 13);
            this.lbl_outoberfläche.TabIndex = 5;
            this.lbl_outoberfläche.Text = "Oberfläche:";
            // 
            // lbl_oberfläche
            // 
            this.lbl_oberfläche.AutoSize = true;
            this.lbl_oberfläche.Location = new System.Drawing.Point(134, 124);
            this.lbl_oberfläche.Name = "lbl_oberfläche";
            this.lbl_oberfläche.Size = new System.Drawing.Size(22, 13);
            this.lbl_oberfläche.TabIndex = 6;
            this.lbl_oberfläche.Text = "- - -";
            // 
            // lbl_outvolumen
            // 
            this.lbl_outvolumen.AutoSize = true;
            this.lbl_outvolumen.Location = new System.Drawing.Point(38, 165);
            this.lbl_outvolumen.Name = "lbl_outvolumen";
            this.lbl_outvolumen.Size = new System.Drawing.Size(51, 13);
            this.lbl_outvolumen.TabIndex = 7;
            this.lbl_outvolumen.Text = "Volumen:";
            // 
            // lbl_volumen
            // 
            this.lbl_volumen.AutoSize = true;
            this.lbl_volumen.Location = new System.Drawing.Point(134, 165);
            this.lbl_volumen.Name = "lbl_volumen";
            this.lbl_volumen.Size = new System.Drawing.Size(22, 13);
            this.lbl_volumen.TabIndex = 8;
            this.lbl_volumen.Text = "- - -";
            this.lbl_volumen.Click += new System.EventHandler(this.label2_Click);
            // 
            // txt_length
            // 
            this.txt_length.AcceptsTab = true;
            this.txt_length.Location = new System.Drawing.Point(137, 50);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(100, 20);
            this.txt_length.TabIndex = 9;
            // 
            // txt_heigth
            // 
            this.txt_heigth.Location = new System.Drawing.Point(137, 27);
            this.txt_heigth.Name = "txt_heigth";
            this.txt_heigth.Size = new System.Drawing.Size(100, 20);
            this.txt_heigth.TabIndex = 10;
            // 
            // txt_width
            // 
            this.txt_width.Location = new System.Drawing.Point(137, 73);
            this.txt_width.Name = "txt_width";
            this.txt_width.Size = new System.Drawing.Size(100, 20);
            this.txt_width.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txt_width);
            this.Controls.Add(this.txt_heigth);
            this.Controls.Add(this.txt_length);
            this.Controls.Add(this.lbl_volumen);
            this.Controls.Add(this.lbl_outvolumen);
            this.Controls.Add(this.lbl_oberfläche);
            this.Controls.Add(this.lbl_outoberfläche);
            this.Controls.Add(this.lbl_width);
            this.Controls.Add(this.lbl_length);
            this.Controls.Add(this.lbl_inputheight);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_calc);
            this.Name = "Form1";
            this.Text = "Oberfläche und Volumen berechnen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_inputheight;
        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Label lbl_width;
        private System.Windows.Forms.Label lbl_outoberfläche;
        private System.Windows.Forms.Label lbl_oberfläche;
        private System.Windows.Forms.Label lbl_outvolumen;
        private System.Windows.Forms.Label lbl_volumen;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.TextBox txt_heigth;
        private System.Windows.Forms.TextBox txt_width;
    }
}

