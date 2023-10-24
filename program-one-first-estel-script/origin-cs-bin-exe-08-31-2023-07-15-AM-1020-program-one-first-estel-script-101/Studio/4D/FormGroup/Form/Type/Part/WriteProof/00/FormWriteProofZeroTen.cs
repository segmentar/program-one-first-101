using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private void FormWriteProofZeroTen(FormHeader item__FORM_HEADER, FormAddresss item__FORM_ADDRESS, FormBody item__FORM_BODY)
        {
            if (File.Exists(Data.Measure.ProofFile))
            {
                File.Delete(Data.Measure.ProofFile);
            }
            else
                "false".ToString();

            StreamWriter streamWriter;

            streamWriter = File.CreateText(Data.Measure.ProofFile);

            using (streamWriter)
            {
                FormWriteProofOneFirst(item__FORM_HEADER, item__FORM_ADDRESS, item__FORM_BODY, streamWriter);

                streamWriter.Flush();

                streamWriter.Close();

                streamWriter.Dispose();
            }

            return;
        }
    }
}
