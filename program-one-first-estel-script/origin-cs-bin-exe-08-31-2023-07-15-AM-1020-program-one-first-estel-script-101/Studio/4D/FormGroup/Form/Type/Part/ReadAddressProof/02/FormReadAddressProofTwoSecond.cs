using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private FormAddresss FormReadAddressProofTwoSecond(FileStream item__FILE_STREAM, BinaryReader item__BINARY_READER)
        {
            FormAddresss formAddresssResult = default;

            var flag__SHOULD_INCLUDE_SIGNATURE = 0b00000010;

            Boolean shouldIncludeSignatureContagiousCheck;

            shouldIncludeSignatureContagiousCheck = (flag__SHOULD_INCLUDE_SIGNATURE & ArchitectureTwoSecond.ReservedFlag).Equals(flag__SHOULD_INCLUDE_SIGNATURE) is true;

            if (shouldIncludeSignatureContagiousCheck)
            {
                item__BINARY_READER.BaseStream.Seek(FormConstant.HeaderSize, SeekOrigin.Begin);
            }
            else
            {
                item__BINARY_READER.BaseStream.Seek(FormConstant.HeaderSizeWithSignature, SeekOrigin.Begin);
            }

            UInt32 headerAddress, contentAddress, localLineAddress, globalLineAddress;

            headerAddress = item__BINARY_READER.ReadUInt32();

            contentAddress = item__BINARY_READER.ReadUInt32();

            localLineAddress = item__BINARY_READER.ReadUInt32();

            globalLineAddress = item__BINARY_READER.ReadUInt32();

            formAddresssResult = FormReadAddressProofThreeThird(item__FILE_STREAM, item__BINARY_READER, headerAddress, contentAddress, localLineAddress, globalLineAddress);

            return formAddresssResult;
        }
    }
}
