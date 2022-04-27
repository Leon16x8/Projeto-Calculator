using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_Calculator
{
    public partial class Form1 : Form
    {
        ModelCalculator model;
        public Form1()
        {
            InitializeComponent();
            model = new ModelCalculator();
        }//fim do construtor



        private void SegundoNumero_Click(object sender, EventArgs e)
        {

        }

        private void boxprimeironum_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa de texto para o primeiro numero

        private void boxsegundonum_TextChanged(object sender, EventArgs e)
        {

        }//fim da caixa de texto para o segundo numero

        private void Mais_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(boxprimeironum.Text);//Coletando Primeiro Numero
                double num2 = Convert.ToDouble(boxsegundonum.Text);//Coletando Segundo Numero
                double resultadoo = model.Somar(num1, num2);//Gerar resultado
                resultado.Text = "" + resultadoo;//Escrever o Result na Tela
            }
            catch (Exception error)
            {
                MessageBox.Show("Os numeros não foram digitados!\n\n" + error);
            }
        }//fim do botão +

        private void mult_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(boxprimeironum.Text);//Coletando Primeiro Numero
                double num2 = Convert.ToDouble(boxsegundonum.Text);//Coletando Segundo Numero
                double resultadoo = model.Multiplicar(num1, num2);//Gerar resultado
                resultado.Text = "" + resultadoo;//Escrever o Result na Tela
            }
            catch (Exception error)
            {
                MessageBox.Show("Os numeros não foram digitados!\n\n" + error);
            }
        }//fim do botão x

        private void menos_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(boxprimeironum.Text);//Coletando Primeiro Numero
                double num2 = Convert.ToDouble(boxsegundonum.Text);//Coletando Segundo Numero
                double resultadoo = model.Subtrair(num1, num2);//Gerar resultado
                resultado.Text = "" + resultadoo;//Escrever o Result na Tela
            }
            catch (Exception error)
            {
                MessageBox.Show("Os numeros não foram digitados!\n\n" + error);
            }
        }//fim do botão menos

        private void divi_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(boxprimeironum.Text);//Coletando Primeiro Numero
                double num2 = Convert.ToDouble(boxsegundonum.Text);//Coletando Segundo Numero
                double resultadoo = model.Dividir(num1, num2);//Gerar resultado
                if (resultadoo == -1)
                {
                    resultado.Text = "Impossivel Dividir por Zero FDP!";
                }
                else
                {
                    resultado.Text = "" + resultadoo;//Escrever o Result na Tela
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Os numeros não foram digitados!\n\n" + error);
            }
        }//fim do botão dividir

        private void raiz_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(boxprimeironum.Text);//Coletando Primeiro Numero
                double resultadoo = model.Raiz(num1);//Gerar resultado
                if (resultadoo == -1)
                {
                    resultado.Text = "Impossivel Calcular Raiz CUZAO !";
                }
                else
                {
                    resultado.Text = "" + resultadoo;//Escrever o Result na Tela
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Os numeros não foram digitados!\n\n" + error);
            }

        }//fim do botão raiz

        private void potencia_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(boxprimeironum.Text);//Coletando Primeiro Numero
                double num2 = Convert.ToDouble(boxsegundonum.Text);//Coletando Segundo Numero
                double resultadoo = model.Potencia(num1, num2);//Gerar resultado
                resultado.Text = "" + resultadoo;//Escrever o Result na Tela
            }
            catch (Exception error)
            {
                MessageBox.Show("Os numeros não foram digitados!\n\n" + error);
            }
        }//fim do botão potenciação

        private void resultado_Click(object sender, EventArgs e)
        {

        }//fim do result

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {                    
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            linkLabel1.Text = ("Visite meu Spotify");
            linkLabel1.Links.Add(0, 20, "https://open.spotify.com/artist/1Inf3L902fK4Nv02GNi4ib");
        }
    }//fim da classe
}//fim do projeto
