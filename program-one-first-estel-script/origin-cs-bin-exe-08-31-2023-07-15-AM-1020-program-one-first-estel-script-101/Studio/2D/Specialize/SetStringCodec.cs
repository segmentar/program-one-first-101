using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.Text;

    public partial class Specialize
    {
        public static void SetStringCodec(UInt32 item__CODE_PAGE)
        {
            var convert = Convert.ToInt32(item__CODE_PAGE);

            ArchitectureTwoSecond.StringCodec = Encoding.GetEncoding(convert);

            return;
        }
    }
}
