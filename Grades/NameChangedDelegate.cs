using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grades
{
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args);

    // former use: public delegate void NameChangedDelegate(string existingName, string newName);
        //Somewhat against convention with regard to parameters in C#


}
