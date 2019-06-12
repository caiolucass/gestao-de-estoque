namespace GestaodeVendas
{
    partial class FormVendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVendas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1_vender = new System.Windows.Forms.Button();
            this.textBox1_id = new System.Windows.Forms.TextBox();
            this.textBox2_nome = new System.Windows.Forms.TextBox();
            this.textBox3_quantidade = new System.Windows.Forms.TextBox();
            this.textBox4_preçouni = new System.Windows.Forms.TextBox();
            this.textBox5_preçofinal = new System.Windows.Forms.TextBox();
            this.button2_menos = new System.Windows.Forms.Button();
            this.button3_mais = new System.Windows.Forms.Button();
            this.button1_finalizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button4_estoque = new System.Windows.Forms.Button();
            this.button4_procurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label1.Location = new System.Drawing.Point(49, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID do Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label2.Location = new System.Drawing.Point(49, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do produto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label3.Location = new System.Drawing.Point(49, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantidade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label4.Location = new System.Drawing.Point(48, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço unitário:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.label5.Location = new System.Drawing.Point(49, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Preço final:";
            // 
            // button1_vender
            // 
            this.button1_vender.BackColor = System.Drawing.Color.White;
            this.button1_vender.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_vender.FlatAppearance.BorderSize = 2;
            this.button1_vender.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1_vender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_vender.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1_vender.Location = new System.Drawing.Point(12, 342);
            this.button1_vender.Name = "button1_vender";
            this.button1_vender.Size = new System.Drawing.Size(97, 52);
            this.button1_vender.TabIndex = 5;
            this.button1_vender.Text = "Vender";
            this.button1_vender.UseVisualStyleBackColor = false;
            this.button1_vender.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1_id
            // 
            this.textBox1_id.Location = new System.Drawing.Point(239, 90);
            this.textBox1_id.Name = "textBox1_id";
            this.textBox1_id.Size = new System.Drawing.Size(142, 20);
            this.textBox1_id.TabIndex = 6;
            this.textBox1_id.TextChanged += new System.EventHandler(this.textBox1_id_TextChanged);
            // 
            // textBox2_nome
            // 
            this.textBox2_nome.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox2_nome.Location = new System.Drawing.Point(239, 132);
            this.textBox2_nome.Name = "textBox2_nome";
            this.textBox2_nome.ReadOnly = true;
            this.textBox2_nome.Size = new System.Drawing.Size(142, 20);
            this.textBox2_nome.TabIndex = 7;
            this.textBox2_nome.TextChanged += new System.EventHandler(this.textBox2_nome_TextChanged);
            // 
            // textBox3_quantidade
            // 
            this.textBox3_quantidade.Location = new System.Drawing.Point(281, 214);
            this.textBox3_quantidade.Name = "textBox3_quantidade";
            this.textBox3_quantidade.ReadOnly = true;
            this.textBox3_quantidade.Size = new System.Drawing.Size(46, 20);
            this.textBox3_quantidade.TabIndex = 8;
            // 
            // textBox4_preçouni
            // 
            this.textBox4_preçouni.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox4_preçouni.Location = new System.Drawing.Point(239, 179);
            this.textBox4_preçouni.Name = "textBox4_preçouni";
            this.textBox4_preçouni.ReadOnly = true;
            this.textBox4_preçouni.Size = new System.Drawing.Size(142, 20);
            this.textBox4_preçouni.TabIndex = 9;
            // 
            // textBox5_preçofinal
            // 
            this.textBox5_preçofinal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox5_preçofinal.Location = new System.Drawing.Point(239, 251);
            this.textBox5_preçofinal.Name = "textBox5_preçofinal";
            this.textBox5_preçofinal.ReadOnly = true;
            this.textBox5_preçofinal.Size = new System.Drawing.Size(142, 20);
            this.textBox5_preçofinal.TabIndex = 10;
            // 
            // button2_menos
            // 
            this.button2_menos.BackColor = System.Drawing.Color.White;
            this.button2_menos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2_menos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2_menos.Location = new System.Drawing.Point(239, 214);
            this.button2_menos.Name = "button2_menos";
            this.button2_menos.Size = new System.Drawing.Size(22, 21);
            this.button2_menos.TabIndex = 11;
            this.button2_menos.Text = "-";
            this.button2_menos.UseVisualStyleBackColor = false;
            this.button2_menos.Click += new System.EventHandler(this.button2_menos_Click);
            // 
            // button3_mais
            // 
            this.button3_mais.BackColor = System.Drawing.Color.White;
            this.button3_mais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3_mais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button3_mais.Location = new System.Drawing.Point(345, 213);
            this.button3_mais.Name = "button3_mais";
            this.button3_mais.Size = new System.Drawing.Size(22, 21);
            this.button3_mais.TabIndex = 12;
            this.button3_mais.Text = "+";
            this.button3_mais.UseVisualStyleBackColor = false;
            this.button3_mais.Click += new System.EventHandler(this.button3_mais_Click);
            // 
            // button1_finalizar
            // 
            this.button1_finalizar.BackColor = System.Drawing.Color.White;
            this.button1_finalizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_finalizar.FlatAppearance.BorderSize = 2;
            this.button1_finalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1_finalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_finalizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1_finalizar.Location = new System.Drawing.Point(127, 342);
            this.button1_finalizar.Name = "button1_finalizar";
            this.button1_finalizar.Size = new System.Drawing.Size(101, 52);
            this.button1_finalizar.TabIndex = 13;
            this.button1_finalizar.Text = "Finalizar Vendas";
            this.button1_finalizar.UseVisualStyleBackColor = false;
            this.button1_finalizar.Click += new System.EventHandler(this.button1_finalizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Gerenciamento de Vendas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(236, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "Informações do Produto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(267, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 56);
            this.button1.TabIndex = 16;
            this.button1.Text = "Menu Principal";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 2;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button2.Location = new System.Drawing.Point(406, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 56);
            this.button2.TabIndex = 17;
            this.button2.Text = "Listar Venda";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(530, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 56);
            this.button3.TabIndex = 18;
            this.button3.Text = "Procurar no estoque";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(465, 306);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(497, 311);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 18);
            this.label9.TabIndex = 31;
            this.label9.Text = "BUSCA";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(417, 322);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(217, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "___________________________________";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 318);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 34;
            this.label8.Text = "Vendas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 326);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(217, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "___________________________________";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 307);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 35;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(397, 255);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(111, 16);
            this.label12.TabIndex = 36;
            this.label12.Text = "(Somente venda)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(397, 183);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(111, 16);
            this.label13.TabIndex = 37;
            this.label13.Text = "(Somente venda)";
            // 
            // button4_estoque
            // 
            this.button4_estoque.BackColor = System.Drawing.Color.White;
            this.button4_estoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4_estoque.FlatAppearance.BorderSize = 2;
            this.button4_estoque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4_estoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button4_estoque.Location = new System.Drawing.Point(260, 353);
            this.button4_estoque.Name = "button4_estoque";
            this.button4_estoque.Size = new System.Drawing.Size(107, 56);
            this.button4_estoque.TabIndex = 38;
            this.button4_estoque.Text = "Listar Estoque";
            this.button4_estoque.UseVisualStyleBackColor = false;
            this.button4_estoque.Click += new System.EventHandler(this.button4_estoque_Click);
            // 
            // button4_procurar
            // 
            this.button4_procurar.BackColor = System.Drawing.Color.White;
            this.button4_procurar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4_procurar.FlatAppearance.BorderSize = 2;
            this.button4_procurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4_procurar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.button4_procurar.Location = new System.Drawing.Point(395, 83);
            this.button4_procurar.Name = "button4_procurar";
            this.button4_procurar.Size = new System.Drawing.Size(113, 30);
            this.button4_procurar.TabIndex = 39;
            this.button4_procurar.Text = "Procurar";
            this.button4_procurar.UseVisualStyleBackColor = false;
            this.button4_procurar.Click += new System.EventHandler(this.button4_procurar_Click);
            // 
            // FormVendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(647, 414);
            this.Controls.Add(this.button4_procurar);
            this.Controls.Add(this.button4_estoque);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1_finalizar);
            this.Controls.Add(this.button3_mais);
            this.Controls.Add(this.button2_menos);
            this.Controls.Add(this.textBox5_preçofinal);
            this.Controls.Add(this.textBox4_preçouni);
            this.Controls.Add(this.textBox3_quantidade);
            this.Controls.Add(this.textBox2_nome);
            this.Controls.Add(this.textBox1_id);
            this.Controls.Add(this.button1_vender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVendas";
            this.Text = "FormVendas";
            this.Load += new System.EventHandler(this.FormVendas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1_vender;
        private System.Windows.Forms.TextBox textBox1_id;
        private System.Windows.Forms.TextBox textBox2_nome;
        private System.Windows.Forms.TextBox textBox3_quantidade;
        private System.Windows.Forms.TextBox textBox4_preçouni;
        private System.Windows.Forms.TextBox textBox5_preçofinal;
        private System.Windows.Forms.Button button2_menos;
        private System.Windows.Forms.Button button3_mais;
        private System.Windows.Forms.Button button1_finalizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button4_estoque;
        private System.Windows.Forms.Button button4_procurar;
    }
}