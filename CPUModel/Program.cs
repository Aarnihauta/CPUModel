using CPUModel.Commands.LowCommands;
int[] registers = new int[2];
var command = new PutToRegisterCommand(2, 14);
command.Execute(registers);
command.Dump();