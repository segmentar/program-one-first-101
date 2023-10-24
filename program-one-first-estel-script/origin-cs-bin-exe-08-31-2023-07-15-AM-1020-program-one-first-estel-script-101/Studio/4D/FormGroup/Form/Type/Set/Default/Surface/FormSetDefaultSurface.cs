using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public static Form[] FormDefaultSetSurface(Int32 index, BaseCFS[] array__BASE_CFS)
        {
            Form[] arrayResult = default;

            var list = FormDefaultSet(array__BASE_CFS);

            var array = new Form[list.Count];

            list.CopyTo(array, index);

            arrayResult = array;

            return arrayResult;
        }
    }
}
