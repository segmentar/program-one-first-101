using Core;

namespace Core
{
    using System;

    public partial class BaseCFS
    {
        public static BaseCFS[] BaseCFSDefaultSetSurface(Int32 index, String[] array_FILE, String item__WORKING_DIRECTORY)
        {
            BaseCFS[] arrayResult = default;

            var list = BaseCFSDefaultSet(array_FILE, item__WORKING_DIRECTORY);

            var array = new BaseCFS[list.Count];

            list.CopyTo(array, index);

            arrayResult = array;

            return arrayResult;
        }
    }
}
