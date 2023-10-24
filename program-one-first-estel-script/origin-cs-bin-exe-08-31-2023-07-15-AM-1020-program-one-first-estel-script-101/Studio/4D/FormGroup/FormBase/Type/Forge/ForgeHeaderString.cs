using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public static String ForgeHeaderString(BaseCFS item__BASE_CFS, Int32[] array_POSITION)
        {
            String stringResult = default;

            var difference = (array_POSITION[0] - item__BASE_CFS.Measure.Position);

            var sub = item__BASE_CFS.Content.Substring(item__BASE_CFS.Measure.Position, difference);

            var result = sub;

            stringResult = result;

            return stringResult;
        }
    }
}
