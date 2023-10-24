using Core;

namespace Core
{
    using System;

    using System.Text;

    internal static class ProgramDefaultArchitectureOneFirst
    {
        internal static Encoding ReaderEncodingDefault;

        internal static Encoding WriterEncodingDefault;

        internal static String ExtensionNameDefault;

        internal static String FullExtensionDefault;

        static ProgramDefaultArchitectureOneFirst()
        {
            ReaderEncodingDefault = Encoding.Default;

            WriterEncodingDefault = Encoding.Default;

            ExtensionNameDefault = "Example";

            FullExtensionDefault = default(String);

            return;
        }
    }
}

namespace Core
{
    using System;

    using System.Text;

    internal static class ProgramDefaultArchitectureTwoSecond
    {
        internal static String SignatureDefault;

        internal static Boolean EndianFormatDefault;

        internal static Byte ReservedFlagDefault;

        internal static Encoding StringCodecDefault;

        internal static UInt16 ChunkSizeDefault;

        internal static UInt32 StartBoundaryDefault;

        internal static String DescriptionDefault;

        static ProgramDefaultArchitectureTwoSecond()
        {
            SignatureDefault = "Estel's Script";

            EndianFormatDefault = BitConverter.IsLittleEndian;

            ReservedFlagDefault = 0;

            StringCodecDefault = Encoding.Default;

            ChunkSizeDefault = 512;

            StartBoundaryDefault = 128;

            DescriptionDefault = DateTime.Now.ToString();
        }
    }
}

namespace Core
{
    using System;

    public static class ProgramDefaultArchitectureThreeThird
    {
        public static Int32 EscapeCharacterLayerNumberDefault;

        static ProgramDefaultArchitectureThreeThird()
        {
            EscapeCharacterLayerNumberDefault = 2;

            return;
        }
    }
}