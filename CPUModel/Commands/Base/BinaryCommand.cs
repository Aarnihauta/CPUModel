using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUModel.Commands.Base
{
    public abstract class BinaryCommand : ICommand
    {
        private int _toResultRegister;
        private string _commandName;
        public BinaryCommand(int toResultRegister, string commandName)
        {
            _toResultRegister = toResultRegister;
            _commandName = commandName;
        }
        public void Dump()
        {
            Console.Write($"{_commandName} r{_toResultRegister}");
        }

        public void Execute(int[] registers, ref int currentCommandIndex)
        {
            registers[_toResultRegister] = ExecuteBinaryCommand(registers[0], registers[1]);
            currentCommandIndex++;
        }
        protected abstract int ExecuteBinaryCommand(int left, int right);
    }
}
