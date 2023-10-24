using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    public partial class Specialize
    {
        public static String GetFullExtension(Boolean answer_UPDATE_should)
        {
            String stringResult = default;

            var descriptor = new String[] {

                ArchitectureOneFirst.ExtensionName,
                ArchitectureTwoSecond.StringCodec.CodePage.ToString(),
                ArchitectureTwoSecond.ChunkSize.ToString(),
                ArchitectureTwoSecond.StartBoundary.ToString()
            };

            var underscore = Convert.ToChar(95);

            var join = String.Join(underscore.ToString(), descriptor);

            var result = join;

            if (answer_UPDATE_should is true)
            {
                String fullExtension;

                fullExtension = result;

                ArchitectureOneFirst.FullExtension = fullExtension;
            }
            else
                "false".ToString();

            stringResult = result;

            return stringResult;
        }
    }
}
