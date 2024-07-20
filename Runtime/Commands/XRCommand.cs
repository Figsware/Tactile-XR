using Tactile.Console;
using Tactile.Console.Commands;

namespace Tactile.XR.Commands
{
    [GlobalCommand]
    internal class XRCommand : BaseCommandGroup
    {
        private static readonly BaseCommand[] XRSubcommands = {
            new EnableCommand()
        };
        
        public XRCommand(): base("xr", XRSubcommands)
        {
        }
    }
}
