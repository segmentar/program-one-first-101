using Core;

namespace Core
{
    using System;

    using System.Linq;

    using System.Collections;

    public partial class FormBase
    {
        public static T[] FormBasePeriodContainerSurface<T>(FormBaseStringFormat stringFormat)
        {
            T[] arrayResult = default;

            var list = FormBasePeriodContainer(stringFormat);

            IEnumerable enumerable;

            enumerable = list.OfType<T>().Cast<T>().ToArray();

            var reflect = (T[])(enumerable as Array);

            T[] array;

            array = reflect;

            arrayResult = array;

            return arrayResult;
        }
    }
}
