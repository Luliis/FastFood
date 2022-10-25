using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RequestSystem
{
    public partial class frm_Principal : Form
    {
        public Funcionario obj_Funcionario_Atual = new Funcionario();

        public frm_Principal()
        {
            InitializeComponent();
            //Pega a Largura e Altura do Monitor
            string Monitor_Largura = Screen.PrimaryScreen.Bounds.Width.ToString();
            string Monitor_Altura = Screen.PrimaryScreen.Bounds.Height.ToString();
            switch (Monitor_Largura)
            {
                case "800":
                    {
                        toolStripStatusLabel4.Width = 20; //sttstrip_Principal: barra separadora do dia e hora
                        toolStripStatusLabel6.Width = 100; //sttstrip_Principal: barra da esquerda
                        toolStripStatusLabel8.Width = 150; //sttstrip_Principal: barra da direita
                        break;
                    }
                case "1280":
                    {
                        toolStripStatusLabel6.Width = 220; //sttstrip_Principal: barra da esquerda
                        toolStripStatusLabel8.Width = 400; //sttstrip_Principal: barra da direita
                        break;
                    }
                case "1366":
                    {
                        toolStripStatusLabel6.Width = 250; //sttstrip_Principal: barra da esquerda
                        toolStripStatusLabel8.Width = 450; //sttstrip_Principal: barra da direita
                        break;
                    }
                case "1440":
                    {
                        toolStripStatusLabel6.Width = 300; //sttstrip_Principal: barra da esquerda
                        toolStripStatusLabel8.Width = 500; //sttstrip_Principal: barra da direita
                        break;
                    }
                case "1920":
                    {
                        toolStripStatusLabel6.Width = 500; //sttstrip_Principal: barra da esquerda
                        toolStripStatusLabel8.Width = 750; //sttstrip_Principal: barra da direita
                        break;
                    }
            }
        }


        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            frm_Cliente obj_frm_Cliente = new frm_Cliente();
            obj_frm_Cliente.ShowDialog();
        }

        private void btn_Pedido_Click(object sender, EventArgs e)
        {
            frm_Pedido obj_frm_Pedido = new frm_Pedido();
            obj_frm_Pedido.ShowDialog();
        }

        private void btn_Produto_Click(object sender, EventArgs e)
        {
            frm_Produto obj_frm_Produto = new frm_Produto();
            obj_frm_Produto.ShowDialog();
        }

        private void btn_Funcionario_Click(object sender, EventArgs e)
        {
            frm_Funcionario obj_frm_Funcionario = new frm_Funcionario();
            obj_frm_Funcionario.ShowDialog();
        }
        private void tm_Principal_Tick(object sender, System.EventArgs e)
        {
            tsslb_Data.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
            tsslb_Hora.Text = DateTime.Now.ToString("HH:mm:ss");
        }
        private void frm_Principal_Shown(object sender, EventArgs e)
        {
            tsslb_Funcionario.Text = obj_Funcionario_Atual.UNm_Funcionario;

            //mFacine ToDo: Carregar o nome do usuário Logado.
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
    }
}
