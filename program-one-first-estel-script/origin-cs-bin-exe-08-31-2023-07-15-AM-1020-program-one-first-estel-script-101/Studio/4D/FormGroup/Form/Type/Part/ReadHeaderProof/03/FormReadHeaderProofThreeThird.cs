using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private FormHeader FormReadHeaderProofThreeThird(FileStream item__FILE_STREAM, BinaryReader item__BINARY_READER, Boolean item__ENDIAN_FORMAT, Byte item__RESERVED_FLAG, UInt32 item__STRING_CODEC, UInt16 item__CHUNK_SIZE, UInt32 item__START_BOUNDARY, UInt32 item__HEADER_ADDRESS)
        {
            FormHeader formHeaderResult = default;

            FormHeader formHeader;

            formHeader = new FormHeader(item__ENDIAN_FORMAT, item__RESERVED_FLAG, item__STRING_CODEC, item__CHUNK_SIZE, item__START_BOUNDARY);

            formHeaderResult = formHeader;

            return formHeaderResult;
        }
    }
}
