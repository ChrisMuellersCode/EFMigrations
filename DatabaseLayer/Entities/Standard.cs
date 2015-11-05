using System.Collections.Generic;

namespace De.Brickmakers.Tutorials.EF.DatabaseLayer.Entities
{
    public class Standard
    {
        public Standard()
        {

        }
        public int StandardId { get; set; }
        public string StandardName { get; set; }

        public ICollection<Student> Students { get; set; }

    }
}
