namespace ICPCAssiut01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region A/ Given a name S. Print "Hello, (name)" without parentheses. Input Only one line containing a string S.  OutputPrint "Hello, " without quotes, then print name.

            Console.WriteLine("Enter Your Name");
            string S = Console.ReadLine()!;

            string Name = S.Insert(0, "Hello, ");

            Console.WriteLine(Name);

            #endregion

        }

    }
}
