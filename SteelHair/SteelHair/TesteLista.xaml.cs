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
using SteelHair.Model;

namespace SteelHair
{
	public partial class TesteLista
	{
		public TesteLista()
		{
			this.InitializeComponent();
            Cliente teste1 = new Cliente("joao", 9111111);
            Cliente teste2 = new Cliente("Lolada", 9111222);
            Cliente teste3 = new Cliente("Carlos", 933311);
			Bdados dados = new Bdados();
            dados.adicionarCliente(teste1);
            dados.adicionarCliente(teste2);
            dados.adicionarCliente(teste3);
            list1.ItemsSource = dados.getLista();
			// Insert code required on object creation below this point.
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
		
			// TODO: Add event handler implementation here.
		}
	}
}