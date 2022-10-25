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
    public partial class frm_Funcionario : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        Funcionario obj_Funcionario_Atual = new Funcionario();
        public frm_Funcionario()

        {
            InitializeComponent();
            PopulaLista();
           
            obj_FuncGeral.StatusBtn(this, 1);
            obj_FuncGeral.HabilitaTela(this, false);
        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            obj_FuncGeral.LimpaTela(this);
            tbox_UNm_Funcionario.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            tbox_UNm_Funcionario.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Instância da Classe BD. 
            BDFuncionario obj_BDUsuario = new BDFuncionario();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDUsuario.Excluir(obj_Funcionario_Atual))
                {
                    MessageBox.Show("O funcionário " + obj_Funcionario_Atual.UNm_Funcionario + " foi excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obj_FuncGeral.LimpaTela(this);
                    obj_FuncGeral.HabilitaTela(this, false);
                    obj_FuncGeral.StatusBtn(this, 1);
                    PopulaLista();
                }
            }
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (obj_FuncGeral.ValidaTela(this))
            {
                BDFuncionario obj_BDFuncionario = new BDFuncionario();
                obj_Funcionario_Atual = PopulaObjeto();

                if (obj_Funcionario_Atual.Cod_Funcionario != -1)
                {
                    obj_BDFuncionario.Alterar(obj_Funcionario_Atual);
                    MessageBox.Show("O funcionário " + obj_Funcionario_Atual.UNm_Funcionario + " foi alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    obj_Funcionario_Atual.Cod_Funcionario = obj_BDFuncionario.Incluir(obj_Funcionario_Atual);
                    PopulaTela(obj_Funcionario_Atual);
                    MessageBox.Show("O funcionário " + obj_Funcionario_Atual.UNm_Funcionario + " foi inserido com sucesso.", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                PopulaLista();
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);
            if (obj_Funcionario_Atual.Cod_Funcionario != -1)
            {
                PopulaTela(obj_Funcionario_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.StatusBtn(this, 1);
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
        private Funcionario PopulaObjeto()
        {
            Funcionario obj_Funcionario = new Funcionario();

            if (tbox_Cod_Funcionario.Text != "")
            {
                obj_Funcionario.Cod_Funcionario = Convert.ToInt16(tbox_Cod_Funcionario.Text);
            }
            obj_Funcionario.UNm_Funcionario = tbox_UNm_Funcionario.Text;
            obj_Funcionario.Pass_Funcionario = obj_FuncGeral.Criptografa(tbox_Pass_Funcionario.Text);

            return obj_Funcionario;
        }

        /***********************************************************************
        *        Método: PopulaTela
        *          Obs.: Responsável por popular o formulário com o conteúdo 
        *                do objeto atual.
        *   Dt. Criação: 13/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        private void PopulaTela(Funcionario pobj_Funcionario)
        {
            if (pobj_Funcionario.Cod_Funcionario != -1)
            {
                tbox_Cod_Funcionario.Text = pobj_Funcionario.Cod_Funcionario.ToString();
            }
            tbox_UNm_Funcionario.Text = pobj_Funcionario.UNm_Funcionario.ToString();
            tbox_Pass_Funcionario.Text = obj_FuncGeral.DesCriptografa(pobj_Funcionario.Pass_Funcionario.ToString());
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
            BDFuncionario obj_BDFuncionario = new BDFuncionario();

            List<Funcionario> Lista = new List<Funcionario>();

            ltbox_Funcionarios.Items.Clear();

            Lista = obj_BDFuncionario.FindAllFuncionario();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_Funcionarios.Items.Add(Lista[i].Cod_Funcionario.ToString() + "-" + Lista[i].UNm_Funcionario.ToString());
                }
            }
        }

        private void ltbox_Funcionarios_Click(object sender, EventArgs e)
        {
            if (ltbox_Funcionarios.SelectedIndex != -1)
            {
                BDFuncionario obj_BDFuncionario = new BDFuncionario();

                string s_linha = ltbox_Funcionarios.Items[ltbox_Funcionarios.SelectedIndex].ToString();
                int i_Pos = 0;


                for (int t = 0; t < s_linha.Length; t++)
                {
                    if (s_linha.Substring(t, 1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }

                obj_Funcionario_Atual.Cod_Funcionario = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_Funcionario_Atual = obj_BDFuncionario.FindByCodFuncionario(obj_Funcionario_Atual);
                PopulaTela(obj_Funcionario_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);

            }
        }


    }
}
