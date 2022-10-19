namespace Modelos {

  class Aluno : Pessoa {
    
    private int periodo;
    

    public int Periodo {
      get => this.periodo;
      set {
        if (value > 0){
        this.periodo = value;
        }  else{
         this.periodo = 1;
           }
      }
    }


    public string Matricula{
      get; set;
    }
    
    public Aluno () : this(0) {
    }
    
    public Aluno(int Periodo) {
      this.Periodo = periodo;
    }

    public Aluno(string matricula, string nome)  :  this(){
      this.Matricula = matricula;
      this.Nome = nome;
    }

    public Aluno(string matricula, string nome, int periodo)  :  this(periodo){
      this.Matricula = matricula;
      this.Nome = nome;
      
    }

    public Matricula Cursar (Curso curso) {
      Matricula matricula = new Matricula();
      matricula.Aluno = this;
      matricula.Curso(curso);
      return matricula;
    }

    public override bool Validar() {
      return this.Matricula != null && this.Matricula.Length > 0;
    }
    
  }
} 