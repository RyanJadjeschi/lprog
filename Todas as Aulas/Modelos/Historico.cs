namespace Modelos {

  class Historico {

    public int Faltas{
      get; set;
    }

    public Turma Turma {
      get; set;
    }

    public Matricula Matricula {
      get; set;
    }

    public List<Nota> Notas {
      get; set;
    }

    public Resultado Resultado {
      get; set;
    }

    public Historico(List<Nota> notas, Resultado resultado ) {
      this.Notas = notas;
      this.Resultado = resultado;
    }
  }
}