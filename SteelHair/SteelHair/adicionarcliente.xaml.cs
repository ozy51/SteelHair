using SteelHair.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SteelHair
{
	/// <summary>
	/// Interaction logic for adicionarcliente.xaml
	/// </summary>
	public partial class adicionarcliente : Window
	{
		public adicionarcliente()
		{
			this.InitializeComponent();
			
			// Insert code required on object creation below this point.
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            
			this.Close();
			// TODO: Add event handler implementation here.
		}

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Cliente teste = new Cliente();
            Boolean sexo=false;
            int contador=0;
            int lol,bs;
            if (masculino.IsChecked == true)
                sexo = true;
            lol=int.Parse(telefone1.Text);
            bs = int.Parse(cabelobrancas1.Text);

            if (teste.validar_telefone(lol) == true)
            {
                MessageBox.Show("Numero de telefone inválido", "Confirmation");
                contador++;
            }

            if (teste.validar_nome(nome.Text) == false)
            {
                MessageBox.Show("Numero de caracteres para o Nome excede o limite máximo de 45 Caracteres", "Confirmation");
                contador++;

            }

            if (teste.validar_morada(morada.Text) == false)
            {
                MessageBox.Show("Numero de caracteres para a Morada excede o limite máximo de 100 caracteres", "Confirmation");
                contador++;
            }

            if (teste.validar_brancas(bs) == false)
            {
                MessageBox.Show("Numero de caracteres para o número de brancas excede o limite máximo de 3 caracteres", "Confirmation");
                contador++;
            }

            if (contador == 0)
            {
                Cliente novo = new Cliente(nome.Text, morada.Text, lol, sexo, cabelonormal.IsChecked, cabeloseco.IsChecked, cabeloporosidade.IsChecked, cabelofino.IsChecked, cabelomedio.IsChecked, cabelogrosso.IsChecked, courogordo.IsChecked, couromuitogordo.IsChecked, courocaspa.IsChecked, couroqueda.IsChecked, couroseco.IsChecked, bs);
            }
            else
                contador = 0;

                       

        }


	}
}