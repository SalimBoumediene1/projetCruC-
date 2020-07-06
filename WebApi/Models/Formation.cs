using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Formation
    {
        private int _Id;
        private string _LastName, _FirstName;
        private bool _Deleted;
        List<Cours> _Cours;

        public int Id { get => _Id; set => _Id = value; }
        public string LastName { get => _LastName; set => _LastName = value; }
        public string FirstName { get => _FirstName; set => _FirstName = value; }
        public bool Deleted { get => _Deleted; set => _Deleted = value; }
        public List<Cours> Cours { get => _Cours; set => _Cours = value; }
    }
}
