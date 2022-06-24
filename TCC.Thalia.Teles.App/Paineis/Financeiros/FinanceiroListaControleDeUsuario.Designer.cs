namespace TCC.Thalia.Teles.App.Paineis.Financeiros
{
    partial class FinanceiroListaControleDeUsuario
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
            this.gridAtendimentos = new System.Windows.Forms.DataGridView();
            this.colunaIdAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaValorParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.caixaTextoTotalParcial = new System.Windows.Forms.TextBox();
            this.caixaTextoTotal = new System.Windows.Forms.TextBox();
            this.caixaTextoDescontos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.etiquetaListagem = new System.Windows.Forms.Label();
            this.caixaDataSelecionada = new System.Windows.Forms.DateTimePicker();
            this.gridServicos = new System.Windows.Forms.DataGridView();
            this.colunaNomeServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaValorServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtendimentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAtendimentos
            // 
            this.gridAtendimentos.AllowUserToAddRows = false;
            this.gridAtendimentos.AllowUserToDeleteRows = false;
            this.gridAtendimentos.AllowUserToResizeColumns = false;
            this.gridAtendimentos.AllowUserToResizeRows = false;
            this.gridAtendimentos.BackgroundColor = System.Drawing.Color.White;
            this.gridAtendimentos.ColumnHeadersHeight = 35;
            this.gridAtendimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaIdAtendimento,
            this.colunaCliente,
            this.colunaCpf,
            this.colunaValorParcial,
            this.colunaDesconto,
            this.colunaTotal});
            this.gridAtendimentos.GridColor = System.Drawing.Color.White;
            this.gridAtendimentos.Location = new System.Drawing.Point(13, 55);
            this.gridAtendimentos.MultiSelect = false;
            this.gridAtendimentos.Name = "gridAtendimentos";
            this.gridAtendimentos.ReadOnly = true;
            this.gridAtendimentos.RowHeadersVisible = false;
            this.gridAtendimentos.RowTemplate.Height = 25;
            this.gridAtendimentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridAtendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAtendimentos.Size = new System.Drawing.Size(619, 401);
            this.gridAtendimentos.TabIndex = 2;
            this.gridAtendimentos.SelectionChanged += new System.EventHandler(this.gridFinanceiro_SelectionChanged);
            // 
            // colunaIdAtendimento
            // 
            this.colunaIdAtendimento.HeaderText = "Id";
            this.colunaIdAtendimento.Name = "colunaIdAtendimento";
            this.colunaIdAtendimento.ReadOnly = true;
            this.colunaIdAtendimento.Width = 50;
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
            this.colunaCpf.Width = 130;
            // 
            // colunaValorParcial
            // 
            this.colunaValorParcial.HeaderText = "Valor Parcial";
            this.colunaValorParcial.Name = "colunaValorParcial";
            this.colunaValorParcial.ReadOnly = true;
            this.colunaValorParcial.Width = 105;
            // 
            // colunaDesconto
            // 
            this.colunaDesconto.HeaderText = "Desconto";
            this.colunaDesconto.Name = "colunaDesconto";
            this.colunaDesconto.ReadOnly = true;
            this.colunaDesconto.Width = 80;
            // 
            // colunaTotal
            // 
            this.colunaTotal.HeaderText = "Total";
            this.colunaTotal.Name = "colunaTotal";
            this.colunaTotal.ReadOnly = true;
            this.colunaTotal.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total parcial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(597, 473);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saldo do mês:";
            // 
            // caixaTextoTotalParcial
            // 
            this.caixaTextoTotalParcial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixaTextoTotalParcial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.caixaTextoTotalParcial.Enabled = false;
            this.caixaTextoTotalParcial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caixaTextoTotalParcial.Location = new System.Drawing.Point(112, 471);
            this.caixaTextoTotalParcial.Name = "caixaTextoTotalParcial";
            this.caixaTextoTotalParcial.Size = new System.Drawing.Size(144, 27);
            this.caixaTextoTotalParcial.TabIndex = 6;
            // 
            // caixaTextoTotal
            // 
            this.caixaTextoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixaTextoTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.caixaTextoTotal.Enabled = false;
            this.caixaTextoTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caixaTextoTotal.Location = new System.Drawing.Point(709, 471);
            this.caixaTextoTotal.Name = "caixaTextoTotal";
            this.caixaTextoTotal.Size = new System.Drawing.Size(174, 27);
            this.caixaTextoTotal.TabIndex = 7;
            // 
            // caixaTextoDescontos
            // 
            this.caixaTextoDescontos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixaTextoDescontos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.caixaTextoDescontos.Enabled = false;
            this.caixaTextoDescontos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caixaTextoDescontos.Location = new System.Drawing.Point(425, 471);
            this.caixaTextoDescontos.Name = "caixaTextoDescontos";
            this.caixaTextoDescontos.Size = new System.Drawing.Size(144, 27);
            this.caixaTextoDescontos.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 473);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Descontos gerais:";
            // 
            // etiquetaListagem
            // 
            this.etiquetaListagem.AutoSize = true;
            this.etiquetaListagem.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.etiquetaListagem.Location = new System.Drawing.Point(11, 19);
            this.etiquetaListagem.Name = "etiquetaListagem";
            this.etiquetaListagem.Size = new System.Drawing.Size(199, 20);
            this.etiquetaListagem.TabIndex = 13;
            this.etiquetaListagem.Text = "Listagem de atendimentos:";
            // 
            // caixaDataSelecionada
            // 
            this.caixaDataSelecionada.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caixaDataSelecionada.Checked = false;
            this.caixaDataSelecionada.CustomFormat = "MM:yyyyy";
            this.caixaDataSelecionada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.caixaDataSelecionada.Location = new System.Drawing.Point(206, 17);
            this.caixaDataSelecionada.Name = "caixaDataSelecionada";
            this.caixaDataSelecionada.Size = new System.Drawing.Size(108, 27);
            this.caixaDataSelecionada.TabIndex = 14;
            this.caixaDataSelecionada.ValueChanged += new System.EventHandler(this.caixaDataSelecionada_ValueChanged);
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
            this.gridServicos.GridColor = System.Drawing.Color.White;
            this.gridServicos.Location = new System.Drawing.Point(638, 92);
            this.gridServicos.MultiSelect = false;
            this.gridServicos.Name = "gridServicos";
            this.gridServicos.ReadOnly = true;
            this.gridServicos.RowHeadersVisible = false;
            this.gridServicos.RowTemplate.Height = 25;
            this.gridServicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridServicos.Size = new System.Drawing.Size(245, 364);
            this.gridServicos.TabIndex = 15;
            // 
            // colunaNomeServico
            // 
            this.colunaNomeServico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaNomeServico.FillWeight = 68.02721F;
            this.colunaNomeServico.HeaderText = "Nome do serviço";
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(638, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(183, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Serviços do atendimento";
            // 
            // FinanceiroListaControleDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.gridServicos);
            this.Controls.Add(this.caixaDataSelecionada);
            this.Controls.Add(this.etiquetaListagem);
            this.Controls.Add(this.caixaTextoDescontos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.caixaTextoTotal);
            this.Controls.Add(this.caixaTextoTotalParcial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAtendimentos);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinanceiroListaControleDeUsuario";
            this.Size = new System.Drawing.Size(896, 554);
            this.Load += new System.EventHandler(this.FinanceiroListaControleDeUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAtendimentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridAtendimentos;
        private DataGridViewTextBoxColumn colunaIdAtendimento;
        private DataGridViewTextBoxColumn colunaCliente;
        private DateTimePicker caixaDataSelecionada;
        private Label label1;
        private Label label2;
        private TextBox caixaTextoTotalParcial;
        private TextBox caixaTextoTotal;
        private TextBox caixaTextoDescontos;
        private Label label3;
        private Label etiquetaListagem;
        private DataGridViewTextBoxColumn colunaCpf;
        private DataGridViewTextBoxColumn colunaValorParcial;
        private DataGridViewTextBoxColumn colunaDesconto;
        private DataGridViewTextBoxColumn colunaTotal;
        private DataGridView gridServicos;
        private Label label4;
        private DataGridViewTextBoxColumn colunaNomeServico;
        private DataGridViewTextBoxColumn colunaValorServico;
    }
}
