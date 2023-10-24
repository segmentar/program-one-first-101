using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private Byte[] FormWriteAddressOneFirst(MemoryStream item__MEMORY_STREAM)
        {
            Byte[] arrayResult = default;

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(item__MEMORY_STREAM);

            using (binaryWriter)
            {
                arrayResult = FormWriteAddressTwoSecond(item__MEMORY_STREAM, binaryWriter);

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            return arrayResult;
        }
    }
}
