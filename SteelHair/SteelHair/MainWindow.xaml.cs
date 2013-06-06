using SteelHair.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SteelHair
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
	///
    public partial class MainWindow : Window
    {
        public ObservableCollection<Cliente> listaclientes;
        public MainWindow()
        {
            InitializeComponent();
            Bdados dados = new Bdados();
            dados.lerClientesFile();
            listaclientes = dados.Clientes;

            this.Closing += new System.ComponentModel.CancelEventHandler(Window_Closing);


        }

        private void Button_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            var newW = new Cliente1(listaclientes);
			newW.ShowDialog(); // works
        	// TODO: Add event handler implementation here.
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            var newlol = new TesteLista();
            newlol.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBox.Show("Exit The Project");
        }
    }
}
