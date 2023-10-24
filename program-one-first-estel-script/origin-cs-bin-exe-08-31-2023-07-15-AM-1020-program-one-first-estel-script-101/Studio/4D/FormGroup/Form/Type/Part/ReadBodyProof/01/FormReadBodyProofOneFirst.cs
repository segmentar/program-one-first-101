using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private FormBody FormReadBodyProofOneFirst(FileStream item__FILE_STREAM)
        {
            FormBody formBodyResult = default;

            BinaryReader binaryReader;

            binaryReader = new BinaryReader(item__FILE_STREAM);

            using (binaryReader)
            {
                formBodyResult = FormReadBodyProofTwoSecond(item__FILE_STREAM, binaryReader);

                binaryReader.Close();

                binaryReader.Dispose();
            }

            return formBodyResult;
        }
    }
}
