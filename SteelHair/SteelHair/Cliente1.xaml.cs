using SteelHair.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
	/// Interaction logic for Cliente1.xaml
	/// </summary>
	public partial class Cliente1 : Window
	{
		public Cliente1(ObservableCollection<Cliente> listaclientes)
		{
			this.InitializeComponent();
            Cliente teste1 = new Cliente("João Miguel Ferreira Martins", 9111111);
            Cliente teste2 = new Cliente("Ana Sofia Nunes Carvalho", 9111222);
            Cliente teste3 = new Cliente("Maria Rosa dos Santos", 933311);
            list1.ItemsSource = listaclientes;
            list1.Items.Add(teste1);
            list1.Items.Add(teste2);
            list1.Items.Add(teste3);
			
			// Insert code required on object creation below this point.
		}


		private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
		{
			var newW  = new adicionarcliente();
			newW.ShowDialog(); // works
			// TODO: Add event handler implementation here.
		}

		private void Button_Click_1(object sender, System.Windows.RoutedEventArgs e)
		{
			// Configure the message box to be displayed 
			string messageBoxText = "Tem a certeza que quer remover este utilizador?";
			string caption = "Remover Utilizador";
			MessageBoxButton button = MessageBoxButton.YesNo;
			MessageBoxImage icon = MessageBoxImage.Warning;
            if (MessageBox.Show(messageBoxText, caption, button, icon) == MessageBoxResult.Yes)
            {
                list1.Items.RemoveAt(list1.Items.IndexOf(list1.SelectedItem));
            }
		}

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Cliente novo = new Cliente();
            novo = (Cliente)list1.SelectedItem;
            var verCliente = new VerCliente(novo);
            verCliente.ShowDialog();
        }
	}
}