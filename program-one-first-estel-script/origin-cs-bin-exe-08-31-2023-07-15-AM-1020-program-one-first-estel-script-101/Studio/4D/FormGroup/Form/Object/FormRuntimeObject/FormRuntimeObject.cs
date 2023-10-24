using Core;

namespace Core
{
    using System;

    public partial struct FormRuntime
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(FormRuntime) + ' ' + '{',
                String.Empty + '.' + "runtime",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(FormBase) + ':' + ' ' + ". . .",
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(FormLine) + ':' + ' ' + ". . .",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FormBase) + ':',
                String.Empty + FormBase,
                String.Empty,
                String.Empty + '~' + "20" + ' ' + nameof(FormLine) + ':',
                String.Empty + FormLine
            });
        }
    }
}
