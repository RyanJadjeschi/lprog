namespace Modelos {

  class Disciplina {
    public string Nome;
    public int semestre;

    public int Semestre{
      set => {
        if (semestre < 1){
       this.semestre = 1;
       }else if (semestre > 10) {
        this.semestre = 10; 
       } else{
              this.semestre = semestre;
       }
      }
    }

    public Disciplina () : this(0) {
    }
    
    public Disciplina (int semestre) {
     
         
     
    }
  }
    
  
}