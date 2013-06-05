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
	/// Interaction logic for Cliente1.xaml
	/// </summary>
	public partial class Cliente1 : Window
	{
		public Cliente1()
		{
			this.InitializeComponent();
			
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
			MessageBox.Show(messageBoxText, caption, button, icon);
			// TODO: Add event handler implementation here.
		}
	}
}