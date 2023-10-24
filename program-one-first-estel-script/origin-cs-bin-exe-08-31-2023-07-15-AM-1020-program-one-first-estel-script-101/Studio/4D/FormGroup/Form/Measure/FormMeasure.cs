using Core;

namespace Core
{
    using System;

    public partial struct FormMeasure
    {
        public String RenderFile;

        public String ProofFile;

        public UInt32 HeaderAddress;

        public UInt32 ContentAddress;

        public UInt32 LocalLineAddress;

        public UInt32 GlobalLineAddress;

        public Int32[] PositionArray;
    }
}