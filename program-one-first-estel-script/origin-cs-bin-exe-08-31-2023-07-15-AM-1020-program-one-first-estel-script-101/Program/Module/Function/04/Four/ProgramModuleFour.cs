using Core;

namespace Core
{
    using System;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleFunctionFour(ProgramModule module)
        {
            Form[] formArray;

            formArray = Form.FormDefaultSetSurface(0, module.Third.BaseCFSArray);

            ProgramModuleFunctionFourth fourth;

            fourth = new ProgramModuleFunctionFourth(formArray);

            module.Fourth = fourth;

            return module;
        }
    }
}
