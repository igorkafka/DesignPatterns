using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Document
    {


    }
    public interface IMachine
    {
        void Print(Document document);
        void Scan(Document document);
        void Fax(Document document);    
    }

    public class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document document)
        {

        }

        public void Print(Document document)
        {
        }

        public void Scan(Document document)
        {
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
