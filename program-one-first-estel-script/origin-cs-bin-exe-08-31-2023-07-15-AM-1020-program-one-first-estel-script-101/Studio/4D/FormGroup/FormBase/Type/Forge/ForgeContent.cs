using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public static String ForgeContent(BaseCFS item__BASE_CFS, Int32[] array_POSITION)
        {
            String stringResult = default;

            var comma = Convert.ToChar(44);

            var start = (array_POSITION[0] + comma.ToString().Length);

            var difference = (array_POSITION[1] - start);

            var sub = item__BASE_CFS.Content.Substring(start, difference);

            var result = sub;

            stringResult = result;

            return stringResult;
        }
    }
}
