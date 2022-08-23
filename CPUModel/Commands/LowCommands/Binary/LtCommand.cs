using CPUModel.Commands.Base;

namespace CPUModel.Commands.LowCommands.Binary;

public class LtCommand : BinaryCommand
{
    public LtCommand(int toResultRegister) : base(toResultRegister, "lt")
    {
    }

    protected override int ExecuteBinaryCommand(int left, int right)
    {
        return Convert.ToInt16(left < right);
    }
}
