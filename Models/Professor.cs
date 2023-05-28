using System;
using System.Threading.Tasks;

namespace DotNet_Heranca_Polimorfismo.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Professor:Pessoa
    {
        public Professor(string nome):base(nome){
            
        }
        public decimal Salario {get; set;}

        public sealed override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} e sou um professor e meu salário é {Salario}");
        }

    }
}
