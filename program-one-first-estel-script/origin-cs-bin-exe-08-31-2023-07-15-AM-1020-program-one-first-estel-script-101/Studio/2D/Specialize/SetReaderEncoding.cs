using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.Text;

    public partial class Specialize
    {
        public static void SetReaderEncoding(Int32 item__CODE_PAGE)
        {
            ArchitectureOneFirst.ReaderEncoding = Encoding.GetEncoding(item__CODE_PAGE);

            return;
        }
    }
}
