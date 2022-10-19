namespace Modelos {

  class Disciplina {
    public string Nome;
    public int semestre;


    public Disciplina Prerequisito {
      get; set;
    }

    public int Semestre {
      set {
        if (semestre < 1){
        this.semestre = 1;
       }else if (semestre > 10) {
        this.semestre = 10; 
       } else{
              this.semestre = value;
       }
      }
    }

    public Disciplina() : this(1) {
    }

    public Disciplina(int semestre) {
      this.Semestre = semestre;
    }

    public Disciplina(string nome) : this(1) {
      this.Nome = nome;
    }

    public Disciplina(string nome, int semestre) : this(semestre) {
      this.Nome = nome;
    }
  }
    
  
}