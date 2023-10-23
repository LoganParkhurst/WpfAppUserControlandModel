using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppUserControlandModel.Models
{
    public interface IPlayable
    {
        string Name { get; set; }
        float Length { get; set; }
    }
}
