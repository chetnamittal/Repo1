using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace HostAPI
{
    public class InvokingClass:IInvokingClass
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        string applicationOption;

        public InvokingClass (string application)
        {
            applicationOption = application;
        }

        public bool  InvokeProperApplication()
        {
            switch (applicationOption)
            {

                case "Console":
                    log.Info("For Console application");
                    string applicationPath = ConfigurationManager.AppSettings["ConsoleApplicationPath"];
                    //create an object for Console application   
                    ConsoleApplicationCall consoleAppInstance = new ConsoleApplicationCall(applicationPath,"Hello World");
                    if (consoleAppInstance.IndividualApplicationcall())
                    {
                        log.Info("The application ran sucessfullly");
                        return true;
                    }
                    else log.Error("Errors occured while running the application");
                    return false;
                                 
                case "Database":
                    string dbConnectionString = ConfigurationManager.ConnectionStrings["DemoDb"].ToString();
                    WriteToDatabaseApplication dbApplicationInstance = new WriteToDatabaseApplication(dbConnectionString);
                    if (dbApplicationInstance.IndividualApplicationcall())
                    {
                        log.Info("The application ran sucessfullly");
                        return true;
                    }
                    else return false;

                case "Window":
                    WindowsApplication windowsApplicationInstance = new WindowsApplication();
                    windowsApplicationInstance.IndividualApplicationcall();
                    //Create an object for windows application
                    return true;
                    break;               

                    break;
                case "Mobile":
                    MobileApplication mobileApplicationInstance = new MobileApplication();
                    mobileApplicationInstance.IndividualApplicationcall();
                    //Create an object for mobile application 
                    return true;

                default:
                    log.Error("Application Not Supported");
                    throw (new Exception());
                
            }
                
        }
      
    }
}
