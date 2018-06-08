using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace HostAPI
{
    public class ConsoleApplicationCall:TopLevelApplication
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        ProcessStartInfo processDetails;
        string  consoleApplicationPath;
        string arguments;
        
        public ConsoleApplicationCall(string fName, string args)
        {
            consoleApplicationPath = fName;
            arguments = args;
        }
        public override bool IndividualApplicationcall()
        {
            processDetails = new ProcessStartInfo
            {
                CreateNoWindow = false,
                FileName = consoleApplicationPath,
                Arguments = arguments
            };
            Process newProcess = new Process { StartInfo = processDetails};
            try
            {
                log.Info("Executing the console application");
                newProcess.Start();
                return true;
                
            }
            catch(Exception ex)
            {
                log.Error("Error While executing the Console application");
                return false;
            }


        }
   
       

       
    }
}
