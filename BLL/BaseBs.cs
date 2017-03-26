using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaseBs
    {
        public MoviesBs MoviesBs { get; set; }
        public UsersBs UsersBs { get; set; }

        public BaseBs()
        {
            MoviesBs = new MoviesBs();
            UsersBs = new UsersBs();
        }
    }
}
