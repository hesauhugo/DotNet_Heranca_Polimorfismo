using System;
using System.Threading.Tasks;

namespace DotNet_Heranca_Polimorfismo.Models
{
    /// <summary>
    /// 
    /// </summary>
    public class Aluno:Pessoa
    {
        public Aluno(string nome):base(nome){
            
        }

        public double Nota {get;set;}
        
        public override void Apresentar(){
            Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} e sou um aluno nota {Nota}");
        }
    }
}
