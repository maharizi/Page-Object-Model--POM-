using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1
{
    internal class Page
    {
        public SearchBar searchBar;
        public FilterBar filterBar;


        public Page() { 
        this.searchBar = new SearchBar();
        this.filterBar = new FilterBar();

        }
    }
}
