namespace Polimorfismo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbAdd = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnGetElement = new System.Windows.Forms.Button();
            this.tbGet = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar elemento";
            // 
            // tbAdd
            // 
            this.tbAdd.Location = new System.Drawing.Point(320, 129);
            this.tbAdd.Name = "tbAdd";
            this.tbAdd.Size = new System.Drawing.Size(339, 31);
            this.tbAdd.TabIndex = 1;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(482, 198);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(166, 47);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Aceptar";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnGetElement
            // 
            this.btnGetElement.Location = new System.Drawing.Point(425, 423);
            this.btnGetElement.Name = "btnGetElement";
            this.btnGetElement.Size = new System.Drawing.Size(234, 63);
            this.btnGetElement.TabIndex = 3;
            this.btnGetElement.Text = "Obtener Elemento";
            this.btnGetElement.UseVisualStyleBackColor = true;
            this.btnGetElement.Click += new System.EventHandler(this.btnGetElement_Click);
            // 
            // tbGet
            // 
            this.tbGet.Location = new System.Drawing.Point(199, 423);
            this.tbGet.Name = "tbGet";
            this.tbGet.Size = new System.Drawing.Size(190, 31);
            this.tbGet.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Indice";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 560);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGet);
            this.Controls.Add(this.btnGetElement);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tbAdd);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAdd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnGetElement;
        private System.Windows.Forms.TextBox tbGet;
        private System.Windows.Forms.Label label2;
    }
}

