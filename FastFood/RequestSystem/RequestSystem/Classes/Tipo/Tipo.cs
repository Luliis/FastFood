/* ***************************************************************************************
 *          Nome: Tipo
 *          obs.: Representa a classe de objetos. Classe com atributos 
 *                privados e métodos (Get/Set) Públicos
 *   Dt. Criação: 06/07/2022
 * Dt. Alteração: --
 *    Criada por: KappyS, Luiz
 * ***************************************************************************************/

namespace RequestSystem
{
    public class Tipo
    {
        ~Tipo()
        {

        }
        #region Atributos Privados
        
        private int v_Cod_Tipo = -1;
        private string v_Nm_Tipo = "";
        
        #endregion
       
        #region Atributos Publicos

        public int Cod_Tipo 
        {
            get => v_Cod_Tipo; 
            set => v_Cod_Tipo = value;
        }
        public string Nm_Tipo 
        {
            get => v_Nm_Tipo;
            set => v_Nm_Tipo = value;
        }

        #endregion
    }
}
