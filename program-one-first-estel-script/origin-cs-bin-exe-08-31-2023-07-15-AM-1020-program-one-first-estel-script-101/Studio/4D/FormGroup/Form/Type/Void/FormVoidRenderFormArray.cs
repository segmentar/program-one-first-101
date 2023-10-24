using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    public partial class Form
    {
        public static void FormRenderFormArrayVoid(Form[] array_FORM)
        {
            foreach (var item_FORM in array_FORM)
            {
                item_FORM.Render();

                var flag_PROOF_has = 0b00000001;

                Boolean hasProofCheck;

                hasProofCheck = (flag_PROOF_has & ArchitectureTwoSecond.ReservedFlag).Equals(flag_PROOF_has);

                if (hasProofCheck is true)
                {
                    item_FORM.Proof();
                }
                else
                    "false".ToString();

                continue;
            }

            return;
        }
    }
}
