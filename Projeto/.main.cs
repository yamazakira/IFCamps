using System;
using System.Collections.Generic;


class Program {

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
        case 1: menuinserirTime(); break;
        case 2: menulistarTime(); break;
      }
    } while (op != 0);
  }

  public static int Menu(){
    Console.WriteLine("-------------- Escolha uma opção ---------------");
    Console.WriteLine("01 Inserir time ");
    Console.WriteLine("02 Listar times ");
    Console.WriteLine("00 Finalizar o sistema");
    Console.WriteLine("------------------------------------------------");
    Console.Write("Opção: ");
    int op = int.Parse(Console.ReadLine());
    Console.WriteLine();
    return op;
  }
  public static void menuinserirTime() {
    Console.WriteLine("-------------- Inserir novo time ---------------");
    Console.Write("Digite o nome do novo time: ");
    string novoTime = Console.ReadLine();
    Console.Write("Quantos jogadores terá o time? ");
    
    for (int i = int.Parse(Console.ReadLine()); i > 0; i--){
      Console.Write("Insira o nome do novo jogador: ");
      string nomeNovoJog = Console.ReadLine();
      Console.Write("Insira a camisa do novo jogaor: ");
      int camisaNovoJog = int.Parse(Console.ReadLine());
      Console.Write("Insira o email do novo jogador: ");
      string emailNovoJog = Console.ReadLine();

      Jogador jog = new Jogador(nomeNovoJog, camisaNovoJog, emailNovoJog, novoTime);
    }

    // A FAZER: CRIAR UMA LISTA AQUI COM OS JOGADORES, ATRIBUIR ESSA LISTA À LISTA NA CLASSE 'TIME' E FAZER COM QUE O CONSTRUTOR TENHA UM PARAMETRO PRA LISTA.
    Time obj = new Time(novoTime);
    Campeonato.inserirTime(obj);

  }
  public static void menulistarTime() {
    foreach (Time obj in Campeonato.listarTimes())
      Console.WriteLine(obj);
  }
} 
