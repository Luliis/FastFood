/***********************************************************************
 *          Nome: BDItemCombo
 *          obs.: Representa a classe de Banco de Dados ItemCombo. 
 *                A Classe utiliza o objeto Connection para acessar o BD
 *   Dt. Criação: 08/07/2022
 * Dt. Alteração: --
 *    Criada por: KappyS, Luiz
 * *********************************************************************/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RequestSystem
{
    class BDItemCombo
    {
        //Destructor da Classe
        ~BDItemCombo()
        {

        }

        /***********************************************************************
         *        Método: Incluir
         *     Parametro: Objeto ItemCombo
         *          Obs.: Responsável por incluir um registro na tabela ItemCombo.
         *   Dt. Criação: 08/07/2022
         * Dt. Alteração: --
         *    Criada por: KappyS, Luiz
         ***********************************************************************/
        public int Incluir(ItemCombo pobj_ItemCombo)
        {
            //(08/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(08/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "INSERT INTO TB_ITEMCOMBO " +
                                   "( " +
                                   "I_COD_COMBO, " +
                                   "I_COD_PRODUTO, " +
                                   "I_QTD_PRODUTO, " +
                                   "D_SUBVLR_ITEMCOMBO " +
                                   ") " +
                                   "VALUES " +
                                   "( " +
                                   "@I_COD_COMBO, " +
                                   "@I_COD_PRODUTO, " +
                                   "@I_QTD_PRODUTO, " +
                                   "@D_SUBVLR_ITEMCOMBO " +
                                   "); " +
                                   " SELECT IDENT_CURRENT('TB_ITEMCOMBO') AS 'ID' ";

            //(08/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(08/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_COMBO", pobj_ItemCombo.Cod_Combo);
            obj_Cmd.Parameters.AddWithValue("@I_COD_PRODUTO", pobj_ItemCombo.Cod_Produto);
            obj_Cmd.Parameters.AddWithValue("@I_QTD_PRODUTO", pobj_ItemCombo.Qtd_Produto);
            obj_Cmd.Parameters.AddWithValue("@D_SUBVLR_ITEMCOMBO", pobj_ItemCombo.SubVlr_ItemCombo);



            try
            {
                //(08/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();
                //(08/07/2022 - KappyS, Luiz) Executar o comando de forma escalar
                int ID = Convert.ToInt16(obj_Cmd.ExecuteScalar());
                //(08/07/2022 - KappyS, Luiz) Fechar a Conexão
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
        *     Parametro: Objeto ItemCombo
        *          Obs.: Responsável por alterar um registro na tabela ItemCombo.
        *   Dt. Criação: 08/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public bool Alterar(ItemCombo pobj_ItemCombo)
        {
            //(08/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(08/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "UPDATE TB_ITEMCOMBO SET " +
                                   "I_COD_COMBO = @I_COD_COMBO, " +
                                   "I_COD_PRODUTO  = @I_COD_PRODUTO, " +
                                   "I_QTD_PRODUTO = @I_QTD_PRODUTO, " +
                                   "D_SUBVLR_ITEMCOMBO = @D_SUBVLR_ITEMCOMBO " +
                                   "WHERE I_COD_ITEMCOMBO = @I_COD_ITEMCOMBO;";


            //(08/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(08/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_ITEMCOMBO", pobj_ItemCombo.Cod_ItemCombo);
            obj_Cmd.Parameters.AddWithValue("@I_COD_COMBO", pobj_ItemCombo.Cod_Combo);
            obj_Cmd.Parameters.AddWithValue("@I_COD_PRODUTO", pobj_ItemCombo.Cod_Produto);
            obj_Cmd.Parameters.AddWithValue("@I_QTD_PRODUTO", pobj_ItemCombo.Qtd_Produto);
            obj_Cmd.Parameters.AddWithValue("@D_SUBVLR_ITEMCOMBO", pobj_ItemCombo.SubVlr_ItemCombo);

            try
            {
                //(08/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();
                //(08/07/2022 - KappyS, Luiz) Executar o comando de forma escalar
                obj_Cmd.ExecuteNonQuery();
                //(08/07/2022 - KappyS, Luiz) Fechar a Conexão
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
        *     Parametro: Objeto ItemCombo
        *          Obs.: Responsável por Excluir um registro na tabela ItemCombo.
        *   Dt. Criação: 08/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public bool Excluir(ItemCombo pobj_ItemCombo)
        {
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());
            string s_SQL_Comando = "DELETE FROM TB_ITEMCOMBO " +
                                   "WHERE I_COD_ITEMCOMBO = @I_COD_ITEMCOMBO;";
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);
            obj_Cmd.Parameters.AddWithValue("@I_COD_ITEMCOMBO", pobj_ItemCombo.Cod_ItemCombo);
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
        *        Método: FindAllByCodItemCombo
        *     Parametro: Objeto ItemCombo
        *          Obs.: Responsável por buscar um registro na tabela ItemCombo.
        *   Dt. Criação: 08/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public ItemCombo FindByCodItemCombo(ItemCombo pobj_ItemCombo)
        {
            //(08/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(08/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_ITEMCOMBO " +
                                   "WHERE I_COD_ITEMCOMBO = @I_COD_ITEMCOMBO;";


            //(08/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(08/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_ITEMCOMBO", pobj_ItemCombo.Cod_ItemCombo);

            try
            {
                //(08/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(08/07/2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_ItemCombo.Cod_ItemCombo = Convert.ToInt16(obj_Dtr["I_COD_ITEMCOMBO"]);
                    pobj_ItemCombo.Cod_Combo = Convert.ToInt16(obj_Dtr["I_COD_COMBO"]);
                    pobj_ItemCombo.Cod_Produto = Convert.ToInt16(obj_Dtr["I_COD_PRODUTO"]);
                    pobj_ItemCombo.Qtd_Produto = Convert.ToInt16(obj_Dtr["I_QTD_PRODUTO"]);
                    pobj_ItemCombo.SubVlr_ItemCombo = Convert.ToDouble(obj_Dtr["D_SUBVLR_ITEMCOMBO"]);
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_ItemCombo;
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
        *        Método: FindAllItemCombo
        *          Obs.: Responsável por buscar todos os registros na tabela ItemCombo.
        *   Dt. Criação: 08/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public List<ItemCombo> FindAllItemCombo()
        {
            //(08/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(08/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_ITEMCOMBO ";

            //(08/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            try
            {
                //(08/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(08/07/2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                //(08/07/2022 - KappyS, Luiz) Cria a Lista para receber os alunos da Tabela
                List<ItemCombo> Lista = new List<ItemCombo>();

                if (obj_Dtr.HasRows)
                {
                    //(08/07/2022 - KappyS, Luiz) Enquanto tiver linha, faça.
                    while (obj_Dtr.Read())
                    {
                        ItemCombo obj_ItemCombo = new ItemCombo();
                        obj_ItemCombo.Cod_ItemCombo = Convert.ToInt16(obj_Dtr["I_COD_ITEMCOMBO"]);
                        obj_ItemCombo.Cod_Combo = Convert.ToInt16(obj_Dtr["I_COD_COMBO"]);
                        obj_ItemCombo.Cod_Produto = Convert.ToInt16(obj_Dtr["I_COD_PRODUTO"]);
                        obj_ItemCombo.Qtd_Produto= Convert.ToInt16(obj_Dtr["I_QTD_PRODUTO"]);
                        obj_ItemCombo.SubVlr_ItemCombo = Convert.ToDouble(obj_Dtr["D_SUBVLR_ITEMCOMBO"]);
                        Lista.Add(obj_ItemCombo);
                    }
                    //(08/07/2022 - KappyS, Luiz) Fecho a conexão com o BD
                    obj_Con.Close();

                    //(08/07/2022 - KappyS, Luiz) Fecho o DataReader
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
        *        Método: FindAllItemCombo
        *          Obs.: Responsável por buscar todos os registros na tabela ItemCombo.
        *   Dt. Criação: 08/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public List<ItemCombo> FindAllCodCombo(ItemCombo pobj_ItemCombo)
        {
            //(08/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(08/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_ITEMCOMBO "+
                                   "WHERE I_COD_COMBO = @I_COD_COMBO;";

            //(08/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            obj_Cmd.Parameters.AddWithValue("@I_COD_COMBO", pobj_ItemCombo.Cod_Combo);

            try
            {
                //(08/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(08/07/2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                //(08/07/2022 - KappyS, Luiz) Cria a Lista para receber os alunos da Tabela
                List<ItemCombo> Lista = new List<ItemCombo>();

                if (obj_Dtr.HasRows)
                {
                    //(08/07/2022 - KappyS, Luiz) Enquanto tiver linha, faça.
                    while (obj_Dtr.Read())
                    {
                        ItemCombo obj_ItemCombo = new ItemCombo();
                        obj_ItemCombo.Cod_ItemCombo = Convert.ToInt16(obj_Dtr["I_COD_ITEMCOMBO"]);
                        obj_ItemCombo.Cod_Combo = Convert.ToInt16(obj_Dtr["I_COD_COMBO"]);
                        obj_ItemCombo.Cod_Produto = Convert.ToInt16(obj_Dtr["I_COD_PRODUTO"]);
                        obj_ItemCombo.Qtd_Produto = Convert.ToInt16(obj_Dtr["I_QTD_PRODUTO"]);
                        obj_ItemCombo.SubVlr_ItemCombo = Convert.ToDouble(obj_Dtr["D_SUBVLR_ITEMCOMBO"]);
                        Lista.Add(obj_ItemCombo);
                    }
                    //(08/07/2022 - KappyS, Luiz) Fecho a conexão com o BD
                    obj_Con.Close();

                    //(08/07/2022 - KappyS, Luiz) Fecho o DataReader
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