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
            list1.ItemsSource = dados.Clientes;
            list1.Items.Add(teste1);
            list1.Items.Add(teste2);
            list1.Items.Add(teste3);
			// Insert code required on object creation below this point.
		}

		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
            Cliente teste4 = new Cliente("joana",8888888);
            list1.Items.Add(teste4);
			// TODO: Add event handler implementation here.
		}

        private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
        {
            list1.Items.RemoveAt(list1.Items.IndexOf(list1.SelectedItem));
            // TODO: Add event handler implementation here.
        }
	}
}