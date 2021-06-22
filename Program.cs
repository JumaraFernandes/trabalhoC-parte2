//Jumara  Andrade Amaro Fernandes
//a43691
using System;
namespace Trabalho_de_programação
{
    class Program
    {
        static void Main(string[] args)
        {
            AlugAuto a = new AlugAuto(20);
             //listar clientes();
          a.AdicinarCliente("aa","Jumara");
           a.AdicinarCliente("bb","Tania");
           a.AdicinarCliente("C8","Nany");
            //a.listarviaturas();
           a.AdicinonarViaturaLuxo(10,"M1");
           a.AdicinonarViaturaLuxo(20,"M2");
           a.AdicinonarViaturaUtilitario("k1");
           a.AdicinonarViaturaUtilitario("U2");
           //a.RegistarAlguer();
           a.RegistarAluguer("aa","k1",6);
           a.RegistarAluguer("bb","M1",6);
           a.RegistarAluguer("aa","M2",7);
           ///a.MostraTotal();

            a.MostraTotal();
           a.MostraAluguerCliente("C6");
           a.MostraAluguerlViatura("L2");
           a.MostraAluguerlViatura("L2");
           a.MostraTotalViatura("U1");
           a.MostraAluguerlViatura("U1");


           int opMenu = 1;
            while(opMenu!=0)
            {
               Console.WriteLine("Bem-vindo!");
               Console.WriteLine("Escolha uma das seguintes opções:");
               Console.WriteLine("1-Adicionar Viatura de Luxo");
               Console.WriteLine("2-Adicinar Viatura de Utilitario");
               Console.WriteLine("3-Adicionar Clientes");
               Console.WriteLine("4-Listar Viaturas");
               Console.WriteLine("5-Listar Clientes");
               Console.WriteLine("6-Registar aluguer");
                Console.WriteLine("7-Mostar Aluguer Cliente");
                Console.WriteLine("8-Mostar Aluguer Viaturas");
                Console.WriteLine("9-Mostrar Total");
                 Console.WriteLine("10-Mostar Tota Por Viaturas");
                Console.WriteLine("0-Sair");

               opMenu =int.Parse(Console.ReadLine());
              
           
              if (opMenu==0)
            {
                break;
            }
           else if (opMenu==1)
            {
                Console.Write("Digite uma matricula: ");
                string matricula = Console.ReadLine();
                Console.Write("Digite uma taxa: ");
                decimal taxaLuxo = decimal.Parse(Console.ReadLine());
                a.AdicinonarViaturaLuxo(taxaLuxo, matricula);
            }
            else if(opMenu==2)
            {
                Console.Write("Digite uma matricula: ");
                string matricula = Console.ReadLine();
                a.AdicinonarViaturaUtilitario(matricula);
            }
            else if (opMenu==3)
            {
                Console.Write("Digite uma Carta: ");
                string carta = Console.ReadLine();
                Console.Write("Digite uma nome: ");
                string nome = Console.ReadLine();
                a.AdicinarCliente(carta,nome);
            }
            
            else if (opMenu==4)
            {
                a.listarviaturas();
            }
            else if (opMenu==5)
            {
                a.listarclientes();
            }
            else  if (opMenu == 6)
            {
                Console.Write("Digite uma Carta: ");
                string carta = Console.ReadLine();
                Console.Write("Digite uma Matricula: ");
                string matricula = Console.ReadLine();
                Console.Write("Digite numero dias: ");
                int dias = int.Parse(Console.ReadLine());
                a.RegistarAluguer(carta,matricula,dias);
                
            }
            else if(opMenu==7)
            {
                 Console.Write("Digite uma Carta: ");
                string carta = Console.ReadLine();
                a.MostraAluguerCliente(carta);
            }
            else if(opMenu==8)
            {
                 Console.Write("Digite uma Matricula: ");
                string matricula = Console.ReadLine();
                a.MostraAluguerlViatura(matricula);
            }
            else if (opMenu==9)
            {
                a.MostraTotal();
            }
            else if (opMenu==10)
            {
                Console.Write("Digite uma Matricula: ");
                string matricula = Console.ReadLine();
                a.MostraTotalViatura(matricula);
            }

            else
            {
                Console.WriteLine("Opcão Invalida, tente novamente");
            }
             
              //Console.Clear();
            }
    


          
    }
    }
    }

