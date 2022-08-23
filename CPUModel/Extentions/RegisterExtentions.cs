namespace CPUModel.Extentions;

public static class RegisterExtentions
{
    public static void Dump(this int[] registers)
    {
        Console.Write($"{registers[0]} {registers[1]}");
    }
}
