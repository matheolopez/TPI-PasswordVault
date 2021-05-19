using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordVault
{
    public class History
    {
        public int fkAccount  // property
        { get; set; }

        public int? his1  // property
        { get; set; }

        public int? his2  // property
        { get; set; }

        public int? his3  // property
        { get; set; }

        public int? his4  // property
        { get; set; }

        public int? his5  // property
        { get; set; }

        public int? his6  // property
        { get; set; }

        public int? his7  // property
        { get; set; }

        public int? his8  // property
        { get; set; }

        public int? his9  // property
        { get; set; }

        public int? his10  // property
        { get; set; }

        private List<int> ids;  // property

        public List<int> getIds()
        {
            ids = new List<int>();
            ids.Add(fkAccount);
            if (his1 != null)
            {
                ids.Add((int)his1);
            }
            if (his2 != null)
            {
                ids.Add((int)his2);
            }
            if (his3 != null)
            {
                ids.Add((int)his3);
            }
            if (his4 != null)
            {
                ids.Add((int)his4);
            }
            if (his5 != null)
            {
                ids.Add((int)his5);
            }
            if (his6 != null)
            {
                ids.Add((int)his6);
            }
            if (his7 != null)
            {
                ids.Add((int)his7);
            }
            if (his8 != null)
            {
                ids.Add((int)his8);
            }
            if (his9 != null)
            {
                ids.Add((int)his9);
            }
            if (his10 != null)
            {
                ids.Add((int)his10);
            }

            return ids;
        }
    }
}
