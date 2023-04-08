using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
     class Counter1
    {
        public delegate void MethodContainer();
        public event MethodContainer OnCount;
        public void Count()
        {
            for (int i = 0; i < 100; i++)
            {
                if(i== 77)
                { 
                    if (OnCount != null)
                    {
                        OnCount();
                    }   
                }
            }
        }
    }
}
