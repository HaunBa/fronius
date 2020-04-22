namespace _22112019_Array
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
            this.lbo_Array = new System.Windows.Forms.ListBox();
            this.lbl_info1 = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_eingabe = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_outputmittelwert = new System.Windows.Forms.Label();
            this.lbl_mittelwert = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbo_Array
            // 
            this.lbo_Array.FormattingEnabled = true;
            this.lbo_Array.Location = new System.Drawing.Point(115, 12);
            this.lbo_Array.Name = "lbo_Array";
            this.lbo_Array.Size = new System.Drawing.Size(120, 95);
            this.lbo_Array.TabIndex = 0;
            this.lbo_Array.SelectedIndexChanged += new System.EventHandler(this.lbo_Array_SelectedIndexChanged);
            // 
            // lbl_info1
            // 
            this.lbl_info1.AutoSize = true;
            this.lbl_info1.Location = new System.Drawing.Point(12, 12);
            this.lbl_info1.Name = "lbl_info1";
            this.lbl_info1.Size = new System.Drawing.Size(83, 13);
            this.lbl_info1.TabIndex = 1;
            this.lbl_info1.Text = "Zahlen im Array:";
            // 
            // btn_add
            // 
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_add.Location = new System.Drawing.Point(12, 209);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 2;
            this.btn_add.Text = "Hinzufügen";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(174, 209);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_eingabe
            // 
            this.lbl_eingabe.AutoSize = true;
            this.lbl_eingabe.Location = new System.Drawing.Point(12, 129);
            this.lbl_eingabe.Name = "lbl_eingabe";
            this.lbl_eingabe.Size = new System.Drawing.Size(49, 13);
            this.lbl_eingabe.TabIndex = 4;
            this.lbl_eingabe.Text = "Eingabe:";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(115, 126);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(120, 20);
            this.txt_input.TabIndex = 5;
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(93, 209);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 6;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_outputmittelwert
            // 
            this.lbl_outputmittelwert.AutoSize = true;
            this.lbl_outputmittelwert.Location = new System.Drawing.Point(12, 155);
            this.lbl_outputmittelwert.Name = "lbl_outputmittelwert";
            this.lbl_outputmittelwert.Size = new System.Drawing.Size(55, 13);
            this.lbl_outputmittelwert.TabIndex = 8;
            this.lbl_outputmittelwert.Text = "Mittelwert:";
            // 
            // lbl_mittelwert
            // 
            this.lbl_mittelwert.AutoSize = true;
            this.lbl_mittelwert.Location = new System.Drawing.Point(112, 155);
            this.lbl_mittelwert.Name = "lbl_mittelwert";
            this.lbl_mittelwert.Size = new System.Drawing.Size(22, 13);
            this.lbl_mittelwert.TabIndex = 9;
            this.lbl_mittelwert.Text = "- - -";
            this.lbl_mittelwert.Click += new System.EventHandler(this.lbl_mittelwert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 240);
            this.Controls.Add(this.lbl_mittelwert);
            this.Controls.Add(this.lbl_outputmittelwert);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_eingabe);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_info1);
            this.Controls.Add(this.lbo_Array);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Arrays verwalten";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbo_Array;
        private System.Windows.Forms.Label lbl_info1;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_eingabe;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_mittelwert;
        private System.Windows.Forms.Label lbl_outputmittelwert;
    }
}

