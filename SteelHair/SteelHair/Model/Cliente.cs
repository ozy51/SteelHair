using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteelHair.Model
{
    public class Cliente
    {
        //atributos cliente
        string nomecompleto;
        string morada;
        long telefone;
        Boolean sexo;
        Boolean cabeloNormal;
        Boolean cabeloSeco;
        Boolean cabeloPorosidade;
        Boolean cabeloFino;
        Boolean cabeloMedio;
        Boolean cabeloGrosso;
        Boolean couroNormal;
        Boolean couroSeco;
        Boolean couroGordo;
        Boolean couroMuitoGordo;
        Boolean couroQueda;
        Boolean couroCaspa;
        string brancas;
        
        //metodos cliente






        //construtores





        // estrutura da bdados
        Cliente(){
            this.nomecompleto = "";
            this.morada = "";
            this.telefone = 0;
            this.sexo = true;
            this.cabeloNormal = true;
            this.cabeloSeco = true;
            this.cabeloPorosidade = true;
            this.cabeloFino = true;
            this.cabeloMedio = true;
            this.cabeloGrosso = true;
            this.couroNormal = true;
            this.couroSeco = true;
            this.couroGordo = true;
            this.couroMuitoGordo = true;
            this.couroQueda = true;
            this.couroCaspa = true;
            this.brancas = "";
        }

        public Cliente(string n,long tel)
        {
            this.nomecompleto = n;
            this.telefone = tel;
        }

        Cliente(string n, string m, int tel, bool sexo, bool cabn, bool cabs, bool cabp, bool cabf, bool cabm, bool cabg, bool cn, bool cg, bool cmg, bool cq, bool cc, string brancas)
        {
            this.nomecompleto = n;
            this.morada = m;
            this.telefone = tel;
            this.sexo = sexo;
            this.cabeloNormal = cabn;
            this.cabeloPorosidade = cabp;
            this.cabeloFino = cabf;
            this.cabeloMedio = cabm;
            this.cabeloGrosso = cabg;
            this.couroNormal = cn;
            this.couroGordo  = cg;
            this.couroMuitoGordo = cmg;
            this.couroQueda =cq;
            this.couroCaspa = cc;
            this.brancas = brancas;



        }



        //Gets e Sets
        public string getNome()
        {
            return this.nomecompleto;
        }

        public long getTel()
        {
            return this.telefone;
        }

        //Metodo toString

        public override string ToString()
        {
            return getNome();
        }


      

    }


}
