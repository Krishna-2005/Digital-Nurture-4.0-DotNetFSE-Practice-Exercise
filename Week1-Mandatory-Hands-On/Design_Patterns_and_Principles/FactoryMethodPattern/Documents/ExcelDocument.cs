using System;

namespace FactoryMethodPattern.Documents
{
    public class ExcelDocument : Document
    {
        public void Open()
        {
            Console.WriteLine("Opening Excel Document.");
        }
    }
}
