using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private Byte[] WriteHeaderBodyAddressTwoSecond(Byte[] array_HEADER, Byte[] array_BODY, Byte[] array_ADDRESS, MemoryStream item__MEMORY_STREAM, BinaryWriter item__BINARY_WRITER)
        {
            Byte[] arrayResult = default;

            /*var flag_SIGNATURE_has = 0b00000010;

            Boolean hasSignatureCheck;

            hasSignatureCheck = (flag_SIGNATURE_has & ArchitectureOneFirst.ReservedFlag).Equals(flag_SIGNATURE_has) is true;

            if (hasSignatureCheck is true)
            {
            item__BINARY_WRITER.Write(ArchitectureOneFirst.Signature);

            item__BINARY_WRITER.BaseStream.Seek(16, SeekOrigin.Begin);
            }
            else
            "false".ToString();*/

            item__BINARY_WRITER.Write(array_HEADER);

            item__BINARY_WRITER.Write(array_ADDRESS);

            item__BINARY_WRITER.BaseStream.Seek(ArchitectureTwoSecond.StartBoundary, SeekOrigin.Begin);

            item__BINARY_WRITER.Write(array_BODY);

            item__BINARY_WRITER.BaseStream.Flush();

            var array = item__MEMORY_STREAM.ToArray();

            arrayResult = array;

            return arrayResult;
        }
    }
}
