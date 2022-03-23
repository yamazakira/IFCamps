using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Text;

class Arquivo<T> {
  public T Abrir(string Arquivo) {
    XmlSerializer xml = new XmlSerializer(typeof(T));
    StreamReader f = new StreamReader(Arquivo, Encoding.Default);
    T obj = (T) xml.Deserialize(f);
    f.Close();
    return obj;
  }
  public void Salvar(string Arquivo, T obj) {
    XmlSerializer xml = new XmlSerializer(typeof(T));
    StreamWriter f = new StreamWriter(Arquivo, false, Encoding.Default);
    xml.Serialize(f, obj);
    f.Close();
  }
  
    /*public static void ArquivosAbrir() {
    XmlSerializer xml = new XmlSerializer(typeof(Time[]));
    StreamReader f = new StreamReader("./times.xml", Encoding.Default);
    times = (Time[]) xml.Deserialize(f);
    nTimes = times.Length;
    f.Close();
  }
  public static void ArquivosSalvar() {
    XmlSerializer xml = new XmlSerializer(typeof(Time[]));
    StreamWriter f = new StreamWriter("./times.xml", false, Encoding.Default);
    xml.Serialize(f, TimeListar());
    f.Close();
  }*/
  
}