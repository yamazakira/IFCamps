using System;
using System.Collections.Generic;

class Jogador {
  private int id;
  private string nome;
  private int camisa;
  private string email;
  private string time;
  public Jogador (int id){
    this.id = id;
  }
  public Jogador (int id , string nome, int camisa , string email, string time){
    this.id = id;
    this.nome = nome;
    this.camisa = camisa;
    this.email = email;
    this.time = time;
  }
  public void setId(int id){
    this.id = id;
  }
  public int getId(){
    return id;
  }
  public void SetNome(string nome){
    this.nome = nome;
  }
  public string GetNome(){
    return nome;
  }
  public void SetCamisa(int camisa){
    if(camisa > 0) this.camisa = camisa;
  }
  public int GetCamisa(){
    return camisa;
  }
  public void SetEmail(string email){
    this.email = email;
  }
  public string GetEmail(){
    return email;
  }
  public void setTime(string time){
    this.time = time;
  }
  public string getTime(){
    return time;
  }
  public override string ToString(){
    return $"{nome} - {camisa} - {email} - {time}";
  }
}