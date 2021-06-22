//Jumara  Andrade Amaro Fernandes
//a43691
using System;
using System.Collections.Generic;
namespace Trabalho_de_programação
{
       abstract class Viatura
    {
      string matricula;
      static decimal precoDias;
  
      List<Aluguer> listaaluguer;

      public Viatura(string matricula)
      {
         this.matricula = matricula;
         listaaluguer = new List<Aluguer>();

      }
      public void AdicionarAluguer(Aluguer aluguer)
      {
         listaaluguer.Add(aluguer);

      }
      //o preco vai receber uma variavel que irei passar como parametro
      public static void DefinirPreco(decimal preco)
        {
            precoDias = preco;

        }
        public void definirPreco(decimal preco)
        {
          DefinirPreco(preco);
        }

      public void MostarViatura()
      {
          Console.WriteLine("Matricula : "+this.matricula);
      
      }
      public string getMatricula()
      {
         return this.matricula;
      }
      public virtual decimal getvalor()
      {
         return precoDias;
      }

      public decimal TotalFaturado()
      {   
        decimal total = 0;
           foreach (Aluguer item in listaaluguer)
           {
               total+=item.getvalor();
           }
           return total;

      }
      public void MostraAluguer()
    {
      foreach (Aluguer item in listaaluguer)
      {
          item.Mostar();
      }
    }
    public virtual void DefinirTaxa(decimal taxaLuxo)
    {}

    }
}