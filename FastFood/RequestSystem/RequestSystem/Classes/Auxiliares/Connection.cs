/* ***********************************************************************************************
 *          Nome: Connection
 *          obs.: Representa a classe de Conexão dom o Banco de Dados. 
 *   Dt. Criação: 06/07/2022
 * Dt. Alteração: --
 *    Criada por: KappyS, Luiz
 * ************************************************************************************************/
namespace RequestSystem
{
    public class Connection
    {
        //(06/07/2022 - KappyS, Luiz) Metodo da classe que retorna o caminho do BD.
        public static string ConectionPath()
        {
            return @"Data Source=(LocalDB)\MSSQLLocalDB; AttachDBFilename=C:\Users\giovanni.mstefani\Desktop\Fast Food - Atualizado\RequestSystem\RequestSystem\Database1.mdf;Integrated Security = True; Connect Timeout = 15";
        }
    }
}