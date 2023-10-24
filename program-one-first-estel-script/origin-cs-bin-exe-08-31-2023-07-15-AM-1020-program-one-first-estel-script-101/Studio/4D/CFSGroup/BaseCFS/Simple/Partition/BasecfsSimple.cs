using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    public partial class BaseCFSSimple
    {
        public BaseCFS Result { get; set; } = default;

        public BaseCFSSimple()
        {
            return;
        }

        ~BaseCFSSimple()
        {
            return;
        }
    }
}

namespace Core
{
    using System;

    using System.IO;

    using System.Text;

    public partial class BaseCFSSimple
    {
        public BaseCFSSimple(String file)
        {
            Encoding encoding;

            encoding = ArchitectureOneFirst.ReaderEncoding;

            var text = File.ReadAllText(file, encoding);

            BaseCFS baseCFS;

            baseCFS = BaseCFS.MakeBaseCFSDefaultSurface(file, text, encoding);

            this.Result = baseCFS;

            return;
        }
    }
}
