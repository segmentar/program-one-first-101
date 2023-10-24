using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class BaseCFS
    {
        public static BaseCFS MakeBaseCFSDefault(String item_FILE, String item_CONTENT, Encoding item_ENCODING, Boolean answer_DEBUG_is)
        {
            BaseCFS baseCFSResult = default;

            var result = new BaseCFSSequence(item_FILE, item_CONTENT, item_ENCODING, answer_DEBUG_is).Result;

            BaseCFSPolicy.BaseCFSArrayList.Add(result);

            baseCFSResult = result;

            return baseCFSResult;
        }
    }
}
