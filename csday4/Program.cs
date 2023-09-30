﻿//object class => object
public class Student
{
    public int Id { get; set; } //private
    public string Name { get; set; }
    public string Address { get; set; }
}
//Logical Class => Class
public class StudentOperations
{
    List<Student> students = new List<Student>(); //save into db  
    //insert
    public void Add(int id, string name, string address)
    {
        Student st = new Student();
        st.Id = id;
        st.Name = name;
        st.Address = address;

        students.Add(st);
    }
    public void GetById(int id) //Get one
    {
        for (int i = 0; i < students.Count(); i++)
        {
            if (id == students[i].Id)
            {
                Console.WriteLine($"Id:{students[i].Id}, Name:{students[i].Name}, Address:{students[i].Address}");
                break;
            }
        }
    }
    public void GetAll() //get all
    {
        for (int i = 0; i < students.Count(); i++)
        {
            Console.WriteLine($"Id:{students[i].Id}, Name:{students[i].Name}, Address:{students[i].Address}");
        }
    }
}
public class Program
{
    public static void Main()
    {
        StudentOperations stoperations = new StudentOperations();
        
        stoperations.Add(1, "Mohan", "Noida");
        stoperations.Add(2, "Ram", "Delhi");

        stoperations.GetAll();
    }
}



