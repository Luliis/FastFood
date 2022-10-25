/***********************************************************************
 *          Nome: BDProduto
 *          obs.: Representa a classe de Banco de Dados Produto. 
 *                A Classe utiliza o objeto Connection para acessar o BD
 *   Dt. Criação: 07/07/2022
 * Dt. Alteração: --
 *    Criada por: KappyS, Luiz
 * *********************************************************************/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RequestSystem
{
    class BDProduto
    {
        //Destructor da Classe
        ~BDProduto()
        {

        }

        /***********************************************************************
         *        Método: Incluir
         *     Parametro: Objeto Produto
         *          Obs.: Responsável por incluir um registro na tabela Produto.
         *   Dt. Criação: 07/07/2022
         * Dt. Alteração: --
         *    Criada por: KappyS, Luiz
         ***********************************************************************/
        public int Incluir(Produto pobj_Produto)
        {
            //(07/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(07/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "INSERT INTO TB_PRODUTO " +
                                   "( " +
                                   "I_COD_TIPO, " +
                                   "S_NM_PRODUTO, " +
                                   "S_DESC_PRODUTO, " +
                                   "D_VLRUNI_PRODUTO " +
                                   ") " +
                                   "VALUES " +
                                   "( " +
                                   "@I_COD_TIPO, " +
                                   "@S_NM_PRODUTO, " +
                                   "@S_DESC_PRODUTO, " +
                                   "@D_VLRUNI_PRODUTO " +
                                   "); " +
                                   " SELECT IDENT_CURRENT('TB_PRODUTO') AS 'ID' ";

            //(07/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(07/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_TIPO", pobj_Produto.Cod_Tipo);
            obj_Cmd.Parameters.AddWithValue("@S_NM_PRODUTO", pobj_Produto.Nm_Produto);
            obj_Cmd.Parameters.AddWithValue("@S_DESC_PRODUTO", pobj_Produto.Desc_Produto);
            obj_Cmd.Parameters.AddWithValue("@D_VLRUNI_PRODUTO", pobj_Produto.VlrUni_Produto);



            try
            {
                //(07/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();
                //(07/07/2022 - KappyS, Luiz) Executar o comando de forma escalar
                int ID = Convert.ToInt16(obj_Cmd.ExecuteScalar());
                //(07/07/2022 - KappyS, Luiz) Fechar a Conexão
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
        *     Parametro: Objeto Produto
        *          Obs.: Responsável por alterar um registro na tabela Produto.
        *   Dt. Criação: 07/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public bool Alterar(Produto pobj_Produto)
        {
            //(07/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(07/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "UPDATE TB_PRODUTO SET " +
                                   "I_COD_TIPO = @I_COD_TIPO, " +
                                   "S_NM_PRODUTO  = @S_NM_PRODUTO, " +
                                   "S_DESC_PRODUTO = @S_DESC_PRODUTO, " +
                                   "D_VLRUNI_PRODUTO = @D_VLRUNI_PRODUTO " +
                                   "WHERE I_COD_PRODUTO = @I_COD_PRODUTO;";


            //(07/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(07/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_PRODUTO", pobj_Produto.Cod_Produto);
            obj_Cmd.Parameters.AddWithValue("@I_COD_TIPO", pobj_Produto.Cod_Tipo);
            obj_Cmd.Parameters.AddWithValue("@S_NM_PRODUTO", pobj_Produto.Nm_Produto);
            obj_Cmd.Parameters.AddWithValue("@S_DESC_PRODUTO", pobj_Produto.Desc_Produto);
            obj_Cmd.Parameters.AddWithValue("@D_VLRUNI_PRODUTO", pobj_Produto.VlrUni_Produto);

            try
            {
                //(07/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();
                //(07/07/2022 - KappyS, Luiz) Executar o comando de forma escalar
                obj_Cmd.ExecuteNonQuery();
                //(07/07/2022 - KappyS, Luiz) Fechar a Conexão
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
        *     Parametro: Objeto Produto
        *          Obs.: Responsável por Excluir um registro na tabela Produto.
        *   Dt. Criação: 07/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public bool Excluir(Produto pobj_Produto)
        {
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());
            string s_SQL_Comando = "DELETE FROM TB_PRODUTO " +
                                   "WHERE I_COD_PRODUTO = @I_COD_PRODUTO;";
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);
            obj_Cmd.Parameters.AddWithValue("@I_COD_PRODUTO", pobj_Produto.Cod_Produto);
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
        *        Método: FindByCodProduto
        *     Parametro: Objeto Produto
        *          Obs.: Responsável por buscar um registro na tabela Produto.
        *   Dt. Criação: 07/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public Produto FindByCodProduto(Produto pobj_Produto)
        {
            //(07/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(07/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_PRODUTO " +
                                   "WHERE I_COD_PRODUTO = @I_COD_PRODUTO;";


            //(07/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(07/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_PRODUTO", pobj_Produto.Cod_Produto);

            try
            {
                //(07/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(07/07/2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_Produto.Cod_Produto = Convert.ToInt16(obj_Dtr["I_COD_PRODUTO"]);
                    pobj_Produto.Cod_Tipo = Convert.ToInt16(obj_Dtr["I_COD_TIPO"]);
                    pobj_Produto.Nm_Produto = obj_Dtr["S_NM_PRODUTO"].ToString();
                    pobj_Produto.Desc_Produto = obj_Dtr["S_DESC_PRODUTO"].ToString();
                    pobj_Produto.VlrUni_Produto = Convert.ToDouble(obj_Dtr["D_VLRUNI_PRODUTO"]);
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_Produto;
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
        *        Método: FindAllProduto
        *          Obs.: Responsável por buscar todos os registros na tabela Produto.
        *   Dt. Criação: 07/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public List<Produto> FindAllProduto()
        {
            //(07/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(07/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_PRODUTO ";

            //(07/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            try
            {
                //(07/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(07/07/2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                //(07/07/2022 - KappyS, Luiz) Cria a Lista para receber os alunos da Tabela
                List<Produto> Lista = new List<Produto>();

                if (obj_Dtr.HasRows)
                {
                    //(07/07/2022 - KappyS, Luiz) Enquanto tiver linha, faça.
                    while (obj_Dtr.Read())
                    {
                        Produto obj_Produto = new Produto();
                        obj_Produto.Cod_Produto = Convert.ToInt16(obj_Dtr["I_COD_PRODUTO"]);
                        obj_Produto.Cod_Tipo = Convert.ToInt16(obj_Dtr["I_COD_TIPO"]);
                        obj_Produto.Nm_Produto = obj_Dtr["S_NM_PRODUTO"].ToString();
                        obj_Produto.Desc_Produto = obj_Dtr["S_DESC_PRODUTO"].ToString();
                        obj_Produto.VlrUni_Produto = Convert.ToDouble(obj_Dtr["D_VLRUNI_PRODUTO"]); 
                        Lista.Add(obj_Produto);
                    }
                    //(07/07/2022 - KappyS, Luiz) Fecho a conexão com o BD
                    obj_Con.Close();

                    //(07/07/2022 - KappyS, Luiz) Fecho o DataReader
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