using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private Byte[] WriteHeaderOneFirst(MemoryStream item__MEMORY_STREAM)
        {
            Byte[] arrayResult = default;

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(item__MEMORY_STREAM);

            using (binaryWriter)
            {
                arrayResult = WriteHeaderThreeSecond(item__MEMORY_STREAM, binaryWriter);

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            return arrayResult;
        }
    }
}
