using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public Form(FormMeasure measure, FormRuntime runtime, BaseCFS baseCFS, Boolean debug)
        {
            FormData data;

            data = new FormData();

            data.Measure = measure;

            data.Runtime = runtime;

            data.BaseCFS = baseCFS;

            if (debug is true)
            {
                data.IsDebug = true;
            }
            else
                "false".ToString();

            this.Data = data;

            return;
        }
    }
}
