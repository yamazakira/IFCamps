using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Text;

class Sistema {
  private static Time[] times = new Time[8];
  private static int nTimes;
  private static List<Jogador> jogs = new List<Jogador>();
  private static List<Campeonato> camps = new List<Campeonato>();

  // ARQUIVOS
  
  public static void ArquivosAbrir() {
    Arquivo<Time[]> f1 = new Arquivo<Time[]>();
    times = f1.Abrir("./times.xml");
    nTimes = times.Length;

    Arquivo<List<Jogador>> f2 = new Arquivo<List<Jogador>>();
    jogs = f2.Abrir("./jogadores.xml");

    Arquivo<List<Campeonato>> f3 = new Arquivo<List<Campeonato>>();
    camps = f3.Abrir("./campeonatos.xml");
    /*
    StreamReader f = new StreamReader("./times.xml", Encoding.Default);
    times = (Time[]) xml.Deserialize(f);
    nTimes = times.Length;
    f.Close();*/
  }
  public static void ArquivosSalvar() {
    Arquivo<Time[]> f1 = new Arquivo<Time[]>();
    f1.Salvar("./times.xml", TimeListar());

    Arquivo<List<Jogador>> f2 = new Arquivo<List<Jogador>>();
    f2.Salvar("./jogadores.xml", jogs);

    Arquivo<List<Campeonato>> f3 = new Arquivo<List<Campeonato>>();
    f3.Salvar("./campeonatos.xml", camps);
    /*
    XmlSerializer xml = new XmlSerializer(typeof(Time[]));
    StreamWriter f = new StreamWriter("./times.xml", false, Encoding.Default);
    xml.Serialize(f, TimeListar());
    f.Close();*/
  }
  
  //CAMPEONATOS

  // Insere um campeonato
  public static void CampInserir(Campeonato obj) {

    // COPIAR PRA TIMES E JOGS
    int id = 0;
    foreach(Campeonato aux in camps)
      if(aux.id > id) id = aux.id;
    obj.id = id+1;
    camps.Add(obj);
  }
  // Lista os campeonatos
  public static List<Campeonato> CampListar() {
    camps.Sort();
    return camps;
  }
  public static Campeonato CampListar(int id) {
    foreach(Campeonato obj in camps)
      if(obj.id == id) return obj;
    return null;
  }
  // Atualiza um campeonato
  public static void CampAtualizar(Campeonato obj) {
    Campeonato aux = CampListar(obj.id);
    if(aux != null) {
      aux.nome = obj.nome;
    }
  }
  // Exclui um campeonato
  public static void CampExcluir(Campeonato obj) {
    Campeonato aux = CampListar(obj.id);
    if(aux != null) camps.Remove(aux);
  }

  //TIMES

  //Insere um time no campeonato
  public static void TimeInserir(Time obj){
    if (nTimes == times.Length)
      Array.Resize(ref times, 2+times.Length);
    times[nTimes] = obj;
    /*int id = 0;
    foreach(Time aux in times)
      if(aux.id > id) id = aux.id;
    obj.id = id+1;*/
    nTimes++;
  }
  // Lista os times
  public static Time[] TimeListar(){
    Time[] aux = new Time[nTimes];
    Array.Copy(times, aux, nTimes);
    Array.Sort(aux);
    return aux;
  }
  public static Time TimeListar(int id){
    foreach(Time obj in times)
      if(obj != null && obj.GetId() == id) return obj;
    return null;
  }
  // Atualiza um time
  public static void TimeAtualizar(Time obj){
    Time aux = TimeListar(obj.GetId());
    if(aux != null)
      aux.SetNome(obj.GetNome());
  }
  // Exclui um time
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

  // Insere um jogador 
  public static void JogadorInserir(Jogador obj){
    
    jogs.Add(obj);
  }
  // Lista os jogadores
  public static List<Jogador> JogadorListar(){
    jogs.Sort();
    return jogs;
  }
  public static Jogador JogadorListar(int id){
    foreach(Jogador obj in jogs)
      if(obj.GetId() == id) return obj;
    return null;
  }
  // Atualiza um jogador
  public static void JogadorAtualizar(Jogador obj){
    Jogador aux = JogadorListar(obj.GetId());
    if(aux != null)
      aux.SetNome(obj.GetNome());
      aux.SetCamisa(obj.GetCamisa());
      aux.SetEmail(obj.GetEmail());
      aux.SetTime(obj.GetTime());
  }
  // Exclui um jogador
  public static void JogadorExcluir(Jogador obj){
    Jogador aux = JogadorListar(obj.GetId());
    if(aux != null) jogs.Remove(aux);
  }

  //nome por id - times
  public static string TimeNPID(int id) {
    foreach(Time obj in times) {
      if(obj.GetId() == id) return obj.GetNome();
    }
    return null;
  }
}
