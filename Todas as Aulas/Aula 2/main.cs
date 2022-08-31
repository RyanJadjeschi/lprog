using System;

class Aula2{


  public struct Aluno {
    public string Matricula; 
    public int Periodo;
  }

  public struct Disciplina {
    public string Nome;
    public int semestre;
  }

  public static bool Matricular(Aluno aluno, Disciplina disciplina) {

    return aluno.Periodo == disciplina.semestre;
    
  }

  public static void Imprimir(Aluno aluno, Disciplina disciplina){
      if (Matricular(aluno, disciplina)){
        Console.WriteLine(aluno.Matricula);
      }
    }
  

  public static void Main (string[] args) {

    Aluno aluno1 = new Aluno {
      Matricula = "012022",
      Periodo = 1
    };
    
    Aluno aluno2 = new Aluno {
      Matricula = "022022",
      Periodo = 3
    };

    Disciplina disciplina = new Disciplina {
      Nome = "Linguagem de Programação",
      semestre = 3
    };

    Imprimir(aluno1, disciplina);
    Imprimir(aluno2, disciplina);
  }






















  
}