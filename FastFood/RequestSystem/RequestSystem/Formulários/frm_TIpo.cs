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
    public partial class frm_Tipo : Form
    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Tipo obj_Tipo_Atual = new Tipo();
        public frm_Tipo()

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
            tbox_Nm_Tipo.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Confirmar_Click(object sender, EventArgs e)
        {
            if (obj_FuncGeral.ValidaTela(this))
            {
                BDTipo obj_BDTipo = new BDTipo();
                obj_Tipo_Atual = PopulaObjeto();

                if (obj_Tipo_Atual.Cod_Tipo != -1)
                {
                    obj_BDTipo.Alterar(obj_Tipo_Atual);
                    MessageBox.Show("O Tipo " + obj_Tipo_Atual.Nm_Tipo + " foi alterado com sucesso.", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    obj_Tipo_Atual.Cod_Tipo = obj_BDTipo.Incluir(obj_Tipo_Atual);
                    PopulaTela(obj_Tipo_Atual);
                    MessageBox.Show("O Tipo " + obj_Tipo_Atual.Nm_Tipo + " foi inserido com sucesso.", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                PopulaLista();
                obj_FuncGeral.HabilitaTela(this, false);
                obj_FuncGeral.StatusBtn(this, 2);
            }
        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, true);
            tbox_Nm_Tipo.Focus();
            obj_FuncGeral.StatusBtn(this, 3);
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            //Instância da Classe BD. 
            BDTipo obj_BDTipo = new BDTipo();

            DialogResult vResp = MessageBox.Show("Confirma a Exclusão?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vResp == DialogResult.Yes)
            {
                if (obj_BDTipo.Excluir(obj_Tipo_Atual))
                {
                    MessageBox.Show("O Tipo " + obj_Tipo_Atual.Nm_Tipo + " foi excluído com sucesso.", "Excluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    obj_FuncGeral.LimpaTela(this);
                    obj_FuncGeral.HabilitaTela(this, false);
                    obj_FuncGeral.StatusBtn(this, 1);
                    PopulaLista();
                }
            }


        }

        /***********************************************************************
        *        Método: PopulaObjeto
        *          Obs.: Responsável por popular o objeto atual com o conteúdo 
        *                do formulário.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private Tipo PopulaObjeto()
        {
            Tipo obj_Tipo = new Tipo();

            if (tbox_Cod_Tipo.Text != "")
            {
                obj_Tipo.Cod_Tipo = Convert.ToInt16(tbox_Cod_Tipo.Text);
            }
            obj_Tipo.Nm_Tipo = tbox_Nm_Tipo.Text;
      

            return obj_Tipo;
        }

        /***********************************************************************
        *        Método: PopulaTela
        *          Obs.: Responsável por popular o formulário com o conteúdo 
        *                do objeto atual.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaTela(Tipo pobj_Tipo)
        {
            if (pobj_Tipo.Cod_Tipo != -1)
            {
                tbox_Cod_Tipo.Text = pobj_Tipo.Cod_Tipo.ToString();


            }
            tbox_Nm_Tipo.Text = pobj_Tipo.Nm_Tipo.ToString();
        }



        /***********************************************************************
        *        Método: PopulaLista
        *          Obs.: Responsável por popular os usuários da tabela na lista 
        *                do formulário.
        *   Dt. Criação: 02/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        private void PopulaLista()
        {
            BDTipo obj_BDTipo = new BDTipo();

            List<Tipo> Lista = new List<Tipo>();

            ltbox_Tipos.Items.Clear();

            Lista = obj_BDTipo.FindAllTipo();

            if (Lista != null)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    ltbox_Tipos.Items.Add(Lista[i].Cod_Tipo.ToString() + "-" + Lista[i].Nm_Tipo.ToString());
                }
            }
        }

        private void ltbox_Tipos_Click(object sender, EventArgs e)
        {
            if (ltbox_Tipos.SelectedIndex != -1)
            {
                BDTipo obj_BDTipo = new BDTipo();

                string s_linha = ltbox_Tipos.Items[ltbox_Tipos.SelectedIndex].ToString();
                int i_Pos = 0;


                for (int t = 0; t < s_linha.Length; t++)
                {
                    if (s_linha.Substring(t, 1) == "-")
                    {
                        i_Pos = t;
                        break;
                    }
                }

                obj_Tipo_Atual.Cod_Tipo = Convert.ToInt16(s_linha.Substring(0, i_Pos));
                obj_Tipo_Atual = obj_BDTipo.FindByCodTipo(obj_Tipo_Atual);
                PopulaTela(obj_Tipo_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
                obj_FuncGeral.HabilitaTela(this, false);

            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            obj_FuncGeral.HabilitaTela(this, false);
            if (obj_Tipo_Atual.Cod_Tipo != -1)
            {
                PopulaTela(obj_Tipo_Atual);
                obj_FuncGeral.StatusBtn(this, 2);
            }
            else
            {
                obj_FuncGeral.LimpaTela(this);
                obj_FuncGeral.StatusBtn(this, 1);
            }
        }


    }
}
