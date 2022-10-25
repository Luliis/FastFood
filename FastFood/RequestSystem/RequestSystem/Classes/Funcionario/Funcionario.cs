/* ***************************************************************************************
 *          Nome: Funcionario
 *          obs.: Representa a classe de objetos. Classe com atributos 
 *                privados e métodos (Get/Set) Públicos
 *   Dt. Criação: 06/07/2022
 * Dt. Alteração: --
 *    Criada por: KappyS, Luiz
 * ***************************************************************************************/

namespace RequestSystem
{
    public class Funcionario
    {
        ~Funcionario()
        {

        }

        #region Atributos Privados

        private int v_Cod_Funcionario = -1;
        private string v_UNm_Funcionario = "";
        private string v_Pass_Funcionario = "";
        private bool v_Adm_Funcionario = false;

        #endregion

        #region Atributos Públicos

        public int Cod_Funcionario 
        {
            get => v_Cod_Funcionario;
            set => v_Cod_Funcionario = value;
        }
        public string UNm_Funcionario 
        { 
            get => v_UNm_Funcionario;
            set => v_UNm_Funcionario = value;
        }
        public string Pass_Funcionario 
        { 
            get => v_Pass_Funcionario; 
            set => v_Pass_Funcionario = value; 
        }
        public bool Adm_Funcionario
        {
            get => v_Adm_Funcionario; 
            set => v_Adm_Funcionario = value;
        }

        #endregion
    }
}
