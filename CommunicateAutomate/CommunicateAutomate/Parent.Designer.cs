namespace CommunicateAutomate
{
    partial class Parent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Parent));
            this.tbParent = new System.Windows.Forms.TextBox();
            this.btnLaunchChild = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tbParent
            // 
            this.tbParent.Location = new System.Drawing.Point(106, 70);
            this.tbParent.Name = "tbParent";
            this.tbParent.Size = new System.Drawing.Size(329, 26);
            this.tbParent.TabIndex = 0;
            this.tbParent.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnLaunchChild
            // 
            this.btnLaunchChild.Location = new System.Drawing.Point(106, 316);
            this.btnLaunchChild.Name = "btnLaunchChild";
            this.btnLaunchChild.Size = new System.Drawing.Size(138, 36);
            this.btnLaunchChild.TabIndex = 1;
            this.btnLaunchChild.Text = "Launch Child";
            this.btnLaunchChild.UseVisualStyleBackColor = true;
            this.btnLaunchChild.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(106, 124);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(329, 132);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // Parent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnLaunchChild);
            this.Controls.Add(this.tbParent);
            this.Name = "Parent";
            this.Text = "Parent Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbParent;
        private System.Windows.Forms.Button btnLaunchChild;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

