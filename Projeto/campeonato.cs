using System;
using System.Collections.Generic;

class Campeonato {
  private string nome;
  private static Time[] times = new Time[8];
  private static int numTimes;

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

  public static void inserirTime(Time obj) {
    // ADICIONA UM TIME NO CAMPEONATO
    if (numTimes == times.Length)
      Array.Resize(ref times, times.Length + 2);

    times[numTimes] = obj;
    numTimes++;
  }
  public static Time[] listarTimes() {
    // LISTA OS TIMES
    Time[] aux = new Time[numTimes];
    Array.Copy(times, aux, numTimes);
    return aux;
  }

  public static void inserirJogador() {
    
  }
}