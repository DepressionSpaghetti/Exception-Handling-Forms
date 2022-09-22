namespace MojaPrvaWindowsAplikacija
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
            this.txtBroj_a = new System.Windows.Forms.TextBox();
            this.txtBroj_b = new System.Windows.Forms.TextBox();
            this.txtSuma = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIzracun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBroj_a
            // 
            this.txtBroj_a.Location = new System.Drawing.Point(127, 90);
            this.txtBroj_a.Name = "txtBroj_a";
            this.txtBroj_a.Size = new System.Drawing.Size(100, 20);
            this.txtBroj_a.TabIndex = 0;
            this.txtBroj_a.TextChanged += new System.EventHandler(this.txtBroj_a_TextChanged);
            // 
            // txtBroj_b
            // 
            this.txtBroj_b.Location = new System.Drawing.Point(524, 89);
            this.txtBroj_b.Name = "txtBroj_b";
            this.txtBroj_b.Size = new System.Drawing.Size(100, 20);
            this.txtBroj_b.TabIndex = 1;
            // 
            // txtSuma
            // 
            this.txtSuma.Enabled = false;
            this.txtSuma.Location = new System.Drawing.Point(127, 305);
            this.txtSuma.Name = "txtSuma";
            this.txtSuma.Size = new System.Drawing.Size(100, 20);
            this.txtSuma.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Broj a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Broj b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(127, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Suma";
            // 
            // btnIzracun
            // 
            this.btnIzracun.Location = new System.Drawing.Point(527, 301);
            this.btnIzracun.Name = "btnIzracun";
            this.btnIzracun.Size = new System.Drawing.Size(75, 23);
            this.btnIzracun.TabIndex = 6;
            this.btnIzracun.Text = "Izracunaj";
            this.btnIzracun.UseVisualStyleBackColor = true;
            this.btnIzracun.Click += new System.EventHandler(this.btnIzracun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnIzracun);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSuma);
            this.Controls.Add(this.txtBroj_b);
            this.Controls.Add(this.txtBroj_a);
            this.Name = "Form1";
            this.Text = "Moj prva windows aplikacija";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBroj_a;
        private System.Windows.Forms.TextBox txtBroj_b;
        private System.Windows.Forms.TextBox txtSuma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIzracun;
    }
}

