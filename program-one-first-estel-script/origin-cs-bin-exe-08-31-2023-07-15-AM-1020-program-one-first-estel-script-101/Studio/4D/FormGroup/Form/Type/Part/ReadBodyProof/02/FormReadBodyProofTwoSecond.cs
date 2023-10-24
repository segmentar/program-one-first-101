using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.IO;

    public partial class Form
    {
        private FormBody FormReadBodyProofTwoSecond(FileStream item__FILE_STREAM, BinaryReader item__BINARY_READER)
        {
            FormBody formBodyResult = default;

            UInt32 headerLength, localLineLength, globalLineLength;

            String[] headerArray, localLineArray, globalLineArray;

            String content;

            item__BINARY_READER.BaseStream.Seek(ArchitectureTwoSecond.StartBoundary, SeekOrigin.Begin);

            headerLength = item__BINARY_READER.ReadUInt32();

            item__BINARY_READER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

            headerArray = new String[headerLength];

            goto section_HEADER;

            section_HEADER:
            {
                var indexer = 0;

                do
                {
                    Boolean shouldBreakCheck;

                    shouldBreakCheck = (indexer == headerLength) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    String stringItem;

                    stringItem = item__BINARY_READER.ReadString();

                    item__BINARY_READER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

                    headerArray[indexer] = stringItem;

                    indexer = indexer + 1;

                    continue;

                } while (true);
            }

            content = item__BINARY_READER.ReadString();

            item__BINARY_READER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

            localLineLength = item__BINARY_READER.ReadUInt32();

            item__BINARY_READER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

            localLineArray = new String[localLineLength];

            goto section__LOCAL_LINE;

            section__LOCAL_LINE:
            {
                var indexer = 0;

                do
                {
                    Boolean shouldBreakCheck;

                    shouldBreakCheck = (indexer == localLineLength) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    String stringItem;

                    stringItem = item__BINARY_READER.ReadString();

                    item__BINARY_READER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

                    localLineArray[indexer] = stringItem;

                    indexer = indexer + 1;

                    continue;

                } while (true);
            }

            globalLineLength = item__BINARY_READER.ReadUInt32();

            item__BINARY_READER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

            globalLineArray = new String[globalLineLength];

            goto section__GLOBAL_LINE;

            section__GLOBAL_LINE:
            {
                var indexer = 0;

                do
                {
                    Boolean shouldBreakCheck;

                    shouldBreakCheck = (indexer == globalLineLength) is true;

                    if (shouldBreakCheck is true)
                    {
                        break;
                    }
                    else
                        "false".ToString();

                    String stringItem;

                    stringItem = item__BINARY_READER.ReadString();

                    item__BINARY_READER.BaseStream.Seek(ArchitectureTwoSecond.ChunkSize, SeekOrigin.Current);

                    globalLineArray[indexer] = stringItem;

                    indexer = indexer + 1;

                    continue;

                } while (true);
            }

            formBodyResult = FormReadBodyProofThreeThird(item__FILE_STREAM, item__BINARY_READER, headerLength, headerArray, content, localLineLength, localLineArray, globalLineLength, globalLineArray);

            return formBodyResult;
        }
    }
}
