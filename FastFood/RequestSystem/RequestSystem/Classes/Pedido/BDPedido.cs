/***********************************************************************
 *          Nome: BDPedido
 *          obs.: Representa a classe de Banco de Dados Pedido. 
 *                A Classe utiliza o objeto Connection para acessar o BD
 *   Dt. Criação: 06/07/2022
 * Dt. Alteração: --
 *    Criada por: KappyS, Kappy
 * *********************************************************************/
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RequestSystem
{
    class BDPedido
    {
        //Destructor da Classe
        ~BDPedido()
        {

        }

        /***********************************************************************
         *        Método: Incluir
         *     Parametro: Objeto Pedido
         *          Obs.: Responsável por incluir um registro na tabela Pedido.
         *   Dt. Criação: 06/07/2022
         * Dt. Alteração: --
         *    Criada por: KappyS, Kappy
         ***********************************************************************/
        public int Incluir(Pedido pobj_Pedido)
        {
            //(06/07/2022 - KappyS, Kappy) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Kappy) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "INSERT INTO TB_PEDIDO " +
                                   "( " +
                                   "I_COD_CLIENTE, " +
                                   "D_VLRTOT_PEDIDO " +
                                   ") " +
                                   "VALUES " +
                                   "( " +
                                   "@I_COD_CLIENTE, " +
                                   "@D_VLRTOT_PEDIDO " +
                                   "); " +
                                   " SELECT IDENT_CURRENT('TB_PEDIDO') AS 'ID' ";

            //(06/07/2022 - KappyS, Kappy) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(06/07/2022 - KappyS, Kappy) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Pedido.Cod_Cliente);
            obj_Cmd.Parameters.AddWithValue("@D_VLRTOT_PEDIDO", pobj_Pedido.VlrTot_Pedido);

            try
            {
                //(06/07/2022 - KappyS, Kappy) Abrir a Conexão
                obj_Con.Open();
                //(06/07/2022 - KappyS, Kappy) Executar o comando de forma escalar
                int ID = Convert.ToInt16(obj_Cmd.ExecuteScalar());
                //(06/07/2022 - KappyS, Kappy) Fechar a Conexão
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
        *     Parametro: Objeto Pedido
        *          Obs.: Responsável por alterar um registro na tabela Pedido.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Kappy
        ***********************************************************************/
        public bool Alterar(Pedido pobj_Pedido)
        {
            //(06/07/2022 - KappyS, Kappy) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Kappy) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "UPDATE TB_PEDIDO SET " +
                                   "I_COD_CLIENTE = @I_COD_CLIENTE, " +
                                   "D_VLRTOT_PEDIDO  = @D_VLRTOT_PEDIDO " +
                                   "WHERE I_COD_PEDIDO = @I_COD_PEDIDO;";


            //(06/07/2022 - KappyS, Kappy) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(06/07/2022 - KappyS, Kappy) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_PEDIDO", pobj_Pedido.Cod_Pedido);
            obj_Cmd.Parameters.AddWithValue("@I_COD_CLIENTE", pobj_Pedido.Cod_Cliente);
            obj_Cmd.Parameters.AddWithValue("@D_VLRTOT_PEDIDO", pobj_Pedido.VlrTot_Pedido);

            try
            {
                //(06/07/2022 - KappyS, Kappy) Abrir a Conexão
                obj_Con.Open();
                //(06/07/2022 - KappyS, Kappy) Executar o comando de forma escalar
                obj_Cmd.ExecuteNonQuery();
                //(06/07/2022 - KappyS, Kappy) Fechar a Conexão
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
        *     Parametro: Objeto Pedido
        *          Obs.: Responsável por Excluir um registro na tabela Pedido.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Kappy
        ***********************************************************************/
        public bool Excluir(Pedido pobj_Pedido)
        {
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());
            string s_SQL_Comando = "DELETE FROM TB_PEDIDO " +
                                   "WHERE I_COD_PEDIDO = @I_COD_PEDIDO;";
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);
            obj_Cmd.Parameters.AddWithValue("@I_COD_PEDIDO", pobj_Pedido.Cod_Pedido);
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
        *        Método: FindByCodPedido
        *     Parametro: Objeto Pedido
        *          Obs.: Responsável por buscar um registro na tabela Pedido.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Kappy
        ***********************************************************************/
        public Pedido FindByCodPedido(Pedido pobj_Pedido)
        {
            //(06/07/2022 - KappyS, Kappy) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Kappy) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_PEDIDO " +
                                   "WHERE I_COD_PEDIDO = @I_COD_PEDIDO;";


            //(06/07/2022 - KappyS, Kappy) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            //(06/07/2022 - KappyS, Kappy) Passo os parametros dos dados dos atributos para a SQL
            obj_Cmd.Parameters.AddWithValue("@I_COD_PEDIDO", pobj_Pedido.Cod_Pedido);

            try
            {
                //(06/07/2022 - KappyS, Kappy) Abrir a Conexão
                obj_Con.Open();

                //(06/07/2022 - KappyS, Kappy) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                if (obj_Dtr.HasRows)
                {
                    obj_Dtr.Read();

                    pobj_Pedido.Cod_Pedido = Convert.ToInt16(obj_Dtr["I_COD_PEDIDO"]);
                    pobj_Pedido.Cod_Cliente = Convert.ToInt16(obj_Dtr["I_COD_CLIENTE"]);
                    pobj_Pedido.VlrTot_Pedido = Convert.ToDouble(obj_Dtr["D_VLRTOT_PEDIDO"]);

                    obj_Con.Close();
                    obj_Dtr.Close();
                    return pobj_Pedido;
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
        *        Método: FindAllPedido
        *          Obs.: Responsável por buscar todos os registros na tabela Pedido.
        *   Dt. Criação: 06/07/2022
        * Dt. Alteração: --
        *    Criada por: KappyS, Kappy
        ***********************************************************************/
        public List<Pedido> FindAllPedido()
        {
            //(06/07/2022 - KappyS, Kappy) Criar o objeto de conexão com o banco.
            SqlConnection obj_Con = new SqlConnection(Connection.ConectionPath());

            //(06/07/2022 - KappyS, Kappy) A instrução de comando da SQL para o BD
            string s_SQL_Comando = "SELECT * FROM TB_PEDIDO ";

            //(06/07/2022 - KappyS, Kappy) Objeto que executará a instrução SQL acima.
            SqlCommand obj_Cmd = new SqlCommand(s_SQL_Comando, obj_Con);

            try
            {
                //(06/07/2022 - KappyS, Kappy) Abrir a Conexão
                obj_Con.Open();

                //(06/07/2022 - KappyS, Kappy) Cria o objeto de leitura
                SqlDataReader obj_Dtr = obj_Cmd.ExecuteReader();

                //(06/07/2022 - KappyS, Kappy) Cria a Lista para receber os alunos da Tabela
                List<Pedido> Lista = new List<Pedido>();

                if (obj_Dtr.HasRows)
                {
                    //(06/07/2022 - KappyS, Kappy) Enquanto tiver linha, faça.
                    while (obj_Dtr.Read())
                    {
                        Pedido obj_Pedido = new Pedido();
                        obj_Pedido.Cod_Pedido = Convert.ToInt16(obj_Dtr["I_COD_PEDIDO"]);
                        obj_Pedido.Cod_Cliente = Convert.ToInt16(obj_Dtr["I_COD_CLIENTE"]);
                        obj_Pedido.VlrTot_Pedido = Convert.ToDouble(obj_Dtr["D_VLRTOT_PEDIDO"]);
                        Lista.Add(obj_Pedido);
                    }
                    //(06/07/2022 - KappyS, Kappy) Fecho a conexão com o BD
                    obj_Con.Close();

                    //(06/07/2022 - KappyS, Kappy) Fecho o DataReader
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