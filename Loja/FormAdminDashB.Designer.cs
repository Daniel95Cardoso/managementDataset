namespace Loja
{
    partial class PainelAdmin
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
            this.painelFooter = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.labelFooter = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.transaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encomendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.vendasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moedaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.despesasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mensaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propiedadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bensToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.produtosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProcurar = new System.Windows.Forms.ComboBox();
            this.tbProcurar = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.painelFooter.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // painelFooter
            // 
            this.painelFooter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.painelFooter.Controls.Add(this.label4);
            this.painelFooter.Controls.Add(this.labelFooter);
            this.painelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painelFooter.Location = new System.Drawing.Point(0, 661);
            this.painelFooter.Name = "painelFooter";
            this.painelFooter.Size = new System.Drawing.Size(1350, 38);
            this.painelFooter.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(597, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Painel do Administrador";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelFooter
            // 
            this.labelFooter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelFooter.AutoSize = true;
            this.labelFooter.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFooter.ForeColor = System.Drawing.Color.White;
            this.labelFooter.Location = new System.Drawing.Point(1114, 13);
            this.labelFooter.Name = "labelFooter";
            this.labelFooter.Size = new System.Drawing.Size(224, 16);
            this.labelFooter.TabIndex = 0;
            this.labelFooter.Text = "Desenvolvido por: Daniel Cardoso";
            this.labelFooter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.transaçãoToolStripMenuItem,
            this.despesasToolStripMenuItem,
            this.propiedadeToolStripMenuItem,
            this.funcionarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStripTopo";
            // 
            // transaçãoToolStripMenuItem
            // 
            this.transaçãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.encomendasToolStripMenuItem1,
            this.vendasToolStripMenuItem1,
            this.clientesToolStripMenuItem,
            this.fornecedoresToolStripMenuItem,
            this.moedaToolStripMenuItem1});
            this.transaçãoToolStripMenuItem.Name = "transaçãoToolStripMenuItem";
            this.transaçãoToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.transaçãoToolStripMenuItem.Text = "Transação";
            // 
            // encomendasToolStripMenuItem1
            // 
            this.encomendasToolStripMenuItem1.Name = "encomendasToolStripMenuItem1";
            this.encomendasToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.encomendasToolStripMenuItem1.Text = "Encomendas";
            this.encomendasToolStripMenuItem1.Click += new System.EventHandler(this.encomendasToolStripMenuItem1_Click);
            // 
            // vendasToolStripMenuItem1
            // 
            this.vendasToolStripMenuItem1.Name = "vendasToolStripMenuItem1";
            this.vendasToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.vendasToolStripMenuItem1.Text = "Vendas";
            this.vendasToolStripMenuItem1.Click += new System.EventHandler(this.vendasToolStripMenuItem1_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // fornecedoresToolStripMenuItem
            // 
            this.fornecedoresToolStripMenuItem.Name = "fornecedoresToolStripMenuItem";
            this.fornecedoresToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.fornecedoresToolStripMenuItem.Text = "Fornecedores";
            this.fornecedoresToolStripMenuItem.Click += new System.EventHandler(this.fornecedoresToolStripMenuItem_Click);
            // 
            // moedaToolStripMenuItem1
            // 
            this.moedaToolStripMenuItem1.Name = "moedaToolStripMenuItem1";
            this.moedaToolStripMenuItem1.Size = new System.Drawing.Size(145, 22);
            this.moedaToolStripMenuItem1.Text = "Moeda";
            this.moedaToolStripMenuItem1.Click += new System.EventHandler(this.moedaToolStripMenuItem1_Click);
            // 
            // despesasToolStripMenuItem
            // 
            this.despesasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mensaisToolStripMenuItem,
            this.contentorToolStripMenuItem});
            this.despesasToolStripMenuItem.Name = "despesasToolStripMenuItem";
            this.despesasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.despesasToolStripMenuItem.Text = "Despesas";
            // 
            // mensaisToolStripMenuItem
            // 
            this.mensaisToolStripMenuItem.Name = "mensaisToolStripMenuItem";
            this.mensaisToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.mensaisToolStripMenuItem.Text = "Mensais";
            this.mensaisToolStripMenuItem.Click += new System.EventHandler(this.mensaisToolStripMenuItem_Click);
            // 
            // contentorToolStripMenuItem
            // 
            this.contentorToolStripMenuItem.Name = "contentorToolStripMenuItem";
            this.contentorToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.contentorToolStripMenuItem.Text = "Contentor";
            this.contentorToolStripMenuItem.Click += new System.EventHandler(this.contentorToolStripMenuItem_Click);
            // 
            // propiedadeToolStripMenuItem
            // 
            this.propiedadeToolStripMenuItem.AutoSize = false;
            this.propiedadeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bensToolStripMenuItem1,
            this.produtosToolStripMenuItem1});
            this.propiedadeToolStripMenuItem.Name = "propiedadeToolStripMenuItem";
            this.propiedadeToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.propiedadeToolStripMenuItem.Text = "Propriedade";
            // 
            // bensToolStripMenuItem1
            // 
            this.bensToolStripMenuItem1.Name = "bensToolStripMenuItem1";
            this.bensToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.bensToolStripMenuItem1.Text = "Bens";
            this.bensToolStripMenuItem1.Click += new System.EventHandler(this.bensToolStripMenuItem1_Click);
            // 
            // produtosToolStripMenuItem1
            // 
            this.produtosToolStripMenuItem1.Name = "produtosToolStripMenuItem1";
            this.produtosToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.produtosToolStripMenuItem1.Text = "Produtos";
            this.produtosToolStripMenuItem1.Click += new System.EventHandler(this.produtosToolStripMenuItem1_Click);
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            this.funcionarioToolStripMenuItem.Click += new System.EventHandler(this.funcionarioToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Selecionar Tabela:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Procurar por Nome ou ID:";
            // 
            // cbProcurar
            // 
            this.cbProcurar.FormattingEnabled = true;
            this.cbProcurar.Items.AddRange(new object[] {
            "Bens",
            "Clientes",
            "Despesas Contentor",
            "Despesas Mensais",
            "Encomendas",
            "Fornecedores",
            "Funcionarios",
            "Moeda",
            "Produtos",
            "Vendas"});
            this.cbProcurar.Location = new System.Drawing.Point(42, 174);
            this.cbProcurar.Name = "cbProcurar";
            this.cbProcurar.Size = new System.Drawing.Size(189, 21);
            this.cbProcurar.TabIndex = 73;
            // 
            // tbProcurar
            // 
            this.tbProcurar.Location = new System.Drawing.Point(42, 103);
            this.tbProcurar.Name = "tbProcurar";
            this.tbProcurar.Size = new System.Drawing.Size(189, 20);
            this.tbProcurar.TabIndex = 72;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(269, 73);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1014, 532);
            this.dataGridView1.TabIndex = 71;
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnProcurar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProcurar.Location = new System.Drawing.Point(42, 219);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(60, 60);
            this.btnProcurar.TabIndex = 70;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // PainelAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 699);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbProcurar);
            this.Controls.Add(this.tbProcurar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnProcurar);
            this.Controls.Add(this.painelFooter);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PainelAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Painel do Administrador";
            this.Load += new System.EventHandler(this.PainelAdmin_Load);
            this.painelFooter.ResumeLayout(false);
            this.painelFooter.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel painelFooter;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despesasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mensaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem propiedadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bensToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem produtosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem transaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encomendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem vendasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moedaToolStripMenuItem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProcurar;
        private System.Windows.Forms.TextBox tbProcurar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnProcurar;
    }
}

