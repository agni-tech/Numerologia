using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumerologiaWin
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void cmdEncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int CalcularValorNumerologico(string palavra)
        {
            int valorTotal = 0;
            foreach (char letra in palavra)
            {
                int valorLetra = ObterValorLetra(letra);
                valorTotal += valorLetra;
            }
            return valorTotal;
        }
        public  int ObterValorLetra(char letra)
        {
            // Tabela de valores numéricos para cada letra
            // Pode-se adicionar mais letras e valores, se necessário
            switch (letra)
            {
                case 'a': return 1;
                case 'b': return 2;
                case 'ç': return 3;
                case 'c': return 3;
                case 'd': return 4;
                case 'e': return 5;
                case 'f': return 6;
                case 'g': return 7;
                case 'h': return 8;
                case 'i': return 9;
                case 'j': return 1;
                case 'k': return 2;
                case 'l': return 3;
                case 'm': return 4;
                case 'n': return 5;
                case 'o': return 6;
                case 'p': return 7;
                case 'q': return 8;
                case 'r': return 9;
                case 's': return 1;
                case 't': return 2;
                case 'u': return 3;
                case 'v': return 4;
                case 'w': return 5;
                case 'x': return 6;
                case 'y': return 7;
                case 'z': return 8;
                default: return 0; // Tratar caracteres que não sejam letras como 0
            }
        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            if (txtText.Text.Trim() == "")
            {
                MessageBox.Show("Favor informar uma palavra ou frase!");
                return;
            }

            try
            {
                int valorNumerologico = CalcularValorNumerologico(txtText.Text.ToLower().Trim());
                lbResult.Text = $"\n Valor da palavra \"{txtText.Text.Trim()}\" é: {valorNumerologico}  e o valor calculado é {CalcularSomaDosDigitos(valorNumerologico)} ";
                txtText.Text = "";

            }
            catch (Exception)
            {

                throw;
            }

        }
        static int CalcularSomaDosDigitos(int numero)
        {
            int soma = 0;
            while (numero != 0)
            {
                int digito = numero % 10;
                soma += digito;
                numero /= 10;
            }
            if (soma == 10) { 
                    return 1;
            }
             if (soma>10) {
                return CalcularSomaDosDigitos(soma);
            }
            return soma;
        }

        private void txtText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cmdCalcular_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}