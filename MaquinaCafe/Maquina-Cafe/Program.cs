class Program
{
    static void Main2()
    {
        var maquina = new Maquina_Cafe.MaquinaCafe.MaquinaCafe();

        Console.WriteLine("Seleccione el tamaño del vaso (Pequeño, Mediano, Grande):");
        string tamano = Console.ReadLine();
        Console.WriteLine(maquina.SeleccionarVaso(tamano, true)); // Suponiendo que hay vasos disponibles

        Console.WriteLine("Seleccione la cantidad de azúcar (0-5):");
        int azucar = int.Parse(Console.ReadLine());
        Console.WriteLine(maquina.SeleccionarAzucar(azucar, true)); // Suponiendo que hay azúcar disponible

        Console.WriteLine(maquina.ServirCafe(tamano, azucar, true)); // Suponiendo que hay café disponible
    }

}