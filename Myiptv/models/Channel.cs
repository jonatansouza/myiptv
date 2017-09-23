using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Myiptv.models
{
    public class Channel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Url { get; set; }
        public string Code { get; set; }
        public byte[] Icon { get; set; }

        public Channel()
        {

        }
        public Channel(int Id, string Name, string Code, string Url, byte[] Icon)
        {
            this.Id = Id;
            this.Name = Name;
            this.Code = Code;
            this.Url = Url;
            this.Icon = Icon;
        }
        public Channel(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public override string ToString()
        {
            return "{Channel: " + Name + ", URL: " + Url + " code: " + Code + "icon }";
            // return "{Channel: " + Name + ", URL: " + Url + " code: " + Code + "icon " + Encoding.Default.GetString(Icon) + " }";
        }


    }
}
