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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdicionarClienteTela));
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
            resources.ApplyResources(this.botaoSalvar, "botaoSalvar");
            this.botaoSalvar.Name = "botaoSalvar";
            this.botaoSalvar.UseVisualStyleBackColor = true;
            this.botaoSalvar.Click += new System.EventHandler(this.botaoSalvar_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // caixaDeTextoNome
            // 
            resources.ApplyResources(this.caixaDeTextoNome, "caixaDeTextoNome");
            this.caixaDeTextoNome.Name = "caixaDeTextoNome";
            // 
            // caixaDeTextoEndereco
            // 
            resources.ApplyResources(this.caixaDeTextoEndereco, "caixaDeTextoEndereco");
            this.caixaDeTextoEndereco.Name = "caixaDeTextoEndereco";
            // 
            // caixaTextoMascaraCelular
            // 
            this.caixaTextoMascaraCelular.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            resources.ApplyResources(this.caixaTextoMascaraCelular, "caixaTextoMascaraCelular");
            this.caixaTextoMascaraCelular.Name = "caixaTextoMascaraCelular";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // caixaTextoMascaraCpf
            // 
            this.caixaTextoMascaraCpf.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            resources.ApplyResources(this.caixaTextoMascaraCpf, "caixaTextoMascaraCpf");
            this.caixaTextoMascaraCpf.Name = "caixaTextoMascaraCpf";
            // 
            // AdicionarClienteTela
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
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