namespace RequestSystem
{
    partial class frm_Principal
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
            this.components = new System.ComponentModel.Container();
            this.tm_Principal = new System.Windows.Forms.Timer(this.components);
            this.pnl_detail = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Pedido = new System.Windows.Forms.Button();
            this.btn_Produto = new System.Windows.Forms.Button();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.btn_Funcionario = new System.Windows.Forms.Button();
            this.sttstrip_Principal = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslb_Data = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslb_Hora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslb_Funcionario = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnl_detail.SuspendLayout();
            this.sttstrip_Principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tm_Principal
            // 
            this.tm_Principal.Enabled = true;
            this.tm_Principal.Tick += new System.EventHandler(this.tm_Principal_Tick);
            // 
            // pnl_detail
            // 
            this.pnl_detail.BackgroundImage = global::RequestSystem.Properties.Resources.oprego_burger;
            this.pnl_detail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_detail.Controls.Add(this.label5);
            this.pnl_detail.Controls.Add(this.label4);
            this.pnl_detail.Controls.Add(this.label3);
            this.pnl_detail.Controls.Add(this.label2);
            this.pnl_detail.Controls.Add(this.label1);
            this.pnl_detail.Controls.Add(this.btn_Sair);
            this.pnl_detail.Controls.Add(this.btn_Pedido);
            this.pnl_detail.Controls.Add(this.btn_Produto);
            this.pnl_detail.Controls.Add(this.btn_Cliente);
            this.pnl_detail.Controls.Add(this.btn_Funcionario);
            this.pnl_detail.Controls.Add(this.sttstrip_Principal);
            this.pnl_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_detail.Location = new System.Drawing.Point(0, 0);
            this.pnl_detail.Name = "pnl_detail";
            this.pnl_detail.Size = new System.Drawing.Size(1196, 573);
            this.pnl_detail.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(1124, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Sair";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(264, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Pedido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(93, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(98, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(87, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Funcionário";
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.White;
            this.btn_Sair.BackgroundImage = global::RequestSystem.Properties.Resources.logoSair;
            this.btn_Sair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Sair.Location = new System.Drawing.Point(1081, 31);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(103, 88);
            this.btn_Sair.TabIndex = 8;
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Pedido
            // 
            this.btn_Pedido.BackColor = System.Drawing.Color.White;
            this.btn_Pedido.BackgroundImage = global::RequestSystem.Properties.Resources.logoPedido;
            this.btn_Pedido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Pedido.Location = new System.Drawing.Point(232, 31);
            this.btn_Pedido.Name = "btn_Pedido";
            this.btn_Pedido.Size = new System.Drawing.Size(104, 88);
            this.btn_Pedido.TabIndex = 7;
            this.btn_Pedido.UseVisualStyleBackColor = false;
            this.btn_Pedido.Click += new System.EventHandler(this.btn_Pedido_Click);
            // 
            // btn_Produto
            // 
            this.btn_Produto.BackColor = System.Drawing.Color.White;
            this.btn_Produto.BackgroundImage = global::RequestSystem.Properties.Resources.logoProduto;
            this.btn_Produto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Produto.Location = new System.Drawing.Point(65, 308);
            this.btn_Produto.Name = "btn_Produto";
            this.btn_Produto.Size = new System.Drawing.Size(104, 88);
            this.btn_Produto.TabIndex = 6;
            this.btn_Produto.UseVisualStyleBackColor = false;
            this.btn_Produto.Click += new System.EventHandler(this.btn_Produto_Click);
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.BackColor = System.Drawing.Color.White;
            this.btn_Cliente.BackgroundImage = global::RequestSystem.Properties.Resources.logoCliente;
            this.btn_Cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Cliente.Location = new System.Drawing.Point(65, 173);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(104, 88);
            this.btn_Cliente.TabIndex = 5;
            this.btn_Cliente.UseVisualStyleBackColor = false;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // btn_Funcionario
            // 
            this.btn_Funcionario.BackColor = System.Drawing.Color.White;
            this.btn_Funcionario.BackgroundImage = global::RequestSystem.Properties.Resources.logoFuncionario;
            this.btn_Funcionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Funcionario.Location = new System.Drawing.Point(65, 31);
            this.btn_Funcionario.Name = "btn_Funcionario";
            this.btn_Funcionario.Size = new System.Drawing.Size(104, 88);
            this.btn_Funcionario.TabIndex = 4;
            this.btn_Funcionario.UseVisualStyleBackColor = false;
            this.btn_Funcionario.Click += new System.EventHandler(this.btn_Funcionario_Click);
            // 
            // sttstrip_Principal
            // 
            this.sttstrip_Principal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sttstrip_Principal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tsslb_Data,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3,
            this.tsslb_Hora,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel9,
            this.tsslb_Funcionario});
            this.sttstrip_Principal.Location = new System.Drawing.Point(0, 551);
            this.sttstrip_Principal.Name = "sttstrip_Principal";
            this.sttstrip_Principal.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.sttstrip_Principal.Size = new System.Drawing.Size(1196, 22);
            this.sttstrip_Principal.TabIndex = 3;
            this.sttstrip_Principal.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(37, 17);
            this.toolStripStatusLabel1.Text = "Data: ";
            // 
            // tsslb_Data
            // 
            this.tsslb_Data.AutoSize = false;
            this.tsslb_Data.Name = "tsslb_Data";
            this.tsslb_Data.Size = new System.Drawing.Size(95, 17);
            this.tsslb_Data.Text = "99/99/9999";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.AutoSize = false;
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(151, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel3.Text = "Hora: ";
            // 
            // tsslb_Hora
            // 
            this.tsslb_Hora.AutoSize = false;
            this.tsslb_Hora.Name = "tsslb_Hora";
            this.tsslb_Hora.Size = new System.Drawing.Size(95, 17);
            this.tsslb_Hora.Text = "99:99:99";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.AutoSize = false;
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(151, 17);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(126, 17);
            this.toolStripStatusLabel5.Text = "RequestSystem vrs. 1.0";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(95, 17);
            this.toolStripStatusLabel7.Text = "by : KappyS, Luiz";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.AutoSize = false;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(118, 17);
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(84, 17);
            this.toolStripStatusLabel9.Text = "Usuário Atual: ";
            // 
            // tsslb_Funcionario
            // 
            this.tsslb_Funcionario.AutoSize = false;
            this.tsslb_Funcionario.Name = "tsslb_Funcionario";
            this.tsslb_Funcionario.Size = new System.Drawing.Size(124, 17);
            // 
            // frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1196, 573);
            this.Controls.Add(this.pnl_detail);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.frm_Principal_Shown);
            this.pnl_detail.ResumeLayout(false);
            this.pnl_detail.PerformLayout();
            this.sttstrip_Principal.ResumeLayout(false);
            this.sttstrip_Principal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer tm_Principal;
        private System.Windows.Forms.StatusStrip sttstrip_Principal;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tsslb_Data;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tsslb_Hora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel tsslb_Funcionario;
        private System.Windows.Forms.Button btn_Funcionario;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Button btn_Produto;
        private System.Windows.Forms.Button btn_Pedido;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.Panel pnl_detail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}