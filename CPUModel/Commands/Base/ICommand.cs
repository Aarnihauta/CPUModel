namespace CPUModel.Commands.Base;
public interface ICommand
{
    void Dump();
    void Execute(int[] registers, ref int currentCommandIndex);
}
