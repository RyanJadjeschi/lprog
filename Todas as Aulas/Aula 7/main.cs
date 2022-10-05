
using System;
using Modelos;

class Aula7 {

  public static void Main (string[] args) {

  Familiar familiar = new Familiar();
  //Impressora.print(familiar);
    
  Endereco endereco = new Endereco();
  Impressora.print(endereco);
    
  Internet internet = new Internet();
  Impressora.print(internet);
    
  Telefone telefone = new Telefone();
  Impressora.print(telefone);
  
  
    
  
  }
    
}