using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    class Encapsulation
    {
        public int PublicInt { get; set; }
        protected int ProtectedInt { get; set; }
        private int PrivateInt { get; set; }
        internal int InternalInt { get; set; }
        protected internal int ProtectedInternalInt { get; set; }

    }

    class Birds : Encapsulation
    {
        Birds bird = new Birds();
        
        void FeedBird()
        {
            //access everything but not private
        }
    }

    class Cats
    {
        Encapsulation encap = new Encapsulation();

        void Encap()
        {
            //access internal and public only
        }
    }
}
