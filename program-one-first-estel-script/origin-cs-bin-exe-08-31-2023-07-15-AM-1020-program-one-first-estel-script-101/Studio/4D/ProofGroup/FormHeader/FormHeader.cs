using Core;

namespace Core
{
    using System;

    [IntentionalShortClass]
    public partial class FormHeader
    {
        public Boolean EndianFormat;

        public Byte ReservedFlag;

        public UInt32 StringCodec;

        public UInt16 ChunkSize;

        public UInt32 StartBoundary;

        public FormHeader(Boolean endianFormat, Byte reservedFlag, UInt32 stringCodec, UInt16 chunkSize, UInt32 startBoundary)
        {
            this.EndianFormat = endianFormat;

            this.ReservedFlag = reservedFlag;

            this.StringCodec = stringCodec;

            this.ChunkSize = chunkSize;

            this.StartBoundary = startBoundary;

            return;
        }

        ~FormHeader()
        {
            return;
        }

        [IntentionalShortMethod]
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                    String.Empty + nameof(FormHeader) + ' ' + "::" + ' ' + '{',
                    String.Empty + '.' + "flat",
                    String.Empty + '\t' + '~' + "01" + ' ' + nameof(EndianFormat) + ':' + ' ' + EndianFormat,
                    String.Empty + '\t' + '~' + "02" + ' ' + nameof(ReservedFlag) + ':' + ' ' + ReservedFlag,
                    String.Empty + '\t' + '~' + "03" + ' ' + nameof(StringCodec) + ':' + ' ' + StringCodec,
                    String.Empty + '\t' + '~' + "04" + ' ' + nameof(ChunkSize) + ':' + ' ' + ChunkSize,
                    String.Empty + '\t' + '~' + "05" + ' ' + nameof(StartBoundary) + ':' + ' ' + StartBoundary,
                    String.Empty + '}'
            });
        }
    }
}
