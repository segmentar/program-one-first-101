using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private Byte[] WriteHeaderZeroTen()
        {
            Byte[] arrayResult = default;

            MemoryStream memoryStream;

            memoryStream = new MemoryStream();

            using (memoryStream)
            {
                arrayResult = WriteHeaderOneFirst(memoryStream);

                memoryStream.Close();

                memoryStream.Dispose();
            }

            return arrayResult;
        }
    }
}
