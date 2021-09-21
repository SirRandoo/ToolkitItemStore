using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToolkitCore.Interfaces;
using ToolkitCore.Models;
using ToolkitCore.Utilities;

namespace ToolkitItemStore.CommandMethods
{
    public class Purchase : CommandMethod
    {
        public Purchase(ToolkitChatCommand command) : base(command)
        {

        }

        public override void Execute(ICommand command)
        {
            MessageSender.SendMessage($"@{command.Username()} this command is not setup yet!", command.Service());
        }
    }
}
