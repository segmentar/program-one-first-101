using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        private void ConsoleSetupTwoSecond()
        {
            do
            {
                SpecializeConsoleLJ.GetConsoleLJInstance().Clear();

                SpecializeConsoleLJ.GetConsoleLJInstance().WriteLine(ConsoleDescriptor());

                var line = SpecializeConsoleLJ.GetConsoleLJInstance().ReadLine();

                Tuple<String[], String, Int32, Boolean> tupleItem;

                tupleItem = ConsoleLJ.ForgeFlatTuple(line);

                ConsoleSetupThreeThird(tupleItem.Item1, tupleItem.Item2, tupleItem.Item3, tupleItem.Item4);

                var array = ConsoleLJ.EndPointHandler(line, ProgramNameValueContainerSurface<Tuple<String, Object>>());

                foreach (Tuple<String, String> tuple in array)
                {
                    String name, value;

                    name = tuple.Item1;

                    value = tuple.Item2;

                    ProgramNameValueVoid(name, value);

                    continue;
                }

                Boolean isEscapeCheck;

                isEscapeCheck = line.Equals("escape") is true;

                if (isEscapeCheck is true)
                {
                    SpecializeConsoleLJ.GetConsoleLJInstance().Clear();

                    break;
                }
                else
                    "false".ToString();

                continue;

            } while (true);

            return;
        }
    }
}
