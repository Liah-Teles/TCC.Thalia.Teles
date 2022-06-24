namespace TCC.Thalia.Teles.App.Paineis.Promocoes
{
    partial class PromocoesControleDeUsuario
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.botaoRemover = new System.Windows.Forms.Button();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.gridPromocoes = new System.Windows.Forms.DataGridView();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPromocoes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botaoRemover);
            this.panel1.Controls.Add(this.botaoAdicionar);
            this.panel1.Controls.Add(this.gridPromocoes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 554);
            this.panel1.TabIndex = 0;
            // 
            // botaoRemover
            // 
            this.botaoRemover.Enabled = false;
            this.botaoRemover.Location = new System.Drawing.Point(94, 26);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(75, 24);
            this.botaoRemover.TabIndex = 18;
            this.botaoRemover.Text = "Remover";
            this.botaoRemover.UseVisualStyleBackColor = true;
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Location = new System.Drawing.Point(13, 26);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(75, 24);
            this.botaoAdicionar.TabIndex = 16;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // gridPromocoes
            // 
            this.gridPromocoes.AllowUserToAddRows = false;
            this.gridPromocoes.AllowUserToDeleteRows = false;
            this.gridPromocoes.AllowUserToResizeColumns = false;
            this.gridPromocoes.AllowUserToResizeRows = false;
            this.gridPromocoes.BackgroundColor = System.Drawing.Color.White;
            this.gridPromocoes.ColumnHeadersHeight = 35;
            this.gridPromocoes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaId,
            this.colunaServico,
            this.colunaDesconto});
            this.gridPromocoes.GridColor = System.Drawing.Color.White;
            this.gridPromocoes.Location = new System.Drawing.Point(13, 56);
            this.gridPromocoes.MultiSelect = false;
            this.gridPromocoes.Name = "gridPromocoes";
            this.gridPromocoes.ReadOnly = true;
            this.gridPromocoes.RowHeadersVisible = false;
            this.gridPromocoes.RowTemplate.Height = 25;
            this.gridPromocoes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridPromocoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPromocoes.Size = new System.Drawing.Size(870, 442);
            this.gridPromocoes.TabIndex = 8;
            this.gridPromocoes.SelectionChanged += new System.EventHandler(this.gridPromocoes_SelectionChanged);
            // 
            // colunaId
            // 
            this.colunaId.HeaderText = "Id";
            this.colunaId.Name = "colunaId";
            this.colunaId.ReadOnly = true;
            // 
            // colunaServico
            // 
            this.colunaServico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaServico.HeaderText = "Serviço";
            this.colunaServico.Name = "colunaServico";
            this.colunaServico.ReadOnly = true;
            // 
            // colunaDesconto
            // 
            this.colunaDesconto.HeaderText = "Desconto";
            this.colunaDesconto.Name = "colunaDesconto";
            this.colunaDesconto.ReadOnly = true;
            // 
            // PromocoesControleDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "PromocoesControleDeUsuario";
            this.Size = new System.Drawing.Size(896, 554);
            this.Load += new System.EventHandler(this.PromocoesControleDeUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPromocoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView gridPromocoes;
        private Button botaoRemover;
        private Button botaoAdicionar;
        private DataGridViewTextBoxColumn colunaId;
        private DataGridViewTextBoxColumn colunaServico;
        private DataGridViewTextBoxColumn colunaDesconto;
    }
}
