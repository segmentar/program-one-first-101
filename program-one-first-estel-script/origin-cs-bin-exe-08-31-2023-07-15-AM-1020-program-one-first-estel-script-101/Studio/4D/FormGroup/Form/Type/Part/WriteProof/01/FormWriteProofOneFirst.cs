using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private void FormWriteProofOneFirst(FormHeader item__FORM_HEADER, FormAddresss item__FORM_ADDRESS, FormBody item__FORM_BODY, StreamWriter item__STREAM_WRITER)
        {
            var line_feed = Convert.ToChar(10);

            var descriptor = new String[] { 
            
                String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(Proof) + ' ' + '{',
                String.Empty,
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(item__FORM_HEADER) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(item__FORM_ADDRESS) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "03" + ' ' + nameof(item__FORM_BODY) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(item__FORM_HEADER) + ':',
                String.Empty + item__FORM_HEADER,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(item__FORM_ADDRESS) + ':',
                String.Empty + item__FORM_ADDRESS,
                String.Empty,
                String.Empty + '~' + "30" + ' ' + nameof(item__FORM_BODY) + ':',
                String.Empty + item__FORM_BODY
            };

            var join = String.Join(line_feed.ToString(), descriptor);
            
            item__STREAM_WRITER.WriteLine(join);

            return;
        }
    }
}
