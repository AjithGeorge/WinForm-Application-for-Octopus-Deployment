using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsAppForOctopusDeployment
{
   public class EnvironmentDetails
    {
        public class Item
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }
        public class RootObject
        {
            public List<Item> Items { get; set; }
        }
    }
    }

