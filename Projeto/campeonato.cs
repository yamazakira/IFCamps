using System;
using System.Collections.Generic;
class Campeonato {
  private static Time[] times = new Time[8];
  private string nome;
  private static int numTimes;
  private static List<Jogador> jogs = new List<Jogador>();
  public Campeonato(string n){
    this.nome = n;
    numTimes+=1;
  }
  public void setNameCamp(string n) {
    this.nome = n;
  }
  public string getNameCamp() {
    return this.nome;
  }
  // Adiciona um time ao campeonato //
  public static void inserirTime(Time obj) {
    if (numTimes == times.Length)
      Array.Resize(ref times, times.Length + 2);
      /* verifica o tamanho do vetor */
    times[numTimes] = obj;
    numTimes++;
  }
  // Lista os times //
  public static Time[] listarTime() {
    Time[] aux = new Time[numTimes];
    Array.Copy(times, aux, numTimes);
    return aux;
  }
  public static Time listarTime(int id) {
    // percorre o vetor //
    foreach(Time obj in times)
      if(obj != null && obj.getId() == id) return obj;
    return null;
  }
  // Atualiza os times //
  public static void atualizarTime(Time obj){
    // localiza o time com o nome informado //
    Time aux = listarTime(obj.getId());
    // atualiza o nome do time //
    if(aux != null) {
      aux.setId(obj.getId());
      aux.setNomeTime(obj.getNomeTime());
    }
  }

  // Remove um time do campeonato //
  public static void excluirTime() {
    
  }
  
  public static void inserirJogador(Jogador obj) {
    // Insere objeto na lista
    jogs.Add(obj);
  }
  
  public static List<Jogador> listarJogador() {
    // Retorna todos os objetos cadastrados
    return jogs;
  }

  public static void listarJogador(string time) {
    // Retorna os objetos cadastrados por time
    foreach(Jogador obj in jogs) {   
      if (obj.GetTime() == time) Console.WriteLine(obj);    
    }
  }
  
  public static void atualizarJogador() {
    
  }
  
  public static void excluirJogador() {
    
  }
}

// Salve luís, aceita o negócio lá no github e dá commit aí pro teu nome ficar salvo no projeto, segundo botão da esquerda.