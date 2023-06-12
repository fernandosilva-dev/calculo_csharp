//Algoritmo que lê o numero escolhido pelo usuário e retorna na tela e calcula ele!
using System;

namespace calculo
  {
  class Program
    {
    static void Main(string[] args)
      {
      //Declaração das variáveis
      float vOperador,vN1, vN2; 
     
     //Inserção do primeiro numero para a  operação
      Console.WriteLine("Insira o primeiro numero da operação: ");
      vN1 = float.Parse(Console.ReadLine());

      ////////////////////////////////////////////////////////////

      //Inserção do segundo numero para a  operação
      Console.WriteLine("Insira o segundo numero da operação: ");
      vN2 = float.Parse(Console.ReadLine());
     
     ////////////////////////////////////////////

      //Digite a operação desejada
      Console.WriteLine("Selecione uma operação: (1) Adição, (2) Subtração, (3) Multiplicação, (4) Divisão: ");
      vOperador = float.Parse(Console.ReadLine()); 

      ///////////////////////////////////////////////////

      //Verificação e tomada de decisão 
      switch(vOperador)
        {
        case 1: 
          Console.WriteLine("O resultado é: "+(vN1 + vN2));
        break;
        case 2: 
          Console.WriteLine("O resultado é: "+(vN1 - vN2));
        break;
        case 3: 
          Console.WriteLine("O resultado é: "+(vN1 * vN2) );
        break;
        case 4: 
          Console.WriteLine("O resultado é: "+(vN1 / vN2) );
        break;
        default: 
          Console.WriteLine("São apenas 4 operações a ser selecionadas! ");
        break;
        }
      }
    }
  }
