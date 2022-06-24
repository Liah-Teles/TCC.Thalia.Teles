namespace TCC.Thalia.Teles.App.Paineis.Atendimentos
{
    partial class AtendimentosControleDeUsuario
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
            this.gridAgenda = new System.Windows.Forms.DataGridView();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botaoAdicionar = new System.Windows.Forms.Button();
            this.calendario = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.botaoRemover = new System.Windows.Forms.Button();
            this.gridServicos = new System.Windows.Forms.DataGridView();
            this.colunaNomeServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaValorServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.botaoEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAgenda
            // 
            this.gridAgenda.AllowUserToAddRows = false;
            this.gridAgenda.AllowUserToDeleteRows = false;
            this.gridAgenda.AllowUserToResizeColumns = false;
            this.gridAgenda.AllowUserToResizeRows = false;
            this.gridAgenda.BackgroundColor = System.Drawing.Color.White;
            this.gridAgenda.ColumnHeadersHeight = 35;
            this.gridAgenda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaId,
            this.colunaHorario,
            this.colunaCliente,
            this.colunaCpf});
            this.gridAgenda.GridColor = System.Drawing.Color.White;
            this.gridAgenda.Location = new System.Drawing.Point(233, 3);
            this.gridAgenda.MultiSelect = false;
            this.gridAgenda.Name = "gridAgenda";
            this.gridAgenda.ReadOnly = true;
            this.gridAgenda.RowHeadersVisible = false;
            this.gridAgenda.RowTemplate.Height = 25;
            this.gridAgenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridAgenda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAgenda.Size = new System.Drawing.Size(660, 475);
            this.gridAgenda.TabIndex = 6;
            this.gridAgenda.SelectionChanged += new System.EventHandler(this.gridAgenda_SelectionChanged);
            // 
            // colunaId
            // 
            this.colunaId.HeaderText = "Id";
            this.colunaId.Name = "colunaId";
            this.colunaId.ReadOnly = true;
            this.colunaId.Width = 50;
            // 
            // colunaHorario
            // 
            this.colunaHorario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colunaHorario.FillWeight = 131.9728F;
            this.colunaHorario.HeaderText = "Horario";
            this.colunaHorario.Name = "colunaHorario";
            this.colunaHorario.ReadOnly = true;
            // 
            // colunaCliente
            // 
            this.colunaCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaCliente.FillWeight = 68.02721F;
            this.colunaCliente.HeaderText = "Nome do Cliente";
            this.colunaCliente.Name = "colunaCliente";
            this.colunaCliente.ReadOnly = true;
            // 
            // colunaCpf
            // 
            this.colunaCpf.HeaderText = "CPF";
            this.colunaCpf.Name = "colunaCpf";
            this.colunaCpf.ReadOnly = true;
            this.colunaCpf.Width = 150;
            // 
            // botaoAdicionar
            // 
            this.botaoAdicionar.Location = new System.Drawing.Point(5, 12);
            this.botaoAdicionar.Name = "botaoAdicionar";
            this.botaoAdicionar.Size = new System.Drawing.Size(66, 26);
            this.botaoAdicionar.TabIndex = 9;
            this.botaoAdicionar.Text = "Novo";
            this.botaoAdicionar.UseVisualStyleBackColor = true;
            this.botaoAdicionar.Click += new System.EventHandler(this.botaoAdicionar_Click);
            // 
            // calendario
            // 
            this.calendario.Location = new System.Drawing.Point(4, 41);
            this.calendario.MaxSelectionCount = 1;
            this.calendario.Name = "calendario";
            this.calendario.TabIndex = 8;
            this.calendario.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendario_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(5, 222);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Serviços do agendamento";
            // 
            // botaoRemover
            // 
            this.botaoRemover.Location = new System.Drawing.Point(149, 12);
            this.botaoRemover.Name = "botaoRemover";
            this.botaoRemover.Size = new System.Drawing.Size(66, 26);
            this.botaoRemover.TabIndex = 12;
            this.botaoRemover.Text = "Remover";
            this.botaoRemover.UseVisualStyleBackColor = true;
            this.botaoRemover.Click += new System.EventHandler(this.botaoRemover_Click);
            // 
            // gridServicos
            // 
            this.gridServicos.AllowUserToAddRows = false;
            this.gridServicos.AllowUserToDeleteRows = false;
            this.gridServicos.AllowUserToResizeColumns = false;
            this.gridServicos.AllowUserToResizeRows = false;
            this.gridServicos.BackgroundColor = System.Drawing.Color.White;
            this.gridServicos.ColumnHeadersHeight = 35;
            this.gridServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaNomeServico,
            this.colunaValorServico});
            this.gridServicos.Enabled = false;
            this.gridServicos.GridColor = System.Drawing.Color.White;
            this.gridServicos.Location = new System.Drawing.Point(5, 245);
            this.gridServicos.MultiSelect = false;
            this.gridServicos.Name = "gridServicos";
            this.gridServicos.ReadOnly = true;
            this.gridServicos.RowHeadersVisible = false;
            this.gridServicos.RowTemplate.Height = 25;
            this.gridServicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridServicos.Size = new System.Drawing.Size(226, 233);
            this.gridServicos.TabIndex = 17;
            // 
            // colunaNomeServico
            // 
            this.colunaNomeServico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaNomeServico.FillWeight = 68.02721F;
            this.colunaNomeServico.HeaderText = "Nome";
            this.colunaNomeServico.Name = "colunaNomeServico";
            this.colunaNomeServico.ReadOnly = true;
            // 
            // colunaValorServico
            // 
            this.colunaValorServico.HeaderText = "Valor";
            this.colunaValorServico.Name = "colunaValorServico";
            this.colunaValorServico.ReadOnly = true;
            this.colunaValorServico.Width = 60;
            // 
            // botaoEditar
            // 
            this.botaoEditar.Location = new System.Drawing.Point(77, 12);
            this.botaoEditar.Name = "botaoEditar";
            this.botaoEditar.Size = new System.Drawing.Size(66, 26);
            this.botaoEditar.TabIndex = 18;
            this.botaoEditar.Text = "Editar";
            this.botaoEditar.UseVisualStyleBackColor = true;
            this.botaoEditar.Click += new System.EventHandler(this.botaoEditar_Click);
            // 
            // AtendimentosControleDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.botaoEditar);
            this.Controls.Add(this.gridServicos);
            this.Controls.Add(this.botaoRemover);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoAdicionar);
            this.Controls.Add(this.calendario);
            this.Controls.Add(this.gridAgenda);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AtendimentosControleDeUsuario";
            this.Size = new System.Drawing.Size(896, 554);
            this.Load += new System.EventHandler(this.AtendimentosControleDeUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAgenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel painelParaGrid;
        private Panel panel2;
        private Button botaoAdicionar;
        private MonthCalendar calendario;
        private DataGridView gridAgenda;
        private DataGridViewTextBoxColumn colunaId;
        private DataGridViewTextBoxColumn colunaHorario;
        private DataGridViewTextBoxColumn colunaCliente;
        private Label label1;
        private DataGridViewTextBoxColumn colunaCpf;
        private Button botaoRemover;
        private DataGridView gridServicos;
        private DataGridViewTextBoxColumn colunaNomeServico;
        private DataGridViewTextBoxColumn colunaValorServico;
        private Button botaoEditar;
    }
}
