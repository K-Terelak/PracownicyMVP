using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace Pracownicy.Model
{

    class EmployeeBuilder
    {
        private static List<Employee> _list = new List<Employee>();
        public List<Employee> employeeList => _list;

        public void AddEmployee(Employee e) => _list.Add(e);

        public void SaveToFile()
        {
            if(_list.Count != 0) { 
            Stream stream = File.OpenWrite("employees.xml");

            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Employee>));

            xmlSer.Serialize(stream, _list);


            stream.Close();
                }
        }

        public void ReadFromFile()
        {
            List<Employee> list = new List<Employee>();

            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Employee>));
            try
            {
                using (FileStream stream = File.Open("employees.xml", FileMode.Open))
                {
                    list = (List<Employee>)xmlSer.Deserialize(stream);
                }
                _list = list;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File does not exist");
            }
        }

        private void ClearList()
        {
            _list.Clear();
        }
    }
}
