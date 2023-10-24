using Core;

namespace Core
{
    using System;

    public class FormConstant
    {
        public const Int32 HeaderSize = (sizeof(Boolean) + sizeof(Byte) + sizeof(UInt32) + sizeof(UInt16) + sizeof(UInt32));

        public const Int32 HeaderSizeWithSignature = (HeaderSize + (sizeof(Byte) * 16));

        public const Int32 AddresssSize = (sizeof(UInt32) * 4);
    }
}
