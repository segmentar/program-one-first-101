using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private FormHeader FormReadHeaderProofZeroTen()
        {
            FormHeader formHeaderResult = default;

            FileStream fileStream;

            fileStream = File.OpenRead(Data.Measure.RenderFile);

            using (fileStream)
            {
                formHeaderResult = FormReadHeaderProofOneFirst(fileStream);

                fileStream.Close();

                fileStream.Dispose();
            }

            return formHeaderResult;
        }
    }
}
