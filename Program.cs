  internal interface IEnumeration
    {
        bool MoveNext();
        object Current { get; }
        void Reset();
    }

    internal class Enumerator : IEnumeration
    {
        int counter = 1;
        public bool MoveNext() => counter-- > 0;
        public object Current => counter;
        public void Reset() => counter = 0;
        [Flags]
        public enum Border { Left, Right, Top, Bottom }

        public Border side = Border.Bottom ^ Border.Top;
    }

    public  static class Test
    {
    public static bool IsCapitalized(this string s)
    {
        return char.IsUpper(s[0]) ;
    }
    public static void ExploitTransformer()
        {
           using (StreamReader reader = File.OpenText(@"C:\Users\ndili\Desktop\playground\playground.hackerrank\designer.py")) {
                using (CustomDisposable disposable = new()) {
                    disposable.stream = reader;
                    disposable.CustomFileReader(@"C:\Users\ndili\Desktop\logs.txt");
                    disposable.Dispose();
                }
            }
        }

    static void Main(string[] args)
    {
        Console.WriteLine("Starting program");
        Console.WriteLine("tarting program".IsCapitalized());
        //ExploitTransformer();


    }
}

    public class CustomDisposable : IDisposable
    {
        public StreamReader? stream { get; set; }
       

        public void CustomFileReader(string file)
        {
            //File file;
            stream = new StreamReader(File.OpenRead(file));
            var lines = stream.ReadToEnd();
        
            Console.WriteLine(lines);
        }

        public void Dispose()
        {
            stream?.Dispose();
        }
    }
