using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.Text;

    public partial class Specialize
    {
        public static void SetWriterEncoding(Int32 item__CODE_PAGE)
        {
            ArchitectureOneFirst.WriterEncoding = Encoding.GetEncoding(item__CODE_PAGE);

            return;
        }
    }
}
