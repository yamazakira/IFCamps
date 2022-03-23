using System;
using System.Collections.Generic;

public class Jogador : IComparable {
  private int id;
  private string nome;
  private int camisa;
  private string email;
  private string time;
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

  public Jogador(){
  }
  
  public Jogador(int id , string nome, int camisa, string email, string time, int idcamp){
    this.id = id;
    this.nome = nome;
    this.camisa = camisa;
    this.email = email;
    this.time = time;
    this.idcamp = idcamp;
  }

  public Jogador(int id) {
    this.id = id;
  }
  public int CompareTo(object obj){
    Jogador x = (Jogador) obj;
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