using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace AdvancedC.Generics
{
    class Generics
    {
        public static void InitiateSalaryDemo()
        {
            // Boxing is to add Value data type so Object type it is stored in heab
            // Unboxing is to extract data type from object type
            // Affect performance over head, generic is better for that.
            // Type saftey.
            // Enhance Performance.
            Salaries salaries = new Salaries();
            ArrayList arrLst = salaries.GetSalaries();
            float salary = (float)arrLst[1]; // casting is mandatory here 
            salary = salary + (salary * 0.02f);
            Console.WriteLine(salary);
        }

        public static void InitiateNonGenerciSortArray()
        {
            object[] arr = new object[] {3,53,6,4,31,3,2,424,234,1 };
            object[] arrstring = new object[] { "d","g","j","r","y","u","x"};
            Employee[] arrEmp = new Employee[] { new Employee{Id=4,Name="4" },
                                                 new Employee{Id=9,Name="9" },
                                                 new Employee{Id=5,Name="5" },
                                                 new Employee{Id=2,Name="2" },
                                                };
            EmployeeGeneric[] arrEmpGene = new EmployeeGeneric[] { new EmployeeGeneric{Id=4,Name="4" },
                                                 new EmployeeGeneric{Id=9,Name="9" },
                                                 new EmployeeGeneric{Id=5,Name="5" },
                                                 new EmployeeGeneric{Id=2,Name="2" },
                                                };
            SortArray sortArr = new SortArray();
            SortArrayGenercis<EmployeeGeneric> sortArrgene = new SortArrayGenercis<EmployeeGeneric>();
            sortArr.BubbleSort(arr);
            sortArr.BubbleSort(arrstring);
            sortArr.BubbleSort(arrEmp);
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
            foreach (var item in arrstring)
            {
                Console.WriteLine(item);
            }
            foreach (var item in arrEmp)
            {
                Console.WriteLine((Employee)item);
            }

            sortArrgene.BubbleSort(arrEmpGene);
            foreach (var item in arrEmp)
            {
                Console.WriteLine(item);
            }

        }
    }
    #region Basics
    class Salaries
    {
        ArrayList _salaryLst = new ArrayList();

        public Salaries()
        {
            _salaryLst.Add(600.34f); // f means to literals this is a float not double i
            _salaryLst.Add(400.14f);
            _salaryLst.Add(4500.332f);
        }

        public ArrayList GetSalaries()
        {
            return _salaryLst;
        }
    }

    class SalariesGeneric
    {
        List<float> _salaryLst = new List<float>();

        public SalariesGeneric()
        {
            _salaryLst.Add(600.34f); // f means to literals this is a float not double i
            _salaryLst.Add(400.14f);
            _salaryLst.Add(4500.332f);
        }

        public List<float> GetSalaries()
        {
            return _salaryLst;
        }
    }
    #endregion

    class SortArray
    {
        public void BubbleSort(object[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                    if (((IComparable)arr[j]).CompareTo(arr[j+1]) > 0)
                    {
                        Swap(arr,j);
                    }
                }
            }
        }

        private void Swap(object[] arr,int j)
        {
            object temp = arr[j];
            arr[j] = arr[j+1];
            arr[j + 1] = temp;
        }
    }

    class SortArrayGenercis<T> where T:IComparable<T> // this called constrains, this is to make sure that any type uses this class must implement icomparable interface.
    {
        public void BubbleSort(T[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j].CompareTo(arr[j + 1]) > 0)
                    {
                        Swap(arr, j);
                    }
                }
            }
        }

        private void Swap(T[] arr, int j)
        {
            T temp = arr[j];
            arr[j] = arr[j + 1];
            arr[j + 1] = temp;
        }
    }
    class Employee : IComparable // if not implementing i comparable it will not work as we depend on it 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo(object obj)
        {
            return this.Id.CompareTo(((Employee)obj).Id); // many casts here which is not correct.
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
    class EmployeeGeneric : IComparable<EmployeeGeneric> // must impletment genric i comparable
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int CompareTo([AllowNull] EmployeeGeneric other)
        {
            return this.Id.CompareTo(other.Id);
        }

        public override string ToString()
        {
            return $"{Id} {Name}";
        }
    }
}
