using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private void FormWriteFileZeroTen()
        {
            Boolean shouldReturnCheck;

            shouldReturnCheck = (Data.Measure.RenderFile == default) is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            if (File.Exists(Data.Measure.RenderFile) is true)
            {
                File.Delete(Data.Measure.RenderFile);
            }
            else
                "false".ToString();

            Byte[] headerArray, bodyArray, addressArray, headerAddressBodyArray;

            headerArray = WriteHeaderZeroTen();

            bodyArray = WriteBodyZeroTen(Data.Runtime.FormBase.HeaderArray, Data.Runtime.FormBase.ContentString, Data.Runtime.FormLine.LocalLineArray, Data.Runtime.FormLine.GlobalLineArray);

            addressArray = FormWriteAddressZeroTen();

            headerAddressBodyArray = WriteHeaderBodyAddressZeroTen(headerArray, bodyArray, addressArray);

            File.WriteAllBytes(Data.Measure.RenderFile, headerAddressBodyArray);

            return;
        }
    }
}
