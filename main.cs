using System;

class Pessoa {
  //METODO DE ACESSO - PUBLIC PRIVATE e PROTECTED
  string nome; 
  int idade;
  float peso, altura;

  //SET
  public void envelhecer(int idd){
    if (idd < 21) {
       altura = altura + 0.5;
    }
    else{
      Console.WriteLine("VALOR INVALIDO");
    }
  }

  //GET
   public int envelhecer(){
       return idd;
  }

  //SET
  public void engordar(int p){
    if (idade > 21 && p > 90) {
       peso = p--;
    }  
    else{
      Console.WriteLine("Você está muito gordo");
    }
  }
        
  //GET
   public int engordar(){
       return peso;
  }

  //SET
  public void engordar(int p){
    if (idade > 21 && p < 60) {
       peso = p++;
    }  
    else{
      Console.WriteLine("Você está muito magro");
    }
  }
        
  //GET
   public int engordar(){
       return peso;
  }
}
