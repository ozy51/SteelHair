using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SteelHair.Model
{
    class Bdados
    {

        public ObservableCollection<Cliente> Clientes { get; set; }



        //file.Close();


        public void escreverClientesFile()
        {
            FileStream outFile;
            BinaryFormatter bFormatter = new BinaryFormatter();

            // Ppen file for output
            outFile = new FileStream("clientes.dat", FileMode.Create, FileAccess.Write);

            // Output object to file via serialization
            bFormatter.Serialize(outFile, Clientes);

            // Close file
            outFile.Close();
        }

        public void lerClientesFile()
        {
            FileStream outFile;
            BinaryFormatter bFormatter = new BinaryFormatter();

            // Ppen file for output
            outFile = new FileStream("clientes.dat", FileMode.Open);
            ObservableCollection<Cliente> clientesin = new ObservableCollection<Cliente>();
            // Output object to file via serialization
            clientesin = (ObservableCollection<Cliente>)bFormatter.Deserialize(outFile);

            // Close file
            outFile.Close();

            this.Clientes = clientesin;
        }

	
	}


    }

