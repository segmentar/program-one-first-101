using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private FormBody FormReadBodyProofThreeThird(FileStream item__FILE_STREAM, BinaryReader item__BINARY_READER, UInt32 item__HEADER_LENGTH, String[] array_HEADER, String item_CONTENT, UInt32 item__LOCAL_LINE_LENGTH, String[] array__LOCAL_LINE, UInt32 item__GLOBAL_LINE_LENGTH, String[] array__GLOBAL_LINE)
        {
            FormBody formBodyResult = default;

            FormBody formBody;

            formBody = new FormBody(item__HEADER_LENGTH, array_HEADER, item_CONTENT, item__LOCAL_LINE_LENGTH, array__LOCAL_LINE, item__GLOBAL_LINE_LENGTH, array__GLOBAL_LINE);

            formBodyResult = formBody;

            return formBodyResult;
        }
    }
}
