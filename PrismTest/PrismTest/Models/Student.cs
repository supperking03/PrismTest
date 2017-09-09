using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Prism.Mvvm;

namespace PrismTest.Models
{
    public class Student: BindableBase
    {
        private string _name;
        private string _id;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                SetProperty ( ref _name, value );
            }
        }

        public string ID
        {
            get
            {
                return _id;
            }
            set
            {
                SetProperty ( ref _id, value );
            }
        }

        public Student ( )
        {
            
        }
    }
}
