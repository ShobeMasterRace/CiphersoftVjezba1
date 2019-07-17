using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Ciphersoft_Vjezba
{
    

    class Program
    {

        static void Main(string[] args)
        {
            Repository<Department> DepartmentRepository = new Repository<Department>();
            List<Department> Dep = DepartmentRepository.GetAll();

            for (int i = 0; i < Dep.Count; i++)
            {
                Console.WriteLine(Dep[i].Id + " " + Dep[i].Name + " " + Dep[i].Surname);




            }

            


        }

       

    }
}
