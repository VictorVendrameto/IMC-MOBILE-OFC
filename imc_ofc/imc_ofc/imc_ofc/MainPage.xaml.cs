using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace imc_ofc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
            private void Button_Clicked(object sender, EventArgs e)
            {
                double peso = double.Parse(txt_peso.Text);
                double altura = double.Parse(txt_altura.Text);

                double imc = peso / (altura * altura);
                imc = Math.Round(imc, 2);
                if (imc < 18.5)
                {
                    DisplayAlert("Você está abaixo do peso", "Seu imc é: " + imc.ToString(), "OK");
                }
                else if (imc >= 18.6 & imc <= 24.9)
                {
                    DisplayAlert("Peso normal", "Seu imc é: " + imc.ToString(), "OK");
                }
                else if (imc >= 25.0 & imc <= 29.9)
                {
                    DisplayAlert("Sobrepeso", "Seu imc é: " + imc.ToString(), "OK");
                }
                else if (imc >= 30.0 & imc <= 34.9)
                {
                    DisplayAlert("Obesidade grau I", "Seu imc é: " + imc.ToString(), "OK");
                }
                else if (imc >= 35.0 & imc <= 39.9)
                {
                    DisplayAlert("Obesidade grau II", "Seu imc é: " + imc.ToString(), "OK");
                }
                else
                {
                    DisplayAlert("Obesidade grau III", "Seu imc é: " + imc.ToString(), "OK");
                }
            }

        }
    }
