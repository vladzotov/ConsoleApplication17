using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication17
{
    class PencilsRepository : BasePencilRepository
    {
        private Pencil[] _pencils;
        private int _lastIndex;

        public PencilsRepository(int size)
            :base(size)
        {
            _lastIndex = 0;
            _pencils = new Pencil[size];
        }

        public Pencil this[int index]
        {
            get { return _pencils[index]; }
            set { _pencils[index] = value; }
        }

        public override void Add(Pencil pencil)
        {
            _pencils[_lastIndex++] = pencil;
        }

        public override Pencil Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
