using System;
using System.Collections.Generic;

class Time {
  private string nome;
  private static List<Jogador> jogs = new List<Jogador>();

  public Time(string n){
    this.nome = n;
  }

  /*
  public void Inserir(Jogador obj){
    // inserir um jogador no time
    jogs.Add(obj);
  }

  public void Listar(){
    foreach(Jogador obj in jogs){
      return obj;
    }
  */

  public void setNomeTime(string n){
    this.nome = n;
  }

  public string getNomeTime(){
    return this.nome;
  }

  public override string ToString(){
    return $"{nome}";
  }
}