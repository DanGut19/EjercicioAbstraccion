// See https://aka.ms/new-console-template for more information
using EjercicioAbstraccion;

Console.WriteLine("Ejercicio Abstraccion");

FrutasDulces frutasDulces = new FrutasDulces();
frutasDulces.Nombre = "Manzana";
frutasDulces.Color = "Roja";
frutasDulces.Tamano = "Pequeno";
frutasDulces.Familia = "Rosaceas";
frutasDulces.TieneSemillas = true;
frutasDulces.EsDulce = true;
frutasDulces.EsAcido = false;
frutasDulces.Imprimir();

FrutasDulces frutasDulces2 = new FrutasDulces();
frutasDulces2.Nombre = "Melon";
frutasDulces2.Color = "Marron con lineas verdes";
frutasDulces2.Tamano = "Grande";
frutasDulces2.Familia = "Cucurbitaceas";
frutasDulces2.TieneSemillas = true;
frutasDulces2.EsDulce = true;
frutasDulces2.EsAcido = false;
frutasDulces2.Imprimir();

FrutasAcidas frutasAcidas = new FrutasAcidas();
frutasAcidas.Nombre = "Pina";
frutasAcidas.Color = "Amarrillo";
frutasAcidas.Tamano = "Pequeno";
frutasAcidas.Familia = "Bromeliaceae";
frutasAcidas.TieneSemillas = false;
frutasAcidas.EsDulce = true;
frutasAcidas.EsAcido = false;
frutasAcidas.Imprimir();

FrutasAcidas frutasAcidas2 = new FrutasAcidas();
frutasAcidas2.Nombre = "Ciruela";
frutasAcidas2.Color = "Morrado";
frutasAcidas2.Tamano = "Pequeno";
frutasAcidas2.Familia = "Rosaceas";
frutasAcidas2.TieneSemillas = true;
frutasAcidas2.EsDulce = false;
frutasAcidas2.EsAcido = true;
frutasAcidas2.Imprimir();