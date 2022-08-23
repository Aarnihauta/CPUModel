using CPUModel.Commands.Base;

namespace CPUModel.Commands.LowCommands;

public class PutToRegisterCommand : ICommand
{
    private readonly int _registerToWrite;
    private readonly int _constant;
    public PutToRegisterCommand(int register, int constant)
    {
        _registerToWrite = register;
        _constant = constant;
    }
    public void Dump()
    {
        Console.Write($"put reg{_registerToWrite} {_constant}");
    }

    public void Execute(int[] registers, ref int currentCommandIndex)
    {
        registers[_registerToWrite] = _constant;
        currentCommandIndex++;
    }
}
