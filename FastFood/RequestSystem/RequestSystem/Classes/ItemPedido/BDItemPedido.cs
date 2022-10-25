/***********************************************************************
 *          Nome: BDItem
 *          obs.: Representa a classe de Banco de Dados Item. 
 *                A Classe utiliza o objeto Connection para acessar o BD
 *   Dt. Criação: 06/07/2022
 * Dt. Alteração: --
 *    Criada por: KappyS, Luiz
 * *********************************************************************/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RequestSystem
{
    class BDItemPedido
    {
        //Destructor da Classe
        ~BDItemPedido()
        {

        }

        /***********************************************************************
         *        Método: Incluir
         *     Parametro: Objeto Item
         *          Obs.: Responsável por incluir um registro na tabela Item.
         *   Dt. Criação: 06/07/2022
         * Dt. Alteração: --
         *    Criada por: KappyS, Luiz
         ***********************************************************************/
        public int Incluir(ItemPedido pobj_ItemPedido)
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "INSERT INTO TB_ITEMPEDIDO " +
                                   "( " +
                                   "I_COD_PEDIDO, " +
                                   "I_COD_PRODUTO, " +
                                   "I_QTD_ITEMPEDIDO, " +
                                   "D_SUBVLR_ITEMPEDIDO " +
                                   ") " +
                                   "VALUES " +
                                   "( " +
                                   "@I_COD_PEDIDO, " +
                                   "@I_COD_PRODUTO, " +
                                   "@I_QTD_ITEMPEDIDO, " +
                                   "@D_SUBVLR_ITEMPEDIDO " +
                                   "); " +
                                   " SELECT IDENT_CURRENT('TB_ITEMPEDIDO') AS 'ID' ";

            //(06/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(06/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_PEDIDO", pobj_ItemPedido.Cod_Pedido);
            obj_Cmd.Parameters.AddWithValue("@I_COD_PRODUTO", pobj_ItemPedido.Cod_Produto);
            obj_Cmd.Parameters.AddWithValue("@I_QTD_ITEMPEDIDO", pobj_ItemPedido.Qtd_ItemPedido);
            obj_Cmd.Parameters.AddWithValue("@D_SUBVLR_ITEMPEDIDO", pobj_ItemPedido.SubVlr_ItemPedido);

            try
            {
                //(06/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();
                //(06/07/2022 - KappyS, Luiz) Executar o comando de forma escalar
                int ID = Convert.ToInt16(obj_Cmd.ExecuteScalar());
                //(06/07/2022 - KappyS, Luiz) Fechar a Conexão
                obj_Con.Close();
                return ID;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "ERRO FATAL NA INCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }

        }

        /***********************************************************************
        *        Método: Alterar
        *     Parametro: Objeto Item
        *          Obs.: Responsável por alterar um registro na tabela Item.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public bool Alterar(ItemPedido pobj_ItemPedido)
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "UPDATE TB_ITEMPEDIDO SET " +
                                   "I_COD_PEDIDO = @I_COD_PEDIDO," +
                                   "I_COD_PRODUTO = @I_COD_PRODUTO," +
                                   "I_QTD_ITEMPEDIDO = @I_QTD_ITEMPEDIDO, " +
                                   "D_SUBVLR_ITEMPEDIDO  = @D_SUBVLR_ITEMPEDIDO " +
                                   "WHERE I_COD_ITEMPEDIDO = @I_COD_ITEMPEDIDO;";


            //(06/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(06/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_ITEMPEDIDO", pobj_ItemPedido.Cod_ItemPedido);
            obj_Cmd.Parameters.AddWithValue("@I_COD_PEDIDO", pobj_ItemPedido.Cod_Pedido);
            obj_Cmd.Parameters.AddWithValue("@I_COD_PRODUTO", pobj_ItemPedido.Cod_Produto);
            obj_Cmd.Parameters.AddWithValue("@I_QTD_ITEMPEDIDO", pobj_ItemPedido.Qtd_ItemPedido);
            obj_Cmd.Parameters.AddWithValue("@D_SUBVLR_ITEMPEDIDO", pobj_ItemPedido.SubVlr_ItemPedido);

            try
            {
                //(06/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();
                //(06/07/2022 - KappyS, Luiz) Executar o comando de forma escalar
                obj_Cmd.ExecuteNonQuery();
                //(06/07/2022 - KappyS, Luiz) Fechar a Conexão
                obj_Con.Close();
                return true;

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "ERRO FATAL NA ALTERAÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        /***********************************************************************
        *        Método: Excluir
        *     Parametro: Objeto Item
        *          Obs.: Responsável por Excluir um registro na tabela Item.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public bool Excluir(ItemPedido pobj_ItemPedido)
        {
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());
            string s_SQL_Comando = "DELETE FROM TB_ITEMPEDIDO " +
                                   "WHERE I_COD_ITEMPEDIDO = @I_COD_ITEMPEDIDO;";
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);
            obj_Cmd.Parameters.AddWithValue("@I_COD_ITEMPEDIDO", pobj_ItemPedido.Cod_ItemPedido);
            try
            {
                obj_Con.Open();
                obj_Cmd.ExecuteNonQuery();
                obj_Con.Close();
                return true;
            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "ERRO FATAL NA EXCLUSÃO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /***********************************************************************
        *        Método: FindByCodItem
        *     Parametro: Objeto Item
        *          Obs.: Responsável por buscar um registro na tabela Item.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public ItemPedido FindByCodItem(ItemPedido pobj_ItemPedido)
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_ITEMPEDIDO " +
                                   "WHERE I_COD_ITEMPEDIDO = @I_COD_ITEMPEDIDO;";


            //(19 / 05 / 2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(19 / 05 / 2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_ITEMPEDIDO", pobj_ItemPedido.Cod_ItemPedido);

            try
            {
                //(19 / 05 / 2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(19 / 05 / 2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();

                    pobj_ItemPedido.Cod_ItemPedido = Convert.ToInt16(obj_Dtr["I_COD_ITEMPEDIDO"]);
                    pobj_ItemPedido.Cod_Pedido = Convert.ToInt16(obj_Dtr["I_COD_PEDIDO"]);
                    pobj_ItemPedido.Cod_Produto = Convert.ToInt16(obj_Dtr["I_COD_PRODUTO"]);
                    pobj_ItemPedido.Qtd_ItemPedido = Convert.ToInt16(obj_Dtr["I_QTD_ITEMPEDIDO"]);
                    pobj_ItemPedido.SubVlr_ItemPedido = Convert.ToDouble(obj_Dtr["D_SUBVLR_ITEMPEDIDO"]); 

                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_ItemPedido;
                }
                else
                {
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return null;
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "ERRO FATAL NA BUSCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }

        }

        /***********************************************************************
        *        Método: FindAllItem
        *          Obs.: Responsável por buscar todos os registros na tabela Item.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public List<ItemPedido> FindAllItem()
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_ITEMPEDIDO ";

            //(06/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            try
            {
                //(06/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(06/07/2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                //(06/07/2022 - KappyS, Luiz) Cria a Lista para receber os alunos da Tabela
                List<ItemPedido> Lista = new List<ItemPedido>();

                if (obj_Dtr.HasRows)
                {
                    //(06/07/2022 - KappyS, Luiz) Enquanto tiver linha, faça.
                    while (obj_Dtr.Read())
                    {
                        ItemPedido obj_ItemPedido = new ItemPedido();

                        obj_ItemPedido.Cod_ItemPedido = Convert.ToInt16(obj_Dtr["I_COD_ITEMPEDIDO"]);
                        obj_ItemPedido.Cod_Pedido = Convert.ToInt16(obj_Dtr["I_COD_PEDIDO"]);
                        obj_ItemPedido.Cod_Produto = Convert.ToInt16(obj_Dtr["I_COD_PRODUTO"]);
                        obj_ItemPedido.Qtd_ItemPedido = Convert.ToInt16(obj_Dtr["I_QTD_ITEMPEDIDO"]);
                        obj_ItemPedido.SubVlr_ItemPedido = Convert.ToDouble(obj_Dtr["D_SUBVLR_ITEMPEDIDO"]);
                        Lista.Add(obj_ItemPedido);
                    }
                    //(06/07/2022 - KappyS, Luiz) Fecho a conexão com o BD
                    obj_Con.Close();

                    //(06/07/2022 - KappyS, Luiz) Fecho o DataReader
                    obj_Dtr.Close();

                    return Lista;

                }
                else
                {
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return null;
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "ERRO FATAL NA BUSCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        /***********************************************************************
        *        Método: FindAllItemByCodPedido
        *          Obs.: Responsável por buscar todos os registros na tabela Item.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public List<ItemPedido> FindAllItemByPedido(ItemPedido pobj_ItemPedido)
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_ITEMPEDIDO "+
                                   "WHERE I_COD_PEDIDO = @I_COD_PEDIDO;";

            //(06/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            obj_Cmd.Parameters.AddWithValue("@I_COD_PEDIDO", pobj_ItemPedido.Cod_Pedido);

            try
            {
                //(06/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(06/07/2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                //(06/07/2022 - KappyS, Luiz) Cria a Lista para receber os alunos da Tabela
                List<ItemPedido> Lista = new List<ItemPedido>();

                if (obj_Dtr.HasRows)
                {
                    //(06/07/2022 - KappyS, Luiz) Enquanto tiver linha, faça.
                    while (obj_Dtr.Read())
                    {
                        ItemPedido obj_ItemPedido = new ItemPedido();

                        obj_ItemPedido.Cod_ItemPedido = Convert.ToInt16(obj_Dtr["I_COD_ITEMPEDIDO"]);
                        obj_ItemPedido.Cod_Pedido = Convert.ToInt16(obj_Dtr["I_COD_PEDIDO"]);
                        obj_ItemPedido.Cod_Produto = Convert.ToInt16(obj_Dtr["I_COD_PRODUTO"]);
                        obj_ItemPedido.Qtd_ItemPedido = Convert.ToInt16(obj_Dtr["I_QTD_ITEMPEDIDO"]);
                        obj_ItemPedido.SubVlr_ItemPedido = Convert.ToDouble(obj_Dtr["D_SUBVLR_ITEMPEDIDO"]);
                        Lista.Add(obj_ItemPedido);
                    }
                    //(06/07/2022 - KappyS, Luiz) Fecho a conexão com o BD
                    obj_Con.Close();

                    //(06/07/2022 - KappyS, Luiz) Fecho o DataReader
                    obj_Dtr.Close();

                    return Lista;

                }
                else
                {
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return null;
                }

            }
            catch (Exception Erro)
            {
                MessageBox.Show(Erro.Message, "ERRO FATAL NA BUSCA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

    }
}