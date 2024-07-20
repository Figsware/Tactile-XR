using Tactile.Console;
using Tactile.Console.Parameters;

namespace Tactile.XR.Commands
{
    internal class EnableCommand : BaseCommandWithParameters<bool>
    {
        public EnableCommand() : base("enabled", "Sets whether XR is enabled", new BooleanParameter("enabled", "Whether XR is enabled"))
        {
        }

        protected override void Execute(Console.Console console, ParsedArguments arguments)
        {
            XRManager.Instance.XREnabled = arguments.Arg1;
        }
    }
}