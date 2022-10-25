/* ***************************************************************************************
 *          Nome: Produto
 *          obs.: Representa a classe de objetos. Classe com atributos 
 *                privados e métodos (Get/Set) Públicos
 *   Dt. Criação: 06/07/2022
 * Dt. Alteração: --
 *    Criada por: KappyS, Luiz
 * ***************************************************************************************/


namespace RequestSystem
{
    class ItemCombo
    {
        ~ItemCombo() 
        {

        }
        #region Atributos Privados
        private int v_Cod_ItemCombo = -1;
        private int v_Cod_Combo = -1;
        private int v_Cod_Produto = -1;
        private int v_Qtd_Produto = 0;
        private double v_SubVlr_ItemCombo = 0;


        #endregion

        #region Atributos Públicos
        public int Cod_ItemCombo 
        {
            get => v_Cod_ItemCombo;
            set => v_Cod_ItemCombo = value;
        }
        public int Cod_Combo
        {
            get => v_Cod_Combo;
            set => v_Cod_Combo = value;
        }
        public int Cod_Produto 
        {
            get => v_Cod_Produto;
            set => v_Cod_Produto = value;
        }
        public int Qtd_Produto 
        {
            get => v_Qtd_Produto;
            set => v_Qtd_Produto = value;
        }
        public double SubVlr_ItemCombo
        {
            get => v_SubVlr_ItemCombo;
            set => v_SubVlr_ItemCombo = value;
        }
        #endregion
    }
}
