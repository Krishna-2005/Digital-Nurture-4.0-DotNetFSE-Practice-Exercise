using FactoryMethodPattern.Documents;

namespace FactoryMethodPattern.Factories
{
    public class PdfDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new PdfDocument();
        }
    }
}
