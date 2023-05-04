using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotDefteri.Models
{
    internal abstract class BaseClass
    {
        public BaseClass()
        {
            CreationDate = DateTime.Now;  //Her yeni eklemede o anki tarih kaydedilmis olacak
        }
        public int Id { get; set; }
        public DateTime CreationDate { get; set; }
        public bool isActive { get; set; }
        //public ICollection<Note>Notes { get; set; }
    }
}
