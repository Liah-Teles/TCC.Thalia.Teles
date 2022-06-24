namespace TCC.Thalia.Teles.App.Paineis.Clientes
{
    partial class AdicionarClienteTela
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
            this.botaoSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.caixaDeTextoNome = new System.Windows.Forms.TextBox();
            this.caixaDeTextoEndereco = new System.Windows.Forms.TextBox();
            this.caixaTextoMascaraCelular = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.caixaTextoMascaraCpf = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // botaoSalvar
            // 
            this.botaoSalvar.Location = new System.Drawing.Point(19, 132);
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.Size = new System.Drawing.Size(385, 28);
            this.botaoSalvar.TabIndex = 5;
            this.botaoSalvar.Text = "Salvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(19, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(241, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(19, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Endereço:";
            // 
            // caixaDeTextoNome
            // 
            this.caixaDeTextoNome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caixaDeTextoNome.Location = new System.Drawing.Point(115, 29);
            this.caixaDeTextoNome.Name = "caixaDeTextoNome";
            this.caixaDeTextoNome.Size = new System.Drawing.Size(289, 27);
            this.caixaDeTextoNome.TabIndex = 1;
            // 
            // caixaDeTextoEndereco
            // 
            this.caixaDeTextoEndereco.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caixaDeTextoEndereco.Location = new System.Drawing.Point(115, 62);
            this.caixaDeTextoEndereco.Name = "caixaDeTextoEndereco";
            this.caixaDeTextoEndereco.Size = new System.Drawing.Size(289, 27);
            this.caixaDeTextoEndereco.TabIndex = 2;
            // 
            // caixaTextoMascaraCelular
            // 
            this.caixaTextoMascaraCelular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.caixaTextoMascaraCelular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caixaTextoMascaraCelular.Location = new System.Drawing.Point(305, 94);
            this.caixaTextoMascaraCelular.Mask = "(99) 00000-0000";
            this.caixaTextoMascaraCelular.Name = "caixaTextoMascaraCelular";
            this.caixaTextoMascaraCelular.Size = new System.Drawing.Size(99, 27);
            this.caixaTextoMascaraCelular.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(19, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "CPF:";
            // 
            // caixaTextoMascaraCpf
            // 
            this.caixaTextoMascaraCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.caixaTextoMascaraCpf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.caixaTextoMascaraCpf.Location = new System.Drawing.Point(115, 95);
            this.caixaTextoMascaraCpf.Mask = "000.000.000-00";
            this.caixaTextoMascaraCpf.Name = "caixaTextoMascaraCpf";
            this.caixaTextoMascaraCpf.Size = new System.Drawing.Size(99, 27);
            this.caixaTextoMascaraCpf.TabIndex = 3;
            // 
            // AdicionarClienteTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(431, 179);
            this.Controls.Add(this.caixaTextoMascaraCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.caixaTextoMascaraCelular);
            this.Controls.Add(this.caixaDeTextoEndereco);
            this.Controls.Add(this.caixaDeTextoNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botaoSalvar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.MinimizeBox = false;
            this.Name = "AdicionarClienteTela";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button botaoSalvar;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox caixaDeTextoNome;
        private TextBox caixaDeTextoEndereco;
        private MaskedTextBox caixaTextoMascaraCelular;
        private Label label4;
        private MaskedTextBox caixaTextoMascaraCpf;
    }
}