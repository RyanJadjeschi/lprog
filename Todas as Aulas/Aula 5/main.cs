using Modelos;

class Aula5 {

  public static void Main (string[] args) {
     Aluno aluno1 = new Aluno(0);
     aluno1.Cpf = "190.196.077-31";
     Impressora.print(aluno1);
    
     Pessoa pessoa1 = new Pessoa();
     pessoa1.Cpf = "190.197.077-31";
     Impressora.print(pessoa1);

     Pessoa pessoa2 = (Pessoa) aluno2;
     aluno2.Cpf = "190.196.077-31";
     Impressora.print(pessoa2);

     Aluno aluno3 = (Aluno) pessoa2;
     Impressora.print(aluno3);

     Professor professor1 = new Professor();
     professor1.Cpf = "190.196.077-31";
     professor1.Codigo = "20212";
     Impressora.print(professor1);
  }
}