using System;
using System.Collections.Generic;

public class Campeonato : IComparable {
  public int id { get; set; }
  public string nome { get; set; }
  
  public int CompareTo(object obj){
    Campeonato x = (Campeonato) obj;
    return this.nome.CompareTo(x.nome);
  }
  public override string ToString() {
    return $"{id}: {nome}";
  }
}