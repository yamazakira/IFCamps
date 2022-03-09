using System;
using System.Collections.Generic;

class Time {
  private int id;
  private string nome;
  public Time(int id , string nome){
    this.id = id;
    this.nome = nome;
  }
  public void setNomeTime(string nome){
    this.nome = nome;
  }
  public string getNomeTime(){
    return this.nome;
  }
  public void SetId(int id){
    this.id = id;
  }
  public int GetId(){
    return id;
  }
  public override string ToString(){
    return $"{id} - {nome}";
  }
}