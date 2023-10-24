using Core;

namespace Core
{
    using System;

    using System.Text;

    public partial class BaseCFSSequence
    {
        public BaseCFS Result { get; set; } = default;

        public BaseCFSSequence(String item_FILE, String item_CONTENT, Encoding item_ENCODING, Boolean answer_DEBUG_is)
        {
            Debug(item_FILE, item_CONTENT, item_ENCODING, answer_DEBUG_is);

            String content, contentSafe;

            content = item_CONTENT;

            contentSafe = ConsoleLJS.SafeString(content);

            BaseCFS controlCFS;

            controlCFS = new BaseCFS(item_FILE, content, contentSafe, item_ENCODING, answer_DEBUG_is);

            this.Result = controlCFS;

            return;
        }

        ~BaseCFSSequence()
        {
            return;
        }
    }
}
