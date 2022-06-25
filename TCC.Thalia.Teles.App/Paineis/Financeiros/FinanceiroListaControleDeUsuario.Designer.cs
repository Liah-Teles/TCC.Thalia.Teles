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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.caixaTextoDescontos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.caixaTextoTotal = new System.Windows.Forms.TextBox();
            this.caixaTextoTotalParcial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.caixaTextoTotalServiços = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridServicos = new System.Windows.Forms.DataGridView();
            this.colunaNomeServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaValorServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.caixaDataSelecionada = new System.Windows.Forms.DateTimePicker();
            this.gridAtendimentos = new System.Windows.Forms.DataGridView();
            this.colunaIdAtendimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaValorParcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtendimentos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.caixaTextoDescontos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.caixaTextoTotal);
            this.groupBox1.Controls.Add(this.caixaTextoTotalParcial);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.caixaDataSelecionada);
            this.groupBox1.Controls.Add(this.gridAtendimentos);
            this.groupBox1.Location = new System.Drawing.Point(7, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(865, 496);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Atendimentos por mês/ano";
            // 
            // caixaTextoDescontos
            // 
            this.caixaTextoDescontos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixaTextoDescontos.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.caixaTextoDescontos.Enabled = false;
            this.caixaTextoDescontos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caixaTextoDescontos.Location = new System.Drawing.Point(412, 461);
            this.caixaTextoDescontos.Name = "caixaTextoDescontos";
            this.caixaTextoDescontos.Size = new System.Drawing.Size(144, 27);
            this.caixaTextoDescontos.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 465);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descontos gerais:";
            // 
            // caixaTextoTotal
            // 
            this.caixaTextoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixaTextoTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.caixaTextoTotal.Enabled = false;
            this.caixaTextoTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caixaTextoTotal.Location = new System.Drawing.Point(681, 461);
            this.caixaTextoTotal.Name = "caixaTextoTotal";
            this.caixaTextoTotal.Size = new System.Drawing.Size(174, 27);
            this.caixaTextoTotal.TabIndex = 27;
            // 
            // caixaTextoTotalParcial
            // 
            this.caixaTextoTotalParcial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixaTextoTotalParcial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.caixaTextoTotalParcial.Enabled = false;
            this.caixaTextoTotalParcial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caixaTextoTotalParcial.Location = new System.Drawing.Point(99, 463);
            this.caixaTextoTotalParcial.Name = "caixaTextoTotalParcial";
            this.caixaTextoTotalParcial.Size = new System.Drawing.Size(144, 27);
            this.caixaTextoTotalParcial.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(569, 465);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Saldo do mês:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 465);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "Total parcial:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.caixaTextoTotalServiços);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.gridServicos);
            this.groupBox2.Location = new System.Drawing.Point(625, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(236, 361);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços do atendimento";
            // 
            // caixaTextoTotalServiços
            // 
            this.caixaTextoTotalServiços.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixaTextoTotalServiços.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.caixaTextoTotalServiços.Enabled = false;
            this.caixaTextoTotalServiços.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caixaTextoTotalServiços.Location = new System.Drawing.Point(97, 328);
            this.caixaTextoTotalServiços.Name = "caixaTextoTotalServiços";
            this.caixaTextoTotalServiços.Size = new System.Drawing.Size(133, 27);
            this.caixaTextoTotalServiços.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Total:";
            // 
            // gridServicos
            // 
            this.gridServicos.AllowUserToAddRows = false;
            this.gridServicos.AllowUserToDeleteRows = false;
            this.gridServicos.AllowUserToResizeColumns = false;
            this.gridServicos.AllowUserToResizeRows = false;
            this.gridServicos.BackgroundColor = System.Drawing.Color.White;
            this.gridServicos.ColumnHeadersHeight = 35;
            this.gridServicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridServicos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaNomeServico,
            this.colunaValorServico});
            this.gridServicos.Enabled = false;
            this.gridServicos.GridColor = System.Drawing.Color.White;
            this.gridServicos.Location = new System.Drawing.Point(6, 26);
            this.gridServicos.MultiSelect = false;
            this.gridServicos.Name = "gridServicos";
            this.gridServicos.ReadOnly = true;
            this.gridServicos.RowHeadersVisible = false;
            this.gridServicos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridServicos.RowTemplate.Height = 25;
            this.gridServicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridServicos.Size = new System.Drawing.Size(224, 296);
            this.gridServicos.TabIndex = 19;
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
            this.colunaValorServico.Width = 90;
            // 
            // caixaDataSelecionada
            // 
            this.caixaDataSelecionada.CalendarFont = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caixaDataSelecionada.Checked = false;
            this.caixaDataSelecionada.CustomFormat = "MM/yyyyy";
            this.caixaDataSelecionada.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.caixaDataSelecionada.Location = new System.Drawing.Point(6, 31);
            this.caixaDataSelecionada.Name = "caixaDataSelecionada";
            this.caixaDataSelecionada.Size = new System.Drawing.Size(108, 27);
            this.caixaDataSelecionada.TabIndex = 22;
            this.caixaDataSelecionada.ValueChanged += new System.EventHandler(this.caixaDataSelecionada_ValueChanged);
            // 
            // gridAtendimentos
            // 
            this.gridAtendimentos.AllowUserToAddRows = false;
            this.gridAtendimentos.AllowUserToDeleteRows = false;
            this.gridAtendimentos.AllowUserToResizeColumns = false;
            this.gridAtendimentos.AllowUserToResizeRows = false;
            this.gridAtendimentos.BackgroundColor = System.Drawing.Color.White;
            this.gridAtendimentos.ColumnHeadersHeight = 35;
            this.gridAtendimentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridAtendimentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaIdAtendimento,
            this.colunaCliente,
            this.colunaCpf,
            this.colunaValorParcial,
            this.colunaDesconto,
            this.colunaTotal});
            this.gridAtendimentos.GridColor = System.Drawing.Color.White;
            this.gridAtendimentos.Location = new System.Drawing.Point(4, 64);
            this.gridAtendimentos.MultiSelect = false;
            this.gridAtendimentos.Name = "gridAtendimentos";
            this.gridAtendimentos.ReadOnly = true;
            this.gridAtendimentos.RowHeadersVisible = false;
            this.gridAtendimentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAtendimentos.RowTemplate.Height = 25;
            this.gridAtendimentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridAtendimentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAtendimentos.Size = new System.Drawing.Size(619, 391);
            this.gridAtendimentos.TabIndex = 20;
            this.gridAtendimentos.SelectionChanged += new System.EventHandler(this.gridAtendimentos_SelectionChanged);
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
            // FinanceiroListaControleDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FinanceiroListaControleDeUsuario";
            this.Size = new System.Drawing.Size(896, 554);
            this.Load += new System.EventHandler(this.FinanceiroListaControleDeUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAtendimentos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox caixaTextoTotalParcial;
        private TextBox caixaTextoTotal;
        private TextBox caixaTextoDescontos;
        private Label label3;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox caixaTextoTotalServiços;
        private Label label5;
        private DataGridView gridServicos;
        private DataGridViewTextBoxColumn colunaNomeServico;
        private DataGridViewTextBoxColumn colunaValorServico;
        private DateTimePicker caixaDataSelecionada;
        private DataGridView gridAtendimentos;
        private DataGridViewTextBoxColumn colunaIdAtendimento;
        private DataGridViewTextBoxColumn colunaCliente;
        private DataGridViewTextBoxColumn colunaCpf;
        private DataGridViewTextBoxColumn colunaValorParcial;
        private DataGridViewTextBoxColumn colunaDesconto;
        private DataGridViewTextBoxColumn colunaTotal;
    }
}
