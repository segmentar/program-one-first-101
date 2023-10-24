using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    internal partial class Program
    {
        private void ConsoleSetupOneFirst()
        {
            InteropStartInfo interopStartInfo;

            interopStartInfo = new InteropStartInfo('#', ';', "::", ":;");

            var array = ConsoleLJ.SettingHandler(interopStartInfo, ProgramNameValueContainerSurface<Tuple<String, Object>>());

            foreach (Tuple<String, String> tuple in array)
            {
                String name, value;

                name = tuple.Item1;

                value = tuple.Item2;

                ProgramNameValueVoid(name, value);

                continue;
            }

            SpecializeConsoleLJ.ValueConsoleLJShow(ArgumentArray, 1000, true, false);

            SpecializeConsoleLJ.GetConsoleLJInstance().Title(ImmutableConsoleLJZeroTen.ProgramName);

            SpecializeConsoleLJ.GetConsoleLJInstance().Style(ConsoleLJWCode.GUIStyle.CommandBackColor, "green");

            SpecializeConsoleLJ.GetConsoleLJInstance().Clear();

            return;
        }
    }
}
