using Core;

namespace Core
{
    using System;

    using System.Collections;

    using System.Collections.Generic;
    using System.Collections.ObjectModel;

    public partial class Form
    {
        public static IList<Form> FormDefaultSet(BaseCFS[] array__BASE_CFS)
        {
            ICollection<Form> collectionResult = default;

            collectionResult = new Collection<Form>();

            foreach (var item__BASE_CFS in array__BASE_CFS)
            {
                foreach (Form form in item__BASE_CFS.Measure.FormArrayList)
                {
                    collectionResult.Add(form);

                    continue;
                }

                continue;
            }

            return new List<Form>(collectionResult);
        }
    }
}
