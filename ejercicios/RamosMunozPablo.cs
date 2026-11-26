/*
 * Estadísticas de un Equipo de Fútbol
 * Implementa un programa con un array de 11 enteros (goles de cada jugador en la temporada).
 * Calcula y muestra: el máximo goleador, el mínimo, la media de goles y cuántos jugadores superan la media.
 */
using static System.Console;
 
//Variables
int[] goles = {2,5,26,11,8,4,49,11,13,4,6};

int golesTotales = 0;
int? maximoGoleador = null;
int? menosGoleador = null;
int mediaGoles = 0;
int superanLaMedia = 0;

//recorrer el vector
for (int i = 0; i <= goles.Length -1; i++)
{
    ActualizarStatsGoles(goles[i],ref golesTotales, ref maximoGoleador, ref menosGoleador);
}
 
//media de goles, tras sumar todos los goles totales dentro del for
mediaGoles = golesTotales / goles.Length;
 
//Jugadores que superan la media
for (int i = 0; i <= goles.Length - 1; i++)
{
    if (goles[i] > mediaGoles)
    {
        superanLaMedia += 1;
    }
}
 
// Mostrar por consola
WriteLine($"Goleador máximo: {maximoGoleador}");
WriteLine($"Menos goleador: {menosGoleador}");
WriteLine($"Media de goles: {mediaGoles}");
WriteLine($"Jugadores por encima de la media: {superanLaMedia}");

//procedimiento
void ActualizarStatsGoles(int goles, ref int golesTotales, ref int? maximoGoleador, ref int? menosGoleador)
{
    golesTotales += goles;
    
    if (maximoGoleador == null || maximoGoleador < goles)
    {
        maximoGoleador = goles;
    }
    
    if (menosGoleador == null || menosGoleador > goles)
    {
        menosGoleador = goles;
    }
}