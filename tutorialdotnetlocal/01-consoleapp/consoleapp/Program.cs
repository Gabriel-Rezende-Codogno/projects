
using System.Diagnostics;

namespace Principal;
public  static class Program

{
    public static void Main(string[] args)
    {
        if (args.Length == 0 || args == null)
        {
            Debug.WriteLine("Nao ha parametros");
        }
        else
        {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
            for (int i = 0;  i < args.Length; i++)
            {
                Debug.WriteLine(args[i]);
            }
#pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

    }

}