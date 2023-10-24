using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private FormAddresss FormReadAddressProofZeroTen()
        {
            FormAddresss formAddresssResult = default;

            FileStream fileStream;

            fileStream = File.OpenRead(Data.Measure.RenderFile);

            using (fileStream)
            {
                formAddresssResult = FormReadAddressProofOneFirst(fileStream);

                fileStream.Close();

                fileStream.Dispose();
            }

            return formAddresssResult;
        }
    }
}
