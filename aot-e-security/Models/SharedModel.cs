using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aot_e_security.Models.DB;

namespace aot_e_security.Models
{
    public class SharedModel
    {
        public int menuID { get; set; }
        public string menuName { get; set; }
        public int menuGroup { get; set; }
        public int menuStatus { get; set; }
        public string menuLink { get; set; }
        public string menuIcon { get; set; }
        public int menuSort { get; set; }
        public bool menuSubStatus { get; set; }
        public List<SharedModel> menuSub { get; set; }
        public int? chkStatus { get; set; }
    }

    public class SharedMath
    {
        private eSecurityContext db = new eSecurityContext();
        public SharedModel sharedModel { get; set; }
        public List<Person> mainMenu()
        {
            return db.Person.ToList();
        }
    }
}
