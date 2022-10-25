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
    public partial class frm_Produto : Form
    {
        public Produto obj_Produto_Atual = new Produto();

        public Produto obj_Produto_Combo = new Produto();

        int i_Cod_ProdCombo = -1;

        FuncGeral obj_FuncGeral = new FuncGeral();
        Tipo obj_Tipo_Atual = new Tipo();
        

        public frm_Produto()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.PopulaMask(this);
            this.Height = 386;
            TitulosLView();
        }




        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            tbox_Vlr_Produto.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }





        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            tbox_Vlr_Produto.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }





        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Instância da Classe BD. 
            BDProduto obj_BDProduto = new BDProduto();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDProduto.Excluir(obj_Produto_Atual))
                {
                    MessageBox.Show("O produto " + obj_Produto_Atual.Nm_Produto + " foi excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (obj_Produto_Atual.Cod_Produto != -1)
            {
                PopulaTela(obj_Produto_Atual);
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

                BDProduto obj_BDProduto = new BDProduto();
                obj_Produto_Atual = PopulaObjeto();



                if (obj_Produto_Atual.Cod_Produto != -1)
                {
                    obj_BDProduto.Alterar(obj_Produto_Atual);
                    MessageBox.Show("O produto " + obj_Produto_Atual.Nm_Produto + " foi alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    obj_Produto_Atual.Cod_Produto = obj_BDProduto.Incluir(obj_Produto_Atual);
                    PopulaTela(obj_Produto_Atual);
                    MessageBox.Show("O produto " + obj_Produto_Atual.Nm_Produto + " foi inserido com sucesso.", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private Produto PopulaObjeto()
        {
            Produto obj_Produto = new Produto();

            if (tbox_Cod_Produto.Text != "")
            {
                obj_Produto.Cod_Produto = Convert.ToInt16(tbox_Cod_Produto.Text);
            }
            obj_Produto.Nm_Produto = tbox_Nm_Produto.Text;
            obj_Produto.Desc_Produto = tbox_Desc_Produto.Text;
            obj_Produto.VlrUni_Produto = Convert.ToDouble(tbox_Vlr_Produto.Text);
            obj_Produto.Cod_Tipo = Convert.ToInt16(tbox_Cod_Tipo.Text);

            // não soubemos radio button

            return obj_Produto;
        }

        /***********************************************************************
        *        Método: PopulaTela
        *          Obs.: Responsável por popular o formulário com o conteúdo 
        *                do objeto atual.
        *   Dt. Criação: 13/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        private void PopulaTela(Produto pobj_Produto)
        {
            if (pobj_Produto.Cod_Produto != -1)
            {
                tbox_Cod_Produto.Text = pobj_Produto.Cod_Produto.ToString();
               
            }
            tbox_Nm_Produto.Text = pobj_Produto.Nm_Produto.ToString();
            tbox_Desc_Produto.Text = pobj_Produto.Desc_Produto.ToString();

            if (pobj_Produto.Cod_Tipo != 1)
            {
                tbox_Vlr_Produto.Text = pobj_Produto.VlrUni_Produto.ToString();
            }
            else
            {
                tbox_Vlr_Produto.Text = CalculaVlr().ToString();
            }
           
            tbox_Cod_Tipo.Text = pobj_Produto.Cod_Tipo.ToString();
            tBox_Cod_Tipo_Leave(tbox_Cod_Tipo, EventArgs.Empty);
            // não soubemos radio button
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
            BDProduto obj_BDProduto = new BDProduto();

            List<Produto> Lista = new List<Produto>();

            ltbox_Produtos.Items.Clear();

            Lista = obj_BDProduto.FindAllProduto();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_Produtos.Items.Add(Lista[i].Cod_Produto.ToString() + "-" + Lista[i].Nm_Produto.ToString());
                }
            }
        }

        private void ltbox_Produtos_Click(object sender, EventArgs e)
        {
            if (ltbox_Produtos.SelectedIndex != -1)
            {
                BDProduto obj_BDProduto = new BDProduto();

                string s_linha = ltbox_Produtos.Items[ltbox_Produtos.SelectedIndex].ToString();
                int i_Pos = 0;


                for (int t = 0; t < s_linha.Length; t++)
                {
                    if (s_linha.Substring(t, 1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }

                obj_Produto_Atual.Cod_Produto = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_Produto_Atual = obj_BDProduto.FindByCodProduto(obj_Produto_Atual);
                PopulaLtView();
                PopulaTela(obj_Produto_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);
                

            }
        }

        public void btn_Tipo_Click(object sender, EventArgs e)
        {
            frm_Tipo obj_frm_Tipo = new frm_Tipo();
            obj_frm_Tipo.ShowDialog();
            tbox_Cod_Tipo.Text = obj_frm_Tipo.obj_Tipo_Atual.Cod_Tipo.ToString();
            tBox_Cod_Tipo_Leave(tbox_Cod_Tipo, e);
     
        }

        public void tBox_Cod_Tipo_Leave(object sender, EventArgs e)
        {
            obj_Tipo_Atual = new Tipo();

            if (((TextBox)sender).Text != "")
            {
                if (Convert.ToInt16(((TextBox)sender).Text) == 1)
                {
                    this.Height = 589;
                    
                    tbox_Cod_ProdCombo.Visible = true;
                    
                    tbox_Vlr_Produto.Tag = 1;
                    tbox_Vlr_Produto.Enabled = false;

                }
                else
                {
                    this.Height = 386;
                }
            }



            if (tbox_Cod_Tipo.Text != "")
            {
                BDTipo obj_BDTipo = new BDTipo();
                obj_Tipo_Atual.Cod_Tipo = Convert.ToInt16(((TextBox)sender).Text);
                obj_Tipo_Atual = obj_BDTipo.FindByCodTipo(obj_Tipo_Atual);
                if (obj_Tipo_Atual != null)
                {
                    lb_Nm_Tipo.Text = obj_Tipo_Atual.Nm_Tipo;

                }
                else
                {
                    tbox_Cod_Tipo.Text = null;
                    lb_Nm_Tipo.Text = "";

                }

            }

        }

        private void tbox_Cod_ProdCombo_Leave(object sender, EventArgs e)
        {

            obj_Produto_Combo = new Produto();


            if (tbox_Cod_ProdCombo.Text != "")
            {
                BDProduto obj_BDProduto = new BDProduto();

                obj_Produto_Combo.Cod_Produto = Convert.ToInt16(((TextBox)sender).Text);
                obj_Produto_Combo = obj_BDProduto.FindByCodProduto(obj_Produto_Combo);
                if (obj_Produto_Combo != null)
                {
                    lb_Nm_ProdCombo.Text = obj_Produto_Combo.Nm_Produto;
                    lb_Vrl_ProdCombo.Text = obj_Produto_Combo.VlrUni_Produto.ToString();

                    Tipo obj_Tipo = new Tipo();
                    BDTipo obj_BDTipo = new BDTipo();
                    obj_Tipo.Cod_Tipo = Convert.ToInt16(obj_Produto_Combo.Cod_Tipo);
                    obj_Tipo = obj_BDTipo.FindByCodTipo(obj_Tipo);
                    lb_Tp_ProdCombo.Text = obj_Tipo.Nm_Tipo;

                }
                else
                {
                    lb_Nm_ProdCombo.Text = "";
                    lb_Vrl_ProdCombo.Text = "";
                    lb_Tp_ProdCombo.Text = "";
                }

            }

        }   

        private void btn_ProdCombo_Click(object sender, EventArgs e)
        {
            frm_Produto obj_frm_ProdCombo = new frm_Produto();
            obj_frm_ProdCombo.ShowDialog();
            obj_Produto_Atual.Cod_Produto = obj_frm_ProdCombo.obj_Produto_Atual.Cod_Produto;
            tbox_Cod_ProdCombo.Text = obj_frm_ProdCombo.obj_Produto_Atual.Cod_Produto.ToString();
            tbox_Cod_ProdCombo_Leave(tbox_Cod_ProdCombo, e);
        }

        private void btn_Pabaxo_Click(object sender, EventArgs e)
        {
            PopulaLinhaLView(ltview_ProdCombo, tbox_Cod_ProdCombo.Text, lb_Nm_ProdCombo.Text, lb_Tp_ProdCombo.Text, lb_Vrl_ProdCombo.Text);
            tbox_Cod_ProdCombo.Text = "";
            lb_Nm_ProdCombo.Text = "";
            lb_Tp_ProdCombo.Text = "";
            lb_Vrl_ProdCombo.Text = "";

            tbox_Cod_ProdCombo.Focus();
            tbox_Vlr_Produto.Text = CalculaVlr().ToString();
        }



        /***********************************************************************
        *        Método: TitulosLView
        *          Obs.: Responsável por Titular a List View
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        private void TitulosLView()
        {
            ltview_ProdCombo.View = View.Details;
            ltview_ProdCombo.Columns.Add("Código", 50);
            ltview_ProdCombo.Columns.Add("Nome", 65);
            ltview_ProdCombo.Columns.Add("Tipo", 203);
            ltview_ProdCombo.Columns.Add("Valor", 75);
        }




        /***********************************************************************
        *        Método: PopulaLinhaLView
        *          Obs.: Responsável por popular a linha com o conteúdo do 
        *                objeto Item da Competência
        *   Dt. Criação: 29/06/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        private void PopulaLinhaLView(ListView pltview, string pCod_ProdCombo, string pNm_ProdCombo, string pTp_ProdCombo, string pVlr_ProdCombo)
        {
            ListViewItem item = new ListViewItem(new[] { pCod_ProdCombo, pNm_ProdCombo, pTp_ProdCombo, pVlr_ProdCombo });
            pltview.Items.Add(item);
        }

        private void btn_Pacima_Click(object sender, EventArgs e)
        {
            if (ltview_ProdCombo.SelectedItems != null)
            {
                DialogResult vResp = MessageBox.Show("Deseja retirar a " + lb_Nm_ProdCombo.Text + " da lista?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vResp == DialogResult.Yes)
                {
                    for (int i = 0; i < ltview_ProdCombo.Items.Count; i++)
                    {
                        if (ltview_ProdCombo.Items[i].Selected)
                        {
                            tbox_Cod_ProdCombo.Text = ltview_ProdCombo.Items[i].SubItems[0].Text;
                            lb_Nm_ProdCombo.Text = ltview_ProdCombo.Items[i].SubItems[1].Text;
                            lb_Tp_ProdCombo.Text = ltview_ProdCombo.Items[i].SubItems[2].Text;
                            lb_Vrl_ProdCombo.Text = ltview_ProdCombo.Items[i].SubItems[3].Text;
                            ltview_ProdCombo.Items[i].Remove();
                            break;
                        }
                    }
                }
                

            }
            else
            {
                MessageBox.Show("Erro ao retirar a UC da Lista.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbox_Vlr_Produto.Text = CalculaVlr().ToString();
        }

        /***********************************************************************
        *        Método: CalculaVlr
        *          Obs.: 
        *   Dt. Criação: 29/06/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        private double CalculaVlr()
        {
            double d_CalculaVlr = 0;
            double d_Desconto = 0;

            for (int i = 0; i < ltview_ProdCombo.Items.Count; i++)
            {
                d_CalculaVlr += Convert.ToDouble(ltview_ProdCombo.Items[i].SubItems[3].Text);
            }
            d_Desconto = d_CalculaVlr * 0.1;
            d_CalculaVlr = d_CalculaVlr - d_Desconto;

            return d_CalculaVlr;
        }


        /***********************************************************************
        *        Método: PopulaLtView
        *          Obs.: Responsável por Popular a List View de Competências
        *   Dt. Criação: 29/06/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        private void PopulaLtView()
        {
            ltview_ProdCombo.Items.Clear();

            BDItemCombo obj_BDItemCombo = new BDItemCombo();
            ItemCombo obj_ItemCombo = new ItemCombo();
            List<ItemCombo> Lista = new List<ItemCombo>();

            if (obj_Produto_Atual.Cod_Tipo == 1)
            {
                obj_ItemCombo.Cod_Combo = obj_Produto_Atual.Cod_Produto;
            }


            

            Lista = obj_BDItemCombo.FindAllCodCombo(obj_ItemCombo);

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


                    PopulaLinhaLView(ltview_ProdCombo, obj_Produto.Cod_Produto.ToString(), obj_Produto.Nm_Produto, obj_Tipo.Nm_Tipo, obj_Produto.VlrUni_Produto.ToString());
                }
            }

        }




    }
}
