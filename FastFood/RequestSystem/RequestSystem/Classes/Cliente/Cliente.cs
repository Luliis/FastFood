/* ***************************************************************************************
 *          Nome: Cliente
 *          obs.: Representa a classe de objetos. Classe com atributos 
 *                privados e métodos (Get/Set) Públicos
 *   Dt. Criação: 06/07/2022
 * Dt. Alteração: --
 *    Criada por: KappyS, Luiz
 * ***************************************************************************************/
namespace RequestSystem
{
    public class Cliente
    {
        ~Cliente()
        {

        }

        #region Atributos Privados
        private int v_Cod_Cliente = -1;
        private string v_Nm_Cliente = "";
        private string v_CPF_Cliente = "";
        #endregion

        #region Metodos Públicos
        public int Cod_Cliente 
        { 
            get => v_Cod_Cliente; 
            set => v_Cod_Cliente = value; 
        }
        public string Nm_Cliente 
        { 
            get => v_Nm_Cliente; 
            set => v_Nm_Cliente = value;
        }
        public string CPF_Cliente 
        { 
            get => v_CPF_Cliente; 
            set => v_CPF_Cliente = value;
        }
        #endregion

    }
}
