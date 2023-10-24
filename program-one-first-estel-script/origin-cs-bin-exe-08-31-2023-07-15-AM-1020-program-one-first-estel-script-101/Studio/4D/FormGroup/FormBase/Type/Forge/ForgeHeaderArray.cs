using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public static String[] ForgeHeaderArray(BaseCFS item__BASE_CFS, Int32[] array_POSITION)
        {
            String[] arrayResult = default;

            var difference = (array_POSITION[0] - item__BASE_CFS.Measure.Position);

            var sub = item__BASE_CFS.Content.Substring(item__BASE_CFS.Measure.Position, difference);

            var period = Convert.ToChar(46);

            var split = sub.Split(new String[] { period.ToString() }, StringSplitOptions.RemoveEmptyEntries);

            var result = split;

            arrayResult = result;

            return arrayResult;
        }
    }
}
