using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HostAPI
{
  public  class WindowsApplication: TopLevelApplication
    {
        public override bool IndividualApplicationcall()
        {
            //Here we shall write code to call the windows application
            return true;
        }
    }
}
