using System;


namespace PServices
{
    public static class EnumService
    {
        /// <summary>
        /// Converts a string into a value of a specified enum.
        /// </summary>
        public static T GetEnumFromString<T>(this string e) where T : struct, IConvertible, IFormattable, IComparable
        {
            if (typeof(T).IsEnum)
            {
                return (T)Enum.Parse(typeof(T), e);
            }
            throw new ArgumentException("Type provided is not an Enum");
        }
    }   
}
