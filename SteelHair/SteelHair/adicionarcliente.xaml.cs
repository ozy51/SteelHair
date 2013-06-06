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
            Boolean sexo=false;

            int lol,numdig=0,x=0,error=0;
            if (masculino.IsChecked == true)
                sexo = true;
            lol=int.Parse(telefone1.Text);

            x=lol;
            do
            {
                x = x / 10;
                numdig++;
            } while (x > 0);

            if(x!=9)
               MessageBox.Show("Numero de telefone inválido", "Confirmation");
                error++;

            if (nome.MaxLength > 41)

                error++;





            Cliente novo = new Cliente(nome.Text, morada.Text, lol, sexo, cabelonormal.IsChecked, cabeloseco.IsChecked, cabeloporosidade.IsChecked, cabelofino.IsChecked, cabelomedio.IsChecked, cabelogrosso.IsChecked, courogordo.IsChecked, couromuitogordo.IsChecked, courocaspa.IsChecked, couroqueda.IsChecked, couroseco.IsChecked, cabelobrancas.Text);
            

                       

        }


	}
}