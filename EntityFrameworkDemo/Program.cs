using EntityFrameworkDemo.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            var dc = new MainContext();
            dc.Makes.Add(new Make
            {
                Name = "Chevrolet",
                FactoryPhone = "+18185553343",
                Models = new List<Model>
                {
                    new Model
                    {
                        Name = "Camaro"
                    },
                    new Model
                    {
                        Name = "Corvette"
                    }
                }
            });

            dc.Makes.Add(new Make
            {
                Name = "Ford",
                FactoryPhone = "+18185553344",
                Models = new List<Model>
                {
                    new Model
                    {
                        Name = "Mustang"
                    }
                }
            });

            dc.SaveChanges();
            Console.WriteLine("Check the database");
            Console.ReadLine();
        }
    }
}
