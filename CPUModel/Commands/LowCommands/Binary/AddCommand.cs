using CPUModel.Commands.Base;

namespace CPUModel.Commands.LowCommands.Binary;

public class AddCommand : BinaryCommand
{
    private readonly int _toResultRegister;

    public AddCommand(int toResultRegister) : base(toResultRegister, "add")
    {
    }

    protected override int ExecuteBinaryCommand(int left, int right)
    {
        return left + right;
    }
}
