namespace _20200324_fakultaet
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
            this.components = new System.ComponentModel.Container();
            this.btn_calc = new System.Windows.Forms.Button();
            this.lbl_input = new System.Windows.Forms.Label();
            this.txt_input_n = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbl_out_solution = new System.Windows.Forms.Label();
            this.lbl_solution = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calc
            // 
            this.btn_calc.Location = new System.Drawing.Point(163, 4);
            this.btn_calc.Name = "btn_calc";
            this.btn_calc.Size = new System.Drawing.Size(75, 23);
            this.btn_calc.TabIndex = 0;
            this.btn_calc.Text = "calc";
            this.btn_calc.UseVisualStyleBackColor = true;
            this.btn_calc.Click += new System.EventHandler(this.btn_calc_Click);
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(8, 9);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(43, 13);
            this.lbl_input.TabIndex = 1;
            this.lbl_input.Text = "Input n:";
            // 
            // txt_input_n
            // 
            this.txt_input_n.Location = new System.Drawing.Point(57, 6);
            this.txt_input_n.Name = "txt_input_n";
            this.txt_input_n.Size = new System.Drawing.Size(100, 20);
            this.txt_input_n.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbl_out_solution
            // 
            this.lbl_out_solution.AutoSize = true;
            this.lbl_out_solution.Location = new System.Drawing.Point(8, 97);
            this.lbl_out_solution.Name = "lbl_out_solution";
            this.lbl_out_solution.Size = new System.Drawing.Size(48, 13);
            this.lbl_out_solution.TabIndex = 3;
            this.lbl_out_solution.Text = "Solution:";
            // 
            // lbl_solution
            // 
            this.lbl_solution.AutoSize = true;
            this.lbl_solution.Location = new System.Drawing.Point(62, 97);
            this.lbl_solution.Name = "lbl_solution";
            this.lbl_solution.Size = new System.Drawing.Size(22, 13);
            this.lbl_solution.TabIndex = 4;
            this.lbl_solution.Text = "- - -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_solution);
            this.Controls.Add(this.lbl_out_solution);
            this.Controls.Add(this.txt_input_n);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.btn_calc);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calc;
        private System.Windows.Forms.Label lbl_input;
        private System.Windows.Forms.TextBox txt_input_n;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label lbl_solution;
        private System.Windows.Forms.Label lbl_out_solution;
    }
}

