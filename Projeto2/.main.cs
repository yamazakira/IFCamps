using System;
using System.Collections.Generic;

class Program {
  public static int idcamp;
  
  public static void Main(string[] args) {
    Console.WriteLine();
    Console.WriteLine("Bem vindo!");
    int opC = 0;
    int op = 0;

    try {
      Sistema.ArquivosAbrir();
    }
    catch(Exception erro) {
      Console.WriteLine(erro);
    }
    // Menu de campeonato(parte 1)
    do {
      try{ 
        opC = MenuCamps();
        switch(opC) {
          case 1 : CampEscolher(); break;
          case 2 : CampInserir(); break;
        }
      }
      catch(Exception erro){
        opC = -1;
        Console.WriteLine("Erro:" + erro.Message);
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();
      }
    } while (opC!= 0);
    
    /*do {
      try{ 
        op2 = MenuContinuar();
        switch(op2) {
          case 1 : MenuOp(); break;
        }
      }
      catch(Exception erro){
        op2 = -1;
        Console.WriteLine("Erro:" + erro.Message);
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();
      }
    } while (op2!= 0);*/
    
    // Menu de opções(parte 1)
    do {
      try{
        op = MenuOp();
        switch(op) {
                     
          case 1 : CampEscolher(); break;
          case 2 : CampInserir(); break;
          case 3 : CampListar(); break;
          case 4 : CampAtualizar(); break;
          case 5 : CampExcluir(); break;
          case 6 : TimeInserir(); break;
          case 7 : TimeListar(); break;
          case 8 : TimeAtualizar(); break;
          case 9 : TimeExcluir(); break;
          case 10 : JogadorInserir(); break;
          case 11: JogadorListar(); break;
          case 12: JogadorAtualizar(); break;
          case 13: JogadorExcluir(); break;
               
        }
      }
      catch(Exception erro){
        op = -1;
        Console.WriteLine("Erro:" + erro.Message);
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();
      }
    } while (op != 0);
    
    try {
      Sistema.ArquivosSalvar();
    }
    catch(Exception erro) {
      Console.WriteLine(erro);
    }
  }
  // Menu de campeonato (parte 2)
  public static int MenuCamps() {
    if(idcamp != 0) return 0;
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine();
    Console.WriteLine("01 - Administrar campeonato existente");
    Console.WriteLine("02 - Inserir novo campeonato");
    Console.WriteLine();
    Console.Write("Opção: ");
    int opC = int.Parse(Console.ReadLine());
    Console.WriteLine("--------------------------------------------"); 
    Console.WriteLine();
    return opC;
  }
  
  //Menu para continuar ou não
  /*public static int MenuContinuar(){
    Console.WriteLine();
    Console.Write("Digite 1 para continuar");
    int op2 = int.Parse(Console.ReadLine());
    Console.WriteLine("--------------------------------------------");
    return op2;
  }*/
  
