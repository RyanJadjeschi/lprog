using System;

namespace Modelos {


  class Impressora {

    public static void print(Object obj) {
      
      Console.WriteLine("---------------------------");
      if (obj is Pessoa) {
        print((Pessoa) obj);
      }
      if (obj is Aluno) {
        print((Aluno) obj);
      }
      if (obj is Professor) {
        print((Professor) obj);
      }
    
      if (obj is Disciplina) {
        print((Disciplina) obj);
      }
      if (obj is Contato) {
        print((Contato) obj);}
      Console.WriteLine("---------------------------");
      
      
    }

    
  private static void print(Pessoa pessoa) {
    Console.WriteLine(
      "Nome: " + pessoa.Nome + "\n" +
      "CPF: " + pessoa.Cpf  
    );
    }
    
    private static void print(Aluno aluno) {
    Console.WriteLine(
      
      "Matricula: " + aluno.Matricula + "\n" +
      "Periodo: " + aluno.Periodo + "\n" 
      
    );
    }

    private static void print(Professor professor) {
    Console.WriteLine(
      
     
      "Codigo: " + professor.Codigo + "\n" 
      
    );
    }

    private static void print(Contato contato) {
    Console.WriteLine(
      contato.Informar()
    );
    }

    private static void print(Disciplina disciplina) {
    Console.WriteLine(
      
      "Nome: " + disciplina.Nome + "\n" +
      "Semestre: " + disciplina.semestre + "\n" 
      
    );
    }
  }
}
