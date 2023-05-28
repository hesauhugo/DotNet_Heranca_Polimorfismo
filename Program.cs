using DotNet_Heranca_Polimorfismo.Models;

var aluno  = new Aluno("Enzo");
aluno.Idade = 1;
aluno.Nota = 10;

aluno.Apresentar();

var professor = new Professor("Enzo");
professor.Idade = 30;
professor.Salario = 1000;
professor.Apresentar();