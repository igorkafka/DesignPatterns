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

    public interface IPrinter
    {
        void Print(Document d);
    }

    public interface IScanner
    {
        void Scan(Document d);
    }

    public class PhotoCopier: IMultiFunctionDevice
    {
        private IPrinter printer;
        private IScanner scanner;
        public PhotoCopier(IPrinter printer, IScanner scanner)
        {
                this.printer = printer; 
                this.scanner = scanner;
        }

        public void Print(Document d)
        {
            printer.Print(d);
        }

        public void Scan(Document d)
        {
            scanner.Scan(d);    
        }
    }

    public interface IMultiFunctionDevice: IScanner, IPrinter
    {
        
    }

    public class MultiFunctionMachine : IMultiFunctionDevice
    {
        public void Print(Document d)
        {
            throw new NotImplementedException();
        }

        public void Scan(Document d)
        {
            throw new NotImplementedException();
        }
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
