using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SmartBusProject
{
    public class Wander
    {
        public String Title {  get; set; }
        public String Description { get; set; }
        public Image photo { get; set; }
        public Image map { get; set; }

        public Wander(string Title, string Description, Image photo, Image map) {

            this.Title = Title;
            this.Description = Description;
            this.photo = photo;
            this.map = map;

        }


    }
}
