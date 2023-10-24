using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public static Char[] FormBaseEscapeCharacterSetSurface(Tuple<Int32, String>[] array_TUPLE)
        {
            Char[] arrayResult = default;

            var list = FormBaseEscapeCharacterSet(array_TUPLE);

            var array = new Char[list.Count];

            list.CopyTo(array, FormBasePolicy.FormBaseIndexPolicy);

            arrayResult = array;

            return arrayResult;
        }
    }
}
