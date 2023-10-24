using Core;

namespace Core
{
    using System;

    public partial class FormSequence
    {
        public static void Debug(BaseCFS item__BASE_CFS, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            var descriptor = new String[] {

                String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(FormSequence) + ' ' + '{',
                String.Empty + '.' + "debug",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(item__BASE_CFS) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(item__BASE_CFS) + ':',
                String.Empty + item__BASE_CFS
            };

            var line_feed = Convert.ToChar(10);

            var join = String.Join(line_feed.ToString(), descriptor);

            ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectory.Core_Debug}-{nameof(Form)}Debug", join);

            return;
        }
    }
}
