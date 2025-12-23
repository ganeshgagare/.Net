namespace Demo_GenericDelegate
{
    public delegate T MyDelegate<T>();
    internal class Program
    {
        static void Main(string[] args)
        {
            SampleClass<string> sample = new SampleClass<string>();
            MyDelegate<string> del = new MyDelegate <string> (sample.SampleMethod);

            string result = del();
            Console.WriteLine(result);
        }
    }
    public class SampleClass<T>
    {
        public T SampleMethod()
        {
            Console.WriteLine("Sample Method");
            return default(T);
        }
    }
}
