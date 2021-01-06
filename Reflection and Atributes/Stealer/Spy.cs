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
                sb.AppendLine($"{field.Name} = {field.GetValue(spyInstance)}");
            }
            
            return sb.ToString();

        }

        public string AnalyzeAcessModifiers(string className)
        {
            StringBuilder sb = new StringBuilder();
            Type spyType = Type.GetType(className);
            FieldInfo[] spyFields = spyType.GetFields(BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static);
            foreach (FieldInfo field in spyFields)
            {
                sb.AppendLine($"{field.Name} must be private!");
            }
            MethodInfo[] getMethods = spyType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            foreach (MethodInfo method in getMethods.Where(m=> m.Name.StartsWith("get")))
            {
                sb.AppendLine($"{method.Name} have to be public!");
            }
            MethodInfo[] setMethods = spyType.GetMethods(BindingFlags.Instance | BindingFlags.Public);
            foreach (MethodInfo method in setMethods.Where(m => m.Name.StartsWith("set")))
            {
                sb.AppendLine($"{method.Name} have to be private!");
            }
            return sb.ToString();
        }

        public string RevealPrivateMethods(string className)
        {
            StringBuilder result = new StringBuilder();
            Type spyClass = Type.GetType(className);
            MethodInfo[] privateMethods = spyClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);
            result.AppendLine($"All Private Methods of Class: {className}");
            result.AppendLine($"Base Class: {GetType().BaseType.Name}");
            foreach (MethodInfo method in privateMethods)
            {
                result.AppendLine(method.Name);
            }
            return result.ToString();
        }

        public string CollectGettersAndSetters(string className)
        {
            StringBuilder result = new StringBuilder();
            Type spyClass = Type.GetType(className);
            MethodInfo[] AllMethods = spyClass.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | 
                                                          BindingFlags.Static | BindingFlags.Public);
            foreach (MethodInfo method in AllMethods.Where(m=> m.Name.Contains("get")))
            {
                result.AppendLine($"{method.Name} will return {method.ReturnType}");
            }
            foreach (MethodInfo method in AllMethods.Where(m=>m.Name.Contains("set")))
            {
                result.AppendLine($"{method.Name} will set field of {method.GetParameters()}");
            }
            return result.ToString();
        }
    }
}
