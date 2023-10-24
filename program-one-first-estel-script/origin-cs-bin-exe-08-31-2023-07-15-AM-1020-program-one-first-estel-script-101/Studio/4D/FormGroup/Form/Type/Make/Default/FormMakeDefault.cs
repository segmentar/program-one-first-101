using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public static Form MakeFormDefault(BaseCFS item__BASE_CFS, Boolean answer_DEBUG_is)
        {
            Form formResult = default;

            var result = new FormSequence(item__BASE_CFS, answer_DEBUG_is).Result;

            FormPolicy.FormArrayList.Add(result);

            formResult = result;

            return formResult;
        }
    }
}
