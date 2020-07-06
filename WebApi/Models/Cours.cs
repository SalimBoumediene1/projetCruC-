using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Models
{
    public class Cours
    {
        private int _Id;
        private string _Matiere;

        public int Id { get => _Id; set => _Id = value; }
        public string Matiere { get => _Matiere; set => _Matiere = value; }
    }


}
