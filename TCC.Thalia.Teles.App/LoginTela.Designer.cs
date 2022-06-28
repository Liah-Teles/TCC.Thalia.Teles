namespace TCC.Thalia.Teles.App
{
    partial class LoginTela
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginTela));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.caixaDeTextoPassword = new System.Windows.Forms.TextBox();
            this.caixaDeTextoUsuario = new System.Windows.Forms.TextBox();
            this.botaoSair = new System.Windows.Forms.Button();
            this.botaoLogin = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.caixaDeTextoPassword);
            this.groupBox1.Controls.Add(this.caixaDeTextoUsuario);
            this.groupBox1.Controls.Add(this.botaoSair);
            this.groupBox1.Controls.Add(this.botaoLogin);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // caixaDeTextoPassword
            // 
            resources.ApplyResources(this.caixaDeTextoPassword, "caixaDeTextoPassword");
            this.caixaDeTextoPassword.Name = "caixaDeTextoPassword";
            // 
            // caixaDeTextoUsuario
            // 
            resources.ApplyResources(this.caixaDeTextoUsuario, "caixaDeTextoUsuario");
            this.caixaDeTextoUsuario.Name = "caixaDeTextoUsuario";
            // 
            // botaoSair
            // 
            resources.ApplyResources(this.botaoSair, "botaoSair");
            this.botaoSair.Name = "botaoSair";
            this.botaoSair.UseVisualStyleBackColor = true;
            this.botaoSair.Click += new System.EventHandler(this.botaoSair_Click);
            // 
            // botaoLogin
            // 
            resources.ApplyResources(this.botaoLogin, "botaoLogin");
            this.botaoLogin.Name = "botaoLogin";
            this.botaoLogin.UseVisualStyleBackColor = true;
            this.botaoLogin.Click += new System.EventHandler(this.botaoLogin_Click);
            // 
            // LoginTela
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginTela";
            this.ShowIcon = false;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label2;
        private Label label1;
        private TextBox caixaDeTextoPassword;
        private TextBox caixaDeTextoUsuario;
        private Button botaoSair;
        private Button botaoLogin;
    }
}