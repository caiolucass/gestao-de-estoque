namespace GestaodeVendas
{
    partial class FormRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRelatorio));
            this.button1_voltar = new System.Windows.Forms.Button();
            this.listBox1_cadastros = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1_vendas = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1_voltar
            // 
            this.button1_voltar.BackColor = System.Drawing.Color.White;
            this.button1_voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1_voltar.FlatAppearance.BorderSize = 2;
            this.button1_voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1_voltar.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1_voltar.Image = ((System.Drawing.Image)(resources.GetObject("button1_voltar.Image")));
            this.button1_voltar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1_voltar.Location = new System.Drawing.Point(12, 469);
            this.button1_voltar.Name = "button1_voltar";
            this.button1_voltar.Size = new System.Drawing.Size(89, 28);
            this.button1_voltar.TabIndex = 3;
            this.button1_voltar.Text = "   Voltar";
            this.button1_voltar.UseVisualStyleBackColor = false;
            this.button1_voltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox1_cadastros
            // 
            this.listBox1_cadastros.FormattingEnabled = true;
            this.listBox1_cadastros.Location = new System.Drawing.Point(12, 79);
            this.listBox1_cadastros.Name = "listBox1_cadastros";
            this.listBox1_cadastros.Size = new System.Drawing.Size(328, 355);
            this.listBox1_cadastros.TabIndex = 4;
            this.listBox1_cadastros.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Relatório";
            // 
            // listBox1_vendas
            // 
            this.listBox1_vendas.FormattingEnabled = true;
            this.listBox1_vendas.Location = new System.Drawing.Point(379, 79);
            this.listBox1_vendas.Name = "listBox1_vendas";
            this.listBox1_vendas.Size = new System.Drawing.Size(360, 355);
            this.listBox1_vendas.TabIndex = 6;
            this.listBox1_vendas.SelectedIndexChanged += new System.EventHandler(this.listBox1_vendas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(125, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cadastros";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(525, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Vendas";
            // 
            // FormRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(751, 509);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox1_vendas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1_cadastros);
            this.Controls.Add(this.button1_voltar);
            this.Name = "FormRelatorio";
            this.Text = "FormRelatorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1_voltar;
        private System.Windows.Forms.ListBox listBox1_cadastros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBox1_vendas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}