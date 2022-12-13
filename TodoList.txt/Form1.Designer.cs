namespace TodoList.txt
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textValue_add = new System.Windows.Forms.TextBox();
            this.textValue_remove = new System.Windows.Forms.TextBox();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Remove_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(282, 282);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // textValue_add
            // 
            this.textValue_add.Location = new System.Drawing.Point(12, 325);
            this.textValue_add.Multiline = true;
            this.textValue_add.Name = "textValue_add";
            this.textValue_add.Size = new System.Drawing.Size(282, 26);
            this.textValue_add.TabIndex = 1;
            // 
            // textValue_remove
            // 
            this.textValue_remove.Location = new System.Drawing.Point(12, 380);
            this.textValue_remove.Multiline = true;
            this.textValue_remove.Name = "textValue_remove";
            this.textValue_remove.Size = new System.Drawing.Size(282, 26);
            this.textValue_remove.TabIndex = 2;
            this.textValue_remove.TextChanged += new System.EventHandler(this.textValue_remove_TextChanged);
            // 
            // Add_btn
            // 
            this.Add_btn.Location = new System.Drawing.Point(343, 325);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(87, 26);
            this.Add_btn.TabIndex = 3;
            this.Add_btn.Text = "Add Todo";
            this.Add_btn.UseVisualStyleBackColor = true;
            this.Add_btn.Click += new System.EventHandler(this.Add_btn_Click);
            // 
            // Remove_btn
            // 
            this.Remove_btn.Location = new System.Drawing.Point(343, 380);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(87, 26);
            this.Remove_btn.TabIndex = 4;
            this.Remove_btn.Text = "Remove Todo";
            this.Remove_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 450);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.textValue_remove);
            this.Controls.Add(this.textValue_add);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Todo List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textValue_add;
        private TextBox textValue_remove;
        private Button Add_btn;
        private Button Remove_btn;
    }
}