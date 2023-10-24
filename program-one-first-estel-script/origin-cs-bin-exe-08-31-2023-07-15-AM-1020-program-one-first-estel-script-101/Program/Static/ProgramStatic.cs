using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        internal static String[] ArgumentArray;

        internal static void Main(params String[] array_ARGUMENT)
        {
            ArgumentArray = array_ARGUMENT;

#if DEBUG
            ConsoleLJS.Bundle(true);
#else
            ConsoleLJS.Bundle(false);
#endif

            Bundle();

            return;
        }

        internal static void Procedure()
        {
            ProgramPolicy.ProgramDebugPolicy = true;

            ProgramPolicy.ProgramInfoPolicy = true;

            BaseCFSPolicy.BaseCFSDebugPolicy = true;

            BaseCFSPolicy.BaseCFSInfoPolicy = true;

            FormPolicy.FormDebugPolicy = true;

            FormPolicy.FormInfoPolicy = true;

            FormBasePolicy.FormBaseDebugPolicy = true;

            FormBasePolicy.FormBaseInfoPolicy = true;

            FormLinePolicy.FormLineDebugPolicy = true;

            FormLinePolicy.FormLineInfoPolicy = true;

            return;
        }

        internal static void Manual()
        {
            ProgramModuleInformation programModuleInformation;

            programModuleInformation = new ProgramModuleInformation()
            {
                Free = true,
                Input = true,
                Render = true,
                Copy = true,
                Output = true,
                Explorer = true,
                Escape = true
            };

            ProgramModule programModule = ProgramModule.ProgramModuleAction(programModuleInformation);

            return;
        }

        internal static void Bundle()
        {
#if DEBUG
            Procedure();
#endif
            Manual();
#if DEBUG
            Raise();
#endif
            Environment.Exit(0);

            return;
        }

        internal static void Raise()
        {
            if (ProgramPolicy.ProgramInfoPolicy is true)
            {
                ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectory.Core_Info}-{nameof(Program)}Info", ProgramPolicy.ProgramArrayList.ToArray());
            }
            else
                "false".ToString();

            if (BaseCFSPolicy.BaseCFSInfoPolicy is true)
            {
                ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectory.Core_Info}-{nameof(BaseCFS)}Info", BaseCFSPolicy.BaseCFSArrayList.ToArray());
            }
            else
                "false".ToString();

            if (FormPolicy.FormInfoPolicy is true)
            {
                ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectory.Core_Info}-{nameof(Form)}Info", FormPolicy.FormArrayList.ToArray());
            }
            else
                "false".ToString();

            if (FormBasePolicy.FormBaseInfoPolicy is true)
            {
                ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectory.Core_Info}-{nameof(FormBase)}Info", FormBasePolicy.FormBaseArrayList.ToArray());
            }
            else
                "false".ToString();

            if (FormLinePolicy.FormLineInfoPolicy is true)
            {
                ConsoleLJS.Render($"{ConsoleLJCode.SpecialDirectory.Core_Info}-{nameof(FormLine)}Info", FormLinePolicy.FormLineArrayList.ToArray());
            }
            else
                "false".ToString();

            return;
        }

        static Program()
        {
            return;
        }
    }
}
