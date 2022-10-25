
namespace RequestSystem
{
    partial class frm_Pedido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Pedido));
            this.pnl_Detail = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ltview_ItemPedido = new System.Windows.Forms.ListView();
            this.btn_Pacima = new System.Windows.Forms.Button();
            this.btn_Pabaxo = new System.Windows.Forms.Button();
            this.lb_Vrl_ProdPedido = new System.Windows.Forms.Label();
            this.lb_Nm_ProdPedido = new System.Windows.Forms.Label();
            this.lb_Tp_ProdPedido = new System.Windows.Forms.Label();
            this.btn_ProdPedido = new System.Windows.Forms.Button();
            this.tbox_Cod_ProdPedido = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.lb_CPF_Cliente = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox_Cod_Pedido = new System.Windows.Forms.TextBox();
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.lb_Nm_Cliente = new System.Windows.Forms.Label();
            this.tbox_Cod_Cliente = new System.Windows.Forms.TextBox();
            this.pnl_List = new System.Windows.Forms.Panel();
            this.ltbox_Pedidos = new System.Windows.Forms.ListBox();
            this.pnl_Button = new System.Windows.Forms.Panel();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.btn_Novo = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.pnl_Tittle = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_Vlr_Pedido = new System.Windows.Forms.TextBox();
            this.pnl_Detail.SuspendLayout();
            this.pnl_List.SuspendLayout();
            this.pnl_Button.SuspendLayout();
            this.pnl_Tittle.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Detail
            // 
            this.pnl_Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(222)))), ((int)(((byte)(72)))));
            this.pnl_Detail.Controls.Add(this.tbox_Vlr_Pedido);
            this.pnl_Detail.Controls.Add(this.label2);
            this.pnl_Detail.Controls.Add(this.label4);
            this.pnl_Detail.Controls.Add(this.label6);
            this.pnl_Detail.Controls.Add(this.ltview_ItemPedido);
            this.pnl_Detail.Controls.Add(this.btn_Pacima);
            this.pnl_Detail.Controls.Add(this.btn_Pabaxo);
            this.pnl_Detail.Controls.Add(this.lb_Vrl_ProdPedido);
            this.pnl_Detail.Controls.Add(this.lb_Nm_ProdPedido);
            this.pnl_Detail.Controls.Add(this.lb_Tp_ProdPedido);
            this.pnl_Detail.Controls.Add(this.btn_ProdPedido);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_ProdPedido);
            this.pnl_Detail.Controls.Add(this.label13);
            this.pnl_Detail.Controls.Add(this.lb_CPF_Cliente);
            this.pnl_Detail.Controls.Add(this.label5);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Pedido);
            this.pnl_Detail.Controls.Add(this.btn_Cliente);
            this.pnl_Detail.Controls.Add(this.lb_Nm_Cliente);
            this.pnl_Detail.Controls.Add(this.tbox_Cod_Cliente);
            this.pnl_Detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_Detail.Location = new System.Drawing.Point(133, 65);
            this.pnl_Detail.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Detail.Name = "pnl_Detail";
            this.pnl_Detail.Size = new System.Drawing.Size(484, 327);
            this.pnl_Detail.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Valor do Pedido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "Codigo do Cliente";
            // 
            // ltview_ItemPedido
            // 
            this.ltview_ItemPedido.FullRowSelect = true;
            this.ltview_ItemPedido.HideSelection = false;
            this.ltview_ItemPedido.Location = new System.Drawing.Point(12, 192);
            this.ltview_ItemPedido.Name = "ltview_ItemPedido";
            this.ltview_ItemPedido.Size = new System.Drawing.Size(457, 123);
            this.ltview_ItemPedido.TabIndex = 61;
            this.ltview_ItemPedido.UseCompatibleStateImageBehavior = false;
            // 
            // btn_Pacima
            // 
            this.btn_Pacima.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pacima.Image")));
            this.btn_Pacima.Location = new System.Drawing.Point(448, 167);
            this.btn_Pacima.Name = "btn_Pacima";
            this.btn_Pacima.Size = new System.Drawing.Size(21, 21);
            this.btn_Pacima.TabIndex = 60;
            this.btn_Pacima.UseVisualStyleBackColor = true;
            this.btn_Pacima.Click += new System.EventHandler(this.btn_Pacima_Click);
            // 
            // btn_Pabaxo
            // 
            this.btn_Pabaxo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pabaxo.Image")));
            this.btn_Pabaxo.Location = new System.Drawing.Point(425, 167);
            this.btn_Pabaxo.Name = "btn_Pabaxo";
            this.btn_Pabaxo.Size = new System.Drawing.Size(21, 21);
            this.btn_Pabaxo.TabIndex = 59;
            this.btn_Pabaxo.UseVisualStyleBackColor = true;
            this.btn_Pabaxo.Click += new System.EventHandler(this.btn_Pabaxo_Click);
            // 
            // lb_Vrl_ProdPedido
            // 
            this.lb_Vrl_ProdPedido.BackColor = System.Drawing.Color.Goldenrod;
            this.lb_Vrl_ProdPedido.Location = new System.Drawing.Point(354, 171);
            this.lb_Vrl_ProdPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Vrl_ProdPedido.Name = "lb_Vrl_ProdPedido";
            this.lb_Vrl_ProdPedido.Size = new System.Drawing.Size(66, 13);
            this.lb_Vrl_ProdPedido.TabIndex = 58;
            this.lb_Vrl_ProdPedido.Tag = "1";
            this.lb_Vrl_ProdPedido.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_Nm_ProdPedido
            // 
            this.lb_Nm_ProdPedido.BackColor = System.Drawing.Color.Goldenrod;
            this.lb_Nm_ProdPedido.Location = new System.Drawing.Point(121, 171);
            this.lb_Nm_ProdPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Nm_ProdPedido.Name = "lb_Nm_ProdPedido";
            this.lb_Nm_ProdPedido.Size = new System.Drawing.Size(161, 13);
            this.lb_Nm_ProdPedido.TabIndex = 57;
            this.lb_Nm_ProdPedido.Tag = "1";
            // 
            // lb_Tp_ProdPedido
            // 
            this.lb_Tp_ProdPedido.BackColor = System.Drawing.Color.Goldenrod;
            this.lb_Tp_ProdPedido.Location = new System.Drawing.Point(286, 171);
            this.lb_Tp_ProdPedido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Tp_ProdPedido.Name = "lb_Tp_ProdPedido";
            this.lb_Tp_ProdPedido.Size = new System.Drawing.Size(62, 13);
            this.lb_Tp_ProdPedido.TabIndex = 56;
            this.lb_Tp_ProdPedido.Tag = "1";
            // 
            // btn_ProdPedido
            // 
            this.btn_ProdPedido.Image = ((System.Drawing.Image)(resources.GetObject("btn_ProdPedido.Image")));
            this.btn_ProdPedido.Location = new System.Drawing.Point(97, 167);
            this.btn_ProdPedido.Name = "btn_ProdPedido";
            this.btn_ProdPedido.Size = new System.Drawing.Size(21, 21);
            this.btn_ProdPedido.TabIndex = 55;
            this.btn_ProdPedido.UseVisualStyleBackColor = true;
            this.btn_ProdPedido.Click += new System.EventHandler(this.btn_ProdPedido_Click);
            // 
            // tbox_Cod_ProdPedido
            // 
            this.tbox_Cod_ProdPedido.Location = new System.Drawing.Point(12, 167);
            this.tbox_Cod_ProdPedido.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_ProdPedido.Name = "tbox_Cod_ProdPedido";
            this.tbox_Cod_ProdPedido.Size = new System.Drawing.Size(76, 20);
            this.tbox_Cod_ProdPedido.TabIndex = 54;
            this.tbox_Cod_ProdPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbox_Cod_ProdPedido.Leave += new System.EventHandler(this.tbox_Cod_ProdPedido_Leave);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(12, 149);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(124, 13);
            this.label13.TabIndex = 53;
            this.label13.Text = "Código do Item (Produto)";
            // 
            // lb_CPF_Cliente
            // 
            this.lb_CPF_Cliente.BackColor = System.Drawing.Color.Goldenrod;
            this.lb_CPF_Cliente.Location = new System.Drawing.Point(286, 82);
            this.lb_CPF_Cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_CPF_Cliente.Name = "lb_CPF_Cliente";
            this.lb_CPF_Cliente.Size = new System.Drawing.Size(132, 13);
            this.lb_CPF_Cliente.TabIndex = 44;
            this.lb_CPF_Cliente.Tag = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 16);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Código Pedido";
            // 
            // tbox_Cod_Pedido
            // 
            this.tbox_Cod_Pedido.Enabled = false;
            this.tbox_Cod_Pedido.Location = new System.Drawing.Point(12, 31);
            this.tbox_Cod_Pedido.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Pedido.Name = "tbox_Cod_Pedido";
            this.tbox_Cod_Pedido.Size = new System.Drawing.Size(77, 20);
            this.tbox_Cod_Pedido.TabIndex = 42;
            this.tbox_Cod_Pedido.Tag = "1";
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cliente.Image")));
            this.btn_Cliente.Location = new System.Drawing.Point(95, 78);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(21, 21);
            this.btn_Cliente.TabIndex = 41;
            this.btn_Cliente.UseVisualStyleBackColor = true;
            this.btn_Cliente.Click += new System.EventHandler(this.btn_Cliente_Click);
            // 
            // lb_Nm_Cliente
            // 
            this.lb_Nm_Cliente.BackColor = System.Drawing.Color.Goldenrod;
            this.lb_Nm_Cliente.Location = new System.Drawing.Point(121, 82);
            this.lb_Nm_Cliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Nm_Cliente.Name = "lb_Nm_Cliente";
            this.lb_Nm_Cliente.Size = new System.Drawing.Size(161, 13);
            this.lb_Nm_Cliente.TabIndex = 40;
            this.lb_Nm_Cliente.Tag = "1";
            // 
            // tbox_Cod_Cliente
            // 
            this.tbox_Cod_Cliente.Location = new System.Drawing.Point(12, 79);
            this.tbox_Cod_Cliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Cod_Cliente.Name = "tbox_Cod_Cliente";
            this.tbox_Cod_Cliente.Size = new System.Drawing.Size(77, 20);
            this.tbox_Cod_Cliente.TabIndex = 39;
            this.tbox_Cod_Cliente.Leave += new System.EventHandler(this.tBox_Cod_Cliente_Leave);
            // 
            // pnl_List
            // 
            this.pnl_List.Controls.Add(this.ltbox_Pedidos);
            this.pnl_List.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_List.Location = new System.Drawing.Point(0, 65);
            this.pnl_List.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_List.Name = "pnl_List";
            this.pnl_List.Size = new System.Drawing.Size(133, 327);
            this.pnl_List.TabIndex = 10;
            // 
            // ltbox_Pedidos
            // 
            this.ltbox_Pedidos.FormattingEnabled = true;
            this.ltbox_Pedidos.Location = new System.Drawing.Point(0, 0);
            this.ltbox_Pedidos.Margin = new System.Windows.Forms.Padding(2);
            this.ltbox_Pedidos.Name = "ltbox_Pedidos";
            this.ltbox_Pedidos.Size = new System.Drawing.Size(135, 329);
            this.ltbox_Pedidos.TabIndex = 0;
            this.ltbox_Pedidos.Click += new System.EventHandler(this.ltbox_Pedidos_Click);
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
            this.pnl_Button.Location = new System.Drawing.Point(0, 392);
            this.pnl_Button.Margin = new System.Windows.Forms.Padding(2);
            this.pnl_Button.Name = "pnl_Button";
            this.pnl_Button.Size = new System.Drawing.Size(617, 53);
            this.pnl_Button.TabIndex = 9;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.BackColor = System.Drawing.Color.White;
            this.btn_Cancelar.FlatAppearance.BorderSize = 0;
            this.btn_Cancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btn_Cancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.btn_Cancelar.Location = new System.Drawing.Point(492, 18);
            this.btn_Cancelar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(61, 21);
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
            this.btn_Confirmar.Location = new System.Drawing.Point(427, 18);
            this.btn_Confirmar.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(61, 21);
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
            this.pnl_Tittle.Size = new System.Drawing.Size(617, 65);
            this.pnl_Tittle.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("LEMON MILK Medium", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(254, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Pedidos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "R$";
            // 
            // tbox_Vlr_Pedido
            // 
            this.tbox_Vlr_Pedido.Location = new System.Drawing.Point(37, 116);
            this.tbox_Vlr_Pedido.Margin = new System.Windows.Forms.Padding(2);
            this.tbox_Vlr_Pedido.Name = "tbox_Vlr_Pedido";
            this.tbox_Vlr_Pedido.Size = new System.Drawing.Size(77, 20);
            this.tbox_Vlr_Pedido.TabIndex = 67;
            // 
            // frm_Pedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 445);
            this.Controls.Add(this.pnl_Detail);
            this.Controls.Add(this.pnl_List);
            this.Controls.Add(this.pnl_Button);
            this.Controls.Add(this.pnl_Tittle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frm_Pedido";
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
        private System.Windows.Forms.Panel pnl_List;
        private System.Windows.Forms.ListBox ltbox_Pedidos;
        private System.Windows.Forms.Panel pnl_Button;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.Button btn_Novo;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Panel pnl_Tittle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Label lb_Nm_Cliente;
        private System.Windows.Forms.TextBox tbox_Cod_Cliente;
        private System.Windows.Forms.Label lb_CPF_Cliente;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox_Cod_Pedido;
        private System.Windows.Forms.ListView ltview_ItemPedido;
        private System.Windows.Forms.Button btn_Pacima;
        private System.Windows.Forms.Button btn_Pabaxo;
        private System.Windows.Forms.Label lb_Vrl_ProdPedido;
        private System.Windows.Forms.Label lb_Nm_ProdPedido;
        private System.Windows.Forms.Label lb_Tp_ProdPedido;
        private System.Windows.Forms.Button btn_ProdPedido;
        private System.Windows.Forms.TextBox tbox_Cod_ProdPedido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_Vlr_Pedido;
    }
}