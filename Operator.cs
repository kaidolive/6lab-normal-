using System;
using System.Collections.Generic;
using System.Text;

namespace _6lab
{
    class Operator : Employee
    {
        public override string WhatYouDo()
        {
            return "Ищу посылку";
        }
        public override int WorkTime()
        {
            return (DateTime.Now.Year - DateOfEmployment.Year) * 12 + DateTime.Now.Month - DateOfEmployment.Month +
                   (DateTime.Now.Day >= DateOfEmployment.Day ? 0 : -1);
        }
    }
}
