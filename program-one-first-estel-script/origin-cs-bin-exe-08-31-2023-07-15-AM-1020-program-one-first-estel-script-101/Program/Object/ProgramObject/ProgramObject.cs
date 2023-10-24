using Core;

namespace Core
{
    using System;

    internal partial class Program
    {

        [IntentionalShortMethod]
        public override String ToString()
        {
            return Data.ToString();
        }
    }
}
