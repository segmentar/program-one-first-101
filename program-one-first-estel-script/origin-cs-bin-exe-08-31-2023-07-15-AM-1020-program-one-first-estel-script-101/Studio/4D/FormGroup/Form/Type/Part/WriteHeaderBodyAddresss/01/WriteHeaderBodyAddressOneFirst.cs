using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private Byte[] WriteHeaderBodyAddressOneFirst(Byte[] array_HEADER, Byte[] array_BODY, Byte[] array_ADDRESS, MemoryStream item__MEMORY_STREAM)
        {
            Byte[] arrayResult = default;

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(item__MEMORY_STREAM);

            using (binaryWriter)
            {
                arrayResult = WriteHeaderBodyAddressTwoSecond(array_HEADER, array_BODY, array_ADDRESS, item__MEMORY_STREAM, binaryWriter);

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            return arrayResult;
        }
    }
}
