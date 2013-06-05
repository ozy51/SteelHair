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


            Cliente novo = new Cliente(nome.Text, morada.Text, lol, sexo, cabelonormal.Checked, cabeloseco.Checked, cabeloporosidade.Checked, cabelofino.Checked, cabelomedio.Checked, cabelogrosso.Checked, courogordo.Checked, couromuitogordo.Checked, courocaspa.Checked, couroqueda.Checked, couroseco.Checked, cabelobrancas.Text);
            


        }


	}
}