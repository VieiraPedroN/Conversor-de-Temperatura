// See https://aka.ms/new-console-template for more information
Console.WriteLine("Escolha a tempetura que você deseja converter:");
Console.WriteLine("1 - Celsius para Fahrenheit");
Console.WriteLine("2 - Fahrenheit para Celsius");
Console.WriteLine("3 - Celsius para Kelvin");
Console.WriteLine("4 - Kelvin para Celsius");
Console.WriteLine("5 - Fahrenheit para Kelvin");
Console.WriteLine("6 - Kelvin para Fahrenheit");
Console.WriteLine("7 - Sair");
int escolha = Convert.ToInt32(Console.ReadLine());
while (escolha != 7)
{
    switch (escolha)
    {
        case 1:
        Console.WriteLine("Insira a temperatura em Celsius:");
        double celsius = Convert.ToDouble(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius}°C é igual a {fahrenheit}°F");
        break;

        case 2:
        Console.WriteLine("Insira a temperatura em Fahrenheit:");
        double fahrenheit2 = Convert.ToDouble(Console.ReadLine());
        double celsius2 = (fahrenheit2 - 32) * 5 / 9;
        Console.WriteLine($"{fahrenheit2}°F é igual a {celsius2}°C");
        break;

        case 3:
        Console.WriteLine("Insira a temperatura em Celsius:");
        double celsius3 = Convert.ToDouble(Console.ReadLine());
        double kelvin = celsius3 + 273.15;
        Console.WriteLine($"{celsius3}°C é igual a {kelvin}K");
        break;

        case 4:
        Console.WriteLine("Insira a temperatura em Kelvin:");
        double kelvin2 = Convert.ToDouble(Console.ReadLine());
        double celsius4 = kelvin2 - 273.15;
        Console.WriteLine($"{kelvin2}K é igual a {celsius4}°C");
        break;

        case 5:
        Console.WriteLine("Insira a temperatura em Fahrenheit:");
        double fahrenheit5 = Convert.ToDouble(Console.ReadLine());
        double kelvin5 = (fahrenheit5 - 32) * 5 / 9 + 273.15;
        Console.WriteLine($"{fahrenheit5}°F é igual a {kelvin5}K");
        break;

        case 6:
        Console.WriteLine("Insira a temperatura em Kelvin:");
        double kelvin6 = Convert.ToDouble(Console.ReadLine());
        double fahrenheit6 = (kelvin6 - 273.15) * 9 / 5 + 32;
        Console.WriteLine($"{kelvin6}K é igual a {fahrenheit6}°F");
        break;

        default:
        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
        break;
    }
    Console.WriteLine("Deseja continuar? (1 - Sim, 2 - Não)");
    int continuar = Convert.ToInt32(Console.ReadLine());
    if (continuar == 2){
        break;
    }
}
        Console.WriteLine("Obrigado por usar o conversor de temperatura!");
