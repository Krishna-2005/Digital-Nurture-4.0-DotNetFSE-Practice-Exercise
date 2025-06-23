using FactoryMethodPattern.Documents;

namespace FactoryMethodPattern.Factories
{
    public class WordDocumentFactory : DocumentFactory
    {
        public override Document CreateDocument()
        {
            return new WordDocument();
        }
    }
}
