namespace RequestSystem
{
    partial class frm_Login
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Pass_Funcionario = new System.Windows.Forms.TextBox();
            this.tbox_UNm_Funcionario = new System.Windows.Forms.TextBox();
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.pnl_Tittle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Detail.SuspendLayout();
            this.pnl_Button.SuspendLayout();
            this.pnl_Tittle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(222)))), ((int)(((byte)(72)))));
            this.pnl_Detail.Controls.Add(this.label3);
            this.pnl_Detail.Controls.Add(this.label2);
            this.pnl_Detail.Controls.Add(this.tbox_Pass_Funcionario);
            this.pnl_Detail.Controls.Add(this.tbox_UNm_Funcionario);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detail.Location = new System.Drawing.Point(0, 80);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(241, 139);
            this.pnl_Detail.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Senha";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome de usuário";
            // 
            // tbox_Pass_Funcionario
            // 
            this.tbox_Pass_Funcionario.Location = new System.Drawing.Point(24, 89);
            this.tbox_Pass_Funcionario.Name = "tbox_Pass_Funcionario";
            this.tbox_Pass_Funcionario.PasswordChar = '*';
            this.tbox_Pass_Funcionario.Size = new System.Drawing.Size(183, 20);
            this.tbox_Pass_Funcionario.TabIndex = 1;
            // 
            // tbox_UNm_Funcionario
            // 
            this.tbox_UNm_Funcionario.Location = new System.Drawing.Point(24, 34);
            this.tbox_UNm_Funcionario.Name = "tbox_UNm_Funcionario";
            this.tbox_UNm_Funcionario.Size = new System.Drawing.Size(183, 20);
            this.tbox_UNm_Funcionario.TabIndex = 0;
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.Color.Khaki;
            this.pnl_Button.Controls.Add(this.btn_Confirmar);
            this.pnl_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Button.Location = new System.Drawing.Point(0, 219);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(241, 73);
            this.pnl_Button.TabIndex = 4;
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.Location = new System.Drawing.Point(24, 18);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(183, 46);
            this.btn_Confirmar.TabIndex = 0;
            this.btn_Confirmar.Text = "CONFIRMAR";
            this.btn_Confirmar.UseVisualStyleBackColor = true;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // pnl_Tittle
            // 
            this.pnl_Tittle.BackColor = System.Drawing.Color.Khaki;
            this.pnl_Tittle.Controls.Add(this.label1);
            this.pnl_Tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tittle.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tittle.Name = "pnl_Tittle";
            this.pnl_Tittle.Size = new System.Drawing.Size(241, 80);
            this.pnl_Tittle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK Medium", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(55, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN ";
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 292);
            this.Controls.Add(this.pnl_Detail);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.pnl_Tittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_Detail.ResumeLayout(false);
            this.pnl_Detail.PerformLayout();
            this.pnl_Button.ResumeLayout(false);
            this.pnl_Tittle.ResumeLayout(false);
            this.pnl_Tittle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Detail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_Pass_Funcionario;
        private System.Windows.Forms.TextBox tbox_UNm_Funcionario;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Panel pnl_Tittle;
        private System.Windows.Forms.Label label1;
    }
}