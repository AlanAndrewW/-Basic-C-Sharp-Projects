using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismAssignment
{
    // Interface IQuittable defines a method Quit()
    public interface IQuittable
    {
        // Method that all classes implementing IQuittable must define
        void Quit();
    }
}