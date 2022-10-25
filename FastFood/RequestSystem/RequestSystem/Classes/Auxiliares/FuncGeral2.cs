/****************************************************************************
* Nome: : FuncGeral
* Observações : Representa a classe de Funções Gerais
* Esta Classe possui metodos publicos que serão ultilizados
* por Formulários e classes.
* Dt. Criação: 24/11/2021
* Dt. Alteração: --
* Criada por: Gui Barci
****************************************************************************/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace RequestSystem
{
    public class FuncGeral2
    {
        ///<summary>
        ///Vetor de byte utilizados para a criptografia (chave externa)
        /// </summary>

        private static byte[] bIV = { 0x50, 0x08, 0xF1, 0xDD, 0xDE, 0x3C, 0xF2, 0x18, 0x44, 0x74, 0x19, 0x2C, 0x53, 0x49, 0xAB, 0xBC };
        string path = Environment.CurrentDirectory;
        public Cliente obj_Usuario = new Cliente();

        /// <summary>
        /// Representação de valor em base 64 (chave interna)
        /// O valor represanta a transformação para base64 de
        /// um conjunto de 32 caracteres (8 * 32 - 256 bits)
        /// a chave é: "Criptografia com Rijndael / AES"
        /// </summary>
        private const string cryptoKey = "Q3JpcHRvZ3JhZmlhcyBjb20gUmluamRhZWwgLyBBRVM=";

        /****************************************************************************
        * Nome: : LimpaTela
        * Observações : Limpa cada campo editável ou modificado no painel
        * Detalhe (pnl_Detail).
        * Parametro : Formulário
        * Dt. Criação: 24/11/2021
        * Dt. Alteração: --
        * Criada por: Gui Barci
        ****************************************************************************/
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


                        if (ctrl is Label && Convert.ToInt16(ctrl.Tag) == 1)
                        {
                            ((Label)ctrl).Text = "";
                        }


                        if (ctrl is CheckBox)
                        {
                            ((CheckBox)ctrl).Checked = false;
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
                                        ((MaskedTextBox)ctrl).Mask = "000,000.00";
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
                                        ((MaskedTextBox)ctrl).Mask = "R$ 000,000.00";
                                        break;
                                    }

                            }
                        }
                    }
                }
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
            bool bValida = false;
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
                                ((TextBox)ctrl).Focus();
                                bValida = false;
                            }
                        }

                        if (ctrl is MaskedTextBox)
                        {
                            if (((MaskedTextBox)ctrl).Text == "")
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

        /****************************************************************************
        * Nome: : ValidaTipo
        * Observações : Habilita cada campo editável no painel Detalhe (pnl_Detail).
        * Parametro : Formulário e um inteiro que defina:
        * 1 - INT
        * 2 - DOUBLE
        * 3 - DATETIME
        *
        * Dt. Criação: 24/11/2021
        * Dt. Alteração: --
        * Criada por: Gui Barci
        ****************************************************************************/
        public bool ValidaTipo(Control objeto, int Tipo)
        {
            bool bValida = true;

            switch (Tipo)
            {
                case 1:
                    {
                        int x = 0;
                        bValida = int.TryParse(objeto.Text, out x);
                        break;
                    }

                case 2:
                    {
                        double x = 0;
                        bValida = double.TryParse(objeto.Text, out x);
                        break;
                    }

                case 3:
                    {
                        DateTime x = DateTime.MinValue;
                        bValida = DateTime.TryParse(objeto.Text, out x);
                        break;
                    }
            }

            if (objeto is MaskedTextBox)
            {
                if (!(bValida))
                {
                    ((MaskedTextBox)objeto).Focus();
                    ((MaskedTextBox)objeto).Clear();
                }
            }
            else
            {
                if (!(bValida))
                {
                    ((TextBox)objeto).Focus();
                    ((TextBox)objeto).Clear();
                }
            }



            return bValida;
        }

        /****************************************************************************
        * Nome: : HabilitaTela
        * Observações : Habilita cada campo editável no painel Detalhe (pnl_Detail).
        * Parametro : Formulário e uma var. booleana
        * Dt. Criação: 24/11/2021
        * Dt. Alteração: --
        * Criada por: Gui Barci
        ****************************************************************************/
        public void HabilitaTela(Form pobj_Form, bool pbHab)
        {
            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Detail")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (ctrl is TextBox && Convert.ToInt16(ctrl.Tag) != 1)
                        {
                            ctrl.Enabled = pbHab;
                        }

                        if (ctrl is Button)
                        {
                            ctrl.Enabled = pbHab;
                        }

                        if (ctrl is MaskedTextBox)
                        {
                            ctrl.Enabled = pbHab;
                        }
                    }
                }
            }
        }

      /****************************************************************************
        * Nome: : TamanhoMaximo
        * Observações : Organiza o Tamanho.
        * Parametro : 
        * Dt. Criação: 24/11/2021
        * Dt. Alteração: --
        * Criada por: Gui Barci
        ****************************************************************************/
        /*public void TamanhoMaximo(Form pobj_Form, string sNm_Tabela)
        {
            string s_NmCampo = "";
            BD_Campo obj_BD_Campo = new BD_Campo();
            Campo obj_Campo = new Campo();

            List<Campo> Lista = new List<Campo>();

            Lista = obj_BD_Campo.FindAllCampo(sNm_Tabela);

            if (Lista.Count != 0)
            {
                for (int i = 0; i < Lista.Count; i++)
                {
                    obj_Campo.Nm_Campo = Lista[i].Nm_Campo;
                    obj_Campo.Tp_Campo = Lista[i].Tp_Campo;
                    obj_Campo.Tam_Campo = Lista[i].Tam_Campo;

                    //Percorre todos os camponentes do Form
                    foreach (Control pnl in pobj_Form.Controls)
                    {
                        if (pnl is Panel && pnl.Name == "pnl_Detail")
                        {
                            foreach (Control ctrl in pnl.Controls)
                            {
                                if (ctrl is TextBox)
                                {
                                    if (obj_Campo.Tp_Campo == "DateTime")
                                    {
                                        s_NmCampo = "TBOX_" + obj_Campo.Nm_Campo.Substring(3, obj_Campo.Nm_Campo.Length - 3);

                                    }
                                    else
                                    {
                                        s_NmCampo = "TBOX_" + obj_Campo.Nm_Campo.Substring(2, obj_Campo.Nm_Campo.Length - 2);
                                    }

                                    if (s_NmCampo == ctrl.Name.ToUpper())
                                    {
                                        ((TextBox)ctrl).MaxLength = obj_Campo.Tam_Campo;
                                    }

                                }


                            }
                        }
                    }
                }
            }
        }
        */
        /****************************************************************************
        * Nome: : StatusBtn
        * Observações : Organiza cada botão no painel de botões (pnl_Button).
        * status (1, 2 ou 3)
        * caso 1 (o primeiro é true e os demais são false)
        * caso 2 (os três primeiros são true e os demais são false)
        * caso 3 (os três primeiros são false e os demais são true)
        * Parametro : Formulário e uma var. int
        * Dt. Criação: 24/11/2021
        * Dt. Alteração: --
        * Criada por: Gui Barci
        ****************************************************************************/
        public void StatusBtn(Form pobj_Form, int piStatus, int NlvUser)
        {
            foreach (Control pnl in pobj_Form.Controls)
            {
                if (pnl is Panel && pnl.Name == "pnl_Button")
                {
                    foreach (Control ctrl in pnl.Controls)
                    {
                        if (NlvUser != 1)
                        {
                            switch (piStatus)
                            {
                                case 1:
                                    {
                                        if (NlvUser != 2)
                                        {
                                            if (ctrl.Name == "btn_Novo")
                                            {
                                                ctrl.Enabled = true;
                                            }
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
                                        if (NlvUser != 2)
                                        {
                                            if (ctrl.Name == "btn_Novo")
                                            {
                                                ctrl.Enabled = true;
                                            }
                                        }


                                        if (ctrl.Name == "btn_Alterar")
                                        {
                                            ctrl.Enabled = true;
                                        }


                                        if (NlvUser != 2)
                                        {
                                            if (ctrl.Name == "btn_Excluir")
                                            {
                                                ctrl.Enabled = true;
                                            }
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
        }

        /***********************************************************************
        * NOME: Criptografa
        * METODO: Criptografa o Password do usuário e retorna o
        * Password criptografado
        * PARAMETRO: String sPassWord
        * RETORNO: String
        * DT CRIAÇÃO: 01/09/2021
        * DT ALTERAÇÃO: -
        * ESCRITA POR: Gui Barci
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



                    //(27 / 05 / 2019 - mfacine)
                    // Define o tamanho da chave "256 = 8 * 32"
                    // Lembre-se: chaves possíves:
                    // 128 (16 caracteres), 192 (24 caracteres) e 256 (32 caracteres)
                    rijndael.KeySize = 256;



                    //(27 / 05 / 2019 - mfacine)
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
        * Nome : DesCriptografa
        * Procedimento : Descriptografa o password do usuário e retorna o
        * pass descriptografado
        * Parametros : sCriptoPassWord
        * Data Criação : 01/09/2021
        * Data Alteração : -
        * Escrito por : mfacine
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
    }
}


