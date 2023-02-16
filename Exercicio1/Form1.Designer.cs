
namespace Exercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.lbValor = new System.Windows.Forms.ListBox();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.lbProduto = new System.Windows.Forms.ListBox();
            this.lbEstoque = new System.Windows.Forms.ListBox();
            this.lbCnpj = new System.Windows.Forms.ListBox();
            this.btnMediaItens = new System.Windows.Forms.Button();
            this.btnMediaCNPJ = new System.Windows.Forms.Button();
            this.lvResult = new MaterialSkin.Controls.MaterialListView();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.lbNome = new System.Windows.Forms.ListBox();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.SuspendLayout();
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel1.Location = new System.Drawing.Point(507, 65);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(76, 19);
            this.materialLabel1.TabIndex = 0;
            this.materialLabel1.Text = "ProdutoID";
            // 
            // lbValor
            // 
            this.lbValor.FormattingEnabled = true;
            this.lbValor.Location = new System.Drawing.Point(863, 87);
            this.lbValor.Name = "lbValor";
            this.lbValor.Size = new System.Drawing.Size(112, 394);
            this.lbValor.TabIndex = 1;
            this.lbValor.SelectedIndexChanged += new System.EventHandler(this.lbValor_SelectedIndexChanged);
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel2.Location = new System.Drawing.Point(896, 61);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(45, 19);
            this.materialLabel2.TabIndex = 2;
            this.materialLabel2.Text = "Valor";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel3.Location = new System.Drawing.Point(1211, 61);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(39, 19);
            this.materialLabel3.TabIndex = 3;
            this.materialLabel3.Text = "Cnpj";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel4.Location = new System.Drawing.Point(1032, 65);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(65, 19);
            this.materialLabel4.TabIndex = 4;
            this.materialLabel4.Text = "Estoque";
            // 
            // lbProduto
            // 
            this.lbProduto.FormattingEnabled = true;
            this.lbProduto.Location = new System.Drawing.Point(511, 87);
            this.lbProduto.Name = "lbProduto";
            this.lbProduto.Size = new System.Drawing.Size(59, 394);
            this.lbProduto.TabIndex = 5;
            this.lbProduto.SelectedIndexChanged += new System.EventHandler(this.lbProduto_SelectedIndexChanged);
            // 
            // lbEstoque
            // 
            this.lbEstoque.FormattingEnabled = true;
            this.lbEstoque.Location = new System.Drawing.Point(1019, 87);
            this.lbEstoque.Name = "lbEstoque";
            this.lbEstoque.Size = new System.Drawing.Size(112, 394);
            this.lbEstoque.TabIndex = 6;
            this.lbEstoque.SelectedIndexChanged += new System.EventHandler(this.lbEstoque_SelectedIndexChanged);
            // 
            // lbCnpj
            // 
            this.lbCnpj.FormattingEnabled = true;
            this.lbCnpj.Location = new System.Drawing.Point(1178, 87);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.Size = new System.Drawing.Size(112, 394);
            this.lbCnpj.TabIndex = 7;
            this.lbCnpj.SelectedIndexChanged += new System.EventHandler(this.lbCnpj_SelectedIndexChanged);
            // 
            // btnMediaItens
            // 
            this.btnMediaItens.Location = new System.Drawing.Point(151, 351);
            this.btnMediaItens.Name = "btnMediaItens";
            this.btnMediaItens.Size = new System.Drawing.Size(292, 33);
            this.btnMediaItens.TabIndex = 8;
            this.btnMediaItens.Text = "Média de Todos os itens";
            this.btnMediaItens.UseVisualStyleBackColor = true;
            this.btnMediaItens.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnMediaCNPJ
            // 
            this.btnMediaCNPJ.Location = new System.Drawing.Point(151, 298);
            this.btnMediaCNPJ.Name = "btnMediaCNPJ";
            this.btnMediaCNPJ.Size = new System.Drawing.Size(292, 33);
            this.btnMediaCNPJ.TabIndex = 9;
            this.btnMediaCNPJ.Text = "Média dos Itens com CNPJ";
            this.btnMediaCNPJ.UseVisualStyleBackColor = true;
            this.btnMediaCNPJ.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvResult
            // 
            this.lvResult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lvResult.Depth = 0;
            this.lvResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.lvResult.FullRowSelect = true;
            this.lvResult.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvResult.HideSelection = false;
            this.lvResult.Location = new System.Drawing.Point(151, 103);
            this.lvResult.MouseLocation = new System.Drawing.Point(-1, -1);
            this.lvResult.MouseState = MaterialSkin.MouseState.OUT;
            this.lvResult.Name = "lvResult";
            this.lvResult.OwnerDraw = true;
            this.lvResult.Size = new System.Drawing.Size(305, 164);
            this.lvResult.TabIndex = 10;
            this.lvResult.UseCompatibleStateImageBehavior = false;
            this.lvResult.View = System.Windows.Forms.View.Details;
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel5.Location = new System.Drawing.Point(255, 65);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(76, 19);
            this.materialLabel5.TabIndex = 11;
            this.materialLabel5.Text = "Resultado";
            // 
            // lbNome
            // 
            this.lbNome.FormattingEnabled = true;
            this.lbNome.Location = new System.Drawing.Point(609, 87);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(199, 394);
            this.lbNome.TabIndex = 12;
            this.lbNome.SelectedIndexChanged += new System.EventHandler(this.lbNome_SelectedIndexChanged);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 11F);
            this.materialLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialLabel6.Location = new System.Drawing.Point(677, 61);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(50, 19);
            this.materialLabel6.TabIndex = 13;
            this.materialLabel6.Text = "Nome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1387, 633);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.materialLabel5);
            this.Controls.Add(this.lvResult);
            this.Controls.Add(this.btnMediaCNPJ);
            this.Controls.Add(this.btnMediaItens);
            this.Controls.Add(this.lbCnpj);
            this.Controls.Add(this.lbEstoque);
            this.Controls.Add(this.lbProduto);
            this.Controls.Add(this.materialLabel4);
            this.Controls.Add(this.materialLabel3);
            this.Controls.Add(this.materialLabel2);
            this.Controls.Add(this.lbValor);
            this.Controls.Add(this.materialLabel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private System.Windows.Forms.ListBox lbValor;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private System.Windows.Forms.ListBox lbProduto;
        private System.Windows.Forms.ListBox lbEstoque;
        private System.Windows.Forms.ListBox lbCnpj;
        private System.Windows.Forms.Button btnMediaItens;
        private System.Windows.Forms.Button btnMediaCNPJ;
        private MaterialSkin.Controls.MaterialListView lvResult;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private System.Windows.Forms.ListBox lbNome;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}

