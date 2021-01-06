using System;

namespace Stealer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Spy spy = new Spy();
            //string[] param = { "username", "password" };
            //string result1 = spy.StealFieldInfo("Stealer.Hacker", param);
            //Console.WriteLine(result1);
            //string result = spy.AnalyzeAcessModifiers("Stealer.Hacker");
            //Console.WriteLine(result);
            // string resultNew = spy.RevealPrivateMethods("Stealer.Hacker");
            // Console.WriteLine(resultNew);
            string result = spy.CollectGettersAndSetters("Stealer.Hacker");
            Console.WriteLine(result);
        }
    }
}
