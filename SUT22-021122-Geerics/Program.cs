using System;
using System.Collections.Generic;
using System.Linq;

namespace SUT22_021122_Geerics
{
    class Program
    {
        static void Main(string[] args)
        {

            GenericTest<int> obj1 = new GenericTest<int>();
            obj1.Compare(1, 2);


            GenericTest<string> obj2 = new GenericTest<string>();
            



            //bool Eq = Check.CheckEqualaty(1, 1);

            //if (Eq)
            //{
            //    Console.WriteLine("The Values are Equal ");
            //}
            //else
            //{
            //    Console.WriteLine("The Values are not Equal");
            //}


            //bool Eq2 = Check.CheckEqualaty("Anas", "Tobias");

            //if (Eq2)
            //{
            //    Console.WriteLine("The Values are Equal ");
            //}
            //else
            //{
            //    Console.WriteLine("The Values are not Equal");
            //}

            Student S1 = new Student()
            {
                ID = 1001,
                Name = "Sara",
                Gender = "F",
                Salary = 25000

            };


            Student S2 = new Student()
            {
                ID = 1002,
                Name = "Tobias",
                Gender = "M",
                 Salary = 25000
            };

            Student S3 = new Student()
            {
                ID = 1003,
                Name = "Reidar",
                Gender = "M",
                Salary = 20000
                
            };

            Student S4 = new Student()
            {
                ID = 1004,
                Name = "Anas",
                Gender = "M",
                Salary = 30000

            };

            // //Queue
            // Queue<Student> stQu = new Queue<Student>();

            // //Add Items to The Queue
            // stQu.Enqueue(S1);
            // stQu.Enqueue(S2);
            // stQu.Enqueue(S3);



            // // Delete Item from Queue 

            // Student sToDelete = stQu.Dequeue();
            // Console.WriteLine(sToDelete.ID + " " + sToDelete.Name);
            // Console.WriteLine("Total Items in The Queue = " + stQu.Count);




            // Console.WriteLine("----- Peek ----");
            // //Peek 
            //Student ps = stQu.Peek();
            // Console.WriteLine(ps.ID  + " " + ps.Name);
            // Console.WriteLine("Total Items in The Queue = " + stQu.Count());





            // //Contains

            // if (stQu.Contains(S1))
            // {
            //     Console.WriteLine("The Item is in the Queue");
            // }
            // else
            // {
            //     Console.WriteLine("The Item is not in the Queue");
            // }



            ////Stack
            //Stack<Student> stStack = new Stack<Student>();

            ////Add items to The Stack
            //stStack.Push(S1);
            //stStack.Push(S2);
            //stStack.Push(S3);


            ////Delete items from Stack 

            //Student sTDelete = stStack.Pop();
            //Console.WriteLine("ID = {0} , Name = {1}", sTDelete.ID, sTDelete.Name);
            //Console.WriteLine("The items in the Stack = " + stStack.Count);



            //foreach (Student item in stStack)
            //{
            //    Console.WriteLine("ID = {0} , Name = {1}", item.ID, item.Name);

            //}




            List<Student> listStuden = new List<Student>();
            listStuden.Add(S1);
            listStuden.Add(S2);
            listStuden.Add(S3);



            //Insert 
            listStuden.Insert(2, S4);

            //Remove 
            listStuden.Remove(S1);
            //Indx of
            Console.WriteLine(listStuden.IndexOf(S4));



            //foreach (Student item in listStuden)
            //{
            //    Console.WriteLine("ID = {0} \n Name = {1}", item.ID, item.Name);
            //}



            //for (int i = 0; i < listStuden.Count; i++)
            //{
            //    Console.WriteLine("For loop");
            //    Student s = listStuden[i];
            //    Console.WriteLine("ID = {0} \n Name = {1}", s.ID, s.Name);

            //}



            //Consoins 
            //if (listStuden.Contains(S1))
            //{
            //    Console.WriteLine("The item is in the List");
            //}

            //else
            //{
            //    Console.WriteLine("The Item is not in the List");
            //}



           //Student toFind =  listStuden.Find(s => s.Name == "Anas");

           // Console.WriteLine("ID = {0} \n Name = {1}", toFind.ID, toFind.Name);

            

           List<Student> sSAlary = listStuden.FindAll(s => s.Salary > 25000);

            foreach (Student item in sSAlary)
            {
                Console.WriteLine("ID = {0} \n Name = {1} \n Salary = {2}" , item.ID, item.Name,item.Salary);

            }



           Student stoFinsAlary =  listStuden.FindLast(s => s.Salary == 25000);
            Console.WriteLine("ID = {0} \n Name = {1} \n Salary = {2}", stoFinsAlary.ID, stoFinsAlary.Name, stoFinsAlary.Salary);

            //Queue<int> numQu = new Queue<int>();

            //numQu.Enqueue(1);
            //numQu.Enqueue(2);
            //numQu.Enqueue(3);

            //numQu.Dequeue();

            //foreach (int item in numQu)
            //{
            //    Console.WriteLine(item);
            //}

            //numQu.Dequeue();


            //foreach (int item2 in numQu)
            //{
            //    Console.WriteLine("The Secound loop");
            //    Console.WriteLine(item2);
            //}

            Console.ReadKey();
        }
    }
}
