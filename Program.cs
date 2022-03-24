//valor por defecto de la cantidad de casillas (nxn)
int casillas = 5;

int salida = 0;
Console.WriteLine("**Ingrese cantidad de casillas 'n' (nxn) para el tablero de damas**\n");
Console.WriteLine("El valor debe numérico y debe estar entre 1 y 10 casillas\n");
var casillaIngresada = Console.ReadLine();

//valido que el dato sea número entero y esté en el rango de 1 y 10 casillas. De lo contrario sigue el seteo original
if (int.TryParse(casillaIngresada, out salida) && salida > 0 && salida < 11)
    casillas = salida;
else
    Console.Write("Se mostrará la cantidad por defecto de n=" + casillas.ToString() + " casillas.\n");

var colorNegro = "X";
var colorBlanco = "_";
var resultado = new string[casillas, casillas];
string tablero = "";

int i, j;

//se recorre la cantidad de casillas en vertical y horizontal para llenarlas con los colores
for (i = 0; i < casillas; i++)
{
    for (j = 0; j < casillas; j++)
    {
        //si el número es impar se comienza con el color negro, sino el blanco
        //permite de esta manera, intercalar los colores entre las líneas
        if (((i + j) % 2) == 0)
            resultado[i, j] = colorNegro;
        else
            resultado[i, j] = colorBlanco;
    }
}


//se guarda la línea en una variable para imprimirla una vez que se termine el recorrido horizontal
for (i = 0; i < casillas; i++)
{
    tablero = "";
    for (j = 0; j < casillas; j++)
    {
        tablero = tablero + resultado[i, j];
    }
    Console.WriteLine(tablero);
}