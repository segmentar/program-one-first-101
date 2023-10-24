using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class FormAddresss
    {
        public UInt32 HeaderAddress;

        public UInt32 ContentAddress;

        public UInt32 LocalLineAddress;

        public UInt32 GlobalLineAddress;

        public FormAddresss(UInt32 headerAddress, UInt32 contentAddress, UInt32 localLineAddress, UInt32 globalLineAddress)
        {
            this.HeaderAddress = headerAddress;

            this.ContentAddress = contentAddress;

            this.LocalLineAddress = localLineAddress;

            this.GlobalLineAddress = globalLineAddress;

            return;
        }

        ~FormAddresss()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(FormAddresss) + ' ' + "::" + ' ' + '{',
                String.Empty + '.' + "flat",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(HeaderAddress) + ':' + ' ' + HeaderAddress,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(ContentAddress) + ':' + ' ' + ContentAddress,
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(LocalLineAddress) + ':' + ' ' + LocalLineAddress,
                String.Empty + '\t' + '~' + "04" + ' ' + nameof(GlobalLineAddress) + ':' + ' ' + GlobalLineAddress,
                String.Empty + '}'
            });
        }
    }
}
