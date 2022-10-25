/* ***************************************************************************************
 *          Nome: ItemPedido
 *          obs.: Representa a classe de objetos. Classe com atributos 
 *                privados e métodos (Get/Set) Públicos
 *   Dt. Criação: 06/07/2022
 * Dt. Alteração: --
 *    Criada por: KappyS, Luiz
 * ***************************************************************************************/

namespace RequestSystem
{
    public class ItemPedido
    {
        ~ItemPedido()
        {

        }
        #region Atributos Privados
        private int v_Cod_ItemPedido = -1;
        private int v_Cod_Pedido = -1;
        private int v_Cod_Produto = -1;
        private int v_Qtd_ItemPedido = 0;
        private double v_SubVlr_ItemPedido = 0;


        #endregion

        #region Atributos Públicos
        public int Cod_ItemPedido 
        {
            get => v_Cod_ItemPedido;
            set => v_Cod_ItemPedido = value;
        }
        public int Cod_Pedido 
        {
            get => v_Cod_Pedido;
            set => v_Cod_Pedido = value;
        }
        public int Cod_Produto
        {
            get => v_Cod_Produto;
            set => v_Cod_Produto = value;
        }
        public int Qtd_ItemPedido
        {
            get => v_Qtd_ItemPedido;
            set => v_Qtd_ItemPedido = value;
        }
        public double SubVlr_ItemPedido
        {
            get => v_SubVlr_ItemPedido;
            set => v_SubVlr_ItemPedido = value;
        }
        #endregion

    }
}
