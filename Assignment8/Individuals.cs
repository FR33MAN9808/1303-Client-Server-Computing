using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8
{
    internal class Individuals
    {
        private string _name;
        private string _address;
        private Dictionary<string,string> _phoneNumber;
        private Dictionary<string, string> _email;
        private string _company = "";

        public Individuals(string name, string address,string company)
        {
            _name = name;
            _address = address;
            _company = company;
            _phoneNumber = new Dictionary<string, string>();
            _email = new Dictionary<string, string>();
        }

        public string Name { get { return _name; } set { _name = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string Company { get { return _company; } set { _company = value; } }

    }
}
