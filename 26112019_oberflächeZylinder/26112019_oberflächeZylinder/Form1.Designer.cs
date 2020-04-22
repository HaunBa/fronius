namespace _26112019_oberflächeZylinder
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
            this.components = new System.ComponentModel.Container();
            this.rbtn_i = new System.Windows.Forms.RadioButton();
            this.rbtn_u = new System.Windows.Forms.RadioButton();
            this.rbtn_r = new System.Windows.Forms.RadioButton();
            this.lbl_inputi = new System.Windows.Forms.Label();
            this.lbl_inputu = new System.Windows.Forms.Label();
            this.lbl_r = new System.Windows.Forms.Label();
            this.txt_i = new System.Windows.Forms.TextBox();
            this.txt_u = new System.Windows.Forms.TextBox();
            this.txt_r = new System.Windows.Forms.TextBox();
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_outputi = new System.Windows.Forms.Label();
            this.lbl_outputu = new System.Windows.Forms.Label();
            this.lbl_outputr = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // rbtn_i
            // 
            this.rbtn_i.AutoSize = true;
            this.rbtn_i.Location = new System.Drawing.Point(12, 12);
            this.rbtn_i.Name = "rbtn_i";
            this.rbtn_i.Size = new System.Drawing.Size(77, 17);
            this.rbtn_i.TabIndex = 0;
            this.rbtn_i.TabStop = true;
            this.rbtn_i.Text = "Berechne I";
            this.rbtn_i.UseVisualStyleBackColor = true;
            // 
            // rbtn_u
            // 
            this.rbtn_u.AutoSize = true;
            this.rbtn_u.Location = new System.Drawing.Point(12, 35);
            this.rbtn_u.Name = "rbtn_u";
            this.rbtn_u.Size = new System.Drawing.Size(82, 17);
            this.rbtn_u.TabIndex = 1;
            this.rbtn_u.TabStop = true;
            this.rbtn_u.Text = "Berechne U";
            this.rbtn_u.UseVisualStyleBackColor = true;
            // 
            // rbtn_r
            // 
            this.rbtn_r.AutoSize = true;
            this.rbtn_r.Location = new System.Drawing.Point(12, 58);
            this.rbtn_r.Name = "rbtn_r";
            this.rbtn_r.Size = new System.Drawing.Size(82, 17);
            this.rbtn_r.TabIndex = 2;
            this.rbtn_r.TabStop = true;
            this.rbtn_r.Text = "Berechne R";
            this.rbtn_r.UseVisualStyleBackColor = true;
            // 
            // lbl_inputi
            // 
            this.lbl_inputi.AutoSize = true;
            this.lbl_inputi.Location = new System.Drawing.Point(12, 93);
            this.lbl_inputi.Name = "lbl_inputi";
            this.lbl_inputi.Size = new System.Drawing.Size(13, 13);
            this.lbl_inputi.TabIndex = 3;
            this.lbl_inputi.Text = "I:";
            // 
            // lbl_inputu
            // 
            this.lbl_inputu.AutoSize = true;
            this.lbl_inputu.Location = new System.Drawing.Point(12, 115);
            this.lbl_inputu.Name = "lbl_inputu";
            this.lbl_inputu.Size = new System.Drawing.Size(18, 13);
            this.lbl_inputu.TabIndex = 4;
            this.lbl_inputu.Text = "U:";
            // 
            // lbl_r
            // 
            this.lbl_r.AutoSize = true;
            this.lbl_r.Location = new System.Drawing.Point(12, 139);
            this.lbl_r.Name = "lbl_r";
            this.lbl_r.Size = new System.Drawing.Size(18, 13);
            this.lbl_r.TabIndex = 5;
            this.lbl_r.Text = "R:";
            // 
            // txt_i
            // 
            this.txt_i.Location = new System.Drawing.Point(64, 90);
            this.txt_i.Name = "txt_i";
            this.txt_i.Size = new System.Drawing.Size(100, 20);
            this.txt_i.TabIndex = 6;
            // 
            // txt_u
            // 
            this.txt_u.Location = new System.Drawing.Point(64, 112);
            this.txt_u.Name = "txt_u";
            this.txt_u.Size = new System.Drawing.Size(100, 20);
            this.txt_u.TabIndex = 7;
            // 
            // txt_r
            // 
            this.txt_r.Location = new System.Drawing.Point(64, 136);
            this.txt_r.Name = "txt_r";
            this.txt_r.Size = new System.Drawing.Size(100, 20);
            this.txt_r.TabIndex = 8;
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(45, 203);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 9;
            this.btn_calc.Text = "Berechnen";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(154, 203);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(75, 23);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Schließen";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_outputi
            // 
            this.lbl_outputi.AutoSize = true;
            this.lbl_outputi.Location = new System.Drawing.Point(194, 90);
            this.lbl_outputi.Name = "lbl_outputi";
            this.lbl_outputi.Size = new System.Drawing.Size(22, 13);
            this.lbl_outputi.TabIndex = 11;
            this.lbl_outputi.Text = "- - -";
            // 
            // lbl_outputu
            // 
            this.lbl_outputu.AutoSize = true;
            this.lbl_outputu.Location = new System.Drawing.Point(194, 115);
            this.lbl_outputu.Name = "lbl_outputu";
            this.lbl_outputu.Size = new System.Drawing.Size(22, 13);
            this.lbl_outputu.TabIndex = 12;
            this.lbl_outputu.Text = "- - -";
            // 
            // lbl_outputr
            // 
            this.lbl_outputr.AutoSize = true;
            this.lbl_outputr.Location = new System.Drawing.Point(194, 139);
            this.lbl_outputr.Name = "lbl_outputr";
            this.lbl_outputr.Size = new System.Drawing.Size(22, 13);
            this.lbl_outputr.TabIndex = 13;
            this.lbl_outputr.Text = "- - -";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lbl_outputr);
            this.Controls.Add(this.lbl_outputu);
            this.Controls.Add(this.lbl_outputi);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_calc);
            this.Controls.Add(this.txt_r);
            this.Controls.Add(this.txt_u);
            this.Controls.Add(this.txt_i);
            this.Controls.Add(this.lbl_r);
            this.Controls.Add(this.lbl_inputu);
            this.Controls.Add(this.lbl_inputi);
            this.Controls.Add(this.rbtn_r);
            this.Controls.Add(this.rbtn_u);
            this.Controls.Add(this.rbtn_i);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtn_i;
        private System.Windows.Forms.RadioButton rbtn_u;
        private System.Windows.Forms.RadioButton rbtn_r;
        private System.Windows.Forms.Label lbl_inputi;
        private System.Windows.Forms.Label lbl_inputu;
        private System.Windows.Forms.Label lbl_r;
        private System.Windows.Forms.TextBox txt_i;
        private System.Windows.Forms.TextBox txt_u;
        private System.Windows.Forms.TextBox txt_r;
        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_outputi;
        private System.Windows.Forms.Label lbl_outputu;
        private System.Windows.Forms.Label lbl_outputr;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}

