namespace TCC.Thalia.Teles.App;

partial class PrincipalTela
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.painelLateral = new System.Windows.Forms.Panel();
            this.botaoFinanceiro = new System.Windows.Forms.Button();
            this.botaoClientes = new System.Windows.Forms.Button();
            this.botaoDescontos = new System.Windows.Forms.Button();
            this.botaoServicos = new System.Windows.Forms.Button();
            this.botaoAgendamentos = new System.Windows.Forms.Button();
            this.painelLogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.painelTopo = new System.Windows.Forms.Panel();
            this.botaoConcluirAgendamento = new System.Windows.Forms.Button();
            this.painelCentral = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.painelLateral.SuspendLayout();
            this.painelLogo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelLateral
            // 
            this.painelLateral.BackColor = System.Drawing.Color.Blue;
            this.painelLateral.Controls.Add(this.botaoFinanceiro);
            this.painelLateral.Controls.Add(this.botaoClientes);
            this.painelLateral.Controls.Add(this.botaoDescontos);
            this.painelLateral.Controls.Add(this.botaoServicos);
            this.painelLateral.Controls.Add(this.botaoAgendamentos);
            this.painelLateral.Controls.Add(this.painelLogo);
            this.painelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.painelLateral.Location = new System.Drawing.Point(0, 0);
            this.painelLateral.Name = "painelLateral";
            this.painelLateral.Size = new System.Drawing.Size(142, 640);
            this.painelLateral.TabIndex = 0;
            // 
            // botaoFinanceiro
            // 
            this.botaoFinanceiro.BackColor = System.Drawing.Color.Blue;
            this.botaoFinanceiro.FlatAppearance.BorderSize = 0;
            this.botaoFinanceiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoFinanceiro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoFinanceiro.ForeColor = System.Drawing.Color.White;
            this.botaoFinanceiro.Location = new System.Drawing.Point(0, 313);
            this.botaoFinanceiro.Name = "botaoFinanceiro";
            this.botaoFinanceiro.Size = new System.Drawing.Size(142, 50);
            this.botaoFinanceiro.TabIndex = 5;
            this.botaoFinanceiro.Text = "Financeiro";
            this.botaoFinanceiro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoFinanceiro.UseVisualStyleBackColor = false;
            this.botaoFinanceiro.Click += new System.EventHandler(this.botaoFinanceiro_Click);
            // 
            // botaoClientes
            // 
            this.botaoClientes.BackColor = System.Drawing.Color.Blue;
            this.botaoClientes.FlatAppearance.BorderSize = 0;
            this.botaoClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoClientes.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoClientes.ForeColor = System.Drawing.Color.White;
            this.botaoClientes.Location = new System.Drawing.Point(0, 263);
            this.botaoClientes.Name = "botaoClientes";
            this.botaoClientes.Size = new System.Drawing.Size(142, 50);
            this.botaoClientes.TabIndex = 4;
            this.botaoClientes.Text = "Clientes";
            this.botaoClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoClientes.UseVisualStyleBackColor = false;
            this.botaoClientes.Click += new System.EventHandler(this.botaoClientes_Click);
            // 
            // botaoDescontos
            // 
            this.botaoDescontos.BackColor = System.Drawing.Color.Blue;
            this.botaoDescontos.FlatAppearance.BorderSize = 0;
            this.botaoDescontos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoDescontos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoDescontos.ForeColor = System.Drawing.Color.White;
            this.botaoDescontos.Location = new System.Drawing.Point(0, 213);
            this.botaoDescontos.Name = "botaoDescontos";
            this.botaoDescontos.Size = new System.Drawing.Size(142, 50);
            this.botaoDescontos.TabIndex = 3;
            this.botaoDescontos.Text = "Descontos";
            this.botaoDescontos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoDescontos.UseVisualStyleBackColor = false;
            this.botaoDescontos.Click += new System.EventHandler(this.botaoDescontos_Click);
            // 
            // botaoServicos
            // 
            this.botaoServicos.BackColor = System.Drawing.Color.Blue;
            this.botaoServicos.FlatAppearance.BorderSize = 0;
            this.botaoServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoServicos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoServicos.ForeColor = System.Drawing.Color.White;
            this.botaoServicos.Location = new System.Drawing.Point(0, 163);
            this.botaoServicos.Name = "botaoServicos";
            this.botaoServicos.Size = new System.Drawing.Size(142, 50);
            this.botaoServicos.TabIndex = 2;
            this.botaoServicos.Text = "Serviços";
            this.botaoServicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoServicos.UseVisualStyleBackColor = false;
            this.botaoServicos.Click += new System.EventHandler(this.botaoServicos_Click);
            // 
            // botaoAgendamentos
            // 
            this.botaoAgendamentos.BackColor = System.Drawing.Color.Blue;
            this.botaoAgendamentos.FlatAppearance.BorderSize = 0;
            this.botaoAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoAgendamentos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.botaoAgendamentos.ForeColor = System.Drawing.Color.White;
            this.botaoAgendamentos.Location = new System.Drawing.Point(0, 113);
            this.botaoAgendamentos.Name = "botaoAgendamentos";
            this.botaoAgendamentos.Size = new System.Drawing.Size(142, 50);
            this.botaoAgendamentos.TabIndex = 1;
            this.botaoAgendamentos.Text = "Agenda";
            this.botaoAgendamentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.botaoAgendamentos.UseVisualStyleBackColor = false;
            this.botaoAgendamentos.Click += new System.EventHandler(this.botaoAgendamentos_Click);
            // 
            // painelLogo
            // 
            this.painelLogo.Controls.Add(this.panel2);
            this.painelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelLogo.Location = new System.Drawing.Point(0, 0);
            this.painelLogo.Name = "painelLogo";
            this.painelLogo.Size = new System.Drawing.Size(142, 107);
            this.painelLogo.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(142, 86);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = " Centro Estetico";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oasis";
            // 
            // painelTopo
            // 
            this.painelTopo.BackColor = System.Drawing.Color.DarkBlue;
            this.painelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelTopo.Location = new System.Drawing.Point(142, 0);
            this.painelTopo.Name = "painelTopo";
            this.painelTopo.Size = new System.Drawing.Size(896, 86);
            this.painelTopo.TabIndex = 1;
            // 
            // botaoConcluirAgendamento
            // 
            this.botaoConcluirAgendamento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.botaoConcluirAgendamento.Location = new System.Drawing.Point(696, 4);
            this.botaoConcluirAgendamento.Name = "botaoConcluirAgendamento";
            this.botaoConcluirAgendamento.Size = new System.Drawing.Size(176, 34);
            this.botaoConcluirAgendamento.TabIndex = 8;
            this.botaoConcluirAgendamento.Text = "Fechar agendamento";
            this.botaoConcluirAgendamento.UseVisualStyleBackColor = true;
            this.botaoConcluirAgendamento.Visible = false;
            this.botaoConcluirAgendamento.Click += new System.EventHandler(this.botaoConcluirAgendamento_Click);
            // 
            // painelCentral
            // 
            this.painelCentral.BackColor = System.Drawing.Color.White;
            this.painelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.painelCentral.Location = new System.Drawing.Point(142, 86);
            this.painelCentral.Name = "painelCentral";
            this.painelCentral.Size = new System.Drawing.Size(896, 554);
            this.painelCentral.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.botaoConcluirAgendamento);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(142, 589);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 51);
            this.panel1.TabIndex = 3;
            // 
            // PrincipalTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1038, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.painelCentral);
            this.Controls.Add(this.painelTopo);
            this.Controls.Add(this.painelLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PrincipalTela";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oasis Estetica";
            this.painelLateral.ResumeLayout(false);
            this.painelLogo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Panel painelLateral;
    private Panel painelTopo;
    private Button botaoAgendamentos;
    private Panel painelLogo;
    private Button botaoFinanceiro;
    private Button botaoClientes;
    private Button botaoDescontos;
    private Button botaoServicos;
    private Label label2;
    private Label label1;
    private Panel painelCentral;
    private Button botaoConcluirAgendamento;
    private Panel panel1;
    private Panel panel2;
}