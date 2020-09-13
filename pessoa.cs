/*Classe Pessoa: Crie uma classe que modele uma pessoa:
Atributos: nome, idade, peso e altura
Métodos: Envelhecer, engordar, emagrecer, crescer. 
Obs: Por padrão, a cada ano que nossa pessoa envelhece, sendo a idade dela menor que 21 anos, ela deve crescer 0,5 cm.
*/
using System;

class Pessoa {

  //atributos
  int idade=0; 
  double peso=0, altura=0;
  string nome = null;

  //set 
  public void envelhecer(int anos_maisvelho){

    if (idade < 21 && idade != 0) {
      for(int i=0;i<(anos_maisvelho-idade);i++){
        altura += 0.05;
      }
    }

    idade = anos_maisvelho;
  }

  public void engordar(double kg_amais){
    peso += kg_amais; 
  }

  public void emagrecer(double kg_amenos){
    peso -= kg_amenos; 
  } 

  public void crescer(double crescimento){
    altura += crescimento;
  }

  public void altera_nome(string new_name){
    nome = new_name;
  }

  //get
  public int getIdade(){
    return idade;
  }

  public double getPeso(){
    return peso;
  }

  public double getAltura(){
    return altura;
  }

  public string getNome(){
    return nome;
  }
}
