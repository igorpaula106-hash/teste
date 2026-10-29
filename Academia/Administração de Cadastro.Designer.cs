namespace Academia
{
    partial class Administração_de_Cadastro
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.título_consultar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(405, 264);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(345, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = " Aluno";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(405, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(345, 61);
            this.button2.TabIndex = 1;
            this.button2.Text = " Professor";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // título_consultar
            // 
            this.título_consultar.AutoSize = true;
            this.título_consultar.BackColor = System.Drawing.Color.Transparent;
            this.título_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.título_consultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.título_consultar.Location = new System.Drawing.Point(509, 161);
            this.título_consultar.Name = "título_consultar";
            this.título_consultar.Size = new System.Drawing.Size(159, 37);
            this.título_consultar.TabIndex = 2;
            this.título_consultar.Text = "Cadastrar";
            // 
            // Administração_de_Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1079, 691);
            this.Controls.Add(this.título_consultar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.MaximumSize = new System.Drawing.Size(1095, 730);
            this.MinimumSize = new System.Drawing.Size(1095, 730);
            this.Name = "Administração_de_Cadastro";
            this.Text = "Administração_de_Cadastro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label título_consultar;
    }
}