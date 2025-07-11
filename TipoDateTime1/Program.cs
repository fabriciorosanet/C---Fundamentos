// See https://aka.ms/new-console-template for more information

Console.WriteLine(" Struct DateTime");

DateTime dataAtual = DateTime.Now;
Console.WriteLine(dataAtual);

// Atribuindo uma data específica
DateTime dataEspecifica = new DateTime(2023, 10, 15);
Console.WriteLine(dataEspecifica);

DateTime dataEspecifica2 = new DateTime(2023, 10, 15, 14, 30, 0);
Console.WriteLine(dataEspecifica2);

// Extraindo informações da data
DateTime hoje = DateTime.Now;
Console.WriteLine(hoje.Year);
Console.WriteLine(hoje.Month);
Console.WriteLine(hoje.Day);
Console.WriteLine(hoje.Hour);
Console.WriteLine(hoje.Minute);
Console.WriteLine(hoje.Second);
Console.WriteLine(hoje.Millisecond);

// Adicionando valores à data
Console.WriteLine(hoje.AddDays(4));
Console.WriteLine(hoje.AddMonths(1));
Console.WriteLine(hoje.AddHours(-1));
Console.WriteLine(hoje.AddYears(5));

// obter o dia da semana e do ano

Console.WriteLine(hoje.DayOfWeek);
Console.WriteLine(hoje.DayOfYear);

// data no formato longo e curto
Console.WriteLine(hoje.ToLongDateString());
Console.WriteLine(hoje.ToShortDateString());

Console.WriteLine(hoje.ToLongTimeString());
Console.WriteLine(hoje.ToShortTimeString());

Console.ReadKey();