  // Menu de operações
  public static int MenuOp(){
    Console.WriteLine("Você está no campeonato de ID " + idcamp);
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine();
    Console.WriteLine("--------------- Campeonatos ----------------");
    Console.WriteLine("01 - Mudar de campeonato");
    Console.WriteLine("02 - Inserir novo campeonato");
    Console.WriteLine("03 - Listar campeonato(s)");
    Console.WriteLine("04 - Atualizar um campeonato");
    Console.WriteLine("05 - Excluir um campeonato");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("------------------ Times -------------------");
    Console.WriteLine("06 - Inserir um time");
    Console.WriteLine("07 - Listar times");
    Console.WriteLine("08 - Atualizar um time");
    Console.WriteLine("09 - Excluir um time");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("---------------- Jogadores -----------------");
    Console.WriteLine("10 - Inserir um jogador");
    Console.WriteLine("11 - Listar jogadores");
    Console.WriteLine("12 - Atualizar um jogador");
    Console.WriteLine("13 - Excluir um jogador");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("00 - Finalizar sistema e salvar informações");
    Console.WriteLine("--------------------------------------------");
    Console.Write("Opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  //CAMPEONATO 

  // Escolher um campeonato existente
  public static void CampEscolher() {
    bool IdExiste = false;
    Console.WriteLine("Escolher um campeonato existente");
    Console.WriteLine();
    if(Sistema.camps.Count > 0) {
      CampListar();
      Console.Write("Insira o ID do campeonato que deseja administrar: ");
      idcamp = int.Parse(Console.ReadLine());
      foreach(Campeonato aux in Sistema.CampListar()) {
        if(aux.id == idcamp) {
          IdExiste = true;
        }
      }
      if(IdExiste == true) {
        Console.WriteLine("Sucesso!");
        Console.WriteLine("--------------------------------------------"); 
        Console.WriteLine();
      }
      else {
        Console.WriteLine("Opa! Não existe um campeonato com esse ID!");
        Console.WriteLine("--------------------------------------------"); 
        Console.WriteLine();
        CampEscolher();
      }
    }
    else {
      Console.WriteLine("Não há campeonatos para escolher!");
      Console.WriteLine("--------------------------------------------"); 
      Console.WriteLine();
    }
  }
  // Inserir um campeonato
  public static void CampInserir() {
    Console.WriteLine("Inserir campeonato ");
    Console.WriteLine();
    Console.Write("Insira o nome do novo campeonato: ");
    string nnome = Console.ReadLine();
    Campeonato cobj = new Campeonato { nome = nnome };
    Sistema.CampInserir(cobj);
    /*idcamp = cobj.id;*/
    Console.WriteLine("Sucesso!");
    Console.WriteLine("--------------------------------------------"); 
    Console.WriteLine();
  }
  // Listar os campeonatos
  public static void CampListar() {
    Console.WriteLine("Listar Campeonatos");
    foreach(Campeonato obj in Sistema.CampListar()){ 
      Console.WriteLine(obj);
    }
    Console.WriteLine();
  }
  
  // Atualizar um campeonato
  public static void CampAtualizar() {
    bool IdExiste = false;
    Console.WriteLine("Atualizar campeonato");
    Console.WriteLine();
    CampListar();
    Console.Write("Insira o ID do campeonato que deseja atualizar: ");
    int nid = int.Parse(Console.ReadLine());
    Console.Write("Insira o novo nome desse campeonato: ");
    string nnome = Console.ReadLine();
    try {
      foreach(Campeonato aux in Sistema.CampListar()) {
        if(aux.id == nid) {
          IdExiste = true;
        }
      }
      if(IdExiste == true) {
        Campeonato obj = new Campeonato { id = nid, nome = nnome };
        Sistema.CampAtualizar(obj);
        Console.WriteLine("Sucesso!");
        Console.WriteLine();
      }
      else {
        Console.WriteLine("Opa! Não existe um campeonato com esse ID!");
        Console.WriteLine();
        CampEscolher();
      }
    }
    catch (NullReferenceException){
      Console.WriteLine("Opa! Não existe um campeonato com esse ID!");
      Console.WriteLine();
      CampEscolher();
    }
  }
    
  // Exclui um campeonato
  public static void CampExcluir() {
    bool IdExiste = false;
    Console.WriteLine("Excluir campeonato");
    Console.WriteLine();
    Console.WriteLine("Isso irá excluir também todos os times e jogadores participantes do campeonato escolhido. Você deve estar administrando outro campeonato para executar essa ação.");
    Console.WriteLine();
    CampListar();
    Console.Write("Insira o ID do campeonato que deseja excluir: ");
    int eid = int.Parse(Console.ReadLine());
    Campeonato obj = new Campeonato {id = eid};
    for(int t = Sistema.camps.Count - 1; t >= 0; t--) 
      if(Sistema.camps[t].id == eid && eid != idcamp) IdExiste = true;

    if(IdExiste == true) {              
      // Excluir times deste campeonato
      foreach(Time auxi in Sistema.TimeListar()){
        if(auxi.GetIdCamp() == eid ) {
          Time exc1 = new Time(auxi.GetId(), "", eid);
          Sistema.TimeExcluir(exc1);
        }
      }
      // Excluir jogadores deste campeonato
      for(int i = Sistema.jogs.Count - 1; i >= 0; i--) {
        if(Sistema.jogs[i].GetIdCamp() == eid) Sistema.jogs.Remove(Sistema.jogs[i]);
      }
      
      Sistema.CampExcluir(obj);
      Console.WriteLine("Sucesso!"); 
    }
    else {
        Console.WriteLine("Ops! Não existe um campeonato com este ID ou você não pode exclui-lo no momento!");
    }
    Console.WriteLine();
  }
  //TIMES

  // Insere um time
  public static void TimeInserir(){
    Console.WriteLine("Inserir novo time");
    Console.WriteLine();
    Console.Write("Informe o nome do time: ");
    Time obj = new Time(0, Console.ReadLine(), idcamp);
    Sistema.TimeInserir(obj);
    Console.WriteLine("Sucesso!");
    Console.WriteLine();
  }
  // Lista os times
  public static void TimeListar(){
    Console.WriteLine("Listar times ");
    foreach(Time obj in Sistema.TimeListar())
      if(obj.GetIdCamp() == idcamp)
        Console.WriteLine(obj);
    Console.WriteLine();
  }
  // Atualiza um time
  public static void TimeAtualizar(){
    bool IdExiste = false;
    Console.WriteLine("Atualizar time ");
    Console.WriteLine();
    TimeListar();
    Console.Write("Selecione ID do time que deseja atualizar: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Insira o novo nome deste time: ");
    string nome = Console.ReadLine();
    try {
      /*int idjog = int.Parse(Console.ReadLine());*/
      foreach(Time aux in Sistema.TimeListar()) {
        if(aux.GetId() == id && aux.GetIdCamp() == idcamp) {
          IdExiste = true;
        }
      }
      if(IdExiste == true) {
        Time obj = new Time(id , nome , idcamp);
        Sistema.TimeAtualizar(obj);
        Console.WriteLine("Sucesso!");
        Console.WriteLine();
      }
      else {
        Console.WriteLine("Opa! Não existe um time com esse ID!");
        Console.WriteLine();
      }
    }
    catch (NullReferenceException){
      Console.WriteLine("Opa! Não existe um time com esse ID!");
    }
  }
  // Exclui um time
  public static void TimeExcluir(){
    bool IdExiste = false;
    Console.WriteLine();
    Console.WriteLine("Excluir um time ");
    Console.WriteLine();
    TimeListar();
    Console.Write("Selecione ID do time que deseja excluir: ");
    int id = int.Parse(Console.ReadLine());
    string nome = "";
    try {
      /*int idjog = int.Parse(Console.ReadLine());*/
      foreach(Time aux in Sistema.TimeListar()) {
        if(aux.GetId() == id && aux.GetIdCamp() == idcamp) {
          IdExiste = true;
        }
      }
      if(IdExiste == true) {
        Time obj = new Time(id , nome , idcamp);
        Sistema.TimeExcluir(obj);
        Console.WriteLine("Sucesso!");
        Console.WriteLine();
      }
      else {
        Console.WriteLine("Opa! Não existe um time com esse ID!");
        Console.WriteLine();
      }
    }
    catch (NullReferenceException){
      Console.WriteLine("Opa! Não existe um time com esse ID!");
      Console.WriteLine();
    }
  }

  //JOGADORES

  // Insere um jogador
  public static void JogadorInserir(){
    bool IdExiste = false;
    Console.WriteLine("Inserir novo jogador ");
    Console.WriteLine();
    Console.Write("Informe o nome do jogador: ");
    string nome = Console.ReadLine();
    Console.Write("Informe a camisa do jogador: ");
    int camisa = int.Parse(Console.ReadLine());
    Console.Write("Informe o email do jogador: ");
    string email = Console.ReadLine();
    Console.WriteLine();
    TimeListar();
    /*foreach(Time t in Sistema.TimeListar()) Console.WriteLine(t);*/
    Console.Write("Para finalizar, informe ID do time do jogador: ");
    try {
      int idtime = int.Parse(Console.ReadLine());
      foreach(Time aux in Sistema.TimeListar()) {
        if(aux.GetId() == idtime && aux.GetIdCamp() == idcamp) {
          IdExiste = true;
        }
      }
      if(IdExiste == true) {
        Jogador obj = new Jogador(0, nome, camisa, email, idtime, idcamp);
        Sistema.JogadorInserir(obj);
        Console.WriteLine("Sucesso!");
      }
      else {
        Console.WriteLine("Opa! Não existe um time com esse ID no campeonato atual!");
      }
      Console.WriteLine();
    }
    catch (NullReferenceException){
      Console.WriteLine("Opa! Não existe um time com esse ID no campeonato atual!");
      Console.WriteLine();
    }
  }
  // Lista os jogadores
  public static void JogadorListar(){
    Console.WriteLine();
    Console.WriteLine("Listar jogadores ");
    foreach(Jogador obj in Sistema.JogadorListar())
      if(obj.GetIdCamp() == idcamp)
        Console.WriteLine(obj);
    Console.WriteLine();
  }
  // Atualiza um jogador
  //VERIFICAR SE TÁ ATUALIZANDO MSM
  public static void JogadorAtualizar(){
    int timeid = 0;
    bool IdExiste = false;
    Console.WriteLine("Atualizar jogador ");
    JogadorListar();
    Console.Write("Selecione ID do jogador que deseja atualizar: ");
    int idjog = int.Parse(Console.ReadLine());
    foreach(Jogador aux in Sistema.JogadorListar()) {
      if(aux.GetId() == idjog && aux.GetIdCamp() == idcamp) {
        IdExiste = true;
      }
    }
    if(IdExiste == true) {
        Console.Write("Insira o novo nome deste jogador: ");
        string nome = Console.ReadLine();
        Console.Write("Insira a nova camisa deste jogador: ");
        int camisa = int.Parse(Console.ReadLine());
        Console.Write("Insira o novo email deste jogador: ");
        string email = Console.ReadLine();
        Jogador obj = new Jogador(idjog, nome, camisa, email, timeid, idcamp);
        Sistema.JogadorAtualizar(obj);
        Console.WriteLine("Sucesso!");
    }
    else {
      Console.WriteLine("Opa! Não existe um jogador com esse ID!");
    }
  
    Console.WriteLine();
  }
  // Exclui um jogador
  public static void JogadorExcluir(){
    bool IdExiste = false;
    Console.WriteLine("Excluir um jogador ");
    Console.WriteLine();
    JogadorListar();
    Console.Write("Selecione ID do jogador que deseja excluir: ");
    try {
      int idjog = int.Parse(Console.ReadLine());
      foreach(Jogador aux in Sistema.JogadorListar()) {
        if(aux.GetId() == idjog && aux.GetIdCamp() == idcamp) {
          IdExiste = true;
        }
      }
      if(IdExiste == true) {
        Jogador obj = new Jogador(idjog);
        Sistema.JogadorExcluir(obj);
        Console.WriteLine("Sucesso!");
        Console.WriteLine();
      }
      else {
        Console.WriteLine("Opa! Não existe um jogador com esse ID!");
        Console.WriteLine();
      }
    }
    catch (NullReferenceException){
      Console.WriteLine("Opa! Não existe um jogador com esse ID!");
      Console.WriteLine();
    }
  }
    /*int id = int.Parse(Console.ReadLine());
    Jogador obj = new Jogador(id);
    Sistema.JogadorExcluir(obj);
    Console.WriteLine("Sucesso!");*/
}