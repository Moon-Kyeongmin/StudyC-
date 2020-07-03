using static System.Console;

/// <summary>
/// HelloApp namespace
/// </summary>
namespace HelloApp
{
    /// <summary>
    /// 기본 클래스
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            
            if (args.Length == 0)
            {
                WriteLine("HelloApp.exe name");
                return;
            }

            WriteLine($"Hello,{args[0]}");
        }
    }
}
