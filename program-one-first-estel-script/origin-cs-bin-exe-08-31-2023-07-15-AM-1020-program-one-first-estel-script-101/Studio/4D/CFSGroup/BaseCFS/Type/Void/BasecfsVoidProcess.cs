using Core;

using Core.DimensionTwoSecond;

namespace Core
{
    using System;

    using System.IO;

    public partial class BaseCFS
    {
        public static void Process(BaseCFS item__BASE_CFS, String item__WORKING_DIRECTORY)
        {
            item__BASE_CFS.Measure.Position = item__BASE_CFS.Measure.Position - 1;

            do
            {
                item__BASE_CFS.Measure.Position = item__BASE_CFS.Measure.Position + 1;

                var boolean_safe_BREAK_should = false;

                boolean_safe_BREAK_should = boolean_safe_BREAK_should || (item__BASE_CFS.Measure.Position < 0) is true;

                boolean_safe_BREAK_should = boolean_safe_BREAK_should || (item__BASE_CFS.Measure.Position >= item__BASE_CFS.Content.Length) is true;

                Boolean shouldBreakCheck;

                shouldBreakCheck = boolean_safe_BREAK_should is true;

                if (shouldBreakCheck is true)
                {
                    break;
                }
                else
                    "false".ToString();

                Form form;

                form = Form.MakeFormDefaultSurface(item__BASE_CFS);

                Boolean isDefaultCheck, shouldContinueCheck;

                isDefaultCheck = (form == default) is true;

                shouldContinueCheck = isDefaultCheck is true;

                if (shouldContinueCheck is true)
                {
                    continue;
                }
                else
                    "false".ToString();;

                var path_NAME_file__RENDER = $"Form ({item__BASE_CFS.Measure.FormArrayList.Count})";

                var path_FILE_filename__RENDER = Path.Combine(item__WORKING_DIRECTORY, path_NAME_file__RENDER);

                var path_FILE_filename_with_extension__RENDER = Path.ChangeExtension(path_FILE_filename__RENDER, ArchitectureOneFirst.FullExtension);

                var path_NAME_file__PROOF = $"Form ({item__BASE_CFS.Measure.FormArrayList.Count}) Proof";

                var path_FILE_filename__PROOF = Path.Combine(item__WORKING_DIRECTORY, path_NAME_file__PROOF);

                var path_FILE_filename_with_extension__PROOF = Path.ChangeExtension(path_FILE_filename__PROOF, "txt");

                String renderFile, proofFile;

                renderFile = path_FILE_filename_with_extension__RENDER;

                proofFile = path_FILE_filename_with_extension__PROOF;

                form.Data.Measure.RenderFile = renderFile;

                form.Data.Measure.ProofFile = proofFile;

                item__BASE_CFS.Measure.FormArrayList.Add(form);

                continue;

            } while (true);

            return;
        }
    }
}
