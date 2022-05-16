using System.Threading;

menu();

static void menu()
{
    Console.Clear();
    Console.WriteLine("S = Segundo => 10s = 10 segundos");
    Console.WriteLine("M = Minuto => 10m = 10 minutos");
    Console.WriteLine("0 =  Sair");
    Console.WriteLine("Quanto tempo deseja contar?");

    string dado = Console.ReadLine().ToLower();
    char tipo = Convert.ToChar(dado.Substring(dado.Length - 1, 1));
    int time = int.Parse(dado.Substring(0, dado.Length -1));

    int multplicador = 1;

    if(tipo == 'm')
        multplicador = 60;

    if (time == 0)
        System.Environment.Exit(0);

    PreStart (time * multplicador);
}

static void PreStart(int time)
{
    Console.Clear();
    Console.WriteLine("Preparar...");
    Thread.Sleep(1000);
    Console.WriteLine("Apontar...");
    Thread.Sleep(1000);
    Console.WriteLine("Fogo...");
    Thread.Sleep(2000);

    Start(time);
}

static void Start(int time)
{
    
    //int currentTime = 0;
    int currentTime = -1;

    
    
    // while(currentTime != time)
    // {
    //     Console.Clear();
    //     currentTime++;
    //     Console.WriteLine(currentTime);
    //     Thread.Sleep(1000);
    // }

    // Extrapolando conceitos - Cronometro começa do tempo escolhido ate 0.
    do 
    {
        Console.Clear();
        Console.WriteLine(time);
        time--;
        Thread.Sleep(1000);
    }
    while(time != currentTime);

    Console.Clear();
    Console.WriteLine("Cronômetro finalizado!");
    Thread.Sleep(2000);
    menu();
    
}
