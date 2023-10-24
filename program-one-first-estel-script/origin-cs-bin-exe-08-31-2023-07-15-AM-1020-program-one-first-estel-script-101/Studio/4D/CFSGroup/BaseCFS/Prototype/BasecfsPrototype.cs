using Core;

namespace Core
{
    using System;

    using System.Text;

    using System.Collections;

    public partial class BaseCFS
    {
        public BaseCFS(String file, String content, String contentSafe, Encoding encoding, Boolean debug)
        {
            BaseCFSMeasure measure;

            measure = new BaseCFSMeasure();

            measure.FormArrayList = new ArrayList();

            this.Measure = measure;

            this.File = file;

            this.Content = content;

            this.ContentSafe = contentSafe;

            this.Encoding = encoding;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
