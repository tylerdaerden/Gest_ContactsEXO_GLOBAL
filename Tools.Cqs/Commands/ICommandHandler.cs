using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools.Cqs.Commands
{
    public interface ICommandHandler<TCommand>
        where TCommand : ICommand
    {
        Result Execute(TCommand command);
    }
}
