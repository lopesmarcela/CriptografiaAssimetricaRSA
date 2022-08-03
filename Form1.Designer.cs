namespace Criptografia
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
            this.tbfrase = new System.Windows.Forms.TextBox();
            this.btnCriptografar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDescriptografar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblcripto = new System.Windows.Forms.Label();
            this.lbldescrip = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbfrase
            // 
            this.tbfrase.Location = new System.Drawing.Point(211, 59);
            this.tbfrase.Name = "tbfrase";
            this.tbfrase.Size = new System.Drawing.Size(383, 23);
            this.tbfrase.TabIndex = 0;
            // 
            // btnCriptografar
            // 
            this.btnCriptografar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCriptografar.Location = new System.Drawing.Point(341, 93);
            this.btnCriptografar.Name = "btnCriptografar";
            this.btnCriptografar.Size = new System.Drawing.Size(105, 38);
            this.btnCriptografar.TabIndex = 2;
            this.btnCriptografar.Text = "Criptografar";
            this.btnCriptografar.UseVisualStyleBackColor = true;
            this.btnCriptografar.Click += new System.EventHandler(this.btnCriptografar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Frase:";
            // 
            // btnDescriptografar
            // 
            this.btnDescriptografar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDescriptografar.Location = new System.Drawing.Point(331, 273);
            this.btnDescriptografar.Name = "btnDescriptografar";
            this.btnDescriptografar.Size = new System.Drawing.Size(128, 38);
            this.btnDescriptografar.TabIndex = 4;
            this.btnDescriptografar.Text = "Descriptografar";
            this.btnDescriptografar.UseVisualStyleBackColor = true;
            this.btnDescriptografar.Click += new System.EventHandler(this.btnDescriptografar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Frase criptografada:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Frase descriptografada:";
            // 
            // lblcripto
            // 
            this.lblcripto.AutoSize = true;
            this.lblcripto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblcripto.Location = new System.Drawing.Point(211, 179);
            this.lblcripto.Name = "lblcripto";
            this.lblcripto.Size = new System.Drawing.Size(16, 21);
            this.lblcripto.TabIndex = 7;
            this.lblcripto.Text = "-";
            // 
            // lbldescrip
            // 
            this.lbldescrip.AutoSize = true;
            this.lbldescrip.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbldescrip.Location = new System.Drawing.Point(211, 310);
            this.lbldescrip.Name = "lbldescrip";
            this.lbldescrip.Size = new System.Drawing.Size(16, 21);
            this.lbldescrip.TabIndex = 8;
            this.lbldescrip.Text = "-";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(211, 141);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 121);
            this.textBox1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 353);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbldescrip);
            this.Controls.Add(this.lblcripto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDescriptografar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCriptografar);
            this.Controls.Add(this.tbfrase);
            this.Name = "Form1";
            this.Text = "Algoritmo Criptografia RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbfrase;
        private Button btnCriptografar;
        private Label label1;
        private Button btnDescriptografar;
        private Label label2;
        private Label label3;
        private Label lblcripto;
        private Label lbldescrip;
        private TextBox textBox1;
    }
}