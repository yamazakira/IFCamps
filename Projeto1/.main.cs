using System;
using System.Collections.Generic;
class Program {
  public static int idTimes = 1;
  public static int idJogs = 1;
  public static void Main(string[] args) {
    Console.WriteLine("Bem vindo!");
    int op = 0;
    do {
      op = Menu();
      switch(op) {
        case 1 : TimeInserir(); break;
        case 2 : TimeListar(); break;
        case 3 : TimeAtualizar(); break;
        case 4 : TimeExcluir(); break;
        case 5 : JogadorInserir(); break;
        case 6 : JogadorListar(); break;
        case 7 : JogadorAtualizar(); break;
        case 8 : JogadorExcluir(); break;
      }
    } while (op != 0);
  }

  public static int Menu(){
    Console.WriteLine();
    Console.WriteLine("Escolha uma opção:");
    Console.WriteLine();
    Console.WriteLine("01 - Inserir um time");
    Console.WriteLine("02 - Listar times");
    Console.WriteLine("03 - Atualizar um time");
    Console.WriteLine("04 - Excluir um time");
    Console.WriteLine("05 - Inserir um jogador");
    Console.WriteLine("06 - Listar jogadores");
    Console.WriteLine("07 - Atualizar um jogador");
    Console.WriteLine("08 - Excluir um jogador");
    Console.WriteLine("00 - Finalizar sistema");
    Console.WriteLine();
    Console.Write("Opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }

  //TIMES

  // Insere um time
  public static void TimeInserir(){
    Console.WriteLine();
    Console.WriteLine("Inserir novo time");
    Console.WriteLine();
    Console.Write("Informe o nome do time: ");
    Time obj = new Time(Program.idTimes, Console.ReadLine());
    idTimes++;
    Sistema.TimeInserir(obj);
    Console.WriteLine("Sucesso!");
  }
  // Lista os times
  public static void TimeListar(){
    Console.WriteLine();
    Console.WriteLine("Listar times");
    foreach(Time obj in Sistema.TimeListar())
      Console.WriteLine(obj);
  }
  // Atualiza um time
  public static void TimeAtualizar(){
    // AJEITAR AQ DPS PRA N ATUALIZAR UM TIME Q N EXISTE
    Console.WriteLine();
    Console.WriteLine("Atualizar time");
    Console.WriteLine();
    TimeListar();
    Console.Write("Selecione ID do time que deseja atualizar: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Insira o novo nome deste time: ");
    string nome = Console.ReadLine();

    Time obj = new Time(id, nome);
    Sistema.TimeAtualizar(obj);
    Console.WriteLine("Sucesso!");
  }

  // Exclui um time
  public static void TimeExcluir(){
    Console.WriteLine();
    Console.WriteLine("Excluir um time");
    Console.WriteLine();
    TimeListar();
    Console.Write("Selecione ID do time que deseja excluir: ");
    int id = int.Parse(Console.ReadLine());
    string nome = "";

    Time obj = new Time(id, nome);
    Sistema.TimeExcluir(obj);
    Console.WriteLine("Sucesso!");
  }

  //JOGADORES

  // Insere um Jogador
  public static void JogadorInserir(){
    Console.WriteLine();
    Console.WriteLine("Inserir novo jogador");
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
      Jogador obj = new Jogador(idJogs, nome, camisa, email, Sistema.TimeNPID(int.Parse(Console.ReadLine())));
      Sistema.JogadorInserir(obj);
      idJogs++;
      Console.WriteLine("Sucesso!");
    }
    catch (NullReferenceException){
      Console.WriteLine("Opa! Não existe um time com esse ID!");
    }
  }
  
  public static void JogadorListar(){
    Console.WriteLine();
    Console.WriteLine("Listar jogadores");
    foreach(Jogador obj in Sistema.JogadorListar())
      Console.WriteLine(obj);
  }
  
  public static void JogadorAtualizar(){
    string timenome = null;
    Console.WriteLine();
    Console.WriteLine("Atualizar jogador");
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
    Jogador jog = new Jogador(id, nome, camisa, email, timenome);
    Sistema.JogadorAtualizar(jog);
    Console.WriteLine("Sucesso!");
  }

  public static void JogadorExcluir(){
    Console.WriteLine();
    Console.WriteLine("Excluir um jogador");
    Console.WriteLine();
    JogadorListar();
    Console.Write("Selecione ID do jogador que deseja excluir: ");
    int id = int.Parse(Console.ReadLine());
    Jogador obj = new Jogador(id);
    Sistema.JogadorExcluir(obj);
    Console.WriteLine("Sucesso!");
  }
}