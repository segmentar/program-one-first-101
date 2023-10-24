using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private Byte[] FormWriteAddressZeroTen()
        {
            Byte[] arrayResult = default;

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            using (memoryStream)
            {
                arrayResult = FormWriteAddressOneFirst(memoryStream);

                memoryStream.Close();

                memoryStream.Dispose();
            }

            return arrayResult;
        }
    }
}
