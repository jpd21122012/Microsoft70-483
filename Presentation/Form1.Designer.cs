namespace Presentation
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
            this.lstClasses = new System.Windows.Forms.ListBox();
            this.lstAttributes = new System.Windows.Forms.ListBox();
            this.lstMethods = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstClasses
            // 
            this.lstClasses.FormattingEnabled = true;
            this.lstClasses.ItemHeight = 25;
            this.lstClasses.Location = new System.Drawing.Point(78, 75);
            this.lstClasses.Name = "lstClasses";
            this.lstClasses.Size = new System.Drawing.Size(423, 579);
            this.lstClasses.TabIndex = 0;
            // 
            // lstAttributes
            // 
            this.lstAttributes.FormattingEnabled = true;
            this.lstAttributes.ItemHeight = 25;
            this.lstAttributes.Location = new System.Drawing.Point(637, 75);
            this.lstAttributes.Name = "lstAttributes";
            this.lstAttributes.Size = new System.Drawing.Size(462, 579);
            this.lstAttributes.TabIndex = 1;
            // 
            // lstMethods
            // 
            this.lstMethods.FormattingEnabled = true;
            this.lstMethods.ItemHeight = 25;
            this.lstMethods.Location = new System.Drawing.Point(1221, 75);
            this.lstMethods.Name = "lstMethods";
            this.lstMethods.Size = new System.Drawing.Size(468, 579);
            this.lstMethods.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1779, 1047);
            this.Controls.Add(this.lstMethods);
            this.Controls.Add(this.lstAttributes);
            this.Controls.Add(this.lstClasses);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstClasses;
        private System.Windows.Forms.ListBox lstAttributes;
        private System.Windows.Forms.ListBox lstMethods;
    }
}

