using Core;

namespace Core
{
    using System;

    public partial class FormBase
    {
        public FormBase(
String headerString,
String headerStringSafe,
String[] headerArray,
String[] headerArraySafe,
String content,
String contentSafe,
String reflect,
String reflectSafe,
Boolean debug
            )
        {
            this.HeaderString = headerString;

            this.HeaderStringSafe = headerStringSafe;

            this.HeaderArray = headerArray;

            this.HeaderArraySafe = headerArraySafe;

            this.ContentString = content;

            this.ContentStringSafe = contentSafe;

            this.ReflectString = reflect;

            this.ReflectStringSafe = reflectSafe;

            if (debug is true)
            {
                this.IsDebug = true;
            }
            else
                "false".ToString();

            return;
        }
    }
}
