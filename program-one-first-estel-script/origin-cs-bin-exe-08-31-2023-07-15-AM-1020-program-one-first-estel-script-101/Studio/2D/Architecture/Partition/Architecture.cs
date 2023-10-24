using Core;

namespace Core.DimensionTwoSecond
{
    using System;

    using System.Text;

    public static class ArchitectureOneFirst
    {
        public static Encoding ReaderEncoding;

        public static Encoding WriterEncoding;

        public static String ExtensionName;

        public static String FullExtension;

        static ArchitectureOneFirst()
        {
            ReaderEncoding = ProgramDefaultArchitectureOneFirst.ReaderEncodingDefault;

            WriterEncoding = ProgramDefaultArchitectureOneFirst.WriterEncodingDefault;

            ExtensionName = ProgramDefaultArchitectureOneFirst.ExtensionNameDefault;

            FullExtension = ProgramDefaultArchitectureOneFirst.FullExtensionDefault;

            return;
        }
    }
}

namespace Core.DimensionTwoSecond
{
    using System;

    using System.Text;

    public static class ArchitectureTwoSecond
    {
        public static String Signature;

        public static String Description;

        public static Boolean EndianFormat;

        public static Byte ReservedFlag;

        public static Encoding StringCodec;

        public static UInt16 ChunkSize;

        public static UInt32 StartBoundary;

        static ArchitectureTwoSecond()
        {
            Signature = ProgramDefaultArchitectureTwoSecond.SignatureDefault;

            Description = ProgramDefaultArchitectureTwoSecond.DescriptionDefault;

            EndianFormat = ProgramDefaultArchitectureTwoSecond.EndianFormatDefault;

            ReservedFlag = ProgramDefaultArchitectureTwoSecond.ReservedFlagDefault;

            StringCodec = ProgramDefaultArchitectureTwoSecond.StringCodecDefault;

            ChunkSize = ProgramDefaultArchitectureTwoSecond.ChunkSizeDefault;

            StartBoundary = ProgramDefaultArchitectureTwoSecond.StartBoundaryDefault;

            return;
        }
    }
}

namespace Core.DimensionTwoSecond
{
    using System;

    public static class ArchitectureThreeThird
    {
        public static Int32 EscapeCharacterLayerNumber;

        static ArchitectureThreeThird()
        {
            EscapeCharacterLayerNumber = ProgramDefaultArchitectureThreeThird.EscapeCharacterLayerNumberDefault;

            return;
        }
    }
}