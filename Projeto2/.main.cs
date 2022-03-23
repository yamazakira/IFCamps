using System;
using System.Collections.Generic;
class Program {
  public static int idTimes = 1;
  public static int idJogs = 1;
  public static int idcamp = 1;
  public static int opC;
  
  public static void Main(string[] args) {
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
    } while (op!= 0);
    // Menu de opções
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
    Console.WriteLine("Bem vindo!");
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine();
    Console.WriteLine("01 - Administrar campeonato existente");
    Console.WriteLine("02 - Inserir novo campeonato");
    Console.WriteLine();
    Console.Write("Opção: ");
    int opC = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return opC;
  }
  // Menu de operações
  public static int MenuOp(){
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine();
    // CRIAR MENU DE CAMPEONATO(opcional)
    Console.WriteLine("--------------- Campeonatos ----------------");
    Console.WriteLine("01 - Mudar de campeonato");
    Console.WriteLine("02 - Inserir novo campeonato");
    Console.WriteLine("03 - Listar campeonato(s)");
    Console.WriteLine("04 - Atualizar um campeonato");
    Console.WriteLine("05 - Excluir um campeonato");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    //CRIAR MENU DE TIMES(opcional)
    Console.WriteLine("------------------ Times -------------------");
    Console.WriteLine("06 - Inserir um time");
    Console.WriteLine("07 - Listar times");
    Console.WriteLine("08 - Atualizar um time");
    Console.WriteLine("09 - Excluir um time");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    // CRIAR MENU DE JOGADORES(opcional)
    Console.WriteLine("---------------- Jogadores -----------------");
    Console.WriteLine("10 - Inserir um jogador");
    Console.WriteLine("11 - Listar jogadores");
    Console.WriteLine("12 - Atualizar um jogador");
    Console.WriteLine("13 - Excluir um jogador");
    Console.WriteLine("--------------------------------------------");
    Console.WriteLine();
    Console.WriteLine("00 - Finalizar sistema");
    Console.WriteLine("--------------------------------------------");
    Console.Write("Opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  //CAMPEONATO 

  // Escolher um campeonato existente
  public static void CampEscolher() {
    Console.WriteLine();
    Console.WriteLine("Escolher um campeonato existente");
    Console.WriteLine();
    CampListar();
    Console.Write("Insira o ID do campeonato que deseja administrar: ");
    idcamp = int.Parse(Console.ReadLine());
    opC = 0;
    Console.WriteLine("--------------------------------------------");
  }
  // Inserir um campeonato
  public static void CampInserir() {
    Console.WriteLine("Inserir campeonato ");
    Console.WriteLine();
    Console.Write("Insira o nome do novo campeonato: ");
    string nnome = Console.ReadLine();
    Campeonato cobj = new Campeonato { nome = nnome };
    Sistema.CampInserir(cobj);
    Console.WriteLine();
    idcamp = cobj.id;
    Console.WriteLine("Sucesso!");
    Console.WriteLine("--------------------------------------------");
  }
  // Listar os campeonatos
  public static void CampListar() {
    foreach(Campeonato obj in Sistema.CampListar()){ 
      Console.WriteLine(obj);
    }
  }
  // Atualizar um campeonato
  //VERIFICAR SE O CAMP EXISTE
  public static void CampAtualizar() {
    Console.WriteLine("Atualizar campeonato");
    Console.WriteLine();
    CampListar();
    Console.Write("Insira o ID do campeonato que deseja atualizar: ");
    int nid = int.Parse(Console.ReadLine());
    Console.Write("Insira o novo nome desse campeonato: ");
    string nnome = Console.ReadLine();
    Campeonato obj = new Campeonato { id = nid, nome = nnome };
    Sistema.CampAtualizar(obj);
    Console.WriteLine("Sucesso!");
    Console.WriteLine("--------------------------------------------");
  }
  // Exclui um campeonato
  //VERIFICAR SE O CAMP EXISTE
  public static void CampExcluir() {
    Console.WriteLine("Excluir campeonato ");
    Console.WriteLine();
    CampListar();
    Console.Write("Insira o ID do campeonato que deseja excluir: ");
    int eid = int.Parse(Console.ReadLine());
    Campeonato obj = new Campeonato {id = eid};
    Sistema.CampExcluir(obj);
    Console.WriteLine("Sucesso!");
    Console.WriteLine("--------------------------------------------");
  }

  //TIMES

  // Insere um time
  public static void TimeInserir(){
    Console.WriteLine("------------ Inserir novo time -------------");
    Console.WriteLine();
    Console.Write("Informe o nome do time: ");
    Time obj = new Time(Program.idTimes, Console.ReadLine(), idcamp);
    idTimes++;
    Sistema.TimeInserir(obj);
    Console.WriteLine("Sucesso!");
    Console.WriteLine("--------------------------------------------");
  }
  // Lista os times
  public static void TimeListar(){
    Console.WriteLine();
    Console.WriteLine("Listar times ");
    foreach(Time obj in Sistema.TimeListar())
      if(obj.GetIdCamp() == idcamp)
        Console.WriteLine(obj);
    Console.WriteLine("--------------------------------------------");
  }
  // Atualiza um time
  // VERIFICAR SE QUANDO ATUALIZA O NOME DO TIME ATUALIZA PRO JOG TB
  // VERIFICAR SE O TIME EXISTE
  public static void TimeAtualizar(){
    Console.WriteLine();
    Console.WriteLine("Atualizar time ");
    Console.WriteLine();
    TimeListar();
    Console.Write("Selecione ID do time que deseja atualizar: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Insira o novo nome deste time: ");
    string nome = Console.ReadLine();

    Time obj = new Time(id, nome, idcamp);
    Sistema.TimeAtualizar(obj);
    Console.WriteLine("Sucesso!");
    Console.WriteLine("--------------------------------------------");
  }
  // Exclui um time
  //VERIFICAR SE O TIME EXISTE
  public static void TimeExcluir(){
    Console.WriteLine();
    Console.WriteLine(" Excluir um time ");
    Console.WriteLine();
    TimeListar();
    Console.Write("Selecione ID do time que deseja excluir: ");
    int id = int.Parse(Console.ReadLine());
    string nome = "";

    Time obj = new Time(id, nome, idcamp);
    Sistema.TimeExcluir(obj);
    Console.WriteLine("Sucesso!");
    Console.WriteLine("--------------------------------------------");
  }

  //JOGADORES

  // Insere um jogador
  // VERIFICAR SE TÁ INSERINDO JOG EM UM TIME Q N EXISTE
  public static void JogadorInserir(){
    Console.WriteLine("Inserir novo jogador ");
    Console.WriteLine();
    Console.Write("Informe o nome do jogador: ");
    string nome = Console.ReadLine();
    Console.Write("Informe a camisa do jogador: ");
    int camisa = int.Parse(Console.ReadLine());
    Console.Write("Informe o email do jogador: ");
    string email = Console.ReadLine();
    Console.WriteLine();
    foreach(Time t in Sistema.TimeListar()) Console.WriteLine(t);
    Console.Write("Para finalizar, informe ID do time do jogador: ");
    try {
      Jogador obj = new Jogador(idJogs, nome, camisa, email, Sistema.TimeNPID(int.Parse(Console.ReadLine())), idcamp);
      Sistema.JogadorInserir(obj);
      idJogs++;
      Console.WriteLine("Sucesso!");
      Console.WriteLine("--------------------------------------------");
    }
    catch (NullReferenceException){
      Console.WriteLine("Opa! Não existe um time com esse ID!");
    }
  }
  // Lista os jogadores
  public static void JogadorListar(){
    Console.WriteLine();
    Console.WriteLine("Listar jogadores ");
    foreach(Jogador obj in Sistema.JogadorListar())
      Console.WriteLine(obj);
    Console.WriteLine("--------------------------------------------");
  }
  // Atualiza um jogador
  // VERIFICAR SE O JOGADOR EXISTE
  public static void JogadorAtualizar(){
    string timenome = null;
    Console.WriteLine();
    Console.WriteLine(" Atualizar jogador ");
    Console.WriteLine();
    foreach(Jogador j in Sistema.JogadorListar()) Console.WriteLine(j);
    Console.Write("Selecione ID do jogador que deseja atualizar: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Insira o novo nome deste jogador: ");
    string nome = Console.ReadLine();
    Console.Write("Insira a nova camisa deste jogador: ");
    int camisa = int.Parse(Console.ReadLine());
    Console.Write("Insira o novo email deste jogador: ");
    string email = Console.ReadLine();
    foreach(Jogador obj in Sistema.JogadorListar()){
      if(obj.GetId() == id) timenome = obj.GetTime();
    }
    Jogador jog = new Jogador(id, nome, camisa, email, timenome, idcamp);
    Sistema.JogadorAtualizar(jog);
    Console.WriteLine("Sucesso!");
    Console.WriteLine("--------------------------------------------");
  }
  // Exclui um jogador
  //VERIFICAR SE O JOGADOR EXISTE
  public static void JogadorExcluir(){
    Console.WriteLine();
    Console.WriteLine(" Excluir um jogador ");
    Console.WriteLine();
    JogadorListar();
    Console.Write("Selecione ID do jogador que deseja excluir: ");
    int id = int.Parse(Console.ReadLine());
    Jogador obj = new Jogador(id);
    Sistema.JogadorExcluir(obj);
    Console.WriteLine("Sucesso!");
    Console.WriteLine("--------------------------------------------");
  }
}