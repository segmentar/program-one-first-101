using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class BaseCFS
    {
        public static BaseCFS MakeBaseCFSDefaultSurface(String item_FILE, String item_CONTENT, Encoding item_ENCODING)
        {
            BaseCFS baseCFSResult = default;

            baseCFSResult = MakeBaseCFSDefault(item_FILE, item_CONTENT, item_ENCODING, BaseCFSPolicy.BaseCFSDebugPolicy);

            return baseCFSResult;
        }
    }
}
