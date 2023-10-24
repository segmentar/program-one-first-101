using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    internal partial class Program
    {
        public static void ProgramNameValueVoidOneFirst(String name, String value, String item_STRING, Int32 item__SIGNED_INTEGER_BIT_32, Int32 item__SIGNED_INTEGER_BIT_16, UInt32 item__UNSIGNED_INTEGER_BIT_32, UInt16 item__UNSIGNED_INTEGER_BIT_16, Char item_CHARACTER, Boolean item_BOOLEAN, Byte item_BYTE)
        {
            switch (name)
            {
                case nameof(ArchitectureOneFirst.ReaderEncoding):
                    Specialize.SetReaderEncoding(item__SIGNED_INTEGER_BIT_32);
                    break;

                case nameof(ArchitectureOneFirst.WriterEncoding):
                    Specialize.SetWriterEncoding(item__SIGNED_INTEGER_BIT_32);
                    break;

                case nameof(ArchitectureTwoSecond.Signature):
                    ArchitectureTwoSecond.Signature = item_STRING;
                    break;

                case nameof(ArchitectureTwoSecond.EndianFormat):
                    ArchitectureTwoSecond.EndianFormat = item_BOOLEAN;
                    break;

                case nameof(ArchitectureTwoSecond.ReservedFlag):
                    ArchitectureTwoSecond.ReservedFlag = item_BYTE;
                    break;

                case nameof(ArchitectureTwoSecond.StringCodec):
                    Specialize.SetStringCodec(item__UNSIGNED_INTEGER_BIT_32);
                    break;

                case nameof(ArchitectureTwoSecond.ChunkSize):
                    ArchitectureTwoSecond.ChunkSize = item__UNSIGNED_INTEGER_BIT_16;
                    break;

                case nameof(ArchitectureTwoSecond.StartBoundary):
                    ArchitectureTwoSecond.StartBoundary = item__UNSIGNED_INTEGER_BIT_32;
                    break;

                case nameof(ArchitectureTwoSecond.Description):
                    ArchitectureTwoSecond.Description = item_STRING;
                    break;

                case nameof(ArchitectureOneFirst.ExtensionName):
                    ArchitectureOneFirst.ExtensionName = item_STRING;
                    break;

                default:
                    break;
            }

            return;
        }
    }
}
