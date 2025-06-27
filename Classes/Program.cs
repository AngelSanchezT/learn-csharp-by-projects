using _06_Classes;

internal class Program
{
    static void Main()
    {
        Videogame videogame1 = new Videogame("Lies Of Pi", 2023, "Souls");
        Videogame videogame2 = new Videogame("Sekiro", 2019, "Souls");

        // Imprimir información de los videojuegos
        videogame1.ImprimirInformacion();
        videogame2.ImprimirInformacion();

        Videogame.Conteo();
    }
}