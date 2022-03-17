using System;
using System.Collections.Generic;

class Jogador {
  private int id;
  private string nome;
  private int camisa;
  private string email;
  private string time;
  
  public Jogador(int id , string nome, int camisa, string email, string time){
    this.id = id;
    this.nome = nome;
    this.camisa = camisa;
    this.email = email;
    this.time = time;
    //this.idCampeonato = idcamp;
  }

  public Jogador(int id) {
    this.id = id;
  }
  public void SetNome(string nome){
    this.nome = nome;
  }
  public string GetNome(){
    return this.nome;
  }
  public void SetId(int id){
    this.id = id;
  }
  public int GetId(){
    return id;
  }
  public void SetCamisa(int camisa){
    this.camisa = camisa;
  }
  public int GetCamisa(){
    return camisa;
  }
  public void SetTime(string time){
    this.time = time;
  }
  public string GetTime(){
    return this.time;
  }
  public void SetEmail(string email){
    this.email = email;
  }
    
  public string GetEmail(){
    return this.email;
  }

  public override string ToString(){
    return $"{id} -- {nome} - {camisa} - {email} - {time}";
  }
}