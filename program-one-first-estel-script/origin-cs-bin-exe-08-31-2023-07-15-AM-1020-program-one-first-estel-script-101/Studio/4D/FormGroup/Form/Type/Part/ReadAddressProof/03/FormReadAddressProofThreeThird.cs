using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private FormAddresss FormReadAddressProofThreeThird(FileStream item__FILE_STREAM, BinaryReader item__BINARY_READER, UInt32 item__HEADER_ADDRESS, UInt32 item__CONTENT_ADDRESS, UInt32 item__LOCAL_LINE_ADDRESS, UInt32 item__GLOBAL_LINE_ADDRESS)
        {
            FormAddresss formAddresssResult = default;

            FormAddresss formAddresss;

            formAddresss = new FormAddresss(item__HEADER_ADDRESS, item__CONTENT_ADDRESS, item__LOCAL_LINE_ADDRESS, item__GLOBAL_LINE_ADDRESS);

            formAddresssResult = formAddresss;

            return formAddresssResult;
        }
    }
}
