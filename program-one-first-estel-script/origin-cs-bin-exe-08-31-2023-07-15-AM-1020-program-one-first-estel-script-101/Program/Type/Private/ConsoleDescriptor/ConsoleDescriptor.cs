using Core;

using Core.DimensionTwoSecond;

using Core.DimensionTwoSecond.ConsoleLJ;

namespace Core
{
    using System;

    internal partial class Program
    {

        [IntentionalShortMethod]
        private String ConsoleDescriptor()
        {
            Specialize.GetFullExtension(true);

            return String.Join('\n'.ToString(), new String[] {

                String.Empty,
                String.Empty + '\t' + $"This is `{ImmutableConsoleLJZeroTen.ProgramName}`" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + "Refer to the DSNMG in Studio/1D for more information" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + "Enter name and value to modify variable" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + "Enter `escape` to run and exit" + ' ' + '.',
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "ordinal-1" + ' ' + '*' + "endian-unsigned-integer-bit-128" + ' ' + "signature" + '^' + ' ' + nameof(ArchitectureTwoSecond.Signature) + ':' + ' ' + ArchitectureTwoSecond.Signature,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "ordinal-2" + ' ' + '*' + "endian-unsigned-integer-bit-8" + ' ' + "endian-format" + '^' + ' ' + nameof(ArchitectureTwoSecond.EndianFormat) + ':' + ' ' + ArchitectureTwoSecond.EndianFormat,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "ordinal-3" + ' ' + '*' + "endian-unsigned-integer-bit-8" + ' ' + "reserved-flag" + '^' + ' ' + nameof(ArchitectureTwoSecond.ReservedFlag) + ':' + ' ' + ArchitectureTwoSecond.ReservedFlag,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "ordinal-4" + ' ' + '*' + "endian-unsigned-integer-bit-32" + ' ' + "string-codec" + '^' + ' ' + nameof(ArchitectureTwoSecond.StringCodec) + ':' + ' ' + ArchitectureTwoSecond.StringCodec + ' ' + $"<{ArchitectureTwoSecond.StringCodec.CodePage}>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "ordinal-5" + ' ' + '*' + "endian-unsigned-integer-bit-16" + ' ' + "chunk-size" + '^' + ' ' + nameof(ArchitectureTwoSecond.ChunkSize) + ':' + ' ' + ArchitectureTwoSecond.ChunkSize,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "ordinal-6" + ' ' + '*' + "endian-unsigned-integer-bit-32" + ' ' + "start-boundary" + '^' + ' ' + nameof(ArchitectureTwoSecond.StartBoundary) + ':' + ' ' + ArchitectureTwoSecond.StartBoundary,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "ordinal-7" + ' ' + '*' + "endian-unsigned-integer-bit-32" + ' ' + "header-address" + '^' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "ordinal-8" + ' ' + '*' + "endian-unsigned-integer-bit-32" + ' ' + "content-address" + '^' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "ordinal-9" + ' ' + '*' + "endian-unsigned-integer-bit-32" + ' ' + "local-line-array-address" + '^' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "ordinal-10" + ' ' + '*' + "endian-unsigned-integer-bit-32" + ' ' + "global-line-array-address" + '^' + ' ' + "<automatic>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + "ordinal-11" + ' ' + '*' + "edinan-unsigned-integer" + ' ' + nameof(ArchitectureTwoSecond.Description) + ':' + ' ' + ArchitectureTwoSecond.Description,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitectureOneFirst.ReaderEncoding) + ':' + ' ' + ArchitectureOneFirst.ReaderEncoding + ' ' + $"<{ArchitectureOneFirst.ReaderEncoding.CodePage}>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitectureOneFirst.WriterEncoding) + ':' + ' ' + ArchitectureOneFirst.WriterEncoding + ' ' + $"<{ArchitectureOneFirst.WriterEncoding.CodePage}>",
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitectureOneFirst.ExtensionName) + ':' + ' ' + ArchitectureOneFirst.ExtensionName,
                String.Empty,
                String.Empty + '\t' + '~' + ' ' + nameof(ArchitectureOneFirst.FullExtension) + ':' + ' ' + ArchitectureOneFirst.FullExtension,
                String.Empty,
                String.Empty + '\t' + "Prompt" + ':' + ' ',
                String.Empty
            });
        }
    }
}
