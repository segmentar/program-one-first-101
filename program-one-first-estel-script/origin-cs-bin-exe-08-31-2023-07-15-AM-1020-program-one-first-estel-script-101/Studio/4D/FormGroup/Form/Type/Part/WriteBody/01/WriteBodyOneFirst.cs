using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private Byte[] WriteBodyOneFirst(String[] array_HEADER, String item_CONTENT, String[] array__LOCAL_LINE, String[] array__GLOBAL_LINE, MemoryStream item__MEMORY_STREAM)
        {
            Byte[] arrayResult = default;

            BinaryWriter binaryWriter;

            binaryWriter = new BinaryWriter(item__MEMORY_STREAM);

            using (binaryWriter)
            {
                arrayResult = WriteBodyTwoSecond(array_HEADER, item_CONTENT, array__LOCAL_LINE, array__GLOBAL_LINE, item__MEMORY_STREAM, binaryWriter);

                binaryWriter.Close();

                binaryWriter.Dispose();
            }

            return arrayResult;
        }
    }
}
