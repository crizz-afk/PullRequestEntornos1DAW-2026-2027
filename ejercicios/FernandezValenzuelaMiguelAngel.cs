using System.Text;
using static System.Console;

OutputEncoding = Encoding.UTF8;
Random rnd = new Random();


var matriz = new int[5, 5];

int opcionMenu;

do
{
    MostrarMenu();
    opcionMenu = LeerEntero("Introduzca el número de la opción que desee: ");

    switch (opcionMenu)
    {
        case 1:
            RellenarMatriz();
            WriteLine("\n--- Matriz Generada ---");
            ImprimirMatriz();

            WriteLine("\n--- Recorrido Filas y Columnas Ascendentes ---");
            RecorrerFilColAsc();
            break; 

        case 2:
            RellenarMatriz();
            WriteLine("\n--- Matriz Generada ---");
            ImprimirMatriz();
            
            WriteLine("\n--- Recorrido Filas y Columnas Descendentes ---");
            RecorrerFilColDesc();
            break;
        
        case 3:
            RellenarMatriz();
            WriteLine("\n--- Matriz Generada ---");
            ImprimirMatriz();
            
            WriteLine("\n--- Recorrido Filas Ascendentes y Columnas Descendentes ---");
            RecorrerFilAscColDesc();
            break;
        
        case 4: 
            RellenarMatriz();
            WriteLine("\n--- Matriz Generada ---");
            ImprimirMatriz();
            
            WriteLine("\n--- Recorrido Filas Descendentes y Columnas Ascendentes ---");
            RecorrerFilDescColAsc();
            break;
        
        case 5 :
            RellenarMatriz();
            WriteLine("\n--- Matriz Generada ---");
            ImprimirMatriz();
            
            WriteLine("\n--- Recorrido Diagonal Filas y Columnas Ascendentes ---");
            RecorrerDiagonalFilColAsc();
            break;
        
        case 6:
            RellenarMatriz();
            WriteLine("\n--- Matriz Generada ---");
            ImprimirMatriz();
            
            WriteLine("\n--- Recorrido Diagonal Filas y Columnas Descendentes ---");
            RecorrerDiagonalFilColDesc();
            break;
        
        case 7:
            RellenarMatriz();
            WriteLine("\n--- Matriz Generada ---");
            ImprimirMatriz();
            
            WriteLine("\n--- Recorrido Diagonal Filas Ascendentes y Columnas Descendentes ---");
            RecorrerDiagonalFilAscColDesc();
            break;
        
        case 8:
            RellenarMatriz();
            WriteLine("\n--- Matriz Generada ---");
            ImprimirMatriz();
            
            WriteLine("\n--- Recorrido Diagonal Filas Descendentes y Columnas Ascendentes ---");
            RecorrerDiagonalFilDescColAsc();
            break;
        
        case 9:
            WriteLine("Ha sido un placer. ¡Vuelva pronto!");
            break;

        default:
            WriteLine("Opción no válida. Por favor, elija entre 1 y 9");
            break;
        
    }

} while (opcionMenu != 9);

return;

void RellenarMatriz()
{
    for (var i = 0; i < matriz.GetLength(0); i++) {
        for (var j = 0; j < matriz.GetLength(1); j++) {
            matriz[i, j] = rnd.Next(0, 10); 
        }
    } 
}


void ImprimirMatriz()
{
    for (var i = 0; i < matriz.GetLength(0); i++)
    {
        for (var j = 0; j < matriz.GetLength(1); j++)
        {
            Write(matriz[i,j] + " ");
        }

        WriteLine();
    }
}


void RecorrerFilColAsc()
{
    for (var i = 0; i < matriz.GetLength(0); i++)
    {
        for (var j = 0; j < matriz.GetLength(1); j++)
        {
            Write(matriz[i, j] + " ");
        }
    }
    WriteLine();
}


void RecorrerFilColDesc()
{
    for (var i = matriz.GetLength(0) -1; i >= 0; i--)
    {
        for (var j = matriz.GetLength(1) -1 ; j >= 0; j--)
        {
            Write(matriz[i,j] + " ");
        }
    }
    WriteLine();
}


void RecorrerFilAscColDesc()
{
    for (var i = 0; i < matriz.GetLength(0); i++)
    {
        for (var j = matriz.GetLength(1) - 1; j >= 0; j--)
        {
            Write(matriz[i,j] + " ");
        }
    }
    WriteLine();
}


void RecorrerFilDescColAsc()
{
    for (var i = matriz.GetLength(0) -1; i >= 0; i--)
    {
        for (var j = 0; j < matriz.GetLength(1); j++)
        {
            Write(matriz[i,j] + " ");
        }
    }
    WriteLine();
}


void RecorrerDiagonalFilColAsc()
{
    for (var i = 0; i < matriz.GetLength(0); i++)
    {
        Write(matriz[i,i] + " ");
    }
    WriteLine();
}


void RecorrerDiagonalFilColDesc()
{
    for (var i = matriz.GetLength(0) - 1; i >= 0; i--)
    {
        Write(matriz[i, i] + " ");
    }
    WriteLine();
}


void RecorrerDiagonalFilAscColDesc()
{
    var col = matriz.GetLength(1) - 1; 

    for (var fila = 0; fila < matriz.GetLength(0); fila++) 
    {
        Write(matriz[fila, col] + " ");
        col--;
    }
    WriteLine();
}


void RecorrerDiagonalFilDescColAsc()
{
    var col = 0; 

    for (var fila = matriz.GetLength(0) - 1; fila >= 0; fila--) 
    {
        Write(matriz[fila, col] + " ");
        col++; 
    }
    WriteLine();
}


int LeerEntero(string mensaje)
{
    bool inputOk;
    int numero;
    do {
        Write(mensaje);
        var convertido = int.TryParse(ReadLine(), out numero);
        if (!convertido)
        {
            WriteLine("ERROR: Debes introducir un número entero");
            inputOk = false;
        }
        else
        {
            inputOk = true;
        }
    } while (!inputOk);
    return numero;
}


void MostrarMenu()
{
    WriteLine("-----------------------------------------------------------");
    WriteLine("Introduzca el número de la opción que desee:");
    WriteLine("1. Recorrer Matriz Filas y Columnas Ascendentes");
    WriteLine("2. Recorrer Matriz Filas y Columnas Descendentes");
    WriteLine("3. Recorrer Matriz Filas Ascendentes y Columnas Descendentes");
    WriteLine("4. Recorrer Matriz Filas Descendentes y Columnas Ascendentes");
    WriteLine("5. Recorrer Matriz Diagonal Filas y Columnas Ascendentes");
    WriteLine("6. Recorrer Matriz Diagonal Filas y Columnas Descendentes");
    WriteLine("7. Recorrer Matriz Diagonal Filas Ascendentes y Columnas Descendentes");
    WriteLine("8. Recorrer Matriz Diagonal Filas Descendentes y Columnas Ascendentes");
    WriteLine("9. Salir.");
}
