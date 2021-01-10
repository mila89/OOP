using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Linq;
using System.Collections;

namespace ValidationAttributes
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            foreach (PropertyInfo prop in properties)
            {
                IEnumerable<MyValidationAttribute> propertyCustomAttrinutes = prop.GetCustomAttributes<MyValidationAttribute>();                      
                foreach (MyValidationAttribute attribute in propertyCustomAttrinutes)
                {
                    return attribute.IsValid(prop.GetValue(obj));
                }
            }
            
            return obj !=null;
        }
    }
}
