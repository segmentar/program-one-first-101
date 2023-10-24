using Core;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleDefault()
        {
            Program program;

            program = Program.MakeProgramDefaultSurface();

            if (ArchitectureConsoleLJOneFirst.IsExternalCall is false)
            {
                program.ConsoleSetup();
            }
            else
                "false".ToString();

            ProgramModule module;

            module = new ProgramModule();

            module.Program = program;

            module = ProgramModuleFunctionOne(module);

            module = ProgramModuleFunctionTwo(module);

            module = ProgramModuleFunctionThree(module);

            module = ProgramModuleFunctionFour(module);

            return module;
        }
    }
}
