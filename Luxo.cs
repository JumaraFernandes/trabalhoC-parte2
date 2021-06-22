//Jumara  Andrade Amaro Fernandes
//a43691
using System;
using System.Collections.Generic;
namespace Trabalho_de_programação
{
    class Luxo:Viatura
    {
       decimal taxaLuxo;
    
     public  Luxo( string matricula) : base(matricula)
     {
         
     }
    public override void DefinirTaxa(decimal taxaLuxo)
     {
        this.taxaLuxo = taxaLuxo;
     }
     public override decimal getvalor()
      {
         return (base.getvalor() + (base.getvalor() * taxaLuxo / 100));
      }
}
}