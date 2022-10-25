
namespace RequestSystem
{
    partial class frm_Funcionario
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
            this.pnl_Detail = new System.Windows.Forms.Panel();
            this.tbox_Pass_Funcionario = new System.Windows.Forms.TextBox();
            this.tbox_Cod_Funcionario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbox_UNm_Funcionario = new System.Windows.Forms.TextBox();
            this.Label10 = new System.Windows.Forms.Label();
            this.pnl_List = new System.Windows.Forms.Panel();
            this.ltbox_Funcionarios = new System.Windows.Forms.ListBox();
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.pnl_Tittle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Detail.SuspendLayout();
            this.pnl_List.SuspendLayout();
            this.pnl_Button.SuspendLayout();
            this.pnl_Tittle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(222)))), ((int)(((byte)(72)))));
            this.pnl_Detail.Controls.Add(this.tbox_Pass_Funcionario);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Funcionario);
            this.pnl_Detail.Controls.Add(this.label9);
            this.pnl_Detail.Controls.Add(this.label7);
            this.pnl_Detail.Controls.Add(this.tbox_UNm_Funcionario);
            this.pnl_Detail.Controls.Add(this.Label10);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detail.Location = new System.Drawing.Point(133, 65);
            this.pnl_Detail.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(296, 143);
            this.pnl_Detail.TabIndex = 11;
            // 
            // tbox_Pass_Funcionario
            // 
            this.tbox_Pass_Funcionario.Location = new System.Drawing.Point(195, 77);
            this.tbox_Pass_Funcionario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbox_Pass_Funcionario.Name = "tbox_Pass_Funcionario";
            this.tbox_Pass_Funcionario.PasswordChar = '*';
            this.tbox_Pass_Funcionario.Size = new System.Drawing.Size(76, 20);
            this.tbox_Pass_Funcionario.TabIndex = 11;
            // 
            // tbox_Cod_Funcionario
            // 
            this.tbox_Cod_Funcionario.Enabled = false;
            this.tbox_Cod_Funcionario.Location = new System.Drawing.Point(19, 32);
            this.tbox_Cod_Funcionario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbox_Cod_Funcionario.Name = "tbox_Cod_Funcionario";
            this.tbox_Cod_Funcionario.Size = new System.Drawing.Size(76, 20);
            this.tbox_Cod_Funcionario.TabIndex = 7;
            this.tbox_Cod_Funcionario.Tag = "1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(198, 60);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Senha";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Código";
            // 
            // tbox_UNm_Funcionario
            // 
            this.tbox_UNm_Funcionario.Location = new System.Drawing.Point(19, 77);
            this.tbox_UNm_Funcionario.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tbox_UNm_Funcionario.Name = "tbox_UNm_Funcionario";
            this.tbox_UNm_Funcionario.Size = new System.Drawing.Size(164, 20);
            this.tbox_UNm_Funcionario.TabIndex = 9;
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(16, 60);
            this.Label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(93, 13);
            this.Label10.TabIndex = 8;
            this.Label10.Text = "Nome Funcionário";
            // 
            // pnl_List
            // 
            this.pnl_List.Controls.Add(this.ltbox_Funcionarios);
            this.pnl_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_List.Location = new System.Drawing.Point(0, 65);
            this.pnl_List.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(133, 143);
            this.pnl_List.TabIndex = 10;
            // 
            // ltbox_Funcionarios
            // 
            this.ltbox_Funcionarios.FormattingEnabled = true;
            this.ltbox_Funcionarios.Location = new System.Drawing.Point(0, 0);
            this.ltbox_Funcionarios.Margin = new System.Windows.Forms.Padding(2);
            this.ltbox_Funcionarios.Name = "ltbox_Funcionarios";
            this.ltbox_Funcionarios.Size = new System.Drawing.Size(135, 147);
            this.ltbox_Funcionarios.TabIndex = 0;
            this.ltbox_Funcionarios.Click += new System.EventHandler(this.ltbox_Funcionarios_Click);
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.Color.Khaki;
            this.pnl_Button.Controls.Add(this.btn_Cancelar);
            this.pnl_Button.Controls.Add(this.btn_Alterar);
            this.pnl_Button.Controls.Add(this.btn_Confirmar);
            this.pnl_Button.Controls.Add(this.btn_Novo);
            this.pnl_Button.Controls.Add(this.btn_Excluir);
            this.pnl_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Button.Location = new System.Drawing.Point(0, 208);
            this.pnl_Button.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(429, 53);
            this.pnl_Button.TabIndex = 9;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Cancelar.Location = new System.Drawing.Point(351, 18);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(66, 21);
            this.btn_Cancelar.TabIndex = 9;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.White;
            this.btn_Alterar.FlatAppearance.BorderSize = 0;
            this.btn_Alterar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Alterar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Alterar.Location = new System.Drawing.Point(65, 18);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(56, 21);
            this.btn_Alterar.TabIndex = 6;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.White;
            this.btn_Confirmar.FlatAppearance.BorderSize = 0;
            this.btn_Confirmar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Confirmar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Confirmar.Location = new System.Drawing.Point(282, 18);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(63, 21);
            this.btn_Confirmar.TabIndex = 8;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.BackColor = System.Drawing.Color.White;
            this.btn_Novo.FlatAppearance.BorderSize = 0;
            this.btn_Novo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Novo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Novo.Location = new System.Drawing.Point(5, 18);
            this.btn_Novo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(56, 21);
            this.btn_Novo.TabIndex = 5;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = false;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.White;
            this.btn_Excluir.FlatAppearance.BorderSize = 0;
            this.btn_Excluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Excluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Excluir.Location = new System.Drawing.Point(126, 18);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(56, 21);
            this.btn_Excluir.TabIndex = 7;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // pnl_Tittle
            // 
            this.pnl_Tittle.BackColor = System.Drawing.Color.Khaki;
            this.pnl_Tittle.Controls.Add(this.label1);
            this.pnl_Tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tittle.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tittle.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Tittle.Name = "pnl_Tittle";
            this.pnl_Tittle.Size = new System.Drawing.Size(429, 65);
            this.pnl_Tittle.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(78, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cadastro Funcionário";
            // 
            // frm_Funcionario
            // 
            this.ClientSize = new System.Drawing.Size(429, 261);
            this.Controls.Add(this.pnl_Detail);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.pnl_Tittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Funcionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnl_Detail.ResumeLayout(false);
            this.pnl_Detail.PerformLayout();
            this.pnl_List.ResumeLayout(false);
            this.pnl_Button.ResumeLayout(false);
            this.pnl_Tittle.ResumeLayout(false);
            this.pnl_Tittle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Detail;
        private System.Windows.Forms.TextBox tbox_Pass_Funcionario;
        private System.Windows.Forms.TextBox tbox_Cod_Funcionario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbox_UNm_Funcionario;
        private System.Windows.Forms.Label Label10;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.ListBox ltbox_Funcionarios;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Panel pnl_Tittle;
        private System.Windows.Forms.Label label1;
    }
}