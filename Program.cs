double cm, m, km;
Console.WriteLine("Entre com a medida (em metros): ");
string entrada = Console.ReadLine();
m = Convert.ToDouble(entrada);
cm = m * 100;
km = m / 100;
Console.WriteLine("Equivalência");


Console.Write(cm);
Console.WriteLine("cm");

Console.Write(m);
Console.WriteLine("m");


Console.Write(km);
Console.WriteLine("km");