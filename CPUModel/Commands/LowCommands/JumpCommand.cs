using CPUModel.Commands.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CPUModel.Commands.LowCommands
{
    public class JumpCommand : ICommand
    {
        public void Dump()
        {
            throw new NotImplementedException();
        }

        public void Execute(int[] registers, ref int currentCommandIndex)
        {
            currentCommandIndex += registers[0];
        }
    }
}
