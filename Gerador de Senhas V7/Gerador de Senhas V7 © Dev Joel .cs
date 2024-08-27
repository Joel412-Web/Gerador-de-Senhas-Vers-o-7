using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gerador_de_Senhas_V7
{
    public partial class FrGerador : Form
    {
        public FrGerador()
        {
            InitializeComponent();
        }

        private void BtnGerar_Click(object sender, EventArgs e)
        {
            // Obtém o comprimento da senha
            int comprimento = (int)NChars.Value;

            // Verifica se pelo menos uma opção foi selecionada
            if (!chkMaiusculas.Checked && !chkMinusculas.Checked && !chkNumeros.Checked && !chkSimbolos.Checked)
            {
                LBLStatus.Text = "Erro: Selecione pelo menos um tipo de caractere.";
                return;
            }

            // Cria o conjunto de caracteres baseados nas opções selecionadas
            StringBuilder caracteres = new StringBuilder();

            if (chkMaiusculas.Checked)
                caracteres.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

            if (chkMinusculas.Checked)
                caracteres.Append("abcdefghijklmnopqrstuvwxyz");

            if (chkNumeros.Checked)
                caracteres.Append("0123456789");

            if (chkSimbolos.Checked)
                caracteres.Append("!@#$%^&*()_+-=[]{}|;:,.<>?");

            // Gera a senha aleatoriamente com o comprimento especificado
            Random random = new Random();
            StringBuilder senha = new StringBuilder();

            for (int i = 0; i < comprimento; i++)
            {
                int indice = random.Next(caracteres.Length);
                senha.Append(caracteres[indice]);
            }

            // Exibe a senha no TextBox
            txtPassword.Text = senha.ToString();

            // Atualiza o status para indicar sucesso
            LBLStatus.Text = "Senha gerada com sucesso!";

        }

        private void BtnLimpar_Click(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
            NChars.Value = 0;
            chkMaiusculas.Checked = false;
            chkMinusculas.Checked = false;
            chkNumeros.Checked = false;
            chkSimbolos.Checked = false;
            LBLStatus.Text = string.Empty;
            LBLStatus.Text = "Valores Limpos Com sucesso!";
            
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            Sair();
        }
        private void Sair()
        {
            if (MessageBox.Show("Deseja Sair do Programa?","SAIR",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.No)return;
            Application.Exit();
        }

        private void BtnCopiar_Click(object sender, EventArgs e)
        {
            // Verifica se há uma senha no TextBox
            if (!string.IsNullOrEmpty(txtPassword.Text))
            {
                // Copia o texto do TextBox para a área de transferência
                Clipboard.SetText(txtPassword.Text);

                // Atualiza o texto do Label com a mensagem de sucesso
                LBLStatus.Text = "Senha copiada com sucesso para a área de transferência.";
            }
            else
            {
                // Atualiza o texto do Label com a mensagem de erro
                LBLStatus.Text = "Não há senha para copiar.";
            }
        }
    }
}
