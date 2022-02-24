using System;
using System.Collections.Generic;
using System; 

public class Program {

  public static void Main(string[] args) {
    Console.WriteLine("Bem vindo!");
    Console.WriteLine("----- Escolha um nome para seu campeonato: -----");
    Campeonato camp = new Campeonato(Console.ReadLine());
    Console.WriteLine($"Você criou o campeonato '{camp.getNameCamp()}'!");
    Console.WriteLine();
    int op = 0;

    do {
      op = Menu();
      switch(op){
        case 1: inserirTime(); break;
        case 2: listarTime(); break;
      }
    } while (op != 0);
  }

  public static int Menu(){
    Console.WriteLine("-------------- Escolha uma opção ---------------");
    Console.WriteLine("01 - Inserir time");
    Console.WriteLine("02 - Listar times");
    Console.WriteLine("00 - Finalizar o sistema");
    Console.WriteLine("------------------------------------------------");
    Console.Write("Opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
  public static void menuinserirTime() {
    // MENU PARA INSERIR TIMES
  }
  public static void menulistarTime() {
    // MENU PARA LISTAR OS TIMES
  }
}

class Campeonato {
  private string nome;
  private static Time[] times = new Time[8];
  private int numTimes = 0;

  public Campeonato(string n){
    this.nome = n;
    this.numTimes+=1;
  }
  public void setNameCamp(string n) {
    this.nome = n;
  }

  public string getNameCamp() {
    return this.nome;
  }

  public static void inserirTime() {
    // ADICIONA UM TIME NO CAMPEONATO
  }
  public static void listarTime() {
    // LISTA OS TIMES
  }
}
  
class Time {
  private string nome;
  private static List<Jogador> jogs = new List<Jogador>();
  public void Inserir(Jogador obj){
    /* inserir um jogador no time*/
    jogs.Add(obj);
  }
  public void Listar(){
    foreach(Jogador obj in jogs){
      return obj;
    }
  }
  /*public Atualizar(){
    Jogador aux = Listar()
  }
  public Remover(){
    
  }*/
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
  public override string ToString(){
    $"{nome} , {camisa} , {email}";
  }
}