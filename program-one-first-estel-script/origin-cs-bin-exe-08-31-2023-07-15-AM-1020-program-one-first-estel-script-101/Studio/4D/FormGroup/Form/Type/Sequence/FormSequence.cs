using Core;

namespace Core
{
    using System;

    public partial class FormSequence
    {
        public Form Result { get; set; } = default;

        public FormSequence(BaseCFS item__BASE_CFS, Boolean answer_DEBUG_is)
        {
            Debug(item__BASE_CFS, answer_DEBUG_is);

            FormMeasure measure;

            measure = new FormMeasure();

            measure.PositionArray = new Int32[2];

            var comma = Convert.ToChar(44);

            var period = Convert.ToChar(46);

            var concat = new String(period, 5);

            measure.PositionArray[0] = item__BASE_CFS.Content.IndexOf(comma.ToString(), item__BASE_CFS.Measure.Position);

            measure.PositionArray[1] = item__BASE_CFS.Content.IndexOf(concat.ToString(), item__BASE_CFS.Measure.Position);

            var boolean_safe_RETURN_should = true;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should && (measure.PositionArray[0] < 0) is false;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should && (measure.PositionArray[1] < 0) is false;
            
            boolean_safe_RETURN_should = boolean_safe_RETURN_should && (measure.PositionArray[0] < measure.PositionArray[1]) is true;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should && (measure.PositionArray[1] > measure.PositionArray[0]) is true;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should && (item__BASE_CFS.Measure.Position < measure.PositionArray[0]) is true;

            boolean_safe_RETURN_should = boolean_safe_RETURN_should && (item__BASE_CFS.Measure.Position < measure.PositionArray[1]) is true;

            Boolean shouldReturnCheck;

            shouldReturnCheck = boolean_safe_RETURN_should is false;

            if (shouldReturnCheck is true)
            {
                return;
            }
            else
                "false".ToString();

            FormBase formBase;

            formBase = FormBase.MakeFormBaseDefaultSurface(item__BASE_CFS, measure.PositionArray);

            FormLine formLine;

            formLine = FormLine.MakeFormLineDefaultSurface(formBase.ContentString);

            FormRuntime runtime;

            runtime = new FormRuntime();

            runtime.FormBase = formBase;

            runtime.FormLine = formLine;
            
            item__BASE_CFS.Measure.Position = (measure.PositionArray[1] + concat.Length);

            item__BASE_CFS.Measure.Position = item__BASE_CFS.Measure.Position - 1;

            Form form;

            form = new Form(measure, runtime, item__BASE_CFS, answer_DEBUG_is);

            this.Result = form;

            return;
        }

        ~FormSequence()
        {
            return;
        }
    }
}
