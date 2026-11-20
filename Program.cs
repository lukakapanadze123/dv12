namespace dv12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");




            //1. სტუდენტი
            Student student1 = new("saxeli1", "gvari1", 20, 85);
            Student student2 = new("saxeli2", "gvari2", 22, 70);
            Student student3 = new("saxeli3", "gvari3", 19, 95);
            Student student4 = new("saxeli1", "gvari1", 20, 85);
            Student student5 = new("saxeli5", "gvari5", 21, 60);

            Student[] students = { student1, student2, student3, student4, student5 };
            Array.Sort(students);

            foreach (var item in students)
            {
                Console.WriteLine(item.Name + " " + item.Surname + " " + item.Age + " " + item.Sore);
            }

            foreach (var item in students)
            {
                int count = 0;
                foreach (var item1 in students)
                {
                    if (item.Equals(item1))
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine("meordeba " + item.Name + " " + item.Surname + " " + item.Age + " " + item.Sore);
                }
            }


            //2. ფილმი
            Movie movie1 = new("filmi1", 2010);
            Movie movie2 = new("filmi2", 1999);
            Movie movie3 = new("filmi3", 2021);
            Movie movie4 = new("filmi2", 1999);
            Movie movie5 = new("filmi5", 2005);

            Movie[] movies = { movie1, movie2, movie3, movie4, movie5 };
            Array.Sort(movies);

            foreach (var item in movies)
            {
                Console.WriteLine(item.Name + " " + item.Year);
            }

            foreach (var item in movies)
            {
                int count = 0;
                foreach (var item1 in movies)
                {
                    if (item.Equals(item1))
                    {
                        count++;
                    }
                }
                if (count > 1)
                {
                    Console.WriteLine("meordeba " + item.Name + " " + item.Year);
                }
            }



































        }
    }
}
