using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private FormHeader FormReadHeaderProofTwoSecond(FileStream item__FILE_STREAM, BinaryReader item__BINARY_READER)
        {
            FormHeader formHeaderResult = default;

            Boolean endianFormat;

            Byte reservedFlag;

            UInt32 stringCodec;

            UInt16 chunkSize;

            UInt32 startBoundary;

            UInt32 headerAddress;

            endianFormat = item__BINARY_READER.ReadBoolean();

            reservedFlag = item__BINARY_READER.ReadByte();

            stringCodec = item__BINARY_READER.ReadUInt32();

            chunkSize = item__BINARY_READER.ReadUInt16();

            startBoundary = item__BINARY_READER.ReadUInt32();

            headerAddress = item__BINARY_READER.ReadUInt32();

            formHeaderResult = FormReadHeaderProofThreeThird(item__FILE_STREAM, item__BINARY_READER, endianFormat, reservedFlag, stringCodec, chunkSize, startBoundary, headerAddress);

            return formHeaderResult;
        }
    }
}
