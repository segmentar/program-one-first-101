using Core;

namespace Core
{
    using System;

    internal partial class Program
    {
        public static void ProgramNameValueVoid(String name, String value)
        {
            String reflectString;

            reflectString = value;

            var reflect__SIGNED_INTEGER_BIT_32 = default(Int32);

            var reflect__SIGNED_INTEGER_BIT_16 = default(Int16);

            var reflect__UNSIGNED_INTEGER_BIT_32 = default(UInt32);

            var reflect__UNSIGNED_INTEGER_BIT_16 = default(UInt16);

            var reflect_CHARACTER = default(Char);

            var reflect_BOOLEAN = default(Boolean);

            var reflect_BYTE = default(Byte);

            try
            {
                reflect__SIGNED_INTEGER_BIT_32 = Int32.Parse(value);
            }
            catch (Exception exception)
            {
                exception.ToString();
            }

            try
            {
                reflect__SIGNED_INTEGER_BIT_16 = Int16.Parse(value);
            }
            catch (Exception exception)
            {
                exception.ToString();
            }

            try
            {
                reflect__UNSIGNED_INTEGER_BIT_32 = UInt32.Parse(value);
            }
            catch (Exception exception)
            {
                exception.ToString();
            }

            try
            {
                reflect__UNSIGNED_INTEGER_BIT_16 = UInt16.Parse(value);
            }
            catch (Exception exception)
            {
                exception.ToString();
            }

            try
            {
                var oth = reflectString[0];

                reflect_CHARACTER = oth;
            }
            catch (Exception exception)
            {
                exception.ToString();
            }

            try
            {
                reflect_BOOLEAN = Boolean.Parse(value);
            }
            catch (Exception exception)
            {
                exception.ToString();
            }
            
            try
            {
                reflect_BYTE = Byte.Parse(value);
            }
            catch (Exception exception)
            {
                exception.ToString();
            }

            ProgramNameValueVoidOneFirst(
name,
value,
reflectString,
reflect__SIGNED_INTEGER_BIT_32,
reflect__SIGNED_INTEGER_BIT_16,
reflect__UNSIGNED_INTEGER_BIT_32,
reflect__UNSIGNED_INTEGER_BIT_16,
reflect_CHARACTER,
reflect_BOOLEAN,
reflect_BYTE
                );

            return;
        }
    }
}
