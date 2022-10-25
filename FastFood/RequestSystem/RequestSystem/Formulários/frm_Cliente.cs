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
    public partial class frm_Cliente : Form
    {
        public Cliente obj_Cliente_Atual = new Cliente();
        FuncGeral obj_FuncGeral = new FuncGeral();

        public frm_Cliente()
        {
            InitializeComponent();
            PopulaLista();
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
            obj_FuncGeral.PopulaMask(this);
        }




        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            tbox_Nm_Cliente.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }





        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            tbox_Nm_Cliente.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }





        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Instância da Classe BD. 
            BDCliente obj_BDCliente = new BDCliente();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDCliente.Excluir(obj_Cliente_Atual))
                {
                    MessageBox.Show("O cliente " + obj_Cliente_Atual.Nm_Cliente + " foi excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (obj_Cliente_Atual.Cod_Cliente != -1)
            {
                PopulaTela(obj_Cliente_Atual);
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
                BDCliente obj_BDCliente = new BDCliente();
                obj_Cliente_Atual = PopulaObjeto();



                if (obj_Cliente_Atual.Cod_Cliente != -1)
                {
                    obj_BDCliente.Alterar(obj_Cliente_Atual);
                    MessageBox.Show("O cliente " + obj_Cliente_Atual.Nm_Cliente + " foi alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    obj_Cliente_Atual.Cod_Cliente = obj_BDCliente.Incluir(obj_Cliente_Atual);
                    PopulaTela(obj_Cliente_Atual);
                    MessageBox.Show("O cliente " + obj_Cliente_Atual.Nm_Cliente + " foi inserido com sucesso.", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private Cliente PopulaObjeto()
        {
            Cliente obj_Cliente = new Cliente();

            if (tbox_Cod_Cliente.Text != "")
            {
                obj_Cliente.Cod_Cliente = Convert.ToInt16(tbox_Cod_Cliente.Text);
            }
            obj_Cliente.Nm_Cliente = tbox_Nm_Cliente.Text;
            obj_Cliente.CPF_Cliente = mtbox_CPF_Cliente.Text;
            

            // não soubemos radio button

            return obj_Cliente;
        }

        /***********************************************************************
        *        Método: PopulaTela
        *          Obs.: Responsável por popular o formulário com o conteúdo 
        *                do objeto atual.
        *   Dt. Criação: 13/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        private void PopulaTela(Cliente pobj_Cliente)
        {
            if (pobj_Cliente.Cod_Cliente != -1)
            {
                tbox_Cod_Cliente.Text = pobj_Cliente.Cod_Cliente.ToString();
            }
            tbox_Nm_Cliente.Text = pobj_Cliente.Nm_Cliente.ToString();
            mtbox_CPF_Cliente.Text = pobj_Cliente.CPF_Cliente.ToString();
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
            BDCliente obj_BDCliente = new BDCliente();

            List<Cliente> Lista = new List<Cliente>();

            ltbox_Clientes.Items.Clear();

            Lista = obj_BDCliente.FindAllCliente();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_Clientes.Items.Add(Lista[i].Cod_Cliente.ToString() + "-" + Lista[i].Nm_Cliente.ToString());
                }
            }
        }

        private void ltbox_Clientes_Click(object sender, EventArgs e)
        {
            if (ltbox_Clientes.SelectedIndex != -1)
            {
                BDCliente obj_BDCliente = new BDCliente();

                string s_linha = ltbox_Clientes.Items[ltbox_Clientes.SelectedIndex].ToString();
                int i_Pos = 0;


                for (int t = 0; t < s_linha.Length; t++)
                {
                    if (s_linha.Substring(t, 1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }

                obj_Cliente_Atual.Cod_Cliente = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_Cliente_Atual = obj_BDCliente.FindByCodCliente(obj_Cliente_Atual);
                PopulaTela(obj_Cliente_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);

            }
        }


    }
}
