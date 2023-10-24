using Core;

namespace Core
{
    using System;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleFunctionThree(ProgramModule module)
        {
            BaseCFS[] baseCFSArray;

            baseCFSArray = BaseCFS.BaseCFSDefaultSetSurface(0, module.Second.FileArray, module.First.WorkingDirectory);
                
            ProgramModuleFunctionThird third;

            third = new ProgramModuleFunctionThird(baseCFSArray);

            module.Third = third;

            return module;
        }
    }
}