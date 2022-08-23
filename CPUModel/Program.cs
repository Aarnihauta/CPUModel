using CPUModel.Commands.Base;
using CPUModel.Commands.LowCommands;
using CPUModel.Commands.LowCommands.Binary;
using CPUModel.Extentions;

int[] registers = new int[3];

var commands = new ICommand[]
{
    new PutToRegisterCommand(0, 10),
    new PutToRegisterCommand(1, 5),
    new AddCommand(0),
    new SubstractCommand(0),
    new GtCommand(2),
    new LtCommand(2),
};

foreach(var command in commands)
{
    command.Execute(registers);
    command.Dump();
    Console.CursorLeft = 30;
    registers.Dump();
    Console.WriteLine();
}    