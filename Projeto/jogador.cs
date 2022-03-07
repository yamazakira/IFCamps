using System;
using System.Collections.Generic;

class Jogador {
  private string nome;
  private int camisa;
  private string email;
  private string Idtime;
  public Jogador(int id){
    this.id = id;
  }
  public Jogador (int IdJog , string nome, int camisa , string email, int IdTime){
    this.IdJog = IdJog;
    this.nome = nome;
    this.camisa = camisa;
    this.email = email;
    this.Idtime = Idtime;
  }
  public void setIdJog(int id){
    this.id = id;
  }
  public int getIdJog(){
    return this.id;
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
  public int getIdTime(){
    return Idtime;
  }
  public override string ToString(){
    return $"{nome} - {camisa} - {email} - {time}";
  }
}