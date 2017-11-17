using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    abstract class BasePencilRepository
    {
        protected int Size { get; } 

        public BasePencilRepository(int size)
        {
            Size = size;
        }

        public abstract void Add(Pencil pencil);

        public abstract Pencil Get(int id);

        public virtual void Print(Pencil pencil)
        {
            Console.WriteLine(pencil.ToString());
        }
    }
}
