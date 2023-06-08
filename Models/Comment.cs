using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Project_2023.Models
{

    public class Comment
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public DateTime Date { get; set; }
        public User User { get; set; }
        public Conference Conference { get; set; }

    }
}
