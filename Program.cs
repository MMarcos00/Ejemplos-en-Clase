
using Ejemplo.CLase_Hijo;

Nintendo SW = new Nintendo();
SW.EsPortatil = true;
SW.AnioLanzamineto = 2017;
SW.Marca = "Nintendo Switch";
string resultado = SW.MostrarDetallesNintendo();
Console.WriteLine(resultado);

Playstation ps = new Playstation();
ps.AnioLanzamineto = 2021;
ps.Marca = "PlayStation 5";
string resultado2 = ps.MostrarDetallesPS();
Console.WriteLine(resultado);

Xbox bx = new Xbox();
bx.AnioLanzamineto = 2021;
bx.Marca = "Xbox Series X";
string resultado3 = bx.MostrarDetallesXB();
Console.WriteLine(resultado);