using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppForOctopusDeployment
{
    public class ChannelDetails
    {
        public class Item
        {
            public string Name { get; set; }

            public string Id { get; set; }
        }

        public class RootObject
        {
            public List<Item> Items { get; set; }
        }
    }
}
