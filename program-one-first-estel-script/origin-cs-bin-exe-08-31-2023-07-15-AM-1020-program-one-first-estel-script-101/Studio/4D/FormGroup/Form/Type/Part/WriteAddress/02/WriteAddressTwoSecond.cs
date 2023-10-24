using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private Byte[] FormWriteAddressTwoSecond(MemoryStream item__MEMORY_STREAM, BinaryWriter item__BINARY_WRITER)
        {
            Byte[] arrayResult = default;

            item__BINARY_WRITER.Write(Data.Measure.HeaderAddress);

            item__BINARY_WRITER.Write(Data.Measure.ContentAddress);

            item__BINARY_WRITER.Write(Data.Measure.LocalLineAddress);

            item__BINARY_WRITER.Write(Data.Measure.GlobalLineAddress);

            item__BINARY_WRITER.BaseStream.Flush();

            var array = item__MEMORY_STREAM.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
