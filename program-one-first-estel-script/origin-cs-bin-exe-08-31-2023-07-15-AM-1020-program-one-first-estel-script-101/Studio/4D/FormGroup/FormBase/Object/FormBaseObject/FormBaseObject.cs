using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(FormBase) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(HeaderString) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(HeaderStringSafe) + ':' + ' ' + $"<safe><<{HeaderStringSafe}>>",
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(HeaderArray) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(HeaderArraySafe) + ':' + ' ' + ". . ." + ' ' + $"<{HeaderArraySafe.Length}>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(ContentString) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(ContentStringSafe) + ':' + ' ' + $"<safe><<{ContentStringSafe}>>",
                String.Empty + '\t' + '~' + "08" + ' ' + nameof(ReflectString) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "09" + ' ' + nameof(ReflectStringSafe) + ':' + ' ' + $"<safe><<{ReflectStringSafe}>>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + "<safe>" + ' ' + nameof(HeaderArraySafe) + ':',
                String.Empty + String.Join('\n'.ToString(), HeaderArraySafe),
            });
        }
    }
}
