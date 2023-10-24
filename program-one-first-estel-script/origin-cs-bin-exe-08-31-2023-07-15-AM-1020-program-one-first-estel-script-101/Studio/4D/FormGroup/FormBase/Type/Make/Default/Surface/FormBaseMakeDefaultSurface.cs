using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public static FormBase MakeFormBaseDefaultSurface(BaseCFS item__BASE_CFS, Int32[] positionArray)
        {
            FormBase formBaseResult = default;

            formBaseResult = MakeFormBaseDefault(item__BASE_CFS, positionArray, FormBasePolicy.FormBaseDebugPolicy);

            return formBaseResult; 
        }
    }
}
