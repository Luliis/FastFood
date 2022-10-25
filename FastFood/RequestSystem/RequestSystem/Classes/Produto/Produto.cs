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
    public class Produto
    {
        ~Produto()
        {

        }
        #region Atributos Privados
        private int v_Cod_Produto = -1;
        private int v_Cod_Tipo = -1;
        private string v_Nm_Produto = "";
        private string v_Desc_Produto = "";
        private double v_VlrUni_Produto = 0;


        #endregion

        #region Atributos Públicos

        public int Cod_Produto
        { 
            get => v_Cod_Produto;
            set => v_Cod_Produto = value; 
        }
        public int Cod_Tipo
        { 
            get => v_Cod_Tipo; 
            set => v_Cod_Tipo = value; 
        }
        public string Nm_Produto 
        {
            get => v_Nm_Produto; 
            set => v_Nm_Produto = value; 
        }
        public string Desc_Produto
        {
            get => v_Desc_Produto;
            set => v_Desc_Produto = value;
        }
        public double VlrUni_Produto
        {
            get => v_VlrUni_Produto;
            set => v_VlrUni_Produto = value;
        }
        

        #endregion
    }
}
