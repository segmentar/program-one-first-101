using Core;

namespace Core
{
    using System;

    public partial class FormBaseSequence
    {
        public FormBase Result { get; set; } = default; 

        public FormBaseSequence(BaseCFS item__BASE_CFS, Int32[] array_POSITION, Boolean debug)
        {
            Debug(item__BASE_CFS, array_POSITION, debug);

            String headerString, headerStringSafe, contentString, contentStringSafe, reflectString, reflectStringSafe;

            headerString = FormBase.ForgeHeaderString(item__BASE_CFS, array_POSITION);

            headerStringSafe = ConsoleLJS.SafeString(headerString);

            FormBaseStringFormat formBaseStringFormat;

            formBaseStringFormat = new FormBaseStringFormat();

            formBaseStringFormat.StringValue = headerString;

            formBaseStringFormat.StringValueFormat = headerString.Trim();

            var array_PERIOD = FormBase.FormBasePeriodContainerSurface<Tuple<Int32, String>>(formBaseStringFormat);

            ConsoleLJS.Log(false, $"[{headerString}] header -> <{String.Join('\n'.ToString(), (Object[])array_PERIOD)}>");

            var array_ESCAPE = FormBase.FormBaseEscapeCharacterSetSurface(array_PERIOD);

            String[] headerArray, headerArraySafe;
           
            headerArray = FormBase.ForgeHeaderArray(item__BASE_CFS, array_POSITION);

            headerArraySafe = ConsoleLJS.SafeArray(headerArray);

            contentString = FormBase.ForgeContent(item__BASE_CFS, array_POSITION);

            contentStringSafe = ConsoleLJS.SafeString(contentString);

            ReflectStringFormat reflectStringFormat;

            reflectStringFormat = new ReflectStringFormat();

            reflectStringFormat.StringValue = contentString;

            reflectStringFormat.StringValueFormat = contentString.Trim();

            ReflectModule reflectModule;

            reflectModule = ReflectModule.ReflectModuleAction(reflectStringFormat, array_ESCAPE, true);

            reflectString = String.Empty;

            reflectStringSafe = String.Empty;

            FormBase formBase;

            formBase = new FormBase(headerString, headerStringSafe, headerArray, headerArraySafe, contentString, contentStringSafe, reflectString, reflectStringSafe, debug);

            this.Result = formBase;

            return;
        }

        ~FormBaseSequence()
        {
            return;
        }
    }
}
