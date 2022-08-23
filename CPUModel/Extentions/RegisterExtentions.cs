namespace CPUModel.Extentions;

public static class RegisterExtentions
{
    public static void Dump(this int[] registers)
    {
        foreach (var register in registers)
            Console.Write(register + " ");

    }
}
