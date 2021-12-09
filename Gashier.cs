using System;
using System.Collections.Generic;
using System.Text;

namespace _6lab
{
    class Gashier : Employee
    {
        public override int WorkTime()
        {
            return Convert.ToInt32((DateTime.Now - DateOfEmployment).TotalDays);
        }
        public override string WhatYouDo()
        {
            return "Пополняю транспортные карты";
        }

    }
}
