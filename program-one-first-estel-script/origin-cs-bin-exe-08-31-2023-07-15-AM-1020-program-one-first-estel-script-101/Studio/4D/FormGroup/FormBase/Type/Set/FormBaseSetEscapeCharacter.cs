using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class FormBase
    {
        public static IList<Char> FormBaseEscapeCharacterSet(Tuple<Int32, String>[] array_TUPLE)
        {
            ICollection<Char> collectionResult = default;

            collectionResult = new Collection<Char>();

            foreach (var item_TUPLE in array_TUPLE)
            {
                var item__PERIOD_NUMBER = item_TUPLE.Item1;

                var item__HEADER_ARGUMENT = item_TUPLE.Item2;

                Boolean shouldContinueCheck;

                shouldContinueCheck = item__PERIOD_NUMBER.Equals(ArchitectureThreeThird.EscapeCharacterLayerNumber) is false;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                foreach (var item_CHARACTER in item__HEADER_ARGUMENT)
                {
                    collectionResult.Add(item_CHARACTER);

                    continue;
                }

                continue;
            }

            return new List<Char>(collectionResult);
        }
    }
}
