namespace TCC.Thalia.Teles.App.Paineis.Clientes
{
    partial class ClientesControleDeUsuario
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
            this.painelPrincipal = new System.Windows.Forms.Panel();
            this.gridClientes = new System.Windows.Forms.DataGridView();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaEndereco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botaoRemover = new System.Windows.Forms.Button();
            this.botaoEditar = new System.Windows.Forms.Button();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.painelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // painelPrincipal
            // 
            this.painelPrincipal.Controls.Add(this.gridClientes);
            this.painelPrincipal.Controls.Add(this.botaoRemover);
            this.painelPrincipal.Controls.Add(this.botaoEditar);
            this.painelPrincipal.Controls.Add(this.botaoAdicionar);
            this.painelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.painelPrincipal.Name = "painelPrincipal";
            this.painelPrincipal.Size = new System.Drawing.Size(896, 554);
            this.painelPrincipal.TabIndex = 0;
            // 
            // gridClientes
            // 
            this.gridClientes.AllowUserToAddRows = false;
            this.gridClientes.AllowUserToDeleteRows = false;
            this.gridClientes.AllowUserToResizeColumns = false;
            this.gridClientes.AllowUserToResizeRows = false;
            this.gridClientes.BackgroundColor = System.Drawing.Color.White;
            this.gridClientes.ColumnHeadersHeight = 35;
            this.gridClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaId,
            this.nomeCliente,
            this.valorServico,
            this.colunaCpf,
            this.colunaEndereco});
            this.gridClientes.GridColor = System.Drawing.Color.White;
            this.gridClientes.Location = new System.Drawing.Point(13, 56);
            this.gridClientes.MultiSelect = false;
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.ReadOnly = true;
            this.gridClientes.RowHeadersVisible = false;
            this.gridClientes.RowTemplate.Height = 25;
            this.gridClientes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridClientes.Size = new System.Drawing.Size(870, 442);
            this.gridClientes.TabIndex = 20;
            this.gridClientes.SelectionChanged += new System.EventHandler(this.gridClientes_SelectionChanged);
            // 
            // colunaId
            // 
            this.colunaId.HeaderText = "Id";
            this.colunaId.Name = "colunaId";
            this.colunaId.ReadOnly = true;
            this.colunaId.Width = 50;
            // 
            // nomeCliente
            // 
            this.nomeCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nomeCliente.HeaderText = "Nome";
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.ReadOnly = true;
            // 
            // valorServico
            // 
            this.valorServico.HeaderText = "Celular";
            this.valorServico.Name = "valorServico";
            this.valorServico.ReadOnly = true;
            this.valorServico.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.valorServico.Width = 130;
            // 
            // colunaCpf
            // 
            this.colunaCpf.HeaderText = "CPF";
            this.colunaCpf.Name = "colunaCpf";
            this.colunaCpf.ReadOnly = true;
            this.colunaCpf.Width = 110;
            // 
            // colunaEndereco
            // 
            this.colunaEndereco.HeaderText = "Endereço";
            this.colunaEndereco.Name = "colunaEndereco";
            this.colunaEndereco.ReadOnly = true;
            this.colunaEndereco.Width = 300;
            // 
            // botaoRemover
            // 
            this.botaoRemover.Enabled = false;
            this.botaoRemover.Location = new System.Drawing.Point(175, 26);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(75, 24);
            this.botaoRemover.TabIndex = 19;
            this.botaoRemover.Text = "Remover";
            this.botaoRemover.UseVisualStyleBackColor = true;
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // botaoEditar
            // 
            this.botaoEditar.Enabled = false;
            this.botaoEditar.Location = new System.Drawing.Point(94, 26);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(75, 24);
            this.botaoEditar.TabIndex = 18;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Location = new System.Drawing.Point(13, 26);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(75, 24);
            this.botaoAdicionar.TabIndex = 17;
            this.botaoAdicionar.Text = "Adicionar";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // ClientesControleDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.painelPrincipal);
            this.Name = "ClientesControleDeUsuario";
            this.Size = new System.Drawing.Size(896, 554);
            this.Load += new System.EventHandler(this.ClientesControleDeUsuario_Load);
            this.painelPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel painelPrincipal;
        private DataGridView gridClientes;
        private Button botaoRemover;
        private Button botaoEditar;
        private Button botaoAdicionar;
        private DataGridViewTextBoxColumn colunaId;
        private DataGridViewTextBoxColumn nomeCliente;
        private DataGridViewTextBoxColumn valorServico;
        private DataGridViewTextBoxColumn colunaEndereco;
        private DataGridViewTextBoxColumn colunaDocumento;
        private DataGridViewTextBoxColumn colunaCpf;
    }
}
