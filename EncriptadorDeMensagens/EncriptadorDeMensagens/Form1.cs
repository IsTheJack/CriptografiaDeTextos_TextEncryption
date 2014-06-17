using System;
using System.Linq;
using System.Windows.Forms;

namespace EncriptadorDeMensagens
{
    public partial class frmPrincipal : Form
    {
        string sequencia = "";
        int tamanho;
        int[] arrayNumeroChar;

        public frmPrincipal()
        {
            InitializeComponent(); //Construtor
        }

        public void Criptografar()
        {
            OperacaoDaCriptografia(true);
        }

        private void Decodificar()
        {
            OperacaoDaCriptografia(false);
        }

        //Se o valor do argumento do método abaixo for verdadeiro, ele criptografará,
        //caso contrário, fará a ação inversa.
        public void OperacaoDaCriptografia(bool criptografar) 
        {
            tamanho = txtMensagem.Text.Count();
            arrayNumeroChar = new int[tamanho];
            short sinal;

            if (criptografar)
            {
                sinal = 1;
            }
            else
            {
                sinal = -1;
            }
      
            for (int i = 0; i < tamanho; i++)
            {
                if (Convert.ToInt32(Convert.ToChar(txtMensagem.Text.Substring(i, 1))) != 13) //Se o caractere for diferenter de 'ENTER'
                {
                    if (i % 2 == 0 && i % 3 != 0 && i % 5 != 0 && i % 7 != 0)
                    {
                        do
                        {
                            arrayNumeroChar[i] = Convert.ToInt32(Convert.ToChar(txtMensagem.Text.Substring(i, 1))) + 2 * sinal;
                        } while (i % 3 == 0 || i % 5 == 0 || i % 7 == 0);
                    }
                    else if (i % 3 == 0 && i % 2 != 0 && i % 5 != 0 && i % 7 != 0)
                    {
                        do
                        {
                            arrayNumeroChar[i] = Convert.ToInt32(Convert.ToChar(txtMensagem.Text.Substring(i, 1))) + 3 * sinal;
                        } while (i % 2 == 0 || i % 5 == 0 || i % 7 == 0);
                    }
                    else if (i % 5 == 0 && i % 2 != 0 && i % 3 != 0 && i % 7 != 0)
                    {
                        do
                        {
                            arrayNumeroChar[i] = Convert.ToInt32(Convert.ToChar(txtMensagem.Text.Substring(i, 1))) + 5 * sinal;
                        } while (i % 2 == 0 || i % 3 == 0 || i % 7 == 0);
                    }
                    else if (i % 7 == 0 && i % 2 != 0 && i % 3 != 0 && i % 5 != 0)
                    {
                        do
                        {
                            arrayNumeroChar[i] = Convert.ToInt32(Convert.ToChar(txtMensagem.Text.Substring(i, 1))) + 7 * sinal;
                        } while (i % 2 == 0 || i % 3 == 0 || i % 5 == 0);
                    }
                    else
                    {
                        arrayNumeroChar[i] = Convert.ToInt32(Convert.ToChar(txtMensagem.Text.Substring(i, 1))) + 1 * sinal;
                    }
                }
                else
                {
                    arrayNumeroChar[i] = 13; //'Enter' não é criptografado
                }
            }

            TextoParaCaixa();
        }

        public void TextoParaCaixa()
        {
            for (int i = 0; i < tamanho; i++)
            {
                sequencia += Convert.ToString(Convert.ToChar(arrayNumeroChar[i]));
            }
            txtMensagem.Text = sequencia;
            sequencia = "";
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtMensagem.Text.Count().ToString());
        }

        private void btnCriptografar_Click(object sender, EventArgs e)
        {
            Criptografar();
        }

        private void btnDecodificar_Click(object sender, EventArgs e)
        {
            Decodificar();
        }
    }
}
