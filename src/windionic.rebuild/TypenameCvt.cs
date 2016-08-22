using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace windionic.rebuild
{
    internal class TypenameCvt
    {
        private static string _GetJsTypename(Type type)
        {
            if (type == typeof(int) ||
                type == typeof(float) ||
                type == typeof(short) ||
                type == typeof(double))
                return "number";

            if (type == typeof(string))
                return "string";
            if (type == typeof(void))
                return "void";
            if (type == typeof(bool))
                return "boolean";

            return "any";
        }
        public static string GetJsTypename(Type type)
        {
            var innerType = type;
            if (type.IsArray)
                innerType = type.GetElementType();

            var innerTypeName = _GetJsTypename(innerType);

            if (type.IsArray)
                return innerTypeName + "[]";
            else
                return innerTypeName;
        }
    }
}
