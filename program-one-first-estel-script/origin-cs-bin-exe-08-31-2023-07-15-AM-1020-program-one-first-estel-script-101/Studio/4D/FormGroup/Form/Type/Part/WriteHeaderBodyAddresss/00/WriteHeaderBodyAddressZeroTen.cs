using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private Byte[] WriteHeaderBodyAddressZeroTen(Byte[] array_HEADER, Byte[] array_BODY, Byte[] array_ADDRESS)
        {
            Byte[] arrayResult = default;

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            using (memoryStream)
            {
                arrayResult = WriteHeaderBodyAddressOneFirst(array_HEADER, array_BODY, array_ADDRESS, memoryStream);

                memoryStream.Close();

                memoryStream.Dispose();
            }

            return arrayResult;
        }
    }
}
