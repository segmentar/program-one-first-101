using Core;

namespace Core
{
    using System;

    public partial class FormLineSequence
    {
        public static void Debug(String content, Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = new String[] {

                String.Empty + nameof(FormLine) + ' ' + "::" + ' ' + nameof(FormLineSequence) + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(content) + ':' + ' ' + content,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}'
            };

            var join = String.Join('\n'.ToString(), descriptor);

            ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectory.Core_Debug}-{nameof(FormLine)}Debug", 1, join);

            return;
        }
    }
}
