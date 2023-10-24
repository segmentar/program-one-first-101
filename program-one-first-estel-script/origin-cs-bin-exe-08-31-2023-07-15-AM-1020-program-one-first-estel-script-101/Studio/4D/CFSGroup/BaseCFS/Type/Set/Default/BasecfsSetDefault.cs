using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class BaseCFS
    {
        public static IList<BaseCFS> BaseCFSDefaultSet(String[] array_FILE, String item__WORKING_DIRECTORY)
        {
            ICollection<BaseCFS> collectionResult = default;

            collectionResult = new Collection<BaseCFS>();

            foreach (var item_FILE in array_FILE)
            {
                var result = new BaseCFSSimple(item_FILE).Result;

                Process(result, item__WORKING_DIRECTORY);

                collectionResult.Add(result);

                continue;
            }

            return new List<BaseCFS>(collectionResult);
        }
    }
}
