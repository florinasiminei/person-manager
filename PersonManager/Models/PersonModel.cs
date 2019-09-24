using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonManager.Models
{
    class PersonModel
    {
        private string _first_name;
        private string _last_name;
        private string _menu;

        public PersonModel(string first_name, string last_name, string menu)
        {
            _first_name = first_name;
            _last_name = last_name;
            _menu = menu;
        }

        public string FirstName
        {
            get { return _first_name; }
            set { _first_name = value; }
        }
        public string LastName
        {
            get { return _last_name; }
            set { _last_name = value; }
        }
        public string Menu
        {
            get { return _menu; }
            set { _menu = value; }
        }

        //this method is used to print nicely a Person object in the ListView
        public override string ToString()
        {
            return string.Format("{0} {1}", FirstName, LastName);
        }
    }
}
