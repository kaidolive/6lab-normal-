using System;
using System.Collections.Generic;
using System.Text;

namespace _6lab
{
    class Postman : Employee
    {
        public override string WhatYouDo()
        {
            return "Разношу почту, не мешайте";
        }
        public override int WorkTime()
        {
            return DateTime.Now.Year - DateOfEmployment.Year;
        }
    }
}
