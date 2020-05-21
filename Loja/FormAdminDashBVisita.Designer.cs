namespace Loja
{
    partial class FormAdminDashBVisita
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
            this.label4 = new System.Windows.Forms.Label();
            this.labelFooter = new System.Windows.Forms.Label();
            this.painelFooter = new System.Windows.Forms.Panel();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbProcurar = new System.Windows.Forms.TextBox();
            this.cbProcurar = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new Loja.DataSet1();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.painelFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(619, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Painel do Visita";
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
            // painelFooter
            // 
            this.painelFooter.BackColor = System.Drawing.Color.LightSeaGreen;
            this.painelFooter.Controls.Add(this.label4);
            this.painelFooter.Controls.Add(this.labelFooter);
            this.painelFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.painelFooter.Location = new System.Drawing.Point(0, 661);
            this.painelFooter.Name = "painelFooter";
            this.painelFooter.Size = new System.Drawing.Size(1350, 38);
            this.painelFooter.TabIndex = 1;
            // 
            // btnProcurar
            // 
            this.btnProcurar.BackColor = System.Drawing.Color.Aquamarine;
            this.btnProcurar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProcurar.Location = new System.Drawing.Point(35, 207);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(60, 60);
            this.btnProcurar.TabIndex = 64;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = false;
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(262, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1014, 532);
            this.dataGridView1.TabIndex = 65;
            // 
            // tbProcurar
            // 
            this.tbProcurar.Location = new System.Drawing.Point(35, 91);
            this.tbProcurar.Name = "tbProcurar";
            this.tbProcurar.Size = new System.Drawing.Size(189, 20);
            this.tbProcurar.TabIndex = 66;
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
            this.cbProcurar.Location = new System.Drawing.Point(35, 162);
            this.cbProcurar.Name = "cbProcurar";
            this.cbProcurar.Size = new System.Drawing.Size(189, 21);
            this.cbProcurar.TabIndex = 67;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "Procurar por Nome ou ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 69;
            this.label2.Text = "Selecionar Tabela:";
            // 
            // FormAdminDashBVisita
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
            this.Name = "FormAdminDashBVisita";
            this.Text = "Painel Visita";
            this.painelFooter.ResumeLayout(false);
            this.painelFooter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelFooter;
        private System.Windows.Forms.Panel painelFooter;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tbProcurar;
        private System.Windows.Forms.ComboBox cbProcurar;
        private DataSet1 dataSet1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}