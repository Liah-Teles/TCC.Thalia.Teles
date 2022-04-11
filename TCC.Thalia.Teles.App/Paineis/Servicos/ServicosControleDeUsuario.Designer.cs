namespace TCC.Thalia.Teles.App.Paineis.Servicos
{
    partial class ServicosControleDeUsuario
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
            this.gridAgenda = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.colunaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridAgenda)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gridAgenda);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 20);
            this.panel1.Size = new System.Drawing.Size(1245, 755);
            this.panel1.TabIndex = 0;
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
            this.nomeServico,
            this.valorServico});
            this.gridAgenda.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridAgenda.GridColor = System.Drawing.Color.White;
            this.gridAgenda.Location = new System.Drawing.Point(10, 75);
            this.gridAgenda.MultiSelect = false;
            this.gridAgenda.Name = "gridAgenda";
            this.gridAgenda.ReadOnly = true;
            this.gridAgenda.RowHeadersVisible = false;
            this.gridAgenda.RowTemplate.Height = 25;
            this.gridAgenda.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gridAgenda.Size = new System.Drawing.Size(1225, 660);
            this.gridAgenda.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(171, 35);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 34);
            this.button3.TabIndex = 7;
            this.button3.Text = "Remover";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(90, 35);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 34);
            this.button2.TabIndex = 6;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // colunaId
            // 
            this.colunaId.HeaderText = "Id";
            this.colunaId.Name = "colunaId";
            this.colunaId.ReadOnly = true;
            this.colunaId.Width = 50;
            // 
            // nomeServico
            // 
            this.nomeServico.HeaderText = "Nome do Serviço";
            this.nomeServico.Name = "nomeServico";
            this.nomeServico.ReadOnly = true;
            this.nomeServico.Width = 200;
            // 
            // valorServico
            // 
            this.valorServico.HeaderText = "Valor do Serviço";
            this.valorServico.Name = "valorServico";
            this.valorServico.ReadOnly = true;
            this.valorServico.Width = 150;
            // 
            // ServicosControleDeUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Name = "ServicosControleDeUsuario";
            this.Size = new System.Drawing.Size(1245, 755);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridAgenda)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private DataGridView gridAgenda;
        private DataGridViewTextBoxColumn colunaId;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridViewTextBoxColumn nomeServico;
        private DataGridViewTextBoxColumn valorServico;
    }
}
