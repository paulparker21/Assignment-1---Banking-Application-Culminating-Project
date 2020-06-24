using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1___Banking_Application_Culminating_Project
{
    class bankAccount
    {
        public string Name { get; set; }

        public string Calculate { get; set; }

        public float Sum { get; set; }

        public delegate float Comision(float comission);

    }
}

