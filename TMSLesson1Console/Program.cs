using System.Reflection;
using TMSLesson1Library;

namespace TMSLesson1Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Assembly assembly = Assembly.LoadFrom("../../../../TMSLesson1Library/bin/Debug/net8.0/TMSLesson1Library.dll");
            var type = assembly.GetType("TMSLesson1Library.StringAnalyzer");
            object o = Activator.CreateInstance(type);

            while (true)
            {
                Console.WriteLine("Введите целое число");
                string input = Console.ReadLine();
                var s = type.InvokeMember("OddOrEvenAnalyzer", BindingFlags.Default | BindingFlags.InvokeMethod, null, o, new object[] { input }, null);
                Console.WriteLine($"Ответ: {s.ToString()}");
            }




        }
    }
}
