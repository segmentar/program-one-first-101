using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private FormBody FormReadBodyProofZeroTen()
        {
            FormBody formBodyResult = default;

            FileStream fileStream;

            fileStream = File.OpenRead(Data.Measure.RenderFile);

            using (fileStream)
            {
                formBodyResult = FormReadBodyProofOneFirst(fileStream);
                
                fileStream.Close();

                fileStream.Dispose();
            }

            return formBodyResult;
        }
    }
}
