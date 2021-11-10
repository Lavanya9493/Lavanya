using System;

namespace WhyProperties
{
    class Employee
    {
        int _eno;
        string _ename;
        public int Eno
        {
           set
            {
               if(value<0)
                 throw new Exception("Employee number cannot be negative and zero");
               _eno=value;
            }
            get
            {
               return _eno;
            }
        }
        public string Ename
        {
            get {return string.IsNullOrEmpty(this._ename)?"No Name":this._ename;}
            set
            {
                if(string.IsNullOrEmpty(value))
                throw new Exception("Employee name cannot be null or empty");
                this._ename=value;
            }
        }
        public string Email
        {get;set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1=new Employee();
            e1.Eno=123;
            e1.Ename="Lavanya";
            e1.Email="lavanyajonnalagadda123@gmail.com";
            Console.WriteLine("{0}\t{1}\t{2}",e1.Eno,e1.Ename,e1.Email);
        }
    }
}
