using System;

namespace Modelos {


  class Impressora {

    public static void print(Texto texto) {
      
      Console.WriteLine("---------------------------");
      Console.WriteLine(texto.Informar());
      Console.WriteLine("---------------------------");
      
      
    }

    
  public static void print(Pessoa pessoa) {
    Console.WriteLine(
      "Nome: " + pessoa.Nome + "\n" +
      "CPF: " + pessoa.Cpf  
    );
    }
    
   

    public static void print(Professor professor) {
    Console.WriteLine(
      
     
      "Codigo: " + professor.Codigo + "\n" 
      
    );
    }

    public static void print(Contato contato) {
    Console.WriteLine(
      contato.Informar()
    );
    }

    public static void print(Disciplina disciplina) {
    Console.WriteLine(
      
      "Nome: " + disciplina.Nome + "\n" +
      "Semestre: " + disciplina.semestre + "\n" 
      
    );
    }
  }
}
