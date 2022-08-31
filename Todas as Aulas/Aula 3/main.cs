using System;
using Modelos;

class Aula3 {
  
  public static void Main (string[] args) {
    Aluno aluno1 = new Aluno {
      Matricula = "2021ENEL123" ,
      Nome = "Ryan" ,
    };
    Impressora.print(aluno1);
    
    Aluno aluno2 = new Aluno();
    Impressora.print(aluno2);
    
    Aluno aluno3 = new Aluno(2);
    Impressora.print(aluno3);
    
    Aluno aluno4 = new Aluno("2021ENEL456", "Luis");
    Impressora.print(aluno4);
    
    Aluno aluno5 = new Aluno("2021ENEL789", "LuisCaraDeBunda", 3);
    Impressora.print(aluno5);

    
    Disciplina disciplina1 = new Disciplina (0);

    Disciplina disciplina2 = new Disciplina (11);
      

    Impressora.print (disciplina1);
    Impressora.print (disciplina2);






    
  }
}