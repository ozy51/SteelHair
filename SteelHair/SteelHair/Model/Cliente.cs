﻿using System;
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
        int telefone;
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
        private System.Windows.Controls.TextBox nome;
        private System.Windows.Controls.TextBox morada1;
        private System.Windows.Controls.TextBox telefone1;
        
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
        }



        public Cliente(string n, string m, int tel, bool sexo, bool cabelon)
        {
            this.nomecompleto = n;
            this.morada= m;
            this.telefone = tel;
            this.sexo = sexo;
            this.cabeloNormal = cabelon;
        }

     

      

    }


}
