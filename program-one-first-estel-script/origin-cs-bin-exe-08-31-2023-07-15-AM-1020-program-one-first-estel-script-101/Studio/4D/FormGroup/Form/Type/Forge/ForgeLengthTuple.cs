using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    public partial class Form
    {
        public static Tuple<Int32, Int32, Int32, Int32> ForgeLengthTuple(Form form)
        {
            Tuple<Int32, Int32, Int32, Int32> tupleResult = default;

            Int32 headerLength, contentLength, localLineLength, globalLineLength;

            headerLength = 0;

            headerLength = headerLength + ArchitectureTwoSecond.ChunkSize;

            headerLength = headerLength + (ArchitectureTwoSecond.ChunkSize * form.Data.Runtime.FormBase.HeaderArray.Length);

            contentLength = 0;

            contentLength = contentLength + ArchitectureTwoSecond.ChunkSize;

            localLineLength = 0;

            localLineLength = localLineLength + ArchitectureTwoSecond.ChunkSize;

            localLineLength = localLineLength + (ArchitectureTwoSecond.ChunkSize * form.Data.Runtime.FormLine.LocalLineArray.Length);

            globalLineLength = 0;

            globalLineLength = globalLineLength + ArchitectureTwoSecond.ChunkSize;

            globalLineLength = globalLineLength + (ArchitectureTwoSecond.ChunkSize * form.Data.Runtime.FormLine.GlobalLineArray.Length);

            Tuple<Int32, Int32, Int32, Int32> tuple;

            tuple = new Tuple<Int32, Int32, Int32, Int32>(headerLength, contentLength, localLineLength, globalLineLength);

            tupleResult = tuple;

            return tupleResult;
        }
    }
}
