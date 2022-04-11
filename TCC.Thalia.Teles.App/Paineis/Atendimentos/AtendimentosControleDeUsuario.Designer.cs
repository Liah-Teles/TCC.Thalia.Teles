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
            this.painelParaGrid = new System.Windows.Forms.Panel();
            this.gridAgenda = new System.Windows.Forms.DataGridView();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaHorario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colunaProfissional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.painelParaGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgenda)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelParaGrid
            // 
            this.painelParaGrid.Controls.Add(this.gridAgenda);
            this.painelParaGrid.Dock = System.Windows.Forms.DockStyle.Right;
            this.painelParaGrid.Location = new System.Drawing.Point(248, 0);
            this.painelParaGrid.Name = "painelParaGrid";
            this.painelParaGrid.Size = new System.Drawing.Size(997, 755);
            this.painelParaGrid.TabIndex = 1;
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
            this.colunaServico,
            this.colunaProfissional});
            this.gridAgenda.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridAgenda.GridColor = System.Drawing.Color.White;
            this.gridAgenda.Location = new System.Drawing.Point(0, 0);
            this.gridAgenda.MultiSelect = false;
            this.gridAgenda.Name = "gridAgenda";
            this.gridAgenda.ReadOnly = true;
            this.gridAgenda.RowHeadersVisible = false;
            this.gridAgenda.RowTemplate.Height = 25;
            this.gridAgenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridAgenda.Size = new System.Drawing.Size(997, 755);
            this.gridAgenda.TabIndex = 0;
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
            this.colunaHorario.HeaderText = "Horario";
            this.colunaHorario.Name = "colunaHorario";
            this.colunaHorario.ReadOnly = true;
            this.colunaHorario.Width = 150;
            // 
            // colunaServico
            // 
            this.colunaServico.HeaderText = "Serviço";
            this.colunaServico.Name = "colunaServico";
            this.colunaServico.ReadOnly = true;
            this.colunaServico.Width = 150;
            // 
            // colunaProfissional
            // 
            this.colunaProfissional.HeaderText = "Profissional";
            this.colunaProfissional.Name = "colunaProfissional";
            this.colunaProfissional.ReadOnly = true;
            this.colunaProfissional.Width = 200;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.monthCalendar1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.panel2.Size = new System.Drawing.Size(242, 755);
            this.panel2.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(10, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(232, 377);
            this.panel1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 330);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 45);
            this.label1.TabIndex = 6;
            this.label1.Text = "Profissionais";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(6, 35);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            // 
            // AtendimentosControleDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.painelParaGrid);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "AtendimentosControleDeUsuario";
            this.Size = new System.Drawing.Size(1245, 755);
            this.painelParaGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAgenda)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel painelParaGrid;
        private DataGridView gridAgenda;
        private DataGridViewTextBoxColumn colunaId;
        private DataGridViewTextBoxColumn colunaHorario;
        private DataGridViewTextBoxColumn colunaServico;
        private DataGridViewTextBoxColumn colunaProfissional;
        private Panel panel2;
        private Button button1;
        private Label label1;
        private MonthCalendar monthCalendar1;
        private Panel panel1;
    }
}
