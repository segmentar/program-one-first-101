using Core;

namespace Core
{
    using System;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleFunctionOne(ProgramModule module)
        {
            var tuple = ConsoleLJ.ForgeCurrentTuple__FILE_DIRECTORY();

            String file, directory;

            file = tuple.Item1;

            directory = tuple.Item2;

            String workingDirectory;

            workingDirectory = ConsoleLJS.WorkingDirectory(directory, true);

            ProgramModuleFunctionFirst first;

            first = new ProgramModuleFunctionFirst(file, directory, workingDirectory);

            module.First = first;

            return module;
        }
    }
}
