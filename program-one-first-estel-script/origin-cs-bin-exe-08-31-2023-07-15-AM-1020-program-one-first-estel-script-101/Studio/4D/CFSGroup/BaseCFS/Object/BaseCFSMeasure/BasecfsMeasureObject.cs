using Core;

namespace Core
{
    using System;

    public partial class BaseCFS
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(BaseCFS) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "compress",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(IsDebug) + ':' + ' ' + IsDebug,
                String.Empty + '.' + "compress-raw",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(Measure) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(File) + ':' + ' ' + File,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(Content) + ':' + ' ' + "<hidden>",
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(ContentSafe) + ':' + ' ' + $"<safe><<{ContentSafe}>>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(Encoding) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(Measure) + ':',
                String.Empty + Measure,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(Encoding) + ':',
                String.Empty + Encoding
            });
        }
    }
}
