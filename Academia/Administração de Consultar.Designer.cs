namespace Academia
{
    partial class Consultar
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.título_consultar = new System.Windows.Forms.Label();
            this.botão_atualizar = new System.Windows.Forms.Button();
            this.botão_excluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(976, 419);
            this.dataGridView1.TabIndex = 0;
            // 
            // título_consultar
            // 
            this.título_consultar.AutoSize = true;
            this.título_consultar.BackColor = System.Drawing.Color.Transparent;
            this.título_consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.título_consultar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.título_consultar.Location = new System.Drawing.Point(256, 36);
            this.título_consultar.Name = "título_consultar";
            this.título_consultar.Size = new System.Drawing.Size(562, 37);
            this.título_consultar.TabIndex = 1;
            this.título_consultar.Text = " Cadastrados de alunos e Professores";
            // 
            // botão_atualizar
            // 
            this.botão_atualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botão_atualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botão_atualizar.Location = new System.Drawing.Point(25, 580);
            this.botão_atualizar.Name = "botão_atualizar";
            this.botão_atualizar.Size = new System.Drawing.Size(254, 58);
            this.botão_atualizar.TabIndex = 2;
            this.botão_atualizar.Text = "Atualizar";
            this.botão_atualizar.UseVisualStyleBackColor = false;
            // 
            // botão_excluir
            // 
            this.botão_excluir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botão_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.botão_excluir.Location = new System.Drawing.Point(326, 580);
            this.botão_excluir.Name = "botão_excluir";
            this.botão_excluir.Size = new System.Drawing.Size(254, 58);
            this.botão_excluir.TabIndex = 3;
            this.botão_excluir.Text = "Excluir";
            this.botão_excluir.UseVisualStyleBackColor = false;
            // 
            // Consultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1079, 691);
            this.Controls.Add(this.botão_excluir);
            this.Controls.Add(this.botão_atualizar);
            this.Controls.Add(this.título_consultar);
            this.Controls.Add(this.dataGridView1);
            this.MaximumSize = new System.Drawing.Size(1095, 730);
            this.MinimumSize = new System.Drawing.Size(1095, 730);
            this.Name = "Consultar";
            this.Text = "Consultar";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label título_consultar;
        private System.Windows.Forms.Button botão_atualizar;
        private System.Windows.Forms.Button botão_excluir;
    }
}