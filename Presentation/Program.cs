using System;

namespace Presentation
{
    //https://www.codeproject.com/Tips/1157736/Unity-Dependency-Injection-with-N-Layer-Project
    public class Program
    {
        static void Main()
        {
            Bootstrapper.Init();
            var initiator = DependencyInjector.Retrieve<Initiator>();
            var data = initiator.FetchData();
            Console.WriteLine(data);
            Console.ReadLine();
        }
    }
}
