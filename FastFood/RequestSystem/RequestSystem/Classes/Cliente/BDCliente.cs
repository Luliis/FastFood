/***********************************************************************
 *          Nome: BDCliente
 *          obs.: Representa a classe de Banco de Dados Cliente. 
 *                A Classe utiliza o objeto Connection para acessar o BD
 *   Dt. Criação: 06/07/2022
 * Dt. Alteração: --
 *    Criada por:KappyS, Luiz
 * *********************************************************************/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RequestSystem
{
    class BDCliente
    {
        //Destructor da Classe
        ~BDCliente()
        {

        }

        /***********************************************************************
         *        Método: Incluir
         *     Parametro: Objeto Cliente
         *          Obs.: Responsável por incluir um registro na tabela Cliente.
         *   Dt. Criação: 06/07/2022
         * Dt. Alteração: --
         *    Criada por: KappyS, Luiz
         ***********************************************************************/
        public int Incluir(Cliente pobj_Cliente)
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "INSERT INTO TB_CLIENTE " +
                                   "( " +
                                   "S_NM_CLIENTE, " +
                                   "S_CPF_CLIENTE " +
                                   ") " +
                                   "VALUES " +
                                   "( " +
                                   "@S_NM_CLIENTE, " +
                                   "@S_CPF_CLIENTE " +
                                   "); " +
                                   " SELECT IDENT_CURRENT('TB_CLIENTE') AS 'ID' ";

            //(19 / 05 / 2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(19 / 05 / 2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@S_NM_CLIENTE", pobj_Cliente.Nm_Cliente);
            obj_Cmd.Parameters.AddWithValue("@S_CPF_CLIENTE", pobj_Cliente.CPF_Cliente);

            try
            {
                //(19 / 05 / 2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();
                //(19 / 05 / 2022 - KappyS, Luiz) Executar o comando de forma escalar
                int ID = Convert.ToInt16(obj_Cmd.ExecuteScalar());
                //(19 / 05 / 2022 - KappyS, Luiz) Fechar a Conexão
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
        *     Parametro: Objeto Cliente
        *          Obs.: Responsável por alterar um registro na tabela Cliente.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public bool Alterar(Cliente pobj_Cliente)
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "UPDATE TB_CLIENTE SET " +
                                   "S_NM_CLIENTE = @S_NM_CLIENTE, " +
                                   "S_CPF_CLIENTE  = @S_CPF_CLIENTE " +
                                   "WHERE I_COD_CLIENTE = @I_COD_CLIENTE;";


            //(19 / 05 / 2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(19 / 05 / 2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Cliente.Cod_Cliente);
            obj_Cmd.Parameters.AddWithValue("@S_NM_CLIENTE", pobj_Cliente.Nm_Cliente);
            obj_Cmd.Parameters.AddWithValue("@S_CPF_CLIENTE", pobj_Cliente.CPF_Cliente);

            try
            {
                //(19 / 05 / 2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();
                //(19 / 05 / 2022 - KappyS, Luiz) Executar o comando de forma escalar
                obj_Cmd.ExecuteNonQuery();
                //(19 / 05 / 2022 - KappyS, Luiz) Fechar a Conexão
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
        *     Parametro: Objeto Cliente
        *          Obs.: Responsável por Excluir um registro na tabela Cliente.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public bool Excluir(Cliente pobj_Cliente)
        {
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());
            string s_SQL_Comando = "DELETE FROM TB_CLIENTE " +
                                   "WHERE I_COD_CLIENTE = @I_COD_CLIENTE;";
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);
            obj_Cmd.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Cliente.Cod_Cliente);
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
        *        Método: FindByCodCliente
        *     Parametro: Objeto Cliente
        *          Obs.: Responsável por buscar um registro na tabela Cliente.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public Cliente FindByCodCliente(Cliente pobj_Cliente)
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_CLIENTE " +
                                   "WHERE I_COD_CLIENTE = @I_COD_CLIENTE;";


            //(19 / 05 / 2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(19 / 05 / 2022 - KappyS, Luiz) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Cliente.Cod_Cliente);

            try
            {
                //(19 / 05 / 2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(19 / 05 / 2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();
                    pobj_Cliente.Cod_Cliente = Convert.ToInt16(obj_Dtr["I_COD_CLIENTE"]);
                    pobj_Cliente.Nm_Cliente = obj_Dtr["S_NM_CLIENTE"].ToString();
                    pobj_Cliente.CPF_Cliente = obj_Dtr["S_CPF_CLIENTE"].ToString();
                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_Cliente;
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
        *        Método: FindAllCliente
        *          Obs.: Responsável por buscar todos os registros na tabela Cliente.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Luiz
        ***********************************************************************/
        public List<Cliente> FindAllCliente()
        {
            //(06/07/2022 - KappyS, Luiz) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Luiz) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_CLIENTE ";

            //(06/07/2022 - KappyS, Luiz) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            try
            {
                //(06/07/2022 - KappyS, Luiz) Abrir a Conexão
                obj_Con.Open();

                //(06/07/2022 - KappyS, Luiz) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                //(06/07/2022 - KappyS, Luiz) Cria a Lista para receber os alunos da Tabela
                List<Cliente> Lista = new List<Cliente>();

                if (obj_Dtr.HasRows)
                {
                    //(06/07/2022 - KappyS, Luiz) Enquanto tiver linha, faça.
                    while (obj_Dtr.Read())
                    {
                        Cliente obj_Cliente = new Cliente();
                        obj_Cliente.Cod_Cliente = Convert.ToInt16(obj_Dtr["I_COD_CLIENTE"]);
                        obj_Cliente.Nm_Cliente = obj_Dtr["S_NM_CLIENTE"].ToString();
                        obj_Cliente.CPF_Cliente = obj_Dtr["S_CPF_CLIENTE"].ToString();
                        Lista.Add(obj_Cliente);
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