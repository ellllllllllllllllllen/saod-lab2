using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab2
{
    class Program
    {
        struct WORKER
        {
            public string name;
            public string position;
            public int year;

            public WORKER(string name, string position, int year)
            {
                this.name = name;
                this.position = position;
                this.year = year;

            }
        }

        static void Main(string[] args)
        {
            WORKER w1 = new WORKER("Zavadskaya E.V.     ", "Student             ", 2018 );
            WORKER w2 = new WORKER("Ivanov I.I.         ", "Designer            ", 2017 );
            WORKER w3 = new WORKER("Tarasevich A.S.     ", "Student             ", 2016 );
            WORKER w4 = new WORKER("Suchozkaja E.A.     ", "Student             ", 2016 );
            WORKER w5 = new WORKER("Kruglic K.S.        ", "Student             ", 2016 );
            WORKER w6 = new WORKER("Dementey A.A.       ", "Doctor              ", 2009 );
            WORKER w7 = new WORKER("Racovski V.I.       ", "Cleaner             ", 2010 );
            WORKER w8 = new WORKER("Gitsarev V.A.       ", "Programmer          ", 2014 );
            WORKER w9 = new WORKER("Marchuc D.A.        ", "Teacher             ", 2015 );
            WORKER w10 = new WORKER("Klitsunova K.S.     ", "Bartender           ", 2017 );
            
            WORKER[] massiv = new WORKER[10] { w1, w2, w3, w4, w5, w6, w7, w8, w9, w10 };
            using (Stream stream = new FileStream("worker.txt", FileMode.OpenOrCreate))
            {
                StreamWriter writer = new StreamWriter(stream, System.Text.Encoding.Default);
                for (int i = 0; i < 10; i++)
                {
                    
                    writer.Write(massiv[i].name);
                    writer.Write(massiv[i].position);
                    writer.WriteLine(massiv[i].year);
                }

                writer.Flush();
                writer.Close();

            }

            for (int i = 0; i < massiv.Length; i++)
            {
                bool f = false;
                for (int j = 0; j < massiv.Length - 1; j++)
                {
                    if (massiv[j].year > massiv[j + 1].year)
                    {
                        f = true;
                        int temp = massiv[j].year;
                        massiv[j].year = massiv[j + 1].year;
                        massiv[j + 1].year = temp;

                    }

                }
                if (!f) break;
            }
            for (int i = 0; i < massiv.Length; i++)
            {
                Console.WriteLine(massiv[i].year);
                
            }
            using (Stream stream = new FileStream("worker1.txt", FileMode.OpenOrCreate))
            {
                StreamWriter writer = new StreamWriter(stream, System.Text.Encoding.Default);
                for (int i = 0; i < 10; i++)
                {
                    
                    writer.Write(massiv[i].name);
                    writer.Write(massiv[i].position);
                    writer.WriteLine(massiv[i].year);
                }

                writer.Flush();
                writer.Close();

            }

            Console.WriteLine("Input the position: ");
            string position = Console.ReadLine();
            for (int i = 0; i < massiv.Length; i++)
            {
                
                if (massiv[i].position.Contains(position))
                {
                    
                    Console.WriteLine(massiv[i].name);
                }
            }


        }



        
    }
}
