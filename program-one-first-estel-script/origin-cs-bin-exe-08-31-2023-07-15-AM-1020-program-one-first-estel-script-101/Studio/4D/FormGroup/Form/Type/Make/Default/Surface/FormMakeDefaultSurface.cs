using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public static Form MakeFormDefaultSurface(BaseCFS item__BASE_CFS)
        {
            Form formResult = default;

            formResult = MakeFormDefault(item__BASE_CFS, FormPolicy.FormDebugPolicy);

            return formResult;
        }
    }
}
