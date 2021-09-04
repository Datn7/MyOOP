using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOOP
{
    public interface IInterfaces
    {
        //interface contains definitions for a group of related functionalities that calss or struct can implement


        void Stay();
        void Sit();
        void Attack();
    }

    class Dog : IInterfaces
    {
        public void Attack()
        {
            throw new NotImplementedException();
        }

        public void Sit()
        {
            throw new NotImplementedException();
        }

        public void Stay()
        {
            throw new NotImplementedException();
        }
    }
}
