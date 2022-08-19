using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
namespace MercadoExemploClasses
{
    internal class MercadoDoZe
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            List <Funcionario> listaFunc = new List<Funcionario>();
            Produto prod = new Produto();
            Cliente cliente = new Cliente();
            
            Menu(); //chama o menu
        }
        public static void Menu()
        {
            int opc = 0;            
            do
            {
                Funcionario func = new Funcionario();
                Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-Menu+-+-+-+-+-+-+-+-+-+-+-+-");
                Console.WriteLine("1-Cadastrar funcionario");
                Console.WriteLine("2-Buscar funcionario");
                Console.WriteLine("3-Cadastrar Cliente");
                Console.WriteLine("4-Buscar cliente");
                Console.WriteLine("5-Inserir um produto");
                Console.WriteLine("6-Retirar produto");
                Console.WriteLine("7-Buscar Produto");
                Console.WriteLine("0-Sair");
                Console.WriteLine("Digite a opção");
                Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-Menu+-+-+-+-+-+-+-+-+-+-+-+-");
                opc = Convert.ToInt16(Console.ReadLine());

                switch (opc)
                {
                    case 1:
                        func.CadastraFuncionario();                        
                        break;
                        //case 2:
                }
            } while (opc != 0);
            
        }
        public List<Funcionario> BuscarFuncionario() //ForEach in Lengt
        {
            List<Funcionario> listaFunc = new List<Funcionario>();
            // Aqui você implementa a sua solução.
            // Indico usar um parametro global para salvar todo funcionario cadastrado

            return listaFunc;
        }
    
    }
}
