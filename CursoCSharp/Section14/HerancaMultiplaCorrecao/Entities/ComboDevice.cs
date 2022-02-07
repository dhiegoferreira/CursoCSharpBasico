



namespace CursoCSharp.Section14.HerancaMultiplaCorrecao.Entities
{
    internal class ComboDevice : Device, IScanner,
    {

        public override void PocessDoc(string document)
        {
            System.Console.WriteLine("Processing document: " + document);
        }

        public string Scan()
        {
            return "sccaner string";
        }

        public void Print(string document)
        {

            System.Console.WriteLine("Printer document: " + document);
        }


    }
}
