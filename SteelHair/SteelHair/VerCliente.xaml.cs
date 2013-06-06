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
	public partial class VerCliente
	{

		public VerCliente(Cliente cliente)
		{
			this.InitializeComponent();
            nome_cliente.Content = cliente.getNome();
            morada_cliente.Content = cliente.getNome();
            telefone_cliente.Content = cliente.getTel();
			// Insert code required on object creation below this point.
		}

	}
}