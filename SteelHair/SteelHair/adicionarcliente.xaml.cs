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
            int lol;
            if (masculino.IsChecked == true)
                sexo = true;
            lol=int.Parse(telefone1.Text);

<<<<<<< HEAD

=======
            //Cliente novo = new Cliente(nome.Text,morada.Text,lol,sexo,cabelonormal,cabeloseco,cabeloporosidade,cabelofino,cabelomedio,cabelogrosso,couroseco,courogordo,couromuitogordo,courocaspa,couroqueda,couroseco,cabelobrancas.Text);
            
>>>>>>> 6e350fd4722b1fbceb17ea80630d7b1991882b65

        }


	}
}