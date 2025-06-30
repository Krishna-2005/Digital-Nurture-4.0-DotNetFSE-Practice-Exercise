using System;

namespace FactoryMethodPattern.Documents
{
    public class WordDocument : Document
    {
        public void Open()
        {
            Console.WriteLine("Opening Word Document.");
        }
    }
}
