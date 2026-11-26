using System.Text.RegularExpressions;

//Expresion Regular DNI


string texto = Console.ReadLine() ?? "Vacio";
string patron = (@"^\d{8}[A-Za-z$]");

 bool EsValido = Regex.IsMatch(texto, patron);
 if (EsValido)
 {
     Console.WriteLine("Correcto");
 }

 else
 {
     Console.WriteLine("Incorrecto");
 }