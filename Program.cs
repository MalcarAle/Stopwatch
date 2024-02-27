namespace Stopwatch
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      Menu();
    }

    static void Menu()
    {

      Console.Clear();

      Console.WriteLine("=======================");
      Console.WriteLine("Bem vindo ao Stopwatch!");
      Console.WriteLine("=======================");

      Console.WriteLine("");

      Console.WriteLine("S = Segundos => 10s = 10 segundos");
      Console.WriteLine("M = Minuto => 1m = 1 minuto");
      Console.WriteLine("0 = Sair");
      Console.WriteLine("Quanto tempo deseja contar?");

      var data = Console.ReadLine()!.Trim().ToLower();

      if (string.IsNullOrEmpty(data))
      {
        Console.WriteLine("Entrada inválida, tente novamente!");
        Console.ReadKey();
        Menu();
      }

      if (data.StartsWith('0'))
      {
        System.Environment.Exit(0);
      }

      char type = data[data.Length - 1];

      if (type != 's' && type != 'm')
      {
        Console.WriteLine("Você não indicou minuto ou segundo, tente novamente!");
        Console.ReadKey();
        Menu();

      }

      int time;
      if (!int.TryParse(data.Substring(0, data.Length - 1), out time))
      {
        Console.WriteLine("Você não indicou minuto ou segundo, tente novamente!");
        Console.ReadKey();
        Menu();

      }
      int multiplier = 1;


      if (type == 'm')
        multiplier = 60;


      PreStart(time * multiplier);

    }
    static void Start(int time)
    {

      int currentTime = 0;

      while (currentTime != time)
      {
        Console.Clear();

        currentTime++;

        Console.WriteLine(currentTime);
        Thread.Sleep(1000);
      }

      Console.Clear();

      Console.WriteLine("StopWatch finalizado!");
      Console.WriteLine("Pressione alguma tecla para voltar!");
      Console.ReadKey();
      Menu();

    }
    static void PreStart(int time)
    {
      Console.Clear();
      Console.WriteLine("Ready...");
      Thread.Sleep(1000);
      Console.WriteLine("Set...");
      Thread.Sleep(1000);
      Console.WriteLine("Go...");
      Thread.Sleep(2500);

      Start(time);
    }
  }
}