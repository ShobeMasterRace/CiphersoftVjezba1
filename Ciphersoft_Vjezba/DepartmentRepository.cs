using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ciphersoft_Vjezba
{

    //Generička metoda bez <T> type [ADD, EDIT, DELETE, GET, GETALL, ADDMULTIPLE]
    public class DepartmentRepository
    {
        private BlogDbContext BDC; //private jer sadrži liste baze podataka i connection string

        public DepartmentRepository()
        {

            BDC = new BlogDbContext();



        }

        

        public List<Department> GetAll()
        {
            List<Department> departments = BDC.Lista.ToList();
            return departments;


        }

        public Department Get(int id) //dohvaćamo ID
        {
            Department department = BDC.Lista.FirstOrDefault(a => a.Id == id);
            return department; //vraćamo sadržaj tog ID-a (tipa Ime, prezime, itd.)


        }

        public Department Add(Department item) //dohvaćamo objekat iz baze
        {
            BDC.Lista.Add(item);
            BDC.SaveChanges();
            return item; //s obzirom da se zna o kojoj se postavi radi, ne trebamo posebno pisat za svaki objekat (tipa Ime, Prezime) vraćamo novi objekat unutar baze


        }

        public List<Department> AddMultiple(List<Department> departments) //dohvaćamo listu objekata
        {
            for (int i = 0; i < departments.Count; i++)
            {
                BDC.Lista.Add(departments[i]);
                BDC.SaveChanges();
                

            }

            return departments; //vraćamo novu listu objekata unutar baze

        }

        public Department Edit(Department item) //dohvaćamo objekat iz baze
        {            
            BDC.Attach(item).State = EntityState.Modified;
            BDC.SaveChanges();
            return item; //vraćamo objekat u bazu izmjenjen
        }

        public void Delete(int id) //dohvaćamo ID
        {
            
            Department item = BDC.Lista.FirstOrDefault(a => a.Id == id);
            BDC.Lista.Remove(item);
            BDC.SaveChanges(); //brišemo tog user-a pod odabranim ID-om

        }
    }
}
