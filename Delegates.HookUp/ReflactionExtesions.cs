using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Delegates.HookUp
{
    public static class ReflactionExtesions
    {
        public static TValue GetValue<TValue>(this object obj, string declaredFieldName)
        {
            var declaredField = ((TypeInfo)obj.GetType()).DeclaredFields.FirstOrDefault(d => d.Name == declaredFieldName);
            if (declaredField == null) throw new KeyNotFoundException($"Field {declaredFieldName} was not found.");
            return (TValue)declaredField.GetValue(obj);
        }

        public static TValue GetValue<TValue>(this object obj)
        {
            var type = typeof(TValue);

            var declaredField = ((TypeInfo)obj.GetType()).DeclaredFields.FirstOrDefault(d => d.FieldType == type);
            if (declaredField == null) throw new KeyNotFoundException($"Type {type.Name} was not found.");
            return (TValue)declaredField.GetValue(obj);
        }
    }
}
