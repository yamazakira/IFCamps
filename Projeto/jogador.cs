using System;
using System.Collections.Generic;

class Jogador {
  private string nome;
  private int camisa;
  private string email;
  private string time;
  
  public Jogador (string nome, int camisa , string email, string time){
    this.nome = nome;
    this.camisa = camisa;
    this.email = email;
    this.time = time;
  }

  public void SetCamisa(int camisa){
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
  public string GetTime(){
    return time;
  }
  public override string ToString(){
    return $"{nome} - {camisa} - {email} - {time}";
  }
}