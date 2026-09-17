using Homerseklet;

HomersekletAtvalto homerseklet = new HomersekletAtvalto();

homerseklet.Celsius = 20;

double Fahrenheit = homerseklet.ToFahrenheit();

Console.WriteLine("Fahrenheit:" + Fahrenheit);

Console.WriteLine("Fahrenheit kapott parameterbol: "+ HomersekletAtvalto.CelsiusToFahrenheit(30));


