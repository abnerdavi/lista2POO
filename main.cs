using System;

class MainClass {
  public static void Main (string[] args) {
    Pessoa individuo = new Pessoa();

    individuo.envelhecer(18);
    individuo.altera_nome("Davi");
    individuo.engordar(60.5);
    individuo.crescer(1.70);

    Console.WriteLine("Nome: {0}", individuo.getNome());
    Console.WriteLine("Idade: {0}",individuo.getIdade());
    Console.WriteLine("Altura: {0} ",individuo.getAltura());
    Console.WriteLine("Peso: {0}",individuo.getPeso());

  }
}