using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Stealer
{
    public class Spy
    {
        public string StealFieldInfo(string nameClass, params string[] fieldsName)
        {
            StringBuilder sb = new StringBuilder();
            Type spyType = Type.GetType(nameClass);     
            sb.AppendLine($"Class under investigation: {spyType}");
            FieldInfo[] spyFields = spyType.GetFields(BindingFlags.Instance | BindingFlags.Public |
                                                      BindingFlags.NonPublic | BindingFlags.Static );
            Object spyInstance = Activator.CreateInstance(spyType, new object[] { });
            foreach (FieldInfo field in spyFields.Where(f=>fieldsName.Contains(f.Name)))
            {
                sb.AppendLine($"{field.Name} ={field.GetValue(spyInstance)}");
            }
            
            return sb.ToString();

        }
    }
}
