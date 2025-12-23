//using System.Reflection;

//namespace Demo_Refelction
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            string assemblyPath = @"C:\Users\IET\Desktop\.Net\Day6\Demo_MyMath\bin\Debug\net8.0\Demo_MyMath.dll";


//            Assembly asm = Assembly.LoadFrom(assemblyPath);
//            Type[] allTypes = asm.GetTypes();
//            for (int i = 0; i < allTypes.Length; i++)
//            {
//                Type type = allTypes[i];
//                //Console.WriteLine(type.FullName);
//                Console.WriteLine(type.Name);
//                //Console.WriteLine(type.IsAbstract.ToString());

//                MethodInfo[] allMethods = type.GetMethods();
//                for (int j = 0; j < allMethods.Length; j++)
//                {
//                    MethodInfo method = allMethods[j];
//                    Console.WriteLine($"MEthod Name= {method.Name}, Return Type = {method.ReturnType.ToString()}");

//                }
//            }
//        }
//    }
//}