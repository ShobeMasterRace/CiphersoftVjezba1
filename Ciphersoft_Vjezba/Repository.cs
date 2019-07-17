using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciphersoft_Vjezba
{

    //GENERIČKA METODA SA <T> TYPE [ADD, EDIT, DELETE, GET, GETALL, ADDMULTIPLE]
    public class Repository<T> where T: BaseModel 
    {
        private BlogDbContext BDC;

        public Repository()
        {

            BDC = new BlogDbContext();



        }



        public List<T> GetAll()
        {
            List<T> departments = BDC.Set<T>().ToList();
            return departments;


        }

        public T Get(int id)
        {
            T department = BDC.Set<T>().FirstOrDefault(a => a.Id == id);
            return department;


        }

        public T Add(T item)
        {
            BDC.Set<T>().Add(item);
            BDC.SaveChanges();
            return item;


        }

        public List<T> AddMultiple(List<T> departments)
        {
            for (int i = 0; i < departments.Count; i++)
            {
                BDC.Set<T>().Add(departments[i]);
                BDC.SaveChanges();


            }

            return departments;

        }

        public T Edit(T item)
        {
            BDC.Attach(item).State = EntityState.Modified;
            BDC.SaveChanges();
            return item;
        }

        public void Delete(int id)
        {

            T item = BDC.Set<T>().FirstOrDefault(a => a.Id == id);
            BDC.Set<T>().Remove(item);
            BDC.SaveChanges();

        }



    }
}
