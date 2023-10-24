using Core;

namespace Core
{
    using System;

    public partial class FormBaseSequence
    {
        public static void Debug(BaseCFS item__BASE_CFS, Int32[] array_POSITION, Boolean debug)
        {
            if (debug is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = new String[] {

                String.Empty + nameof(FormBase) + ' ' + "::" + ' ' + nameof(FormBaseSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(item__BASE_CFS) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(array_POSITION) + ':' + ' ' + $"<{array_POSITION.Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(debug) + ':' + ' ' + debug,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(item__BASE_CFS) + ':',
                String.Empty + item__BASE_CFS,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(array_POSITION) + ':',
                String.Empty + String.Join('\n'.ToString(), array_POSITION)
            };

            var line_feed = Convert.ToChar(10);

            var join = String.Join(line_feed.ToString(), descriptor);

            ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectory.Core_Debug}-{nameof(FormBase)}Debug", join);

            return;
        }
    }
}
