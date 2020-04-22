namespace _11122019_ArraySorting
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_generate = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_sort = new System.Windows.Forms.Button();
            this.Btn_remove = new System.Windows.Forms.Button();
            this.Btn_removeduplicates = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(303, 147);
            this.listBox1.TabIndex = 0;
            // 
            // btn_generate
            // 
            this.btn_generate.Location = new System.Drawing.Point(12, 194);
            this.btn_generate.Name = "btn_generate";
            this.btn_generate.Size = new System.Drawing.Size(75, 23);
            this.btn_generate.TabIndex = 1;
            this.btn_generate.Text = "Generate";
            this.btn_generate.UseVisualStyleBackColor = true;
            this.btn_generate.Click += new System.EventHandler(this.Btn_generate_Click);
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(240, 194);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.Btn_close_Click);
            // 
            // btn_sort
            // 
            this.btn_sort.Location = new System.Drawing.Point(131, 194);
            this.btn_sort.Name = "btn_sort";
            this.btn_sort.Size = new System.Drawing.Size(75, 23);
            this.btn_sort.TabIndex = 3;
            this.btn_sort.Text = "Sort";
            this.btn_sort.UseVisualStyleBackColor = true;
            this.btn_sort.Click += new System.EventHandler(this.Btn_sort_Click);
            // 
            // Btn_remove
            // 
            this.Btn_remove.Location = new System.Drawing.Point(93, 166);
            this.Btn_remove.Name = "Btn_remove";
            this.Btn_remove.Size = new System.Drawing.Size(75, 23);
            this.Btn_remove.TabIndex = 4;
            this.Btn_remove.Text = "Remove";
            this.Btn_remove.UseVisualStyleBackColor = true;
            this.Btn_remove.Click += new System.EventHandler(this.Btn_remove_Click);
            // 
            // Btn_removeduplicates
            // 
            this.Btn_removeduplicates.Location = new System.Drawing.Point(174, 166);
            this.Btn_removeduplicates.Name = "Btn_removeduplicates";
            this.Btn_removeduplicates.Size = new System.Drawing.Size(141, 23);
            this.Btn_removeduplicates.TabIndex = 5;
            this.Btn_removeduplicates.Text = "Remove Duplicates";
            this.Btn_removeduplicates.UseVisualStyleBackColor = true;
            this.Btn_removeduplicates.Click += new System.EventHandler(this.Btn_removeduplicates_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 229);
            this.Controls.Add(this.Btn_removeduplicates);
            this.Controls.Add(this.Btn_remove);
            this.Controls.Add(this.btn_sort);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_generate);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_generate;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_sort;
        private System.Windows.Forms.Button Btn_remove;
        private System.Windows.Forms.Button Btn_removeduplicates;
    }
}

