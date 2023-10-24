using Core;

namespace Core
{
    using System;

    using System.IO;

    public partial struct ProgramModule
    {
        public static ProgramModule ProgramModuleAction(ProgramModuleInformation information)
        {
            ProgramModule module;

            if (information.Free is true)
            {
                ConsoleLJS.Free();
            }
            else
                "false".ToString();

            module = ProgramModuleDefault();

            if (information.Input is true)
            {
                AppDomain.CurrentDomain.ProcessExit += new EventHandler((Object sender, EventArgs e) => {

                    Interop.Inpuf02OL(module.Second.FileArray);
                });
            }
            else
                "false".ToString();

            if (information.Render is true)
            {
                Form.FormRenderFormArrayVoid(module.Fourth.FormArray);
            }
            else
                "false".ToString();

            if (information.Copy is true)
            {
                AppDomain.CurrentDomain.ProcessExit += new EventHandler((Object sender, EventArgs e) => {

                    Interop.Copyf03L(Directory.GetFiles(module.First.WorkingDirectory));
                });
            }
            else
                "false".ToString();

            if (information.Output is true)
            {
                AppDomain.CurrentDomain.ProcessExit += new EventHandler((Object sender, EventArgs e) => {

                    Interop.Outpf04OL(Form.FormFilenameSetSurface(module.Fourth.FormArray));
                });
            }
            else
                "false".ToString();

            if (information.Explorer is true)
            {
                AppDomain.CurrentDomain.ProcessExit += new EventHandler((Object sender, EventArgs e) => {

                    ConsoleLJS.Explorer(1, Directory.GetCurrentDirectory());
                });
            }
            else
                "false".ToString();

            if (information.Escape is true)
            {
                AppDomain.CurrentDomain.ProcessExit += new EventHandler((Object sender, EventArgs e) => {

                    SpecializeConsoleLJ.GetConsoleLJInstance().Escape();
                });
            }
            else
                "false".ToString();

            return module;
        } 
    }
}
