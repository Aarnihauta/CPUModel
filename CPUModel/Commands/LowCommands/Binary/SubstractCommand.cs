using CPUModel.Commands.Base;

namespace CPUModel.Commands.LowCommands.Binary;

public class SubstractCommand : BinaryCommand
{
    public SubstractCommand(int toResultRegister) : base(toResultRegister, "sub")
    {
    }

    protected override int ExecuteBinaryCommand(int left, int right)
    {
        return left - right;
    }
}
