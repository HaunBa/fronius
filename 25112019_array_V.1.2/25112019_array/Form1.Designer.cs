namespace _25112019_array
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
            this.btn_add = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.lbl_input = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.lbo_array = new System.Windows.Forms.ListBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lbl_max = new System.Windows.Forms.Label();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_Mittelwert = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_search = new System.Windows.Forms.Label();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.lbl_outposition = new System.Windows.Forms.Label();
            this.lbl_position = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(15, 145);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Hinzufügen";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(204, 255);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(18, 108);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(49, 13);
            this.lbl_input.TabIndex = 2;
            this.lbl_input.Text = "Eingabe:";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(70, 105);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(88, 20);
            this.txt_input.TabIndex = 3;
            // 
            // lbo_array
            // 
            this.lbo_array.FormattingEnabled = true;
            this.lbo_array.Location = new System.Drawing.Point(177, 30);
            this.lbo_array.Name = "lbo_array";
            this.lbo_array.Size = new System.Drawing.Size(68, 95);
            this.lbo_array.TabIndex = 4;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(96, 145);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 5;
            this.btn_delete.Text = "Löschen";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lbl_max
            // 
            this.lbl_max.AutoSize = true;
            this.lbl_max.Location = new System.Drawing.Point(20, 39);
            this.lbl_max.Name = "lbl_max";
            this.lbl_max.Size = new System.Drawing.Size(27, 13);
            this.lbl_max.TabIndex = 6;
            this.lbl_max.Text = "Max";
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Location = new System.Drawing.Point(93, 39);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(24, 13);
            this.lbl_min.TabIndex = 7;
            this.lbl_min.Text = "Min";
            // 
            // lbl_Mittelwert
            // 
            this.lbl_Mittelwert.AutoSize = true;
            this.lbl_Mittelwert.Location = new System.Drawing.Point(146, 39);
            this.lbl_Mittelwert.Name = "lbl_Mittelwert";
            this.lbl_Mittelwert.Size = new System.Drawing.Size(22, 13);
            this.lbl_Mittelwert.TabIndex = 8;
            this.lbl_Mittelwert.Text = "- - -";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(70, 234);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(63, 23);
            this.btn_search.TabIndex = 9;
            this.btn_search.Text = "Suchen";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.Location = new System.Drawing.Point(18, 211);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(41, 13);
            this.lbl_search.TabIndex = 10;
            this.lbl_search.Text = "Suche:";
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(70, 208);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(88, 20);
            this.txt_search.TabIndex = 11;
            // 
            // lbl_outposition
            // 
            this.lbl_outposition.AutoSize = true;
            this.lbl_outposition.Location = new System.Drawing.Point(170, 211);
            this.lbl_outposition.Name = "lbl_outposition";
            this.lbl_outposition.Size = new System.Drawing.Size(47, 13);
            this.lbl_outposition.TabIndex = 12;
            this.lbl_outposition.Text = "Position:";
            // 
            // lbl_position
            // 
            this.lbl_position.AutoSize = true;
            this.lbl_position.Location = new System.Drawing.Point(223, 211);
            this.lbl_position.Name = "lbl_position";
            this.lbl_position.Size = new System.Drawing.Size(22, 13);
            this.lbl_position.TabIndex = 13;
            this.lbl_position.Text = "- - -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 290);
            this.Controls.Add(this.lbl_position);
            this.Controls.Add(this.lbl_outposition);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.lbl_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_Mittelwert);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.lbl_max);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.lbo_array);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.ListBox lbo_array;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lbl_max;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_Mittelwert;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_position;
        private System.Windows.Forms.Label lbl_outposition;
    }
}

