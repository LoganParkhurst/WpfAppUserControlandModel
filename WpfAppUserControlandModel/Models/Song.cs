using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppUserControlandModel.Models
{
    public class Song : IPlayable
    {
        public string Name { get; set; }
        public float Length { get; set; }

        public Song(string _name, float _length) 
        {
            Name = _name;
            Length = _length;
        }
    }
}
