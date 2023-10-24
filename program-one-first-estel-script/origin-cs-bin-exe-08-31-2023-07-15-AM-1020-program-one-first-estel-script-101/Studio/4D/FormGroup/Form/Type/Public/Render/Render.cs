using Core;

namespace Core
{
    using System;

    public partial class Form
    {
        public void Render()
        {
            Expression expression;

            expression = Expression.MakeExpressionRoot();

            expression.InstructionHandler(Data.Runtime.FormLine.LocalLineArray);

            Expression.SaveToCurrentDirectory("sample", expression);

            Expression loadedExpression;

            loadedExpression = Expression.LoadFromCurrentDirectory("sample");

            var array = Contribute.ContributeDefaultSetSurface(Data.Runtime.FormLine.GlobalLineArray);

            Contribute.Include(array);

            Contribute.SaveToCurrentDirectory("example");

            FormWriteFileZeroTen();

            return;
        }
    }
}
