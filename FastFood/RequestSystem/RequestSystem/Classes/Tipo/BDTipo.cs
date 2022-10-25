/***********************************************************************
 *          Nome: BDTipo
 *          obs.: Representa a classe de Banco de Dados Tipo. 
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
    class BDTipo
    {
        //Destructor da Classe
        ~BDTipo()
        {

        }

        /***********************************************************************
         *        Método: Incluir
         *     Parametro: Objeto Tipo
         *          Obs.: Responsável por incluir um registro na tabela Tipo.
         *   Dt. Criação: 07/07/2022
         * Dt. Alteração: --
         *    Criada por: KappyS, Luiz
         ***********************************************************************/
        public int Incluir(Tipo pobj_Tipo)
        {
            //(07/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(07/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "INSERT INTO TB_TIPO " +
                                   "( " +
                                   "S_NM_TIPO " +
                                   ") " +
                                   "VALUES " +
                                   "( " +
                                   "@S_NM_TIPO " +
                                   "); " +
                                   " SELECT IDENT_CURRENT('TB_TIPO') AS 'ID' ";

            //(07/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(07/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@S_NM_TIPO", pobj_Tipo.Nm_Tipo);

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
        *     Parametro: Objeto Tipo
        *          Obs.: Responsável por alterar um registro na tabela Tipo.
        *   Dt. Criação: 07/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public bool Alterar(Tipo pobj_Tipo)
        {
            //(07/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(07/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "UPDATE TB_TIPO SET " +
                                   "S_NM_TIPO = @S_NM_TIPO " +
                                   "WHERE I_COD_TIPO = @I_COD_TIPO;";


            //(07/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(07/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_TIPO", pobj_Tipo.Cod_Tipo);
            obj_Cmd.Parameters.AddWithValue("@S_NM_TIPO", pobj_Tipo.Nm_Tipo);

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
        *     Parametro: Objeto Tipo
        *          Obs.: Responsável por Excluir um registro na tabela Tipo.
        *   Dt. Criação: 07/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public bool Excluir(Tipo pobj_Tipo)
        {
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());
            string s_SQL_Comando = "DELETE FROM TB_TIPO " +
                                   "WHERE I_COD_TIPO = @I_COD_TIPO;";
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);
            obj_Cmd.Parameters.AddWithValue("@I_COD_TIPO", pobj_Tipo.Cod_Tipo);
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
        *        Método: FindByUNmTipo
        *     Parametro: Objeto Tipo
        *          Obs.: Responsável por buscar um registro na tabela Tipo.
        *   Dt. Criação: 07/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public Tipo FindByUNmTipo(Tipo pobj_Tipo)
        {
            //(07/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(07/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_TIPO" +
                                   "WHERE S_NM_TIPO = @S_NM_TIPO;";


            //(07/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(07/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@S_NM_TIPO", pobj_Tipo.Nm_Tipo);

            try
            {
                //(07/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(07/07/2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_Tipo.Cod_Tipo = Convert.ToInt16(obj_Dtr["I_COD_TIPO"]);
                    pobj_Tipo.Nm_Tipo = obj_Dtr["S_NM_TIPO"].ToString();
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_Tipo;
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
        *        Método: FindByCodTipo
        *     Parametro: Objeto Tipo
        *          Obs.: Responsável por buscar um registro na tabela Tipo.
        *   Dt. Criação: 07/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public Tipo FindByCodTipo(Tipo pobj_Tipo)
        {
            //(07/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(07/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_TIPO " +
                                   "WHERE I_COD_TIPO = @I_COD_TIPO;";


            //(07/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(07/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_TIPO", pobj_Tipo.Cod_Tipo);

            try
            {
                //(07/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(07/07/2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_Tipo.Cod_Tipo = Convert.ToInt16(obj_Dtr["I_COD_TIPO"]);
                    pobj_Tipo.Nm_Tipo = obj_Dtr["S_NM_TIPO"].ToString();
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_Tipo;
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
                *        Método: FindAllTipo
                *          Obs.: Responsável por buscar todos os registros na tabela UC.
                *   Dt. Criação: 27/07/2022
                * Dt. Alteração: --
                *    Criada por: KappyS, Luiz 
                ***********************************************************************/
        public List<Tipo> FindAllTipo()
        {
            //(27/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(27/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_TIPO ";

            //(27/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            try
            {
                //(27/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(27/07/2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                //(27/07/2022 - KappyS, Luiz) Cria a Lista para receber os alunos da Tabela
                List<Tipo> Lista = new List<Tipo>();

                if (obj_Dtr.HasRows)
                {
                    //(27/07/2022 - KappyS, Luiz) Enquanto tiver linha, faça.
                    while (obj_Dtr.Read())
                    {
                        Tipo obj_Tipo = new Tipo();
                        obj_Tipo.Cod_Tipo = Convert.ToInt16(obj_Dtr["I_COD_TIPO"]);
                        obj_Tipo.Nm_Tipo = obj_Dtr["S_NM_TIPO"].ToString();
               
                        Lista.Add(obj_Tipo);
                    }
                    //(27/07/2022 - KappyS, Luiz) Fecho a conexão com o BD
                    obj_Con.Close();

                    //(27/07/2022 - KappyS, Luiz) Fecho o DataReader
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