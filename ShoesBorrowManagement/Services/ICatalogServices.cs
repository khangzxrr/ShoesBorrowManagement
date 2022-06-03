using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoesBorrowManagement.Services
{
    internal interface ICatalogServices
    {
        bool Validate(string name);
        void Add(string name);
    }
}
