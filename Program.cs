namespace Exercicio3
{
  class Program
  {
    static void Main(string[] args)
    {
      System.Console.WriteLine("----------Exercício 1: Repita a senha válida----------");

      string senha = "2002";

      System.Console.WriteLine("Informe a senha:");
      string senhaInformada = Console.ReadLine();

      while(senhaInformada != senha)
      {
        System.Console.WriteLine("Senha inválida");
        System.Console.WriteLine("Informe a senha:");

        senhaInformada = Console.ReadLine();
      }

      System.Console.WriteLine("Acesso permitido");

      System.Console.WriteLine("----------Exercício 2: Combustível preferido----------");

      int alcool = 0;
      int gasolina = 0;
      int diesel = 0;

      System.Console.WriteLine("Informe o combustível preferido:");
      int tipo = int.Parse(Console.ReadLine());

      while(tipo != 4)
      {
        if (tipo == 1)
        {
          alcool += 1;
        }
        else if (tipo == 2)
        {
          gasolina += 1;
        } else {
          diesel += 1;
        }

        System.Console.WriteLine("Informe o combustível preferido:");
        tipo = int.Parse(Console.ReadLine());
      }

      System.Console.WriteLine("Muito Obrigado");
      System.Console.WriteLine($"Alcool: {alcool}");
      System.Console.WriteLine($"Gasolina: {gasolina}");
      System.Console.WriteLine($"Diesel: {diesel}");

    }
  }
}