namespace RequestSystem
{
    partial class frm_Produto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Produto));
            this.pnl_Tittle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.pnl_List = new System.Windows.Forms.Panel();
            this.ltbox_Produtos = new System.Windows.Forms.ListBox();
            this.pnl_Detail = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.tbox_Vlr_Produto = new System.Windows.Forms.TextBox();
            this.ltview_ProdCombo = new System.Windows.Forms.ListView();
            this.btn_Pacima = new System.Windows.Forms.Button();
            this.btn_Pabaxo = new System.Windows.Forms.Button();
            this.lb_Vrl_ProdCombo = new System.Windows.Forms.Label();
            this.lb_Nm_ProdCombo = new System.Windows.Forms.Label();
            this.lb_Tp_ProdCombo = new System.Windows.Forms.Label();
            this.btn_ProdCombo = new System.Windows.Forms.Button();
            this.tbox_Cod_ProdCombo = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_Tipo = new System.Windows.Forms.Button();
            this.lb_Nm_Tipo = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbox_Cod_Tipo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_Cod_Produto = new System.Windows.Forms.TextBox();
            this.tbox_Desc_Produto = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Nm_Produto = new System.Windows.Forms.TextBox();
            this.pnl_Tittle.SuspendLayout();
            this.pnl_Button.SuspendLayout();
            this.pnl_List.SuspendLayout();
            this.pnl_Detail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Tittle
            // 
            this.pnl_Tittle.BackColor = System.Drawing.Color.Khaki;
            this.pnl_Tittle.Controls.Add(this.label1);
            this.pnl_Tittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_Tittle.Location = new System.Drawing.Point(0, 0);
            this.pnl_Tittle.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Tittle.Name = "pnl_Tittle";
            this.pnl_Tittle.Size = new System.Drawing.Size(617, 47);
            this.pnl_Tittle.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro Produto";
            // 
            // pnl_Button
            // 
            this.pnl_Button.BackColor = System.Drawing.Color.Khaki;
            this.pnl_Button.Controls.Add(this.btn_Cancelar);
            this.pnl_Button.Controls.Add(this.btn_Confirmar);
            this.pnl_Button.Controls.Add(this.btn_Excluir);
            this.pnl_Button.Controls.Add(this.btn_Alterar);
            this.pnl_Button.Controls.Add(this.btn_Novo);
            this.pnl_Button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_Button.Location = new System.Drawing.Point(0, 493);
            this.pnl_Button.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(617, 46);
            this.pnl_Button.TabIndex = 1;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.Location = new System.Drawing.Point(417, 12);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(92, 27);
            this.btn_Cancelar.TabIndex = 4;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = false;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.White;
            this.btn_Confirmar.Location = new System.Drawing.Point(321, 12);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(92, 27);
            this.btn_Confirmar.TabIndex = 3;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.White;
            this.btn_Excluir.Location = new System.Drawing.Point(197, 12);
            this.btn_Excluir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(92, 27);
            this.btn_Excluir.TabIndex = 2;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.White;
            this.btn_Alterar.Location = new System.Drawing.Point(101, 12);
            this.btn_Alterar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(92, 27);
            this.btn_Alterar.TabIndex = 1;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Novo
            // 
            this.btn_Novo.BackColor = System.Drawing.Color.White;
            this.btn_Novo.Location = new System.Drawing.Point(5, 12);
            this.btn_Novo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_Novo.Name = "btn_Novo";
            this.btn_Novo.Size = new System.Drawing.Size(92, 27);
            this.btn_Novo.TabIndex = 0;
            this.btn_Novo.Text = "Novo";
            this.btn_Novo.UseVisualStyleBackColor = false;
            this.btn_Novo.Click += new System.EventHandler(this.btn_Novo_Click);
            // 
            // pnl_List
            // 
            this.pnl_List.Controls.Add(this.ltbox_Produtos);
            this.pnl_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_List.Location = new System.Drawing.Point(0, 47);
            this.pnl_List.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(162, 446);
            this.pnl_List.TabIndex = 2;
            // 
            // ltbox_Produtos
            // 
            this.ltbox_Produtos.FormattingEnabled = true;
            this.ltbox_Produtos.Location = new System.Drawing.Point(2, 2);
            this.ltbox_Produtos.Margin = new System.Windows.Forms.Padding(2);
            this.ltbox_Produtos.Name = "ltbox_Produtos";
            this.ltbox_Produtos.Size = new System.Drawing.Size(161, 446);
            this.ltbox_Produtos.TabIndex = 0;
            this.ltbox_Produtos.Click += new System.EventHandler(this.ltbox_Produtos_Click);
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(222)))), ((int)(((byte)(72)))));
            this.pnl_Detail.Controls.Add(this.label7);
            this.pnl_Detail.Controls.Add(this.tbox_Vlr_Produto);
            this.pnl_Detail.Controls.Add(this.ltview_ProdCombo);
            this.pnl_Detail.Controls.Add(this.btn_Pacima);
            this.pnl_Detail.Controls.Add(this.btn_Pabaxo);
            this.pnl_Detail.Controls.Add(this.lb_Vrl_ProdCombo);
            this.pnl_Detail.Controls.Add(this.lb_Nm_ProdCombo);
            this.pnl_Detail.Controls.Add(this.lb_Tp_ProdCombo);
            this.pnl_Detail.Controls.Add(this.btn_ProdCombo);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_ProdCombo);
            this.pnl_Detail.Controls.Add(this.label13);
            this.pnl_Detail.Controls.Add(this.btn_Tipo);
            this.pnl_Detail.Controls.Add(this.lb_Nm_Tipo);
            this.pnl_Detail.Controls.Add(this.label6);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Tipo);
            this.pnl_Detail.Controls.Add(this.label5);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Produto);
            this.pnl_Detail.Controls.Add(this.tbox_Desc_Produto);
            this.pnl_Detail.Controls.Add(this.label4);
            this.pnl_Detail.Controls.Add(this.label3);
            this.pnl_Detail.Controls.Add(this.label2);
            this.pnl_Detail.Controls.Add(this.tbox_Nm_Produto);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detail.Location = new System.Drawing.Point(162, 47);
            this.pnl_Detail.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(455, 446);
            this.pnl_Detail.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(327, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 68;
            this.label7.Text = "R$";
            // 
            // tbox_Vlr_Produto
            // 
            this.tbox_Vlr_Produto.Location = new System.Drawing.Point(351, 130);
            this.tbox_Vlr_Produto.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Vlr_Produto.Name = "tbox_Vlr_Produto";
            this.tbox_Vlr_Produto.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbox_Vlr_Produto.Size = new System.Drawing.Size(77, 20);
            this.tbox_Vlr_Produto.TabIndex = 67;
            // 
            // ltview_ProdCombo
            // 
            this.ltview_ProdCombo.FullRowSelect = true;
            this.ltview_ProdCombo.HideSelection = false;
            this.ltview_ProdCombo.Location = new System.Drawing.Point(17, 299);
            this.ltview_ProdCombo.Name = "ltview_ProdCombo";
            this.ltview_ProdCombo.Size = new System.Drawing.Size(415, 123);
            this.ltview_ProdCombo.TabIndex = 52;
            this.ltview_ProdCombo.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Pacima
            // 
            this.btn_Pacima.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pacima.Image")));
            this.btn_Pacima.Location = new System.Drawing.Point(411, 272);
            this.btn_Pacima.Name = "btn_Pacima";
            this.btn_Pacima.Size = new System.Drawing.Size(21, 21);
            this.btn_Pacima.TabIndex = 51;
            this.btn_Pacima.UseVisualStyleBackColor = true;
            this.btn_Pacima.Click += new System.EventHandler(this.btn_Pacima_Click);
            // 
            // btn_Pabaxo
            // 
            this.btn_Pabaxo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pabaxo.Image")));
            this.btn_Pabaxo.Location = new System.Drawing.Point(387, 272);
            this.btn_Pabaxo.Name = "btn_Pabaxo";
            this.btn_Pabaxo.Size = new System.Drawing.Size(21, 21);
            this.btn_Pabaxo.TabIndex = 50;
            this.btn_Pabaxo.UseVisualStyleBackColor = true;
            this.btn_Pabaxo.Click += new System.EventHandler(this.btn_Pabaxo_Click);
            // 
            // lb_Vrl_ProdCombo
            // 
            this.lb_Vrl_ProdCombo.BackColor = System.Drawing.Color.Goldenrod;
            this.lb_Vrl_ProdCombo.Location = new System.Drawing.Point(330, 277);
            this.lb_Vrl_ProdCombo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Vrl_ProdCombo.Name = "lb_Vrl_ProdCombo";
            this.lb_Vrl_ProdCombo.Size = new System.Drawing.Size(51, 13);
            this.lb_Vrl_ProdCombo.TabIndex = 49;
            this.lb_Vrl_ProdCombo.Tag = "1";
            this.lb_Vrl_ProdCombo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Nm_ProdCombo
            // 
            this.lb_Nm_ProdCombo.BackColor = System.Drawing.Color.Goldenrod;
            this.lb_Nm_ProdCombo.Location = new System.Drawing.Point(115, 277);
            this.lb_Nm_ProdCombo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Nm_ProdCombo.Name = "lb_Nm_ProdCombo";
            this.lb_Nm_ProdCombo.Size = new System.Drawing.Size(139, 13);
            this.lb_Nm_ProdCombo.TabIndex = 48;
            this.lb_Nm_ProdCombo.Tag = "1";
            // 
            // lb_Tp_ProdCombo
            // 
            this.lb_Tp_ProdCombo.BackColor = System.Drawing.Color.Goldenrod;
            this.lb_Tp_ProdCombo.Location = new System.Drawing.Point(260, 277);
            this.lb_Tp_ProdCombo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tp_ProdCombo.Name = "lb_Tp_ProdCombo";
            this.lb_Tp_ProdCombo.Size = new System.Drawing.Size(64, 13);
            this.lb_Tp_ProdCombo.TabIndex = 47;
            this.lb_Tp_ProdCombo.Tag = "1";
            // 
            // btn_ProdCombo
            // 
            this.btn_ProdCombo.Image = ((System.Drawing.Image)(resources.GetObject("btn_ProdCombo.Image")));
            this.btn_ProdCombo.Location = new System.Drawing.Point(89, 273);
            this.btn_ProdCombo.Name = "btn_ProdCombo";
            this.btn_ProdCombo.Size = new System.Drawing.Size(21, 21);
            this.btn_ProdCombo.TabIndex = 46;
            this.btn_ProdCombo.UseVisualStyleBackColor = true;
            this.btn_ProdCombo.Click += new System.EventHandler(this.btn_ProdCombo_Click);
            // 
            // tbox_Cod_ProdCombo
            // 
            this.tbox_Cod_ProdCombo.Location = new System.Drawing.Point(18, 273);
            this.tbox_Cod_ProdCombo.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_ProdCombo.Name = "tbox_Cod_ProdCombo";
            this.tbox_Cod_ProdCombo.Size = new System.Drawing.Size(66, 20);
            this.tbox_Cod_ProdCombo.TabIndex = 45;
            this.tbox_Cod_ProdCombo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_Cod_ProdCombo.Visible = false;
            this.tbox_Cod_ProdCombo.Leave += new System.EventHandler(this.tbox_Cod_ProdCombo_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(16, 256);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 13);
            this.label13.TabIndex = 44;
            this.label13.Text = "Código do Item (Produto)";
            // 
            // btn_Tipo
            // 
            this.btn_Tipo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tipo.Image")));
            this.btn_Tipo.Location = new System.Drawing.Point(99, 129);
            this.btn_Tipo.Name = "btn_Tipo";
            this.btn_Tipo.Size = new System.Drawing.Size(21, 21);
            this.btn_Tipo.TabIndex = 38;
            this.btn_Tipo.UseVisualStyleBackColor = true;
            this.btn_Tipo.Click += new System.EventHandler(this.btn_Tipo_Click);
            // 
            // lb_Nm_Tipo
            // 
            this.lb_Nm_Tipo.BackColor = System.Drawing.Color.Goldenrod;
            this.lb_Nm_Tipo.Location = new System.Drawing.Point(125, 132);
            this.lb_Nm_Tipo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Nm_Tipo.Name = "lb_Nm_Tipo";
            this.lb_Nm_Tipo.Size = new System.Drawing.Size(198, 13);
            this.lb_Nm_Tipo.TabIndex = 18;
            this.lb_Nm_Tipo.Tag = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 114);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tipo do Produto";
            // 
            // tbox_Cod_Tipo
            // 
            this.tbox_Cod_Tipo.Location = new System.Drawing.Point(17, 129);
            this.tbox_Cod_Tipo.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Tipo.Name = "tbox_Cod_Tipo";
            this.tbox_Cod_Tipo.Size = new System.Drawing.Size(77, 20);
            this.tbox_Cod_Tipo.TabIndex = 11;
            this.tbox_Cod_Tipo.Leave += new System.EventHandler(this.tBox_Cod_Tipo_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Código Produto";
            // 
            // tbox_Cod_Produto
            // 
            this.tbox_Cod_Produto.Enabled = false;
            this.tbox_Cod_Produto.Location = new System.Drawing.Point(17, 25);
            this.tbox_Cod_Produto.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Produto.Name = "tbox_Cod_Produto";
            this.tbox_Cod_Produto.Size = new System.Drawing.Size(77, 20);
            this.tbox_Cod_Produto.TabIndex = 9;
            this.tbox_Cod_Produto.Tag = "1";
            // 
            // tbox_Desc_Produto
            // 
            this.tbox_Desc_Produto.Location = new System.Drawing.Point(17, 183);
            this.tbox_Desc_Produto.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Desc_Produto.Name = "tbox_Desc_Produto";
            this.tbox_Desc_Produto.Size = new System.Drawing.Size(415, 56);
            this.tbox_Desc_Produto.TabIndex = 6;
            this.tbox_Desc_Produto.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(342, 114);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor do Produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 168);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descrição do Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome do Produto";
            // 
            // tbox_Nm_Produto
            // 
            this.tbox_Nm_Produto.Location = new System.Drawing.Point(18, 78);
            this.tbox_Nm_Produto.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Nm_Produto.Name = "tbox_Nm_Produto";
            this.tbox_Nm_Produto.Size = new System.Drawing.Size(414, 20);
            this.tbox_Nm_Produto.TabIndex = 0;
            // 
            // frm_Produto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 539);
            this.Controls.Add(this.pnl_Detail);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.pnl_Tittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Produto";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.pnl_Tittle.ResumeLayout(false);
            this.pnl_Tittle.PerformLayout();
            this.pnl_Button.ResumeLayout(false);
            this.pnl_List.ResumeLayout(false);
            this.pnl_Detail.ResumeLayout(false);
            this.pnl_Detail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_Tittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.ListBox ltbox_Produtos;
        private System.Windows.Forms.Panel pnl_Detail;
        private System.Windows.Forms.RichTextBox tbox_Desc_Produto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_Nm_Produto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_Cod_Produto;
        private System.Windows.Forms.Button btn_Tipo;
        private System.Windows.Forms.Label lb_Nm_Tipo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbox_Cod_Tipo;
        private System.Windows.Forms.ListView ltview_ProdCombo;
        private System.Windows.Forms.Button btn_Pacima;
        private System.Windows.Forms.Button btn_Pabaxo;
        private System.Windows.Forms.Label lb_Vrl_ProdCombo;
        private System.Windows.Forms.Label lb_Nm_ProdCombo;
        private System.Windows.Forms.Label lb_Tp_ProdCombo;
        private System.Windows.Forms.Button btn_ProdCombo;
        private System.Windows.Forms.TextBox tbox_Cod_ProdCombo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbox_Vlr_Produto;
    }
}