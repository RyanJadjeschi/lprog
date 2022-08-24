namespace Modelos {

  class Aluno {
    public string matricula;
    public int periodo;
    public string nome;

    public Aluno () : this(0) {
    }
    public Aluno(int periodo) {
      if (periodo > 0){
        this.periodo = periodo;
      }  else{
         this.periodo = 1;
      }
    }

    
    public bool Matricular(Disciplina disciplina) {
      return this.periodo == disciplina.semestre;
    }
  }
} 