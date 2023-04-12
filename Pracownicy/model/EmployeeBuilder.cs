﻿using System;
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
            Stream stream = File.OpenWrite("employess.xml");

            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Employee>));

            xmlSer.Serialize(stream, _list);


            stream.Close();
        }

        public void ReadFromFile()
        {
            List<Employee> list = new List<Employee>();

            XmlSerializer xmlSer = new XmlSerializer(typeof(List<Employee>));

            using (FileStream stream = File.Open("employess.xml", FileMode.Open))
            {
                list = (List<Employee>)xmlSer.Deserialize(stream);
            }
            _list = list;
        }

        private void ClearList()
        {
            _list.Clear();
        }
    }
}
