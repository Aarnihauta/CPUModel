using CPUModel.Commands.Base;

namespace CPUModel.Commands.LowCommands.Binary;

public class GtCommand : BinaryCommand
{
    public GtCommand(int toResultRegister) : base(toResultRegister, "gt")
    {
    }

    protected override int ExecuteBinaryCommand(int left, int right)
    {
        return Convert.ToInt16(left > right);
    }
}
