using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private FormHeader FormReadHeaderProofOneFirst(FileStream item__FILE_STREAM)
        {
            FormHeader formHeaderResult = default;

            BinaryReader binaryReader;

            binaryReader = new BinaryReader(item__FILE_STREAM);

            using (binaryReader)
            {
                formHeaderResult = FormReadHeaderProofTwoSecond(item__FILE_STREAM, binaryReader);

                binaryReader.Close();

                binaryReader.Dispose();
            }

            return formHeaderResult;
        }
    }
}
