using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class BaseCFSSequence
    {
        [IntentionalShortMethod]
        public static void Debug(String item_FILE, String item_CONTENT, Encoding item_ENCODING, Boolean answer_DEBUG_is)
        {
            if (answer_DEBUG_is is false)
            {
                return;
            }
            else
                "false".ToString();

            ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectory.Core_Debug}-{nameof(BaseCFS)}", String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(BaseCFS) + ' ' + "::" + ' ' + nameof(BaseCFSSequence) + ' ' + '{',
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(item_FILE) + ':' + ' ' + item_FILE,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(item_CONTENT) + ':' + ' ' + item_CONTENT,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(item_ENCODING) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(answer_DEBUG_is) + ':' + ' ' + answer_DEBUG_is,
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(item_ENCODING) + ':',
                String.Empty + item_ENCODING
            }));

            return;
        }
    }
}
