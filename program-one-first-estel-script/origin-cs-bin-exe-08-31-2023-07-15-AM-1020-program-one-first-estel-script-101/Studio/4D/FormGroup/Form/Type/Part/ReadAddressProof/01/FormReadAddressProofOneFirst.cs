using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private FormAddresss FormReadAddressProofOneFirst(FileStream item__FILE_STREAM)
        {
            FormAddresss formAddresssResult = default;

            BinaryReader binaryReader;

            binaryReader = new BinaryReader(item__FILE_STREAM);

            using (binaryReader)
            {
                formAddresssResult = FormReadAddressProofTwoSecond(item__FILE_STREAM, binaryReader);

                binaryReader.Close();

                binaryReader.Dispose();
            }

            return formAddresssResult;
        }
    }
}
