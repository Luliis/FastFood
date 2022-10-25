/* ***************************************************************************************
 *          Nome: Pedido
 *          obs.: Representa a classe de objetos. Classe com atributos 
 *                privados e métodos (Get/Set) Públicos
 *   Dt. Criação: 06/07/2022
 * Dt. Alteração: --
 *    Criada por: KappyS, Luiz
 * ***************************************************************************************/

namespace RequestSystem
{
    public class Pedido
    {
        ~Pedido()
        {

        }
        #region Atributos Privados
        private int v_Cod_Pedido = -1;
        private int v_Cod_Cliente = -1;
        private double v_VlrTot_Pedido = 0;
        #endregion

        #region Atributos Públicos 
        public int Cod_Pedido 
        { 
            get => v_Cod_Pedido; 
            set => v_Cod_Pedido = value;
        }
        public int Cod_Cliente
        { 
            get => v_Cod_Cliente;
            set => v_Cod_Cliente = value;
        }
        public double VlrTot_Pedido 
        {
            get => v_VlrTot_Pedido; 
            set => v_VlrTot_Pedido = value; 
        }
        #endregion
    }
}
