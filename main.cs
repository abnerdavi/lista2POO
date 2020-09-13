using System;

class MainClass {

  public static int menu(){
    int escolha=0;
    Console.WriteLine("Dados que podem ser alterados:");
    Console.WriteLine("1 - Idade");
    Console.WriteLine("2 - Peso (engordar)");
    Console.WriteLine("3 - Peso (emagrecer)");
    Console.WriteLine("4 - Altura");
    Console.WriteLine("5 - sair sem alterar");
    Console.Write("Digite a opção desejada: ");
    escolha = int.Parse(Console.ReadLine());

    return escolha;
  }

  public static void Main (string[] args) {
    Pessoa individuo = new Pessoa();
    char op = 'y';
    int esc = 0;


    Console.WriteLine("Digite o nome do usuario:");
    individuo.altera_nome(Console.ReadLine());

    Console.WriteLine("Digite a Idade do usuario:");
    individuo.envelhecer(int.Parse(Console.ReadLine()));
      
    Console.WriteLine("Digite o peso do usuario:");
    individuo.engordar(double.Parse(Console.ReadLine()));

    Console.WriteLine("Digite a altura do usuario:");
    individuo.crescer(double.Parse(Console.ReadLine()));

    do{ 
      
      Console.WriteLine("\nNome: {0}", individuo.getNome());
      Console.WriteLine("Idade: {0}",individuo.getIdade());
      Console.WriteLine("Altura: {0} ",individuo.getAltura());
      Console.WriteLine("Peso: {0}",individuo.getPeso());
    
      Console.WriteLine("\nDeseja alterar algum dado do usuario?(Y/y para sim ou N/n para não)"); 
      op = char.Parse(Console.ReadLine()); 

      if(op == 'y' || op=='Y') {     
        esc = menu();

        switch(esc){
          case 1:
            Console.Write("Digite a nova Idade: ");
            individuo.envelhecer(int.Parse(Console.ReadLine()));
            break;
          case 2:
            Console.Write("Digite quantos quilos a mais: ");
            individuo.engordar(double.Parse(Console.ReadLine()));        
            break;
          case 3:
            Console.Write("Digite quantos quilos a menos: ");
            individuo.emagrecer(double.Parse(Console.ReadLine()));
            break;
          case 4:
            Console.Write("Digite quantos quilos a menos: ");
            individuo.crescer(double.Parse(Console.ReadLine()));
            break;
          case 5:
            Console.Write("OK!");
            break;
          default:
            Console.Write("Opção indisponivel...");
            break;
          }

      }
      
      Console.Clear();

    }while(op=='y' || op == 'Y');
  }
}