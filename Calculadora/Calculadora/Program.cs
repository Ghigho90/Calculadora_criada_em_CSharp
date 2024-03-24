class program
{
    static void Main(string[] args)
    {
        Menu();
    }

    public static void Menu()
    {
        Console.Clear();
        Console.WriteLine("Menu");
        Console.WriteLine("1 - Somar");
        Console.WriteLine("2 - Subtrair");
        Console.WriteLine("3 - Multiplicar");
        Console.WriteLine("4 - Dividir");
        Console.WriteLine("5 - Resto da divisão");
        Console.WriteLine("6 - Potenciação");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha uma opção: ");
        int opcao = int.Parse(Console.ReadLine());

        switch(opcao)
        {
            case 1: 
                Somar();
                break;
            case 2: 
                Subtrair();
                break;
            case 3: 
                Multiplicar();
                break;
            case 4:
                Dividir();
                break;
            case 5: 
                RestoDaDivisao();
                break;
            case 6:
                Potenciacao();
                break;
            case 0: 
                break;
            default: 
                Menu();
                break;
        }
    }
     public static void Somar()
    {
        Console.Write("Informe o primeiro número: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        int valor2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"{valor1} + {valor2} = {valor1 + valor2}");
        Console.ReadKey();
        Menu();
    }

    public static void Subtrair()
    {
        Console.Write("Informe o primeiro número: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        int valor2 = int.Parse(Console.ReadLine());

        Console.Write($"{valor1} - {valor2} = {valor1 - valor2}");
        Console.ReadKey();
        Menu();
    }

    public static void Multiplicar()
    {
        Console.Write("Informe o primeiro número: ");
        int valor1 = int.Parse(Console.ReadLine());
        Console.Write("Informe o segundo número: ");
        int valor2 = int.Parse(Console.ReadLine());

        Console.Write($"{valor1} x {valor2} = {valor1 * valor2}");
        Console.ReadKey();
        Menu();
    }

    public static void Dividir()
    {
        Console.Write("Informe o dividendo: ");
        int dividendo = int.Parse(Console.ReadLine());
        Console.Write("Informe o divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        Console.WriteLine($"{dividendo} / {divisor} = {dividendo / divisor}");
        Console.ReadKey();
        Menu();
    }

    public static void RestoDaDivisao()
    {
        Console.Write("Informe o dividendo: ");
        int dividendo = int.Parse(Console.ReadLine());
        Console.Write("Informe o divisor: ");
        int divisor = int.Parse(Console.ReadLine());

        Console.WriteLine($"O resto de {dividendo} / {divisor} é = {dividendo % divisor}");
        Console.ReadKey();
        Menu();
    }

    public static void Potenciacao() 
    {
        Console.Write("Informe a base: ");
        int basePotenciacao = int.Parse(Console.ReadLine());
        Console.Write("Informe o expoente: ");
        int expoente = int.Parse(Console.ReadLine());

        Console.WriteLine($"{basePotenciacao} elevado a {expoente} é = {Math.Pow(basePotenciacao, expoente)}");
        Console.ReadKey();
        Menu();
    }
}