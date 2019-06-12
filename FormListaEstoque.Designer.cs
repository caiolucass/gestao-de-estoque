namespace GestaodeVendas
{
    partial class FormListaEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormListaEstoque));
            this.lv_produtos = new System.Windows.Forms.ListView();
            this.lv_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_quantidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Data = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lv_Preco = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lv_produtos
            // 
            this.lv_produtos.BackColor = System.Drawing.Color.White;
            this.lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lv_name,
            this.lv_id,
            this.lv_category,
            this.lv_quantidade,
            this.lv_Data,
            this.lv_Preco});
            this.lv_produtos.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_produtos.Location = new System.Drawing.Point(12, 12);
            this.lv_produtos.Name = "lv_produtos";
            this.lv_produtos.Size = new System.Drawing.Size(626, 309);
            this.lv_produtos.TabIndex = 0;
            this.lv_produtos.UseCompatibleStateImageBehavior = false;
            this.lv_produtos.View = System.Windows.Forms.View.Details;
            // 
            // lv_name
            // 
            this.lv_name.DisplayIndex = 2;
            this.lv_name.Text = "Nome";
            this.lv_name.Width = 125;
            // 
            // lv_id
            // 
            this.lv_id.Text = "ID";
            this.lv_id.Width = 40;
            // 
            // lv_category
            // 
            this.lv_category.DisplayIndex = 0;
            this.lv_category.Text = "Categoria";
            this.lv_category.Width = 107;
            // 
            // lv_quantidade
            // 
            this.lv_quantidade.DisplayIndex = 4;
            this.lv_quantidade.Text = "Quantidade";
            this.lv_quantidade.Width = 95;
            // 
            // lv_Data
            // 
            this.lv_Data.DisplayIndex = 5;
            this.lv_Data.Text = "Data";
            this.lv_Data.Width = 168;
            // 
            // lv_Preco
            // 
            this.lv_Preco.DisplayIndex = 3;
            this.lv_Preco.Text = "Preço";
            this.lv_Preco.Width = 82;
            // 
            // FormListaEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(650, 333);
            this.Controls.Add(this.lv_produtos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormListaEstoque";
            this.Text = "Produtos no estoque";
            this.Load += new System.EventHandler(this.FormListaEstoque_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_produtos;
        private System.Windows.Forms.ColumnHeader lv_name;
        private System.Windows.Forms.ColumnHeader lv_id;
        private System.Windows.Forms.ColumnHeader lv_category;
        private System.Windows.Forms.ColumnHeader lv_quantidade;
        private System.Windows.Forms.ColumnHeader lv_Data;
        private System.Windows.Forms.ColumnHeader lv_Preco;
    }
}