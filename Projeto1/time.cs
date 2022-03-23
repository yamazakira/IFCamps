using System;
using System.Collections.Generic;

class Time {
  private int id;
  private string nome;
  //private int idCampeonato;
  public Time(int id , string nome/*, int idcamp*/){
    this.id = id;
    this.nome = nome;
    //this.idCampeonato = idcamp;
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
  /*public void setIdCamp(int idcamp){
    this.idCampeonato = idcamp;
  }
  public int getIdCamp(){
    return this.idCampeonato;
  }*/
  public override string ToString(){
    return $"{id} - {nome}";
  }
}