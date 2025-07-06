using FactoryMethodPattern.Documents;

namespace FactoryMethodPattern.Factories
{
    public class ExcelDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new ExcelDocument();
        }
    }
}
