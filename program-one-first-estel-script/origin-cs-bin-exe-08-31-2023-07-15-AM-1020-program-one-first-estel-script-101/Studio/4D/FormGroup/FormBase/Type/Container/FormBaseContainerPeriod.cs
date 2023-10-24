using Core;

namespace Core
{
    using System;

    using System.Collections;

    public partial class FormBase
    {
        public static ArrayList FormBasePeriodContainer(FormBaseStringFormat stringFormat)
        {
            ArrayList listResult = default;

            listResult = new ArrayList();

            var period = Convert.ToChar(46);

            Char[] characterArray;

            characterArray = stringFormat.StringValueFormat.ToCharArray();

            var split = stringFormat.StringValueFormat.Split(new String[] { period.ToString() }, StringSplitOptions.RemoveEmptyEntries);

            ConsoleLJS.Log(false, $"[{split.Length}] [{stringFormat.StringValueFormat[0] == '\r'}] spl -> <{String.Join(','.ToString(), split)}>");

            int x, y, z;

            x = -1;

            y = 0;

            z = 0;

            for (; ; )
            {
                x = x + 1;

                var boolean_safe_BREAK_should = false;

                boolean_safe_BREAK_should = boolean_safe_BREAK_should || split.Length.Equals(y) is true;

                boolean_safe_BREAK_should = boolean_safe_BREAK_should || characterArray.Length.Equals(x) is true;

                Boolean shouldBreakCheck;

                shouldBreakCheck = boolean_safe_BREAK_should is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Char character;

                character = characterArray[x];

                Boolean isPeriodContagentCheck, isNotPedirodAndEqual;

                isPeriodContagentCheck = character.Equals(period) is true;

                isNotPedirodAndEqual = (isPeriodContagentCheck is false) && (z.Equals(0) is true);

                if (isNotPedirodAndEqual is true)
                {
                    continue;
                }
                else
                    "false".ToString();

                if (isPeriodContagentCheck)
                {
                    z = z + 1;

                    goto bypass;
                }
                else
                {
                    String stringItem;

                    stringItem = split[y];

                    var entity_WHITE_SPACE = Convert.ToChar(32);

                    var format = stringItem.Trim(entity_WHITE_SPACE);

                    var reflect_item_entry__COUNT = z;

                    var reflect_item_entry__ARGUMENT = format;

                    Tuple<Int32, String> tuple;

                    tuple = new Tuple<Int32, String>(reflect_item_entry__COUNT, reflect_item_entry__ARGUMENT);

                    z = 0;

                    listResult.Add(tuple);

                    y = y + 1;

                    goto bypass;
                }

                bypass:
                {
                    continue;
                }
            }

            return listResult;
        }
    }
}
