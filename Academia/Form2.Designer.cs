namespace Academia
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.botão_voltar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_peso = new System.Windows.Forms.TextBox();
            this.maskedTextBox_telefone = new System.Windows.Forms.MaskedTextBox();
            this.label_altura = new System.Windows.Forms.Label();
            this.textBox_altura = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_sexo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label_data_nascimento = new System.Windows.Forms.Label();
            this.botão_cadastro2 = new System.Windows.Forms.Button();
            this.label_sexo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_telefone = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // botão_voltar
            // 
            this.botão_voltar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botão_voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botão_voltar.Location = new System.Drawing.Point(627, 608);
            this.botão_voltar.Name = "botão_voltar";
            this.botão_voltar.Size = new System.Drawing.Size(352, 60);
            this.botão_voltar.TabIndex = 83;
            this.botão_voltar.Text = "Voltar";
            this.botão_voltar.UseVisualStyleBackColor = false;
            this.botão_voltar.Click += new System.EventHandler(this.botão_voltar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(495, 489);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Peso:";
            // 
            // textBox_peso
            // 
            this.textBox_peso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_peso.Location = new System.Drawing.Point(496, 505);
            this.textBox_peso.Name = "textBox_peso";
            this.textBox_peso.Size = new System.Drawing.Size(425, 26);
            this.textBox_peso.TabIndex = 81;
            // 
            // maskedTextBox_telefone
            // 
            this.maskedTextBox_telefone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.maskedTextBox_telefone.Location = new System.Drawing.Point(496, 277);
            this.maskedTextBox_telefone.Mask = "(99) 99999-9999";
            this.maskedTextBox_telefone.Name = "maskedTextBox_telefone";
            this.maskedTextBox_telefone.Size = new System.Drawing.Size(425, 26);
            this.maskedTextBox_telefone.TabIndex = 80;
            // 
            // label_altura
            // 
            this.label_altura.AutoSize = true;
            this.label_altura.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_altura.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_altura.Location = new System.Drawing.Point(495, 432);
            this.label_altura.Name = "label_altura";
            this.label_altura.Size = new System.Drawing.Size(42, 13);
            this.label_altura.TabIndex = 77;
            this.label_altura.Text = "Altura:";
            // 
            // textBox_altura
            // 
            this.textBox_altura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.textBox_altura.Location = new System.Drawing.Point(496, 448);
            this.textBox_altura.Name = "textBox_altura";
            this.textBox_altura.Size = new System.Drawing.Size(425, 26);
            this.textBox_altura.TabIndex = 76;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dateTimePicker1.Location = new System.Drawing.Point(496, 332);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(425, 26);
            this.dateTimePicker1.TabIndex = 75;
            this.dateTimePicker1.Value = new System.DateTime(2026, 10, 26, 9, 13, 28, 0);
            // 
            // comboBox_sexo
            // 
            this.comboBox_sexo.AutoCompleteCustomSource.AddRange(new string[] {
            "Masculino",
            "Feminino"});
            this.comboBox_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_sexo.FormattingEnabled = true;
            this.comboBox_sexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.comboBox_sexo.Location = new System.Drawing.Point(496, 388);
            this.comboBox_sexo.Name = "comboBox_sexo";
            this.comboBox_sexo.Size = new System.Drawing.Size(425, 28);
            this.comboBox_sexo.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleName = "";
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.25F);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(496, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(425, 136);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(89, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Insira suas informações para finalizarmos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ebrima", 23.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(61, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informações Pessoais";
            // 
            // label_data_nascimento
            // 
            this.label_data_nascimento.AutoSize = true;
            this.label_data_nascimento.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_data_nascimento.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_data_nascimento.Location = new System.Drawing.Point(493, 313);
            this.label_data_nascimento.Name = "label_data_nascimento";
            this.label_data_nascimento.Size = new System.Drawing.Size(115, 13);
            this.label_data_nascimento.TabIndex = 71;
            this.label_data_nascimento.Text = "Data de Nascimento:";
            // 
            // botão_cadastro2
            // 
            this.botão_cadastro2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.botão_cadastro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.botão_cadastro2.Location = new System.Drawing.Point(221, 608);
            this.botão_cadastro2.Name = "botão_cadastro2";
            this.botão_cadastro2.Size = new System.Drawing.Size(340, 60);
            this.botão_cadastro2.TabIndex = 63;
            this.botão_cadastro2.Text = "Cadastrar";
            this.botão_cadastro2.UseVisualStyleBackColor = false;
            // 
            // label_sexo
            // 
            this.label_sexo.AutoSize = true;
            this.label_sexo.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_sexo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_sexo.Location = new System.Drawing.Point(495, 367);
            this.label_sexo.Name = "label_sexo";
            this.label_sexo.Size = new System.Drawing.Size(35, 13);
            this.label_sexo.TabIndex = 69;
            this.label_sexo.Text = "Sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Location = new System.Drawing.Point(523, 355);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 68;
            // 
            // groupBox2
            // 
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Location = new System.Drawing.Point(32, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 482);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label5.Location = new System.Drawing.Point(523, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 67;
            // 
            // label_telefone
            // 
            this.label_telefone.AutoSize = true;
            this.label_telefone.Font = new System.Drawing.Font("Nirmala Text", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_telefone.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_telefone.Location = new System.Drawing.Point(493, 257);
            this.label_telefone.Name = "label_telefone";
            this.label_telefone.Size = new System.Drawing.Size(54, 13);
            this.label_telefone.TabIndex = 66;
            this.label_telefone.Text = "Telefone:";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1062, 753);
            this.Controls.Add(this.botão_voltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_peso);
            this.Controls.Add(this.maskedTextBox_telefone);
            this.Controls.Add(this.label_altura);
            this.Controls.Add(this.textBox_altura);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox_sexo);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label_data_nascimento);
            this.Controls.Add(this.botão_cadastro2);
            this.Controls.Add(this.label_sexo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label_telefone);
            this.Name = "Form2";
            this.Text = "Segundo cadastro do professor ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botão_voltar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_peso;
        private System.Windows.Forms.MaskedTextBox maskedTextBox_telefone;
        private System.Windows.Forms.Label label_altura;
        private System.Windows.Forms.TextBox textBox_altura;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox_sexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_data_nascimento;
        private System.Windows.Forms.Button botão_cadastro2;
        private System.Windows.Forms.Label label_sexo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_telefone;
    }
}