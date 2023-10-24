using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private Byte[] WriteHeaderThreeSecond(MemoryStream item__MEMORY_STREAM, BinaryWriter item__BINARY_WRITER)
        {
            Byte[] arrayResult = default;

            item__BINARY_WRITER.Write(ArchitectureTwoSecond.EndianFormat);

            item__BINARY_WRITER.Write(ArchitectureTwoSecond.ReservedFlag);

            item__BINARY_WRITER.Write(ArchitectureTwoSecond.StringCodec.CodePage);

            item__BINARY_WRITER.Write(ArchitectureTwoSecond.ChunkSize);

            item__BINARY_WRITER.Write(ArchitectureTwoSecond.StartBoundary);

            item__BINARY_WRITER.BaseStream.Flush();

            var array = item__MEMORY_STREAM.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
