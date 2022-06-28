namespace TCC.Thalia.Teles.App.Paineis.Financeiros
{
    partial class FinanceiroControleDeUsuario
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
            this.gridAgendamentos = new System.Windows.Forms.DataGridView();
            this.colunaIdAgendamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridServicos = new System.Windows.Forms.DataGridView();
            this.colunaIdServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaNomeServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.caixaTextoValorParcial = new System.Windows.Forms.TextBox();
            this.caixaTextoDesconto = new System.Windows.Forms.TextBox();
            this.caixaTextoTotal = new System.Windows.Forms.TextBox();
            this.botaoFinalizar = new System.Windows.Forms.Button();
            this.gridDescontos = new System.Windows.Forms.DataGridView();
            this.colunaNomeServicoDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaValorDesconto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgendamentos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDescontos)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAgendamentos
            // 
            this.gridAgendamentos.AllowUserToAddRows = false;
            this.gridAgendamentos.AllowUserToDeleteRows = false;
            this.gridAgendamentos.AllowUserToResizeColumns = false;
            this.gridAgendamentos.AllowUserToResizeRows = false;
            this.gridAgendamentos.BackgroundColor = System.Drawing.Color.White;
            this.gridAgendamentos.ColumnHeadersHeight = 35;
            this.gridAgendamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridAgendamentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaIdAgendamento,
            this.colunaCliente});
            this.gridAgendamentos.GridColor = System.Drawing.Color.White;
            this.gridAgendamentos.Location = new System.Drawing.Point(17, 67);
            this.gridAgendamentos.MultiSelect = false;
            this.gridAgendamentos.Name = "gridAgendamentos";
            this.gridAgendamentos.ReadOnly = true;
            this.gridAgendamentos.RowHeadersVisible = false;
            this.gridAgendamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridAgendamentos.RowTemplate.Height = 25;
            this.gridAgendamentos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridAgendamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridAgendamentos.Size = new System.Drawing.Size(498, 284);
            this.gridAgendamentos.TabIndex = 1;
            this.gridAgendamentos.SelectionChanged += new System.EventHandler(this.gridAgendamentos_SelectionChanged);
            // 
            // colunaIdAgendamento
            // 
            this.colunaIdAgendamento.HeaderText = "Id";
            this.colunaIdAgendamento.Name = "colunaIdAgendamento";
            this.colunaIdAgendamento.ReadOnly = true;
            this.colunaIdAgendamento.Width = 50;
            // 
            // colunaCliente
            // 
            this.colunaCliente.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaCliente.FillWeight = 68.02721F;
            this.colunaCliente.HeaderText = "Nome do Cliente";
            this.colunaCliente.Name = "colunaCliente";
            this.colunaCliente.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(17, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Selecione o agendamento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(521, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descontos aplicados";
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
            this.colunaIdServico,
            this.colunaNomeServico});
            this.gridServicos.Enabled = false;
            this.gridServicos.GridColor = System.Drawing.Color.White;
            this.gridServicos.Location = new System.Drawing.Point(521, 67);
            this.gridServicos.MultiSelect = false;
            this.gridServicos.Name = "gridServicos";
            this.gridServicos.ReadOnly = true;
            this.gridServicos.RowHeadersVisible = false;
            this.gridServicos.RowTemplate.Height = 25;
            this.gridServicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridServicos.Size = new System.Drawing.Size(302, 147);
            this.gridServicos.TabIndex = 2;
            // 
            // colunaIdServico
            // 
            this.colunaIdServico.HeaderText = "Id";
            this.colunaIdServico.Name = "colunaIdServico";
            this.colunaIdServico.ReadOnly = true;
            this.colunaIdServico.Width = 50;
            // 
            // colunaNomeServico
            // 
            this.colunaNomeServico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaNomeServico.FillWeight = 68.02721F;
            this.colunaNomeServico.HeaderText = "Nome Serviço";
            this.colunaNomeServico.Name = "colunaNomeServico";
            this.colunaNomeServico.ReadOnly = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(521, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Serviços Realizados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(521, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Valor parcial:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(521, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Desconto aplicado:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(521, 443);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Total:";
            // 
            // caixaTextoValorParcial
            // 
            this.caixaTextoValorParcial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixaTextoValorParcial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.caixaTextoValorParcial.Enabled = false;
            this.caixaTextoValorParcial.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caixaTextoValorParcial.Location = new System.Drawing.Point(679, 373);
            this.caixaTextoValorParcial.Name = "caixaTextoValorParcial";
            this.caixaTextoValorParcial.Size = new System.Drawing.Size(144, 27);
            this.caixaTextoValorParcial.TabIndex = 4;
            // 
            // caixaTextoDesconto
            // 
            this.caixaTextoDesconto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixaTextoDesconto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.caixaTextoDesconto.Enabled = false;
            this.caixaTextoDesconto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caixaTextoDesconto.Location = new System.Drawing.Point(679, 408);
            this.caixaTextoDesconto.Name = "caixaTextoDesconto";
            this.caixaTextoDesconto.Size = new System.Drawing.Size(144, 27);
            this.caixaTextoDesconto.TabIndex = 5;
            // 
            // caixaTextoTotal
            // 
            this.caixaTextoTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixaTextoTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.caixaTextoTotal.Enabled = false;
            this.caixaTextoTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.caixaTextoTotal.Location = new System.Drawing.Point(679, 441);
            this.caixaTextoTotal.Name = "caixaTextoTotal";
            this.caixaTextoTotal.Size = new System.Drawing.Size(144, 27);
            this.caixaTextoTotal.TabIndex = 6;
            // 
            // botaoFinalizar
            // 
            this.botaoFinalizar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botaoFinalizar.Location = new System.Drawing.Point(17, 429);
            this.botaoFinalizar.Name = "botaoFinalizar";
            this.botaoFinalizar.Size = new System.Drawing.Size(498, 34);
            this.botaoFinalizar.TabIndex = 7;
            this.botaoFinalizar.Text = "Finalizar Agendamento";
            this.botaoFinalizar.UseVisualStyleBackColor = true;
            this.botaoFinalizar.Click += new System.EventHandler(this.botaoFinalizar_Click);
            // 
            // gridDescontos
            // 
            this.gridDescontos.AllowUserToAddRows = false;
            this.gridDescontos.AllowUserToDeleteRows = false;
            this.gridDescontos.AllowUserToResizeColumns = false;
            this.gridDescontos.AllowUserToResizeRows = false;
            this.gridDescontos.BackgroundColor = System.Drawing.Color.White;
            this.gridDescontos.ColumnHeadersHeight = 35;
            this.gridDescontos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colunaNomeServicoDesconto,
            this.colunaValorDesconto});
            this.gridDescontos.Enabled = false;
            this.gridDescontos.GridColor = System.Drawing.Color.White;
            this.gridDescontos.Location = new System.Drawing.Point(521, 240);
            this.gridDescontos.MultiSelect = false;
            this.gridDescontos.Name = "gridDescontos";
            this.gridDescontos.ReadOnly = true;
            this.gridDescontos.RowHeadersVisible = false;
            this.gridDescontos.RowTemplate.Height = 25;
            this.gridDescontos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridDescontos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridDescontos.Size = new System.Drawing.Size(302, 111);
            this.gridDescontos.TabIndex = 13;
            // 
            // colunaNomeServicoDesconto
            // 
            this.colunaNomeServicoDesconto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colunaNomeServicoDesconto.FillWeight = 68.02721F;
            this.colunaNomeServicoDesconto.HeaderText = "Nome Serviço";
            this.colunaNomeServicoDesconto.Name = "colunaNomeServicoDesconto";
            this.colunaNomeServicoDesconto.ReadOnly = true;
            // 
            // colunaValorDesconto
            // 
            this.colunaValorDesconto.HeaderText = "Valor";
            this.colunaValorDesconto.Name = "colunaValorDesconto";
            this.colunaValorDesconto.ReadOnly = true;
            this.colunaValorDesconto.Width = 80;
            // 
            // FinanceiroControleDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.gridDescontos);
            this.Controls.Add(this.botaoFinalizar);
            this.Controls.Add(this.caixaTextoTotal);
            this.Controls.Add(this.caixaTextoDesconto);
            this.Controls.Add(this.caixaTextoValorParcial);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridServicos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAgendamentos);
            this.Name = "FinanceiroControleDeUsuario";
            this.Size = new System.Drawing.Size(849, 511);
            this.Load += new System.EventHandler(this.FinanceiroControleDeUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAgendamentos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDescontos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView gridAgendamentos;
        private Label label1;
        private Label label2;
        private DataGridView gridServicos;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox caixaTextoValorParcial;
        private TextBox caixaTextoDesconto;
        private TextBox caixaTextoTotal;
        private Button botaoFinalizar;
        private DataGridViewTextBoxColumn colunaIdAgendamento;
        private DataGridViewTextBoxColumn colunaCliente;
        private DataGridViewTextBoxColumn colunaIdServico;
        private DataGridViewTextBoxColumn colunaNomeServico;
        private DataGridView gridDescontos;
        private DataGridViewTextBoxColumn colunaNomeServicoDesconto;
        private DataGridViewTextBoxColumn colunaValorDesconto;
    }
}
