using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private Byte[] WriteBodyZeroTen(String[] array_HEADER, String item_CONTENT, String[] array__LOCAL_LINE, String[] array__GLOBAL_LINE)
        {
            Byte[] arrayResult = default;

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            using (memoryStream)
            {
                arrayResult = WriteBodyOneFirst(array_HEADER, item_CONTENT, array__LOCAL_LINE, array__GLOBAL_LINE, memoryStream);

                memoryStream.Close();

                memoryStream.Dispose();
            }

            return arrayResult;
        }
    }
}
