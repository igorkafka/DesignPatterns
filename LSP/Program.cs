using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    public class Rectangle
    {
        public virtual int Width { get; set; }
        public virtual int Height { get; set; }
        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;    
        }
        public Rectangle()
        {
            
        }
        public override string ToString()
        {
            return $"{nameof(Width)}: {Width} {nameof(Height)}: {Height}";
        }
    }
    public class Square : Rectangle 
    {
        public override int Width 
        { 
            set { base.Width = base.Height = value; } 
        }
        public override int Height
        {
            set { base.Width = base.Height = value; }
        }
    }
    internal class Program
    {
        static public int Area(Rectangle rectangle) => rectangle.Width * rectangle.Height;  
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(2,3);
            Console.WriteLine(rectangle);

            Rectangle square = new Square();
            square.Width = 4;
            square.Height = 9;
            Console.WriteLine(square);
            Console.ReadLine();
        }
    }
}
