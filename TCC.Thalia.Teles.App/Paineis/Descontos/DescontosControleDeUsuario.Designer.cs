namespace TCC.Thalia.Teles.App.Paineis.Descontos
{
    partial class DescontosControleDeUsuario
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
            this.gridDescontos = new System.Windows.Forms.DataGridView();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaValorDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDataInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDataFinal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDescontos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.botaoRemover);
            this.panel1.Controls.Add(this.botaoAdicionar);
            this.panel1.Controls.Add(this.gridDescontos);
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
            // gridDescontos
            // 
            this.gridDescontos.AllowUserToAddRows = false;
            this.gridDescontos.AllowUserToDeleteRows = false;
            this.gridDescontos.AllowUserToResizeColumns = false;
            this.gridDescontos.AllowUserToResizeRows = false;
            this.gridDescontos.BackgroundColor = System.Drawing.Color.White;
            this.gridDescontos.ColumnHeadersHeight = 35;
            this.gridDescontos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridDescontos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaId,
            this.colunaServico,
            this.colunaValorDesconto,
            this.colunaDataInicio,
            this.colunaDataFinal});
            this.gridDescontos.GridColor = System.Drawing.Color.White;
            this.gridDescontos.Location = new System.Drawing.Point(13, 56);
            this.gridDescontos.MultiSelect = false;
            this.gridDescontos.Name = "gridDescontos";
            this.gridDescontos.ReadOnly = true;
            this.gridDescontos.RowHeadersVisible = false;
            this.gridDescontos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridDescontos.RowTemplate.Height = 25;
            this.gridDescontos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridDescontos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDescontos.Size = new System.Drawing.Size(870, 442);
            this.gridDescontos.TabIndex = 8;
            this.gridDescontos.SelectionChanged += new System.EventHandler(this.gridDescontos_SelectionChanged);
            // 
            // colunaId
            // 
            this.colunaId.HeaderText = "Id";
            this.colunaId.Name = "colunaId";
            this.colunaId.ReadOnly = true;
            this.colunaId.Width = 50;
            // 
            // colunaServico
            // 
            this.colunaServico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaServico.HeaderText = "Serviço";
            this.colunaServico.Name = "colunaServico";
            this.colunaServico.ReadOnly = true;
            // 
            // colunaValorDesconto
            // 
            this.colunaValorDesconto.HeaderText = "Valor";
            this.colunaValorDesconto.Name = "colunaValorDesconto";
            this.colunaValorDesconto.ReadOnly = true;
            // 
            // colunaDataInicio
            // 
            this.colunaDataInicio.HeaderText = "Data início";
            this.colunaDataInicio.Name = "colunaDataInicio";
            this.colunaDataInicio.ReadOnly = true;
            // 
            // colunaDataFinal
            // 
            this.colunaDataFinal.HeaderText = "Data final";
            this.colunaDataFinal.Name = "colunaDataFinal";
            this.colunaDataFinal.ReadOnly = true;
            // 
            // DescontosControleDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "DescontosControleDeUsuario";
            this.Size = new System.Drawing.Size(896, 554);
            this.Load += new System.EventHandler(this.DescontosControleDeUsuario_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridDescontos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView gridDescontos;
        private Button botaoRemover;
        private Button botaoAdicionar;
        private DataGridViewTextBoxColumn colunaDesconto;
        private DataGridViewTextBoxColumn colunaId;
        private DataGridViewTextBoxColumn colunaServico;
        private DataGridViewTextBoxColumn colunaValorDesconto;
        private DataGridViewTextBoxColumn colunaDataInicio;
        private DataGridViewTextBoxColumn colunaDataFinal;
    }
}
