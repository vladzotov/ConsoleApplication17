using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    interface IPencilsRepository
    {
        void Add(Pencil pencil);

        Pencil Get(int id);
    }
}
