namespace klassen
{
    partial class Form1
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
            this.lbl_length = new System.Windows.Forms.Label();
            this.lbl_radius = new System.Windows.Forms.Label();
            this.txt_length = new System.Windows.Forms.TextBox();
            this.txt_radius = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_flaechekreis = new System.Windows.Forms.Label();
            this.lbl_umfangkreis = new System.Windows.Forms.Label();
            this.lbl_umfangquadrat = new System.Windows.Forms.Label();
            this.lbl_flaechequadrat = new System.Windows.Forms.Label();
            this.lbl_endergebnis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_length
            // 
            this.lbl_length.AutoSize = true;
            this.lbl_length.Location = new System.Drawing.Point(12, 9);
            this.lbl_length.Name = "lbl_length";
            this.lbl_length.Size = new System.Drawing.Size(40, 13);
            this.lbl_length.TabIndex = 1;
            this.lbl_length.Text = "Länge:";
            // 
            // lbl_radius
            // 
            this.lbl_radius.AutoSize = true;
            this.lbl_radius.Location = new System.Drawing.Point(12, 73);
            this.lbl_radius.Name = "lbl_radius";
            this.lbl_radius.Size = new System.Drawing.Size(43, 13);
            this.lbl_radius.TabIndex = 2;
            this.lbl_radius.Text = "Radius:";
            // 
            // txt_length
            // 
            this.txt_length.Location = new System.Drawing.Point(58, 6);
            this.txt_length.Name = "txt_length";
            this.txt_length.Size = new System.Drawing.Size(100, 20);
            this.txt_length.TabIndex = 3;
            // 
            // txt_radius
            // 
            this.txt_radius.Location = new System.Drawing.Point(58, 70);
            this.txt_radius.Name = "txt_radius";
            this.txt_radius.Size = new System.Drawing.Size(100, 20);
            this.txt_radius.TabIndex = 4;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(12, 221);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 5;
            this.btn_calc.Text = "Berechnen";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(197, 221);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 6;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_flaechekreis
            // 
            this.lbl_flaechekreis.AutoSize = true;
            this.lbl_flaechekreis.Location = new System.Drawing.Point(55, 98);
            this.lbl_flaechekreis.Name = "lbl_flaechekreis";
            this.lbl_flaechekreis.Size = new System.Drawing.Size(22, 13);
            this.lbl_flaechekreis.TabIndex = 7;
            this.lbl_flaechekreis.Text = "- - -";
            // 
            // lbl_umfangkreis
            // 
            this.lbl_umfangkreis.AutoSize = true;
            this.lbl_umfangkreis.Location = new System.Drawing.Point(12, 98);
            this.lbl_umfangkreis.Name = "lbl_umfangkreis";
            this.lbl_umfangkreis.Size = new System.Drawing.Size(22, 13);
            this.lbl_umfangkreis.TabIndex = 8;
            this.lbl_umfangkreis.Text = "- - -";
            // 
            // lbl_umfangquadrat
            // 
            this.lbl_umfangquadrat.AutoSize = true;
            this.lbl_umfangquadrat.Location = new System.Drawing.Point(12, 39);
            this.lbl_umfangquadrat.Name = "lbl_umfangquadrat";
            this.lbl_umfangquadrat.Size = new System.Drawing.Size(22, 13);
            this.lbl_umfangquadrat.TabIndex = 9;
            this.lbl_umfangquadrat.Text = "- - -";
            // 
            // lbl_flaechequadrat
            // 
            this.lbl_flaechequadrat.AutoSize = true;
            this.lbl_flaechequadrat.Location = new System.Drawing.Point(55, 39);
            this.lbl_flaechequadrat.Name = "lbl_flaechequadrat";
            this.lbl_flaechequadrat.Size = new System.Drawing.Size(22, 13);
            this.lbl_flaechequadrat.TabIndex = 10;
            this.lbl_flaechequadrat.Text = "- - -";
            // 
            // lbl_endergebnis
            // 
            this.lbl_endergebnis.AutoSize = true;
            this.lbl_endergebnis.Location = new System.Drawing.Point(42, 164);
            this.lbl_endergebnis.Name = "lbl_endergebnis";
            this.lbl_endergebnis.Size = new System.Drawing.Size(22, 13);
            this.lbl_endergebnis.TabIndex = 11;
            this.lbl_endergebnis.Text = "- - -";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 256);
            this.Controls.Add(this.lbl_endergebnis);
            this.Controls.Add(this.lbl_flaechequadrat);
            this.Controls.Add(this.lbl_umfangquadrat);
            this.Controls.Add(this.lbl_umfangkreis);
            this.Controls.Add(this.lbl_flaechekreis);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txt_radius);
            this.Controls.Add(this.txt_length);
            this.Controls.Add(this.lbl_radius);
            this.Controls.Add(this.lbl_length);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_length;
        private System.Windows.Forms.Label lbl_radius;
        private System.Windows.Forms.TextBox txt_length;
        private System.Windows.Forms.TextBox txt_radius;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_flaechekreis;
        private System.Windows.Forms.Label lbl_umfangkreis;
        private System.Windows.Forms.Label lbl_umfangquadrat;
        private System.Windows.Forms.Label lbl_flaechequadrat;
        private System.Windows.Forms.Label lbl_endergebnis;
    }
}

