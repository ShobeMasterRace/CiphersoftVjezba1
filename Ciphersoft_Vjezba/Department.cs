using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Ciphersoft_Vjezba
{
    public class Department : BaseModel
    {   
        //1. Baza podataka
        public string Name { get; set; }
        public string Surname { get; set; }

    }
}
