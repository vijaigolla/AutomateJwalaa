namespace CommunicateAutomate
{
    partial class Child
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
            this.tbChild = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbChild
            // 
            this.tbChild.Location = new System.Drawing.Point(76, 88);
            this.tbChild.Name = "tbChild";
            this.tbChild.Size = new System.Drawing.Size(336, 26);
            this.tbChild.TabIndex = 0;
            this.tbChild.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(76, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(336, 139);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "Data entered in this child window will show up in the parent and from the parent " +
    "to the Program.cs";
            // 
            // Child
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 423);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbChild);
            this.Name = "Child";
            this.Text = "ChildForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbChild;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}