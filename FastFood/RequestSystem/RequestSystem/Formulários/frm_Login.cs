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
    public partial class frm_Login : Form

    {
        FuncGeral obj_FuncGeral = new FuncGeral();
        public Funcionario obj_Funcionario_Atual = new Funcionario();
        public frm_Login()
        {
            InitializeComponent();
        }
            
         private void btn_Confirmar_Click(object sender, EventArgs e)
            {
                obj_FuncGeral.VerificaNulos(this);

                BDFuncionario obj_BDFuncionario = new BDFuncionario();
                Funcionario obj_Funcionario = new Funcionario();

                obj_Funcionario.UNm_Funcionario = tbox_UNm_Funcionario.Text;
                
                obj_Funcionario = obj_BDFuncionario.FindByUNmFuncionario(obj_Funcionario);

                if (obj_Funcionario == null)
                {
                    MessageBox.Show("Nome do Usuário não encontrado.", "ENTRADA INVÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    tbox_UNm_Funcionario.Focus();
                }
                else
                {
                    if (obj_FuncGeral.Criptografa(tbox_Pass_Funcionario.Text) == obj_Funcionario.Pass_Funcionario)
                    {
                        frm_Principal obj_frm_Principal = new frm_Principal();
                        //obj_frm_Principal.obj_Funcionario_Atual = obj_Funcionario;
                        obj_frm_Principal.ShowDialog();
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Senha não encontrado.", "ENTRADA INVÁLIDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        tbox_Pass_Funcionario.Focus();
                    }
                }

            
         }

  
    }
}
    

