﻿using System;
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
            Object instance=Activator.CreateInstance(spyType, new object[]{ });
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
    }
}
