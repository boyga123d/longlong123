using System;
using System.Collections.Generic;
using _04_generic_example.Model;
using _04_generic_example.Repository;

namespace _04_generic_example
{
    class Program
    {
        private static List<Student> s_students = new List<Student>();
        private static List<Class> s_classes = new List<Class>();
        static void Main(string[] args)
        {

            IRepository<Student> hocsinh = new BaseRepository<Student>(s_students);
            IRepository<Class> lophoc = new BaseRepository<Class>(s_classes);


            lophoc.Add(new Class("18DTHQA1"));
            lophoc.Add(new Class("18DTHQA2"));
            hocsinh.Add(new Student("Vua Lỳ Đòn", 11));
            hocsinh.Add(new Student("Ngô Văn Dậu", 22));
            hocsinh.Add(new Student("Con cò bé bé", 33));
            hocsinh.Add(new Student("Nó đậu cành tre", 44));

             Console.WriteLine("List all classes:");
            foreach (var st in lophoc.GetAll())
            {
               Console.WriteLine(st.Name);
            }

            Console.WriteLine("List all classes:");

            foreach (var cl in hocsinh.GetAll())
            {
                Console.WriteLine(cl.Name);
            }
           
        }
    }
}
