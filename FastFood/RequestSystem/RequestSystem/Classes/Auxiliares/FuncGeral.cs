/***********************************************************************
 *          Nome: FuncGeral
 *          obs.: Representa a classe de Funções Gerais. 
 *                A Classe possui metodos públicos que serão utilizados 
 *                por Formulários e Classes
 *   Dt. Criação: 27/05/2022
 * Dt. Alteração: --
 *    Criada por: mFacine (Monstro)
 * *********************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;


namespace RequestSystem
{
    class FuncGeral
    {
        /// <SUMMARY>
        /// Vetor de byte utilizados para a criptografia (chave externa)
        /// </SUMMARY>
        private static byte[] bIV = { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18, 0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };
        string path = Environment.CurrentDirectory;

        /// <summary>
        /// Representação de valor em base 64 (chave interna)
        /// O valor represanta a transformação para base64 de 
        /// um conjunto de 32 caracteres (8 * 32 - 256 bits)
        /// a chave é: "Criptografia com Rijndael / AES"
        /// </summary>
        private const string cryptoKey = "Q3JpcHRvZ3JhZmlhcyBjb20gUmluamRhZWwgLyBBRVM=";

        /***********************************************************************
        * NOME:            Criptografa        
        * METODO:          Criptografa o Password do usuário e retorna o 
        *                   Password criptografado
        * PARAMETRO:       String sPassWord
        * RETORNO:         String 
        * DT CRIAÇÃO:      27/05/2019    
        * DT ALTERAÇÃO:    -
        * ESCRITA POR:     Monstro (mFacine) 
        ***********************************************************************/
        public string Criptografa(string sPassWord)
        {
            try
            {
                //(27/05/2019-mfacine) Se a string não está vazia, executa a criptografia
                if (!string.IsNullOrEmpty(sPassWord))
                {
                    //(27/05/2019-mfacine) Cria instancias de vetores de bytes com as chaves                
                    byte[] bKey = Convert.FromBase64String(cryptoKey);
                    byte[] bText = new UTF8Encoding().GetBytes(sPassWord);

                    //(27/05/2019-mfacine) Instancia a classe de criptografia Rijndael
                    Rijndael rijndael = new RijndaelManaged();

                    //(27/05/2019 - mfacine)
                    // Define o tamanho da chave "256 = 8 * 32"                
                    // Lembre-se: chaves possíves:                
                    // 128 (16 caracteres), 192 (24 caracteres) e 256 (32 caracteres)                
                    rijndael.KeySize = 256;

                    //(27/05/2019 - mfacine)
                    // Cria o espaço de memória para guardar o valor criptografado:                
                    MemoryStream mStream = new MemoryStream();
                    // Instancia o encriptador                 
                    CryptoStream encryptor = new CryptoStream(
                        mStream,
                        rijndael.CreateEncryptor(bKey, bIV),
                        CryptoStreamMode.Write);

                    //(27/05/2019-mfacine)
                    // Faz a escrita dos dados criptografados no espaço de memória
                    encryptor.Write(bText, 0, bText.Length);
                    // Despeja toda a memória.                
                    encryptor.FlushFinalBlock();
                    // Pega o vetor de bytes da memória e gera a string criptografada                
                    return Convert.ToBase64String(mStream.ToArray());
                }
                else
                {
                    //(27/05/2019-mfacine) Se a string for vazia retorna nulo                
                    return null;
                }
            }
            catch (Exception ex)
            {
                //(27/05/2019-mfacine) Se algum erro ocorrer, dispara a exceção            
                throw new ApplicationException("Erro ao criptografar", ex);
            }
        }



        /*****************************************************************************
        * Nome           : DesCriptografa
        * Procedimento   : Descriptografa o password do usuário e retorna o 
        *                  pass descriptografado
        * Parametros     : sCriptoPassWord
        * Data  Criação  : 27/05/2018
        * Data Alteração : -
        * Escrito por    : mfacine
        * ***************************************************************************/
        public string DesCriptografa(string sCriptoPassWord)
        {
            try
            {
                //(27/05/2019-mfacine) Se a string não está vazia, executa a criptografia           
                if (!string.IsNullOrEmpty(sCriptoPassWord))
                {
                    //(27/05/2019-mfacine) Cria instancias de vetores de bytes com as chaves                
                    byte[] bKey = Convert.FromBase64String(cryptoKey);
                    byte[] bText = Convert.FromBase64String(sCriptoPassWord);

                    // Instancia a classe de criptografia Rijndael                
                    Rijndael rijndael = new RijndaelManaged();

                    //(27/05/2019-mfacine)
                    // Define o tamanho da chave "256 = 8 * 32"                
                    // Lembre-se: chaves possíves:                
                    // 128 (16 caracteres), 192 (24 caracteres) e 256 (32 caracteres)                
                    rijndael.KeySize = 256;

                    //(27/05/2019-mfacine) Cria o espaço de memória para guardar o valor DEScriptografado:               
                    MemoryStream mStream = new MemoryStream();

                    //(27/05/2019-mfacine) Instancia o Decriptador                 
                    CryptoStream decryptor = new CryptoStream(
                        mStream,
                        rijndael.CreateDecryptor(bKey, bIV),
                        CryptoStreamMode.Write);

                    //(27/05/2019-mfacine)
                    // Faz a escrita dos dados criptografados no espaço de memória   
                    decryptor.Write(bText, 0, bText.Length);
                    // Despeja toda a memória.                
                    decryptor.FlushFinalBlock();
                    // Instancia a classe de codificação para que a string venha de forma correta         
                    UTF8Encoding utf8 = new UTF8Encoding();
                    // Com o vetor de bytes da memória, gera a string descritografada em UTF8       
                    return utf8.GetString(mStream.ToArray());
                }
                else
                {
                    //(27/05/2019-mfacine) Se a string for vazia retorna nulo                
                    return null;
                }
            }
            catch (Exception ex)
            {
                //(27/05/2019-mfacine) Se algum erro ocorrer, dispara a exceção            
                throw new ApplicationException("Erro ao descriptografar", ex);
            }
        }

        /***********************************************************************
        *        Método: VerificaNulos
        *     Parametro: Formulário Ativo
        *          Obs.: Responsável por Verificar se os componentes editáveis 
        *          de texto estão nulos no formulários ativo.
        *   Dt. Criação: 09/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        public void VerificaNulos(Form pobj_Form)
        {
            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detail")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            if (((TextBox)ctrl).Text == "")
                            {
                                MessageBox.Show("Um campo não foi preenchido.", "ENTRADA INVALIDA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                ((TextBox)ctrl).Focus();
                                break;
                            }
                        }
                    }
                }
            }
        }

        /***********************************************************************
        *        Método: LimpaTela
        *     Parametro: Formulário Ativo
        *          Obs.: Responsável por Limpar os componentes editáveis dos 
        *                formulários.
        *   Dt. Criação: 27/05/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        public void LimpaTela(Form pobj_Form)
        {
            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detail")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is TextBox)
                        {
                            ((TextBox)ctrl).Clear();
                        }

                        if (ctrl is CheckBox)
                        {
                            ((CheckBox)ctrl).Checked = false;
                        }

                        if (ctrl is Label && Convert.ToInt16(ctrl.Tag) == 1)
                        {
                            ((Label)ctrl).Text = "";
                        }
                        
                        if (ctrl is MaskedTextBox)
                        {
                            ((MaskedTextBox)ctrl).Clear();
                        }
                    }
                }
            }
        }

        /***********************************************************************
        *        Método: HabilitaTela
        *     Parametro: Formulário Ativo e Booleano (True ou False)
        *          Obs.: Responsável por Habilitar os componentes editáveis dos 
        *                formulários.
        *   Dt. Criação: 01/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        public void HabilitaTela(Form pobj_Form, bool b_Hab)
        {
            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detail")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is TextBox && Convert.ToInt16(ctrl.Tag) != 1)
                        {
                            ((TextBox)ctrl).Enabled = b_Hab;
                        }

                        if (ctrl is CheckBox)
                        {
                            ((CheckBox)ctrl).Enabled = b_Hab;
                        }
                        if (ctrl is Button)
                        {
                            ((Button)ctrl).Enabled = b_Hab;
                        }
                        if (ctrl is MaskedTextBox)
                        {
                            ((MaskedTextBox)ctrl).Enabled = b_Hab;
                        }
                    }
                }
            }
        }

        /***********************************************************************
        *        Método: StatusBtn
        *     Parametro: Formulário Ativo e uma variável int
        *          Obs.: Responsável por trazer o Status dos botões na tela dos 
        *                formulários.
        *                Status (1, 2 ou 3)
        *                caso 1 -> btn_Novo será true e os demais false. 
        *                caso 2 -> os três primeiros serão true e os demais false.
        *                caso 3 -> os três primeiros serão false e os demais true.
        *                
        *   Dt. Criação: 01/06/2022
        * Dt. Alteração: --
        *    Criada por: mFacine (Monstro)
        ***********************************************************************/
        public void StatusBtn(Form pobj_Form, int pi_Status)
        {
            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Button")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        switch (pi_Status)
                        {
                            case 1:
                                {
                                    if (ctrl.Name == "btn_Novo")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Alterar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Excluir")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Confirmar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Cancelar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    break;
                                }

                            case 2:
                                {
                                    if (ctrl.Name == "btn_Novo")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Alterar")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Excluir")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Confirmar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Cancelar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    break;
                                }

                            case 3:
                                {

                                    if (ctrl.Name == "btn_Novo")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Alterar")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Excluir")
                                    {
                                        ctrl.Enabled = false;
                                    }

                                    if (ctrl.Name == "btn_Confirmar")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    if (ctrl.Name == "btn_Cancelar")
                                    {
                                        ctrl.Enabled = true;
                                    }

                                    break;
                                }
                        }
                    }
                }
            }
        }

        /****************************************************************************
        * Nome: : PopulaMask
        * Observações : Popula com uma máscara um MaskTextBox
        * Detalhe (pnl_Detail).
        * Parametro : Formulário
        * Dt. Criação: 18/08/2022
        * Dt. Alteração: --
        * Criada por: KappyS, Luiz
        ****************************************************************************/

        public void PopulaMask(Form pobj_Form)
        {
            bool TipoValida = true;

            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detail")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is MaskedTextBox)
                        {
                            switch (Convert.ToInt16(ctrl.Tag))
                            {
                                case 1:
                                    {
                                        int x = 0;
                                        ((MaskedTextBox)ctrl).Mask = "000,000";
                                        TipoValida = int.TryParse(ctrl.Text, out x);
                                        break;
                                    }
                                case 2:
                                    {
                                        double x = 0;
                                        ((MaskedTextBox)ctrl).Mask = "000.00";
                                        TipoValida = double.TryParse(ctrl.Text, out x);
                                        break;
                                    }
                                case 3:
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "00/00/0000";
                                        break;
                                    }
                                case 4:
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "00000-000";
                                        break;
                                    }

                                case 5:
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "000.000.000-00";
                                        break;
                                    }

                                case 6:
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "00.000.000/0000-00";
                                        break;
                                    }
                                case 7:
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "(00) 0000-0000";
                                        break;
                                    }
                                case 8:
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "(00) 00000-0000";
                                        break;
                                    }
                                case 9:
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "00:00";
                                        break;
                                    }
                                case 10:
                                    {
                                        ((MaskedTextBox)ctrl).Mask = "$ 000.00";
                                        break;
                                    }

                            }
                        }
                    }
                }
            }
        }

        public void GravaLog(string s_Txt)
        {
            try
            {

                using (StreamWriter sw = new StreamWriter(path + "log.txt", true))
                {
                    //Write a line of text
                    sw.WriteLine(DateTime.Now.ToString("dd/MM/yyyy") + " " + DateTime.Now.ToString("hh:mm") + " - " + s_Txt);

                    //Close the file
                    sw.Close();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        /****************************************************************************
        * Nome: : ValidaTela
        * Observações : Verifica se algum campo editável está vazio no painel
        * Detalhe (pnl_Detail).
        * Parametro : Formulário
        * Dt. Criação: 24/11/2021
        * Dt. Alteração: --
        * Criada por: Gui Barci
        ****************************************************************************/
        public bool ValidaTela(Form pobj_Form)
        {
            bool bValida = true;
            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detail")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is TextBox && ((TextBox)ctrl).Visible != false)
                        {
                            if (Convert.ToInt32(((TextBox)ctrl).Tag) != 1) 
                            {
                                if (((TextBox)ctrl).Text == "")
                                {
                                    ((TextBox)ctrl).Focus();
                                    bValida = false;
                                }
                            }
                            
                        }
                        
                        if (ctrl is MaskedTextBox)
                        {
                            if (((MaskedTextBox)ctrl).Text.Substring(0,1) == " ")
                            {
                                ((MaskedTextBox)ctrl).Focus();
                                bValida = false;
                            }
                        }
                    }
                }
            }
            if (!(bValida))
            {
                MessageBox.Show("Campo inválido, sem preenchimento.", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return bValida;
        }

    }
}