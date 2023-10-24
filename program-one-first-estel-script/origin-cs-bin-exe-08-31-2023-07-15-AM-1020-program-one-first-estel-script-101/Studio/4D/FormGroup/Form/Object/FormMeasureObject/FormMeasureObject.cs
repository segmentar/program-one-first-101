using Core;

namespace Core
{
    using System;

    public partial struct FormMeasure
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] { 
            
                String.Empty + nameof(Form) + ' ' + "::" + ' ' + nameof(FormMeasure) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(RenderFile) + ':' + ' ' + RenderFile,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(PositionArray) + ':' + ' ' + ". . ." + ' ' + $"<{PositionArray.Length}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(PositionArray) + ':',
                String.Empty + String.Join('\n'.ToString(), PositionArray)
            });
        }
    }
}
