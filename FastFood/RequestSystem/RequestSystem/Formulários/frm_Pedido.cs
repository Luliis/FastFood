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
    public partial class frm_Pedido : Form
    {
        public Pedido obj_Pedido_Atual = new Pedido();

        Produto obj_Produto_Pedido = new Produto();

        int i_Cod_ProdCombo = -1;

        FuncGeral obj_FuncGeral = new FuncGeral();
        Tipo obj_Cliente_Atual = new Tipo();

        public frm_Pedido()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.PopulaMask(this);
            TitulosLView();
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            tbox_Cod_Cliente.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
               
            
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            tbox_Cod_Cliente.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Instância da Classe BD. 
            BDPedido obj_BDPedido = new BDPedido();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDPedido.Excluir(obj_Pedido_Atual))
                {
                    MessageBox.Show("O produto " + obj_Pedido_Atual.Cod_Pedido + " foi excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obj_FuncGeral.LimpaTela(this);
                    obj_FuncGeral.HabilitaTela(this, false);
                    obj_FuncGeral.StatusBtn(this, 1);
                    PopulaLista();
                }
            }

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);
            if (obj_Pedido_Atual.Cod_Pedido != -1)
            {
                PopulaTela(obj_Pedido_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.StatusBtn(this, 1);
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (obj_FuncGeral.ValidaTela(this))
            {
                BDPedido obj_BDPedido = new BDPedido();
                obj_Pedido_Atual = PopulaObjeto();

                if (obj_Pedido_Atual.Cod_Pedido != -1)
                {
                    obj_BDPedido.Alterar(obj_Pedido_Atual);
                    MessageBox.Show("O pedido " + obj_Pedido_Atual.Cod_Pedido + " foi alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    obj_Pedido_Atual.Cod_Pedido = obj_BDPedido.Incluir(obj_Pedido_Atual);
                    PopulaTela(obj_Pedido_Atual);
                    MessageBox.Show("O pedido " + obj_Pedido_Atual.Cod_Pedido + " foi inserido com sucesso.", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                PopulaLista();
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
            }

        }

        /***********************************************************************
       *        Método: PopulaObjeto
       *          Obs.: Responsável por popular o objeto atual com o conteúdo 
       *                do formulário.
       *   Dt. Criação: 13/07/2022
       * Dt. Alteração: --
       *    Criada por: KappyS, Luiz
       ***********************************************************************/
        private Pedido PopulaObjeto()
        {
            Pedido obj_Pedido = new Pedido();

            if (tbox_Cod_Pedido.Text != "")
            {
                obj_Pedido.Cod_Pedido = Convert.ToInt16(tbox_Cod_Pedido.Text);
            }
            obj_Pedido.Cod_Cliente = Convert.ToInt16(tbox_Cod_Cliente.Text);
            obj_Pedido.VlrTot_Pedido = Convert.ToDouble(tbox_Vlr_Pedido.Text);


            return obj_Pedido;
        }

        /***********************************************************************
        *        Método: PopulaTela
        *          Obs.: Responsável por popular o formulário com o conteúdo 
        *                do objeto atual.
        *   Dt. Criação: 13/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        private void PopulaTela(Pedido pobj_Pedido)
        {
            if (pobj_Pedido.Cod_Pedido != -1)
            {
                tbox_Cod_Pedido.Text = pobj_Pedido.Cod_Pedido.ToString();
                
            }
            tbox_Cod_Cliente.Text = pobj_Pedido.Cod_Cliente.ToString();
            tbox_Vlr_Pedido.Text = pobj_Pedido.VlrTot_Pedido.ToString();
            tBox_Cod_Cliente_Leave(tbox_Cod_Cliente, EventArgs.Empty);

        }

        /***********************************************************************
        *        Método: PopulaLtView
        *          Obs.: Responsável por Popular a List View de Competências
        *   Dt. Criação: 29/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaLtView()
        {
            ltview_ItemPedido.Items.Clear();

            BDItemPedido obj_BDItemPedido = new BDItemPedido();
            ItemPedido obj_ItemPedido = new ItemPedido();
            List<ItemPedido> Lista = new List<ItemPedido>();

            obj_ItemPedido.Cod_Pedido = obj_Pedido_Atual.Cod_Pedido;

            Lista = obj_BDItemPedido.FindAllItemByPedido(obj_ItemPedido);

            if (Lista != null)
            {
                BDProduto obj_BDProduto = new BDProduto();
                Produto obj_Produto = new Produto();

                BDTipo obj_BDTipo = new BDTipo();
                Tipo obj_Tipo = new Tipo();


                for (int i = 0; i < Lista.Count; i++)
                {
                    obj_Produto.Cod_Produto = Lista[i].Cod_Produto;
                    obj_Produto = obj_BDProduto.FindByCodProduto(obj_Produto);

                    obj_Tipo.Cod_Tipo = obj_Produto.Cod_Tipo;
                    obj_Tipo = obj_BDTipo.FindByCodTipo(obj_Tipo);

                    
                    PopulaLinhaLView(ltview_ItemPedido, obj_Produto.Cod_Produto.ToString(), obj_Produto.Nm_Produto, obj_Tipo.Nm_Tipo, obj_Produto.VlrUni_Produto.ToString());
                }
            }

        }



        /***********************************************************************
       *        Método: PopulaLista
       *          Obs.: Responsável por popular os usuários da tabela na lista 
       *                do formulário.
       *   Dt. Criação: 13/07/2022
       * Dt. Alteração: --
       *    Criada por: KappyS, Luiz
       ***********************************************************************/
        private void PopulaLista()
        {
            BDPedido obj_BDPedido = new BDPedido();

            BDCliente obj_BDCliente = new BDCliente();

            

            List<Pedido> Lista = new List<Pedido>();

            ltbox_Pedidos.Items.Clear();

            Lista = obj_BDPedido.FindAllPedido();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    Cliente obj_cliente = new Cliente();
                    obj_cliente.Cod_Cliente = Lista[i].Cod_Cliente;

                    obj_cliente = obj_BDCliente.FindByCodCliente(obj_cliente);


                    ltbox_Pedidos.Items.Add(Lista[i].Cod_Pedido.ToString() + "-" + obj_cliente.Nm_Cliente.ToString());
                }
            }
        }

        private void ltbox_Pedidos_Click(object sender, EventArgs e)
        {
            if (ltbox_Pedidos.SelectedIndex != -1)
            {
                BDPedido obj_BDPedido = new BDPedido();

                string s_linha = ltbox_Pedidos.Items[ltbox_Pedidos.SelectedIndex].ToString();
                int i_Pos = 0;


                for (int t = 0; t < s_linha.Length; t++)
                {
                    if (s_linha.Substring(t, 1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }

                obj_Pedido_Atual.Cod_Pedido = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_Pedido_Atual = obj_BDPedido.FindByCodPedido(obj_Pedido_Atual);
                PopulaTela(obj_Pedido_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);

                PopulaLtView();


            }
        }

        public void btn_Cliente_Click(object sender, EventArgs e)
        {
            frm_Cliente obj_frm_Cliente = new frm_Cliente();
            obj_frm_Cliente.ShowDialog();
            tbox_Cod_Cliente.Text = obj_frm_Cliente.obj_Cliente_Atual.Cod_Cliente.ToString();
            tBox_Cod_Cliente_Leave(tbox_Cod_Cliente, e);

        }

        public void tBox_Cod_Cliente_Leave(object sender, EventArgs e)
        {
            Cliente obj_Cliente_Atual = new Cliente();
            
            if (tbox_Cod_Cliente.Text != "")
            {
                BDCliente obj_BDCliente = new BDCliente();
                obj_Cliente_Atual.Cod_Cliente = Convert.ToInt16(((TextBox)sender).Text);
                obj_Cliente_Atual = obj_BDCliente.FindByCodCliente(obj_Cliente_Atual);
                if (obj_Cliente_Atual != null)
                {
                    lb_Nm_Cliente.Text = obj_Cliente_Atual.Nm_Cliente;
                    lb_CPF_Cliente.Text = obj_Cliente_Atual.CPF_Cliente;

                }
                else
                {
                    tbox_Cod_Cliente.Text = null;
                    lb_Nm_Cliente.Text = "";
                    lb_CPF_Cliente.Text = "";
                }

            }

        }
        


        private void btn_ProdPedido_Click(object sender, EventArgs e)
        {
            frm_Produto obj_frm_ProdPedido = new frm_Produto();



            obj_frm_ProdPedido.ShowDialog();

            this.i_Cod_ProdCombo = obj_frm_ProdPedido.obj_Produto_Atual.Cod_Produto;

            tbox_Cod_ProdPedido.Text = obj_frm_ProdPedido.obj_Produto_Atual.Cod_Produto.ToString();

            tbox_Cod_ProdPedido_Leave(tbox_Cod_ProdPedido, e);
        }

        private void tbox_Cod_ProdPedido_Leave(object sender, EventArgs e)
        {
            if (tbox_Cod_ProdPedido.Text != "")
            {
                BDProduto obj_BDProduto = new BDProduto();

                obj_Produto_Pedido.Cod_Produto = Convert.ToInt16(((TextBox)sender).Text);
                obj_Produto_Pedido = obj_BDProduto.FindByCodProduto(obj_Produto_Pedido);
                if (obj_Produto_Pedido != null)
                {
                    lb_Nm_ProdPedido.Text = obj_Produto_Pedido.Nm_Produto;
                    lb_Vrl_ProdPedido.Text = obj_Produto_Pedido.VlrUni_Produto.ToString();

                    Tipo obj_Tipo = new Tipo();
                    BDTipo obj_BDTipo = new BDTipo();
                    obj_Tipo.Cod_Tipo = Convert.ToInt16(obj_Produto_Pedido.Cod_Tipo);
                    obj_Tipo = obj_BDTipo.FindByCodTipo(obj_Tipo);
                    lb_Tp_ProdPedido.Text = obj_Tipo.Nm_Tipo;

                }
                else
                {
                    lb_Nm_ProdPedido.Text = "";
                    lb_Vrl_ProdPedido.Text = "";
                    lb_Tp_ProdPedido.Text = "";
                }

            }

        }

        private void btn_Pabaxo_Click(object sender, EventArgs e)
        {
            PopulaLinhaLView(ltview_ItemPedido, tbox_Cod_ProdPedido.Text, lb_Nm_ProdPedido.Text, lb_Tp_ProdPedido.Text, lb_Vrl_ProdPedido.Text);
            tbox_Cod_ProdPedido.Text = "";
            lb_Nm_ProdPedido.Text = "";
            lb_Tp_ProdPedido.Text = "";
            lb_Vrl_ProdPedido.Text = "";

            tbox_Cod_ProdPedido.Focus();
            tbox_Vlr_Pedido.Text = CalculaVlr().ToString();
        }

        /***********************************************************************
        *        Método: TitulosLView
        *          Obs.: Responsável por Titular a List View
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void TitulosLView()
        {
            ltview_ItemPedido.View = View.Details;
            ltview_ItemPedido.Columns.Add("Código", 50);
            ltview_ItemPedido.Columns.Add("Nome", 65);
            ltview_ItemPedido.Columns.Add("Tipo", 203);
            ltview_ItemPedido.Columns.Add("Valor", 75);
        }

        /***********************************************************************
        *        Método: PopulaLinhaLView
        *          Obs.: Responsável por popular a linha com o conteúdo do 
        *                objeto Item da Competência
        *   Dt. Criação: 29/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaLinhaLView(ListView pltview, string pCod_Produto, string pNm_Produto, string pNm_Tipo, string pVlrUni_Produto)
        {
            ListViewItem item = new ListViewItem(new[] { pCod_Produto, pNm_Produto, pNm_Tipo, pVlrUni_Produto });
            pltview.Items.Add(item);
        }

        private void btn_Pacima_Click(object sender, EventArgs e)
        {
            if (ltview_ItemPedido.SelectedItems != null)
            {
                DialogResult vResp = MessageBox.Show("Deseja retirar a " + lb_Nm_ProdPedido.Text + " da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vResp == DialogResult.Yes)
                {
                    for (int i = 0; i < ltview_ItemPedido.Items.Count; i++)
                    {
                        if (ltview_ItemPedido.Items[i].Selected)
                        {
                            tbox_Cod_ProdPedido.Text = ltview_ItemPedido.Items[i].SubItems[0].Text;
                            lb_Nm_ProdPedido.Text = ltview_ItemPedido.Items[i].SubItems[1].Text;
                            lb_Tp_ProdPedido.Text = ltview_ItemPedido.Items[i].SubItems[2].Text;
                            lb_Vrl_ProdPedido.Text = ltview_ItemPedido.Items[i].SubItems[3].Text;
                            ltview_ItemPedido.Items[i].Remove();
                            break;
                        }
                    }
                }


            }
            else
            {
                MessageBox.Show("Erro ao retirar a UC da Lista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbox_Vlr_Pedido.Text = CalculaVlr().ToString();
        }

        /***********************************************************************
        *        Método: CalculaVlr
        *          Obs.: 
        *   Dt. Criação: 29/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private double CalculaVlr()
        {
            double d_CalculaVlr = 0;

            for (int i = 0; i < ltview_ItemPedido.Items.Count; i++)
            {
                d_CalculaVlr += Convert.ToDouble(ltview_ItemPedido.Items[i].SubItems[3].Text);
            }

            return d_CalculaVlr;
        }


    }
}
