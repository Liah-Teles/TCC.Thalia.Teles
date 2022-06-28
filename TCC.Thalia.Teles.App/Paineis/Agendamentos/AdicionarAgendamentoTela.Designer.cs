namespace TCC.Thalia.Teles.App.Paineis.Agendamentos
{
    partial class AdicionarAgendamentoTela
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.caixaListaClientes = new System.Windows.Forms.ComboBox();
            this.caixaDateHora = new System.Windows.Forms.DateTimePicker();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.gridServicos = new System.Windows.Forms.DataGridView();
            this.colunaNomeServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaValorServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridServicos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Data e Hora:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Serviços:";
            // 
            // caixaListaClientes
            // 
            this.caixaListaClientes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.caixaListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.caixaListaClientes.FormattingEnabled = true;
            this.caixaListaClientes.Location = new System.Drawing.Point(146, 28);
            this.caixaListaClientes.Name = "caixaListaClientes";
            this.caixaListaClientes.Size = new System.Drawing.Size(311, 28);
            this.caixaListaClientes.TabIndex = 3;
            this.caixaListaClientes.SelectedValueChanged += new System.EventHandler(this.caixaListaClientes_SelectedValueChanged);
            // 
            // caixaDateHora
            // 
            this.caixaDateHora.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.caixaDateHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.caixaDateHora.Location = new System.Drawing.Point(146, 66);
            this.caixaDateHora.Name = "caixaDateHora";
            this.caixaDateHora.Size = new System.Drawing.Size(311, 27);
            this.caixaDateHora.TabIndex = 6;
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(382, 318);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(75, 28);
            this.botaoSalvar.TabIndex = 8;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
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
            this.gridServicos.Location = new System.Drawing.Point(146, 99);
            this.gridServicos.Name = "gridServicos";
            this.gridServicos.ReadOnly = true;
            this.gridServicos.RowHeadersVisible = false;
            this.gridServicos.RowTemplate.Height = 25;
            this.gridServicos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridServicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridServicos.Size = new System.Drawing.Size(311, 213);
            this.gridServicos.TabIndex = 16;
            this.gridServicos.SelectionChanged += new System.EventHandler(this.gridServicos_SelectionChanged);
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
            // AdicionarAgendamentoTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 386);
            this.Controls.Add(this.gridServicos);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.caixaDateHora);
            this.Controls.Add(this.caixaListaClientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarAgendamentoTela";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar agendamento";
            this.Load += new System.EventHandler(this.AdicionarAgendamentoTela_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridServicos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox caixaListaClientes;
        private DateTimePicker caixaDateHora;
        private Button botaoSalvar;
        private DataGridView gridServicos;
        private DataGridViewTextBoxColumn colunaNomeServico;
        private DataGridViewTextBoxColumn colunaValorServico;
    }
}