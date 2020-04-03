namespace _20200328_arraystack
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
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_push = new System.Windows.Forms.Button();
            this.btn_pop = new System.Windows.Forms.Button();
            this.btn_peek = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbo_out = new System.Windows.Forms.ListBox();
            this.lbl_out_elements = new System.Windows.Forms.Label();
            this.lbl_elements = new System.Windows.Forms.Label();
            this.txt_outValue = new System.Windows.Forms.TextBox();
            this.txt_inValue = new System.Windows.Forms.TextBox();
            this.lbl_InValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_isEmpty = new System.Windows.Forms.Button();
            this.lbl_isEmpty = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(12, 167);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(132, 23);
            this.btn_clear.TabIndex = 0;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_push
            // 
            this.btn_push.Location = new System.Drawing.Point(12, 109);
            this.btn_push.Name = "btn_push";
            this.btn_push.Size = new System.Drawing.Size(60, 23);
            this.btn_push.TabIndex = 1;
            this.btn_push.Text = "Push";
            this.btn_push.UseVisualStyleBackColor = true;
            this.btn_push.Click += new System.EventHandler(this.btn_push_Click);
            // 
            // btn_pop
            // 
            this.btn_pop.Location = new System.Drawing.Point(78, 109);
            this.btn_pop.Name = "btn_pop";
            this.btn_pop.Size = new System.Drawing.Size(66, 23);
            this.btn_pop.TabIndex = 2;
            this.btn_pop.Text = "Pop";
            this.btn_pop.UseVisualStyleBackColor = true;
            this.btn_pop.Click += new System.EventHandler(this.btn_pop_Click);
            // 
            // btn_peek
            // 
            this.btn_peek.Location = new System.Drawing.Point(78, 138);
            this.btn_peek.Name = "btn_peek";
            this.btn_peek.Size = new System.Drawing.Size(66, 23);
            this.btn_peek.TabIndex = 3;
            this.btn_peek.Text = "Peek";
            this.btn_peek.UseVisualStyleBackColor = true;
            this.btn_peek.Click += new System.EventHandler(this.btn_peek_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(33, 415);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(111, 23);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbo_out
            // 
            this.lbo_out.FormattingEnabled = true;
            this.lbo_out.Location = new System.Drawing.Point(33, 244);
            this.lbo_out.Name = "lbo_out";
            this.lbo_out.Size = new System.Drawing.Size(111, 147);
            this.lbo_out.TabIndex = 5;
            // 
            // lbl_out_elements
            // 
            this.lbl_out_elements.AutoSize = true;
            this.lbl_out_elements.Location = new System.Drawing.Point(30, 203);
            this.lbl_out_elements.Name = "lbl_out_elements";
            this.lbl_out_elements.Size = new System.Drawing.Size(53, 13);
            this.lbl_out_elements.TabIndex = 6;
            this.lbl_out_elements.Text = "Elements:";
            // 
            // lbl_elements
            // 
            this.lbl_elements.AutoSize = true;
            this.lbl_elements.Location = new System.Drawing.Point(89, 203);
            this.lbl_elements.Name = "lbl_elements";
            this.lbl_elements.Size = new System.Drawing.Size(22, 13);
            this.lbl_elements.TabIndex = 7;
            this.lbl_elements.Text = "- - -";
            // 
            // txt_outValue
            // 
            this.txt_outValue.Location = new System.Drawing.Point(78, 72);
            this.txt_outValue.Name = "txt_outValue";
            this.txt_outValue.Size = new System.Drawing.Size(66, 20);
            this.txt_outValue.TabIndex = 9;
            // 
            // txt_inValue
            // 
            this.txt_inValue.Location = new System.Drawing.Point(12, 72);
            this.txt_inValue.Name = "txt_inValue";
            this.txt_inValue.Size = new System.Drawing.Size(60, 20);
            this.txt_inValue.TabIndex = 10;
            // 
            // lbl_InValue
            // 
            this.lbl_InValue.AutoSize = true;
            this.lbl_InValue.Location = new System.Drawing.Point(9, 56);
            this.lbl_InValue.Name = "lbl_InValue";
            this.lbl_InValue.Size = new System.Drawing.Size(43, 13);
            this.lbl_InValue.TabIndex = 11;
            this.lbl_InValue.Text = "InValue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "OutValue";
            // 
            // btn_isEmpty
            // 
            this.btn_isEmpty.Location = new System.Drawing.Point(348, 109);
            this.btn_isEmpty.Name = "btn_isEmpty";
            this.btn_isEmpty.Size = new System.Drawing.Size(75, 23);
            this.btn_isEmpty.TabIndex = 13;
            this.btn_isEmpty.Text = "isEmpty";
            this.btn_isEmpty.UseVisualStyleBackColor = true;
            this.btn_isEmpty.Click += new System.EventHandler(this.btn_isEmpty_Click);
            // 
            // lbl_isEmpty
            // 
            this.lbl_isEmpty.AutoSize = true;
            this.lbl_isEmpty.Location = new System.Drawing.Point(307, 114);
            this.lbl_isEmpty.Name = "lbl_isEmpty";
            this.lbl_isEmpty.Size = new System.Drawing.Size(22, 13);
            this.lbl_isEmpty.TabIndex = 14;
            this.lbl_isEmpty.Text = "- - -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.lbl_isEmpty);
            this.Controls.Add(this.btn_isEmpty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_InValue);
            this.Controls.Add(this.txt_inValue);
            this.Controls.Add(this.txt_outValue);
            this.Controls.Add(this.lbl_elements);
            this.Controls.Add(this.lbl_out_elements);
            this.Controls.Add(this.lbo_out);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_peek);
            this.Controls.Add(this.btn_pop);
            this.Controls.Add(this.btn_push);
            this.Controls.Add(this.btn_clear);
            this.Name = "Form1";
            this.Text = "S";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_push;
        private System.Windows.Forms.Button btn_pop;
        private System.Windows.Forms.Button btn_peek;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ListBox lbo_out;
        private System.Windows.Forms.Label lbl_out_elements;
        private System.Windows.Forms.Label lbl_elements;
        private System.Windows.Forms.TextBox txt_outValue;
        private System.Windows.Forms.TextBox txt_inValue;
        private System.Windows.Forms.Label lbl_InValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_isEmpty;
        private System.Windows.Forms.Label lbl_isEmpty;
    }
}

