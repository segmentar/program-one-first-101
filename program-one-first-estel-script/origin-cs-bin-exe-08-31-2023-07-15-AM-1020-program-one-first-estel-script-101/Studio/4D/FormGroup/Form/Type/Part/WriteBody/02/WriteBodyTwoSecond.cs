using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private Byte[] WriteBodyTwoSecond(String[] array_HEADER, String item_CONTENT, String[] array__LOCAL_LINE, String[] array__GLOBAL_LINE, MemoryStream item__MEMORY_STREAM, BinaryWriter item__BINARY_WRITER)
        {
            Byte[] arrayResult = default;

            var length_HEADER = Convert.ToUInt32(array_HEADER.Length);

            var length__LOCAL_LINE = Convert.ToUInt32(array__LOCAL_LINE.Length);

            var length__GLOBAL_LINE = Convert.ToUInt32(array__GLOBAL_LINE.Length);

            Data.Measure.HeaderAddress = Convert.ToUInt32(ArchitectureTwoSecond.StartBoundary + item__BINARY_WRITER.BaseStream.Position);

            item__BINARY_WRITER.Write(length_HEADER);

            item__BINARY_WRITER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

            foreach (String item_STRING in array_HEADER)
            {
                item__BINARY_WRITER.Write(item_STRING);

                item__BINARY_WRITER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

                continue;
            }

            Data.Measure.ContentAddress = Convert.ToUInt32(ArchitectureTwoSecond.StartBoundary + item__BINARY_WRITER.BaseStream.Position);

            item__BINARY_WRITER.Write(item_CONTENT);

            item__BINARY_WRITER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

            Data.Measure.LocalLineAddress = Convert.ToUInt32(ArchitectureTwoSecond.StartBoundary + item__BINARY_WRITER.BaseStream.Position);

            item__BINARY_WRITER.Write(length__LOCAL_LINE);

            item__BINARY_WRITER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

            foreach (String item_STRING in array__LOCAL_LINE)
            {
                item__BINARY_WRITER.Write(item_STRING);

                item__BINARY_WRITER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

                continue;
            }

            Data.Measure.GlobalLineAddress = Convert.ToUInt32(ArchitectureTwoSecond.StartBoundary + item__BINARY_WRITER.BaseStream.Position);

            item__BINARY_WRITER.Write(length__GLOBAL_LINE);

            item__BINARY_WRITER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

            foreach (String item_STRING in array__GLOBAL_LINE)
            {
                item__BINARY_WRITER.Write(item_STRING);

                item__BINARY_WRITER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

                continue;
            }

            item__BINARY_WRITER.BaseStream.Flush();

            var array = item__MEMORY_STREAM.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
