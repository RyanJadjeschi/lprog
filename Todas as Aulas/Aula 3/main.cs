using System;
using Modelos;

class Aula3 {
  public static void print(Aluno aluno) {
    Console.WriteLine(
      "---------------------------\n" +
      "Matricula: " + aluno.matricula + "\n" +
      "Nome: " + aluno.nome + "\n" +
      "Periodo: " + aluno.periodo + "\n" +
      "---------------------------"
    );
  }
  public static void Main (string[] args) {
    Aluno aluno1 = new Aluno {
      matricula = "2021ENEL123" ,
      nome = "Ryan" ,
      periodo = 0
    };
    print(aluno1);
    Aluno aluno2 = new Aluno();
     print(aluno2);
  }
}