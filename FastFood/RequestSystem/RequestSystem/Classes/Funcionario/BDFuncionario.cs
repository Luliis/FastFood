/***********************************************************************
 *          Nome: BDFuncionario
 *          obs.: Representa a classe de Banco de Dados Funcionario. 
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
    class BDFuncionario
    {
        //Destructor da Classe
        ~BDFuncionario()
        {

        }

        /***********************************************************************
         *        Método: Incluir
         *     Parametro: Objeto Funcionario
         *          Obs.: Responsável por incluir um registro na tabela Funcionario.
         *   Dt. Criação: 06/07/2022
         * Dt. Alteração: --
         *    Criada por: KappyS, Luiz
         ***********************************************************************/
        public int Incluir(Funcionario pobj_Funcionario)
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "INSERT INTO TB_FUNCIONARIO " +
                                   "( " +
                                   "S_UNM_FUNCIONARIO, " +
                                   "S_PASS_FUNCIONARIO " +
                                   ") " +
                                   "VALUES " +
                                   "( " +
                                   "@S_UNM_FUNCIONARIO, " +
                                   "@S_PASS_FUNCIONARIO " +
                                   "); " +
                                   " SELECT IDENT_CURRENT('TB_FUNCIONARIO') AS 'ID' ";

            //(06/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(06/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@S_UNM_FUNCIONARIO", pobj_Funcionario.UNm_Funcionario);
            obj_Cmd.Parameters.AddWithValue("@S_PASS_FUNCIONARIO", pobj_Funcionario.Pass_Funcionario);

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
        *     Parametro: Objeto Funcionario
        *          Obs.: Responsável por alterar um registro na tabela Funcionario.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public bool Alterar(Funcionario pobj_Funcionario)
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "UPDATE TB_FUNCIONARIO SET " +
                                   "S_UNM_FUNCIONARIO = @S_UNM_FUNCIONARIO," +
                                   "S_PASS_FUNCIONARIO = @S_PASS_FUNCIONARIO " +
                                   "WHERE I_COD_FUNCIONARIO = @I_COD_FUNCIONARIO;";


            //(06/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(06/07/2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_FUNCIONARIO", pobj_Funcionario.Cod_Funcionario);
            obj_Cmd.Parameters.AddWithValue("@S_UNM_FUNCIONARIO", pobj_Funcionario.UNm_Funcionario);
            obj_Cmd.Parameters.AddWithValue("@S_PASS_FUNCIONARIO", pobj_Funcionario.Pass_Funcionario);

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
        *     Parametro: Objeto Funcionario
        *          Obs.: Responsável por Excluir um registro na tabela Funcionario.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public bool Excluir(Funcionario pobj_Funcionario)
        {
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());
            string s_SQL_Comando = "DELETE FROM TB_FUNCIONARIO " +
                                   "WHERE I_COD_FUNCIONARIO = @I_COD_FUNCIONARIO;";
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);
            obj_Cmd.Parameters.AddWithValue("@I_COD_FUNCIONARIO", pobj_Funcionario.Cod_Funcionario);
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
        *        Método: FindByCodFuncionario
        *     Parametro: Objeto Funcionario
        *          Obs.: Responsável por buscar um registro na tabela Funcionario.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public Funcionario FindByCodFuncionario(Funcionario pobj_Funcionario)
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_FUNCIONARIO " +
                                   "WHERE I_COD_FUNCIONARIO = @I_COD_FUNCIONARIO;";


            //(19 / 05 / 2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(19 / 05 / 2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_FUNCIONARIO", pobj_Funcionario.Cod_Funcionario);

            try
            {
                //(19 / 05 / 2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(19 / 05 / 2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();

                    pobj_Funcionario.Cod_Funcionario = Convert.ToInt16(obj_Dtr["I_COD_FUNCIONARIO"]);
                    pobj_Funcionario.UNm_Funcionario = obj_Dtr["S_UNM_FUNCIONARIO"].ToString();
                    pobj_Funcionario.Pass_Funcionario = obj_Dtr["S_Pass_FUNCIONARIO"].ToString();
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_Funcionario;
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
        *        Método: FindByUNmFuncionario
        *     Parametro: Objeto Usuario
        *          Obs.: Responsável por buscar um registro na tabela Funcionario.
        *   Dt. Criação: 09/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        public Funcionario FindByUNmFuncionario(Funcionario pobj_Funcionario)
        {
            //(09/06/2022 - mFacine) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(09/06/2022 - mFacine) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_FUNCIONARIO " +
                                   "WHERE S_UNM_FUNCIONARIO = @S_UNM_FUNCIONARIO;";


            //(09/06/2022 - mFacine) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(09/06/2022 - mFacine) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@S_UNM_FUNCIONARIO", pobj_Funcionario.UNm_Funcionario);

            try
            {
                //(09/06/2022 - mFacine) Abrir a Conexão
                obj_Con.Open();

                //(09/06/2022 - mFacine) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_Funcionario.Cod_Funcionario = Convert.ToInt16(obj_Dtr["I_COD_FUNCIONARIO"]);
                    pobj_Funcionario.UNm_Funcionario = obj_Dtr["S_UNM_FUNCIONARIO"].ToString();
                    pobj_Funcionario.Pass_Funcionario = obj_Dtr["S_PASS_FUNCIONARIO"].ToString();
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_Funcionario;
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
        *        Método: FindAllFuncionario
        *          Obs.: Responsável por buscar todos os registros na tabela Funcionario.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public List<Funcionario> FindAllFuncionario()
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_FUNCIONARIO ";

            //(06/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            try
            {
                //(06/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(06/07/2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                //(06/07/2022 - KappyS, Luiz) Cria a Lista para receber os alunos da Tabela
                List<Funcionario> Lista = new List<Funcionario>();

                if (obj_Dtr.HasRows)
                {
                    //(06/07/2022 - KappyS, Luiz) Enquanto tiver linha, faça.
                    while (obj_Dtr.Read())
                    {
                        Funcionario obj_Funcionario = new Funcionario();

                        obj_Funcionario.Cod_Funcionario = Convert.ToInt16(obj_Dtr["I_COD_FUNCIONARIO"]);
                        obj_Funcionario.UNm_Funcionario = obj_Dtr["S_UNM_FUNCIONARIO"].ToString();
                        obj_Funcionario.Pass_Funcionario = obj_Dtr["S_Pass_FUNCIONARIO"].ToString();
                        Lista.Add(obj_Funcionario);
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