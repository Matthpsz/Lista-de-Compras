namespace Lista_de_Compras
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
            this.lb_Pendentes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.tb_produto = new System.Windows.Forms.TextBox();
            this.lb_Comprados = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Quantidade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lb_Pendentes
            // 
            this.lb_Pendentes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Pendentes.FormattingEnabled = true;
            this.lb_Pendentes.ItemHeight = 16;
            this.lb_Pendentes.Location = new System.Drawing.Point(8, 128);
            this.lb_Pendentes.Name = "lb_Pendentes";
            this.lb_Pendentes.Size = new System.Drawing.Size(232, 260);
            this.lb_Pendentes.TabIndex = 0;
            this.lb_Pendentes.SelectedIndexChanged += new System.EventHandler(this.lb_Pendentes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Adicionar Produto";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Confirmar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.Location = new System.Drawing.Point(312, 400);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(75, 23);
            this.btn_Remover.TabIndex = 4;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = true;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // tb_produto
            // 
            this.tb_produto.Location = new System.Drawing.Point(128, 56);
            this.tb_produto.Name = "tb_produto";
            this.tb_produto.Size = new System.Drawing.Size(184, 20);
            this.tb_produto.TabIndex = 5;
            // 
            // lb_Comprados
            // 
            this.lb_Comprados.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Comprados.FormattingEnabled = true;
            this.lb_Comprados.ItemHeight = 16;
            this.lb_Comprados.Location = new System.Drawing.Point(248, 128);
            this.lb_Comprados.Name = "lb_Comprados";
            this.lb_Comprados.Size = new System.Drawing.Size(232, 260);
            this.lb_Comprados.TabIndex = 6;
            this.lb_Comprados.SelectedIndexChanged += new System.EventHandler(this.lb_Comprados_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Produtos Pendentes:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(288, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Produtos Comprados:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(136, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lista de Compras";
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.Location = new System.Drawing.Point(400, 400);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(75, 23);
            this.btn_Comprar.TabIndex = 10;
            this.btn_Comprar.Text = "Comprar";
            this.btn_Comprar.UseVisualStyleBackColor = true;
            this.btn_Comprar.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(312, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Qtd:";
            // 
            // tb_Quantidade
            // 
            this.tb_Quantidade.Location = new System.Drawing.Point(352, 56);
            this.tb_Quantidade.Name = "tb_Quantidade";
            this.tb_Quantidade.Size = new System.Drawing.Size(48, 20);
            this.tb_Quantidade.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 432);
            this.Controls.Add(this.tb_Quantidade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_Comprados);
            this.Controls.Add(this.tb_produto);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Pendentes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lb_Pendentes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.TextBox tb_produto;
        private System.Windows.Forms.ListBox lb_Comprados;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_Comprar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Quantidade;
    }
}

