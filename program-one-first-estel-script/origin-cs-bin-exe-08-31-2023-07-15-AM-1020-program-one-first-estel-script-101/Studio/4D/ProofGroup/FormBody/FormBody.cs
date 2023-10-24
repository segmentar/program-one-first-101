using Core;

namespace Core
{
    using System;


    [IntentionalShortClass]
    public partial class FormBody
    {
        public UInt32 HeaderLength;

        public String[] HeaderArray;

        public String Content;

        public UInt32 LocalLineLength;

        public String[] LocalLineArray;

        public UInt32 GlobalLineLength;

        public String[] GlobalLineArray;

        public FormBody(UInt32 headerLength, String[] headerArray, String content, UInt32 localLineLength, String[] localLineArray, UInt32 globalLineLength, String[] globalLineArray)
        {
            this.HeaderLength = headerLength;

            this.HeaderArray = ConsoleLJS.SafeArray(headerArray);

            this.Content = ConsoleLJS.SafeString(content);

            this.LocalLineLength = localLineLength;

            this.LocalLineArray = ConsoleLJS.SafeArray(localLineArray);

            this.GlobalLineLength = globalLineLength;

            this.GlobalLineArray = ConsoleLJS.SafeArray(globalLineArray);

            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {
                
                String.Empty + nameof(FormBody) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "flat",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(HeaderLength) + ':' + ' ' + HeaderLength,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(HeaderArray) + ':' + ' ' + ". . ." + ' ' + $"<{HeaderArray.Length}>",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(Content) + ':' + ' ' + Content,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(LocalLineLength) + ':' + ' ' + LocalLineLength,
                String.Empty + '\t' + '~' + "05" + ' ' + nameof(LocalLineArray) + ':' + ' ' + ". . ." + $"<{LocalLineArray.Length}>",
                String.Empty + '\t' + '~' + "06" + ' ' + nameof(GlobalLineLength) + ':' + ' ' + GlobalLineLength,
                String.Empty + '\t' + '~' + "07" + ' ' + nameof(GlobalLineArray) + ':' + ' ' + ". . ." + $"<{GlobalLineArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(HeaderArray) + ':',
                String.Empty + String.Join('\n'.ToString(), HeaderArray),
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(LocalLineArray) + ':',
                String.Empty + String.Join('\n'.ToString(), LocalLineArray),
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(GlobalLineArray) + ':',
                String.Empty + String.Join('\n'.ToString(), GlobalLineArray)
            });
        }
    }
}
