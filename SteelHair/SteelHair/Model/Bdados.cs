using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelHair.Model
{
    class Bdados
    {

        List<Cliente> listaClientes = new List<Cliente>();
        public ObservableCollection<Cliente> Clientes { get; set; }


        public void adicionarCliente(Cliente c)
        {
            listaClientes.Add(c);

        }

        public void mostrarCliente()
        {
            for (int i = 0; i < listaClientes.Count; i++)
            {
                Console.WriteLine("Nome: ");
                Console.WriteLine(listaClientes.ElementAt(i).getNome());
                Console.WriteLine("Telefone:");
                Console.WriteLine(listaClientes.ElementAt(i).getTel());
            }
        }
        //System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\Bdados");


        //file.Close();

        public List<Cliente> getLista()
        {
            return this.listaClientes;
        }

	
	}


    }

