namespace TCC.Thalia.Teles.App.Paineis.Promocoes
{
    partial class AdicionarPromocoesTela
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
            this.label3 = new System.Windows.Forms.Label();
            this.listaNomesServicos = new System.Windows.Forms.ComboBox();
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.caixaNumericaValor = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.caixaNumericaValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(42, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Serviço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Desconto:";
            // 
            // listaNomesServicos
            // 
            this.listaNomesServicos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listaNomesServicos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listaNomesServicos.FormattingEnabled = true;
            this.listaNomesServicos.Location = new System.Drawing.Point(137, 29);
            this.listaNomesServicos.Name = "listaNomesServicos";
            this.listaNomesServicos.Size = new System.Drawing.Size(239, 28);
            this.listaNomesServicos.TabIndex = 1;
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(279, 70);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(97, 28);
            this.botaoSalvar.TabIndex = 3;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // caixaNumericaValor
            // 
            this.caixaNumericaValor.DecimalPlaces = 2;
            this.caixaNumericaValor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caixaNumericaValor.Location = new System.Drawing.Point(137, 70);
            this.caixaNumericaValor.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.caixaNumericaValor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.caixaNumericaValor.Name = "caixaNumericaValor";
            this.caixaNumericaValor.Size = new System.Drawing.Size(120, 27);
            this.caixaNumericaValor.TabIndex = 2;
            this.caixaNumericaValor.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AdicionarPromocoesTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 139);
            this.Controls.Add(this.caixaNumericaValor);
            this.Controls.Add(this.botaoSalvar);
            this.Controls.Add(this.listaNomesServicos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarPromocoesTela";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Promoção";
            ((System.ComponentModel.ISupportInitialize)(this.caixaNumericaValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label3;
        private ComboBox listaNomesServicos;
        private Button botaoSalvar;
        private NumericUpDown caixaNumericaValor;
    }
}