namespace _29112019_Bibliothek
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
            this.txt_buchname = new System.Windows.Forms.TextBox();
            this.lbo_bibliothek = new System.Windows.Forms.ListBox();
            this.lbl_input = new System.Windows.Forms.Label();
            this.lbl_buchname = new System.Windows.Forms.Label();
            this.lbl_author = new System.Windows.Forms.Label();
            this.lbl_erschjahr = new System.Windows.Forms.Label();
            this.lbl_verlag = new System.Windows.Forms.Label();
            this.txt_author = new System.Windows.Forms.TextBox();
            this.txt_erschjahr = new System.Windows.Forms.TextBox();
            this.txt_verlag = new System.Windows.Forms.TextBox();
            this.txt_isbn = new System.Windows.Forms.TextBox();
            this.lbl_isbn = new System.Windows.Forms.Label();
            this.btn_remove = new System.Windows.Forms.Button();
            this.txt_suche = new System.Windows.Forms.TextBox();
            this.lbl_suche = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_index = new System.Windows.Forms.Label();
            this.lbl_isbntest = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(15, 181);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "Hinzufügen";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(272, 280);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 1;
            this.btn_close.Text = "Schließen";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_buchname
            // 
            this.txt_buchname.Location = new System.Drawing.Point(106, 50);
            this.txt_buchname.Name = "txt_buchname";
            this.txt_buchname.Size = new System.Drawing.Size(100, 20);
            this.txt_buchname.TabIndex = 2;
            // 
            // lbo_bibliothek
            // 
            this.lbo_bibliothek.FormattingEnabled = true;
            this.lbo_bibliothek.Location = new System.Drawing.Point(223, 12);
            this.lbo_bibliothek.Name = "lbo_bibliothek";
            this.lbo_bibliothek.Size = new System.Drawing.Size(489, 225);
            this.lbo_bibliothek.TabIndex = 3;
            this.lbo_bibliothek.TabStop = false;
            this.lbo_bibliothek.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(12, 23);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(49, 13);
            this.lbl_input.TabIndex = 4;
            this.lbl_input.Text = "Eingabe:";
            // 
            // lbl_buchname
            // 
            this.lbl_buchname.AutoSize = true;
            this.lbl_buchname.Location = new System.Drawing.Point(12, 53);
            this.lbl_buchname.Name = "lbl_buchname";
            this.lbl_buchname.Size = new System.Drawing.Size(61, 13);
            this.lbl_buchname.TabIndex = 6;
            this.lbl_buchname.Text = "Buchname:";
            // 
            // lbl_author
            // 
            this.lbl_author.AutoSize = true;
            this.lbl_author.Location = new System.Drawing.Point(12, 79);
            this.lbl_author.Name = "lbl_author";
            this.lbl_author.Size = new System.Drawing.Size(41, 13);
            this.lbl_author.TabIndex = 7;
            this.lbl_author.Text = "Author:";
            // 
            // lbl_erschjahr
            // 
            this.lbl_erschjahr.AutoSize = true;
            this.lbl_erschjahr.Location = new System.Drawing.Point(12, 102);
            this.lbl_erschjahr.Name = "lbl_erschjahr";
            this.lbl_erschjahr.Size = new System.Drawing.Size(88, 13);
            this.lbl_erschjahr.TabIndex = 8;
            this.lbl_erschjahr.Text = "Erscheinungsjahr";
            // 
            // lbl_verlag
            // 
            this.lbl_verlag.AutoSize = true;
            this.lbl_verlag.Location = new System.Drawing.Point(12, 123);
            this.lbl_verlag.Name = "lbl_verlag";
            this.lbl_verlag.Size = new System.Drawing.Size(40, 13);
            this.lbl_verlag.TabIndex = 9;
            this.lbl_verlag.Text = "Verlag:";
            // 
            // txt_author
            // 
            this.txt_author.Location = new System.Drawing.Point(106, 76);
            this.txt_author.Name = "txt_author";
            this.txt_author.Size = new System.Drawing.Size(100, 20);
            this.txt_author.TabIndex = 10;
            // 
            // txt_erschjahr
            // 
            this.txt_erschjahr.Location = new System.Drawing.Point(106, 99);
            this.txt_erschjahr.Name = "txt_erschjahr";
            this.txt_erschjahr.Size = new System.Drawing.Size(100, 20);
            this.txt_erschjahr.TabIndex = 11;
            // 
            // txt_verlag
            // 
            this.txt_verlag.Location = new System.Drawing.Point(106, 122);
            this.txt_verlag.Name = "txt_verlag";
            this.txt_verlag.Size = new System.Drawing.Size(100, 20);
            this.txt_verlag.TabIndex = 12;
            // 
            // txt_isbn
            // 
            this.txt_isbn.Location = new System.Drawing.Point(106, 143);
            this.txt_isbn.Name = "txt_isbn";
            this.txt_isbn.Size = new System.Drawing.Size(100, 20);
            this.txt_isbn.TabIndex = 13;
            // 
            // lbl_isbn
            // 
            this.lbl_isbn.AutoSize = true;
            this.lbl_isbn.Location = new System.Drawing.Point(12, 145);
            this.lbl_isbn.Name = "lbl_isbn";
            this.lbl_isbn.Size = new System.Drawing.Size(35, 13);
            this.lbl_isbn.TabIndex = 14;
            this.lbl_isbn.Text = "ISBN:";
            // 
            // btn_remove
            // 
            this.btn_remove.Location = new System.Drawing.Point(106, 181);
            this.btn_remove.Name = "btn_remove";
            this.btn_remove.Size = new System.Drawing.Size(75, 23);
            this.btn_remove.TabIndex = 15;
            this.btn_remove.Text = "Löschen";
            this.btn_remove.UseVisualStyleBackColor = true;
            this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
            // 
            // txt_suche
            // 
            this.txt_suche.Location = new System.Drawing.Point(85, 282);
            this.txt_suche.Name = "txt_suche";
            this.txt_suche.Size = new System.Drawing.Size(100, 20);
            this.txt_suche.TabIndex = 16;
            // 
            // lbl_suche
            // 
            this.lbl_suche.AutoSize = true;
            this.lbl_suche.Location = new System.Drawing.Point(38, 285);
            this.lbl_suche.Name = "lbl_suche";
            this.lbl_suche.Size = new System.Drawing.Size(41, 13);
            this.lbl_suche.TabIndex = 17;
            this.lbl_suche.Text = "Suche:";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(191, 280);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 18;
            this.btn_search.Text = "Suchen";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_index
            // 
            this.lbl_index.AutoSize = true;
            this.lbl_index.Location = new System.Drawing.Point(12, 285);
            this.lbl_index.Name = "lbl_index";
            this.lbl_index.Size = new System.Drawing.Size(22, 13);
            this.lbl_index.TabIndex = 19;
            this.lbl_index.Text = "- - -";
            // 
            // lbl_isbntest
            // 
            this.lbl_isbntest.AutoSize = true;
            this.lbl_isbntest.Location = new System.Drawing.Point(103, 165);
            this.lbl_isbntest.Name = "lbl_isbntest";
            this.lbl_isbntest.Size = new System.Drawing.Size(22, 13);
            this.lbl_isbntest.TabIndex = 20;
            this.lbl_isbntest.Text = "- - -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 401);
            this.Controls.Add(this.lbl_isbntest);
            this.Controls.Add(this.lbl_index);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lbl_suche);
            this.Controls.Add(this.txt_suche);
            this.Controls.Add(this.btn_remove);
            this.Controls.Add(this.lbl_isbn);
            this.Controls.Add(this.txt_isbn);
            this.Controls.Add(this.txt_verlag);
            this.Controls.Add(this.txt_erschjahr);
            this.Controls.Add(this.txt_author);
            this.Controls.Add(this.lbl_verlag);
            this.Controls.Add(this.lbl_erschjahr);
            this.Controls.Add(this.lbl_author);
            this.Controls.Add(this.lbl_buchname);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.lbo_bibliothek);
            this.Controls.Add(this.txt_buchname);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_add);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_buchname;
        private System.Windows.Forms.ListBox lbo_bibliothek;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.Label lbl_buchname;
        private System.Windows.Forms.Label lbl_author;
        private System.Windows.Forms.Label lbl_erschjahr;
        private System.Windows.Forms.Label lbl_verlag;
        private System.Windows.Forms.TextBox txt_author;
        private System.Windows.Forms.TextBox txt_erschjahr;
        private System.Windows.Forms.TextBox txt_verlag;
        private System.Windows.Forms.TextBox txt_isbn;
        private System.Windows.Forms.Label lbl_isbn;
        private System.Windows.Forms.Button btn_remove;
        private System.Windows.Forms.TextBox txt_suche;
        private System.Windows.Forms.Label lbl_suche;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_index;
        private System.Windows.Forms.Label lbl_isbntest;
    }
}

