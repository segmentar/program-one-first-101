using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public void Proof()
        {
            Boolean shouldReturnCheck;

            shouldReturnCheck = (Data.Measure.ProofFile == default) is true;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            var entry__FORM_HEADER = FormReadHeaderProofZeroTen();

            var entry__FORM_ADDRESS = FormReadAddressProofZeroTen();

            var entry__FORM_BODY = FormReadBodyProofZeroTen();

            FormWriteProofZeroTen(entry__FORM_HEADER, entry__FORM_ADDRESS, entry__FORM_BODY);

            return;
        }
    }
}
