namespace _26112019_durchschnittsVerbrauch
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
            this.btn_calc = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_strecke = new System.Windows.Forms.Label();
            this.lbl_verbrauch = new System.Windows.Forms.Label();
            this.lbl_durchschnittsverbrauch = new System.Windows.Forms.Label();
            this.lbl_outdurchschnittsverbrauch = new System.Windows.Forms.Label();
            this.txt_verbrauch = new System.Windows.Forms.TextBox();
            this.txt_strecke = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(40, 165);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(107, 32);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "Berechnen";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(199, 165);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(103, 32);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_strecke
            // 
            this.lbl_strecke.AutoSize = true;
            this.lbl_strecke.Location = new System.Drawing.Point(37, 29);
            this.lbl_strecke.Name = "lbl_strecke";
            this.lbl_strecke.Size = new System.Drawing.Size(173, 13);
            this.lbl_strecke.TabIndex = 2;
            this.lbl_strecke.Text = "Eingabe Gefahrene Strecke (in km)";
            // 
            // lbl_verbrauch
            // 
            this.lbl_verbrauch.AutoSize = true;
            this.lbl_verbrauch.Location = new System.Drawing.Point(37, 58);
            this.lbl_verbrauch.Name = "lbl_verbrauch";
            this.lbl_verbrauch.Size = new System.Drawing.Size(128, 13);
            this.lbl_verbrauch.TabIndex = 3;
            this.lbl_verbrauch.Text = "Benzinverbrauch (In Liter)";
            // 
            // lbl_durchschnittsverbrauch
            // 
            this.lbl_durchschnittsverbrauch.AutoSize = true;
            this.lbl_durchschnittsverbrauch.Location = new System.Drawing.Point(224, 111);
            this.lbl_durchschnittsverbrauch.Name = "lbl_durchschnittsverbrauch";
            this.lbl_durchschnittsverbrauch.Size = new System.Drawing.Size(22, 13);
            this.lbl_durchschnittsverbrauch.TabIndex = 4;
            this.lbl_durchschnittsverbrauch.Text = "- - -";
            this.lbl_durchschnittsverbrauch.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_outdurchschnittsverbrauch
            // 
            this.lbl_outdurchschnittsverbrauch.AutoSize = true;
            this.lbl_outdurchschnittsverbrauch.Location = new System.Drawing.Point(37, 111);
            this.lbl_outdurchschnittsverbrauch.Name = "lbl_outdurchschnittsverbrauch";
            this.lbl_outdurchschnittsverbrauch.Size = new System.Drawing.Size(173, 13);
            this.lbl_outdurchschnittsverbrauch.TabIndex = 5;
            this.lbl_outdurchschnittsverbrauch.Text = "Durchschnittsverbrauch in l/100km";
            // 
            // txt_verbrauch
            // 
            this.txt_verbrauch.Location = new System.Drawing.Point(216, 55);
            this.txt_verbrauch.Name = "txt_verbrauch";
            this.txt_verbrauch.Size = new System.Drawing.Size(100, 20);
            this.txt_verbrauch.TabIndex = 6;
            // 
            // txt_strecke
            // 
            this.txt_strecke.Location = new System.Drawing.Point(216, 26);
            this.txt_strecke.Name = "txt_strecke";
            this.txt_strecke.Size = new System.Drawing.Size(100, 20);
            this.txt_strecke.TabIndex = 7;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 225);
            this.Controls.Add(this.txt_strecke);
            this.Controls.Add(this.txt_verbrauch);
            this.Controls.Add(this.lbl_outdurchschnittsverbrauch);
            this.Controls.Add(this.lbl_durchschnittsverbrauch);
            this.Controls.Add(this.lbl_verbrauch);
            this.Controls.Add(this.lbl_strecke);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_calc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_strecke;
        private System.Windows.Forms.Label lbl_verbrauch;
        private System.Windows.Forms.Label lbl_durchschnittsverbrauch;
        private System.Windows.Forms.Label lbl_outdurchschnittsverbrauch;
        private System.Windows.Forms.TextBox txt_verbrauch;
        private System.Windows.Forms.TextBox txt_strecke;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}

