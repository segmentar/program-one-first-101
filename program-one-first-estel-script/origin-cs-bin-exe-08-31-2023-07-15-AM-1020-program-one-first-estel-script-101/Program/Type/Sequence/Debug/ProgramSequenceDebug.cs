using Core;

namespace Core
{
    using System;

    internal partial class ProgramSequence
    {
        internal static void Debug(Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();


            var descriptor = new String[] {

                String.Empty + nameof(Program) + ' ' + "::" + ' ' + nameof(ProgramSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}'
            };

            var join = String.Join('\n'.ToString(), descriptor);

            ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectory.Core_Debug}-{nameof(Program)}Debug", join);

            return;
        }
    }
}
