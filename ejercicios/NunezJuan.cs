
using static System.Console;

using System.Text.RegularExpressions;

/* Ejercicio 27: Extracción de Fechas y URLs Implementa un módulo que, dado un texto, use Regex para extraer todas las fechas en formato DD/MM/AAAA
 o todas las URLs que empiecen por http:// o https://.*/
 

WriteLine("ingresde el texto");
string texto = ReadLine() ?? "";

var fechasValidas = Regex.Matches(texto, @"\b\d{2}/\d{2}/\d{4}\b");
var urlValidas = Regex.Matches(texto, @"https?://\S+");
if (fechasValidas.Count==0)
{
 WriteLine("ninguna fecha valida encontrada");
}
else if (urlValidas.Count==0)
{
 WriteLine("ninguna url valida encontrada");
}

WriteLine("---------fechas validas encontradas");
foreach (Match m in fechasValidas)
{
 WriteLine(m.Value);
}
WriteLine("----------urls validas encontradas");
foreach (Match m in urlValidas)
{
 WriteLine(m.Value);
}