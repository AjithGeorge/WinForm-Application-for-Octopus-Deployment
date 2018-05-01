using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsAppForOctopusDeployment
{
    public class ReleaseDetails
    {
        public class Item
        {
            public string Version { get; set; }

            public string Id { get; set; }


        }

        public class RootObject
        {
            public List<Item> Items { get; set; }
            
        }
    }
}
