using System;
using System.Collections.Generic;

class Sistema {
  private static Time[] times = new Time[8];
  private static int nTimes;
  private static List<Jogador> jogs = new List<Jogador>();

  //TIMES
  public static void TimeInserir(Time obj){
    if (nTimes == times.Length)
      Array.Resize(ref times, 2+times.Length);
    times[nTimes] = obj;
    nTimes++;
  }
  public static Time[] TimeListar(){
    Time[] aux = new Time[nTimes];
    Array.Copy(times, aux, nTimes);
    return aux;
  }
  public static Time TimeListar(int id){
    foreach(Time obj in times)
      if(obj != null && obj.GetId() == id) return obj;
    return null;
  }

  public static void TimeAtualizar(Time obj){
    Time aux = TimeListar(obj.GetId());
    if(aux != null)
      aux.SetNome(obj.GetNome());
  }

  public static void TimeExcluir(Time obj){
    int aux = TimeIndice(obj.GetId());
    if (aux != -1){
      for(int i = aux; i < nTimes - 1; i++)
        times[i] = times[i+1];
      nTimes--;
    }
  }

  private static int TimeIndice(int id){
    for(int i = 0; i < nTimes; i++){
      Time obj = times[i];
      if(obj.GetId() == id) return i;
    }
    return -1;
  }

  //JOGADORES
  public static void JogadorInserir(Jogador obj){
    jogs.Add(obj);
  }
  
  public static List<Jogador> JogadorListar(){
    return jogs;
  }
  
  public static Jogador JogadorListar(int id){
    foreach(Jogador obj in jogs)
      if(obj.GetId() == id) return obj;
    return null;
  }

  public static void JogadorAtualizar(Jogador obj){
    Jogador aux = JogadorListar(obj.GetId());
    if(aux != null)
      aux.SetNome(obj.GetNome());
      aux.SetCamisa(obj.GetCamisa());
      aux.SetEmail(obj.GetEmail());
      aux.SetTime(obj.GetTime());
  }

  public static void JogadorExcluir(Jogador obj){
    Jogador aux = JogadorListar(obj.GetId());
    if(aux != null) jogs.Remove(aux);
  }

  //Nome por id - times
  public static string TimeNPID(int id) {
    foreach(Time obj in times) {
      if(obj.GetId() == id) return obj.GetNome();
    }
    return null;
  }
}
