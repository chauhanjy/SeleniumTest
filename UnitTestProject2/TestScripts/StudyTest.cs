using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2.TestScripts
{
    [TestClass]
    public class StudyTest
    {
        [TestMethod]
        public void test()
        {
            int[] nums = { 1, 2, 3, 4, 5 };
            int target = 4;

            Dictionary<int, int> map = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (map.ContainsKey(complement))
                {
                    Console.WriteLine($"Indices: {map[complement]} and {i}");
                    Console.WriteLine($"Values: {complement} and {nums[i]}");
                    break;
                }
                else
                {
                    if (!map.ContainsKey(nums[i]))
                    {
                        map.Add(nums[i], i);
                    }
                }
            }
        }
    }
    [TestClass]
    public class Employee
    {
        public int empID;
        public string empName;
        public int salary;
        [TestMethod]
        public void Comparenum()
        {
            List<Employee> list = new List<Employee>();
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            emp1.empID = 123;
            emp1.empName = "Jyoti";
            emp1.salary = 10000;
            emp2.empID = 145;
            emp2.empName = "Dhruv";
            emp2.salary = 20000;

            list.Add(emp1);
            list.Add(emp2);

            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.empName);
                Console.WriteLine(emp.salary);
                Console.WriteLine(emp.empID);
            }
            Console.Read();
        }
    }

    [TestClass]
    public class AddValue
    {
        [TestMethod]
        public void Sum()
        {
            int[] values = { 1, 2, 3, 4, 5 };
            int result = 4;

            for(int i=0; i<values.Length; i++)
            {
                for(int j=i+1; j<values.Length; j++)
                {
                    if (values[i] + values[j] == result)
                        Console.WriteLine("Integers are " + values[i] + values[j]);
                }
               
            }
        }
    }

    [TestClass]
    public class CollectionUse
    {
        int[] array = { 1, 2, 3, 4, 5 };
        int result = 5;
        [TestMethod]
        protected void Button1_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();


        }
    }
}
