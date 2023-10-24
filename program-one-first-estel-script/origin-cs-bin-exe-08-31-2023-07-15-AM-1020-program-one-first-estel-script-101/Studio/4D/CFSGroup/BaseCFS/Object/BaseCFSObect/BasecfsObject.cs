using Core;

namespace Core
{
    using System;

    public partial struct BaseCFSMeasure
    {
        public override String ToString()
        {
            return String.Join('\n'.ToString(), new String[] {

                String.Empty + nameof(BaseCFS) + ' ' + "::" + nameof(BaseCFSMeasure) + ' ' + '{',
                String.Empty + '.' + "measure",
                String.Empty + '\t' + '~' + "01" + ' ' + nameof(Position) + ':' + ' ' + Position,
                String.Empty + '\t' + '~' + "02" + ' ' + nameof(FormArrayList) + ':' + ' ' + ". . ." + ' ' + $"<{FormArrayList.Count}>",
                String.Empty + '}',
                String.Empty,
                String.Empty + '~' + "10" + ' ' + nameof(FormArrayList) + ':',
                String.Empty + String.Join('\n'.ToString(), FormArrayList.ToArray())
            });
        }
    }
}
