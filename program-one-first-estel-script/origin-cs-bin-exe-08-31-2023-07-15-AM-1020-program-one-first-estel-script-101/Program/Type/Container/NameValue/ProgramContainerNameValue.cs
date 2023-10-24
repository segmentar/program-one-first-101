using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.Collections;

    internal partial class Program
    {
        internal static ArrayList ProgramNameValueContainer()
        {
            ArrayList listResult = default;

            var list = new ArrayList();

            list.Add(new Tuple<String, Object>(nameof(ArchitectureOneFirst.ReaderEncoding), ArchitectureOneFirst.ReaderEncoding));

            list.Add(new Tuple<String, Object>(nameof(ArchitectureOneFirst.WriterEncoding), ArchitectureOneFirst.WriterEncoding));

            list.Add(new Tuple<String, Object>(nameof(ArchitectureOneFirst.ExtensionName), ArchitectureOneFirst.ExtensionName));

            list.Add(new Tuple<String, Object>(nameof(ArchitectureOneFirst.FullExtension), ArchitectureOneFirst.FullExtension));

            list.Add(new Tuple<String, Object>(nameof(ArchitectureTwoSecond.Signature), ArchitectureTwoSecond.Signature));

            list.Add(new Tuple<String, Object>(nameof(ArchitectureTwoSecond.EndianFormat), ArchitectureTwoSecond.EndianFormat));

            list.Add(new Tuple<String, Object>(nameof(ArchitectureTwoSecond.ReservedFlag), ArchitectureTwoSecond.ReservedFlag));

            list.Add(new Tuple<String, Object>(nameof(ArchitectureTwoSecond.StringCodec), ArchitectureTwoSecond.StringCodec));

            list.Add(new Tuple<String, Object>(nameof(ArchitectureTwoSecond.ChunkSize), ArchitectureTwoSecond.ChunkSize));

            list.Add(new Tuple<String, Object>(nameof(ArchitectureTwoSecond.StartBoundary), ArchitectureTwoSecond.StartBoundary));

            list.Add(new Tuple<String, Object>(nameof(ArchitectureTwoSecond.Description), ArchitectureTwoSecond.Description));

            listResult = list;

            return listResult;
        }
    }
}