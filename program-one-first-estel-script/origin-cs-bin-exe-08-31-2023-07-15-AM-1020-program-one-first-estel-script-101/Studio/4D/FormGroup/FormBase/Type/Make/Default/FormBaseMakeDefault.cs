using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public static FormBase MakeFormBaseDefault(BaseCFS baseCFS, Int32[] array_POSITION, Boolean debug)
        {
            FormBase formBaseResult = default;

            var result = new FormBaseSequence(baseCFS, array_POSITION, debug).Result;

            FormBasePolicy.FormBaseArrayList.Add(result);

            formBaseResult = result;

            return formBaseResult; 
        }
    }
}
