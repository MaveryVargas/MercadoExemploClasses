using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using MercadoExemploClasses;

namespace MercadoExemploClasses
{
    
    internal class Funcionario
    {
        String nome {get;set;}
        String sobrenome {get;set;}
        int idfunc {get;set;} 
        int senha {get;set;}
        public Funcionario()
        {
            this.nome = "";
            this.sobrenome = "";
            this
        }
       
        public void CadastraFuncionario()
        {
            Console.WriteLine("Insira o nome do novo funcionario");
            nome = Console.ReadLine();
            Console.WriteLine("Insira o sobrenome do novo funcionario");
            sobrenome = Console.ReadLine();
            Console.WriteLine("Cadastre uma senha");
            senha = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite um ID para o funcionario");
            idfunc = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("O novo funcionario possui Nome:"+nome+" "+sobrenome+"| Senha:"+senha+"| ID:"+idfunc);
            Thread.Sleep(2400);
            Console.Clear();
        }
    }
}
