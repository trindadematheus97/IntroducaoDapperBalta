using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperDb.Models
{
    public class Category
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Url { get; internal set; }
        public string Description { get; internal set; }
        public int Order { get; internal set; }
        public string Summary { get; internal set; }
        public bool Featured { get; internal set; }
    }
}
