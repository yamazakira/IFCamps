using System;
class Program {
  public static void Main() {
    Campeonato c = new Campeonato("Champions League");
    Time t = new Time("PSG");
    Jogador j1 = new Jogador("Neymar",10,"neymar123@psgmail.com");
    j1.SetCamisa(10);
    Console.WriteLine(Jogador.j1);
    }
}

class Campeonato {
  private string nome;
}
  
class Time {
  private string nome;
  
  public Inserir(){
    Jogador[] j1 = new Jogador[]
      
  }
  public Listar(){
    
  }
  public Remover(){
    
  }
  public Atualizar(){
    
  }
}

class Jogador {
  private string nome;
  private int camisa;
  private string email;
  public Jogador (string nome, int camisa , string email){
    this.nome = nome;
    this.camisa = camisa;
    this.email = email;
  }
  public void int SetCamisa(int camisa){
    if(camisa > 0) this.camisa = camisa;
  }
  public string GetNome(){
    return nome;
  }
  public int GetCamisa(){
    return camisa;
  }
  public string GetEmail(){
    return email;
  }
  public override string ToString(){
    $"{nome} , {camisa} , {email}"
  }
}