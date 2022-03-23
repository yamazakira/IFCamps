using System;
using System.Collections.Generic;

public class Time : IComparable{
  private int id;
  private string nome;
  private int idcamp;
  
  public int Id{
    get => id;
    set => id = value;
  }
  public string Nome{
    get => nome;
    set => nome = value;
  } 
  public int IdCamp{
    get => idcamp;
    set => idcamp = value;
  }

  public Time(){
  }
  
  public Time(int id , string nome, int idcamp){
    this.id = id;
    this.nome = nome;
    this.idcamp = idcamp;
  }
  public int CompareTo(object obj){
    Time x = (Time) obj;
    return this.nome.CompareTo(x.nome);
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
  public void SetIdCamp(int idcamp){
    this.idcamp = idcamp;
  }
  public int GetIdCamp(){
    return this.idcamp;
  }
  public override string ToString(){
    return $"{id} - {nome}";
  }
}