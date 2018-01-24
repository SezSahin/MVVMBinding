using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FirstMVVM.Models;

namespace FirstMVVM.ViewModels
{
    public sealed class MainViewModel
    {
        DataManager DM = new DataManager();
        static readonly MainViewModel _instance = new MainViewModel();
        public Person ImportantPerson { get; set; }
        public List<Person> ImportantPersons { get; set; }
        private MainViewModel()
        {
            ImportantPersons = DM.ImportantPersons;
            ImportantPerson = DM.ImportantPerson;
        }
        public static MainViewModel Instance
        {
            get
            {
                return _instance;
            }
        }
        public void SaveChanges()
        {
            Debug.Assert(false, string.Format("{0} was updated", Instance.ImportantPerson.FirstName));
            Debug.Assert(false, string.Format("{0} was updated", Instance.ImportantPerson.FirstName));
        }
    }
}
