using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MarkOGDev.Microsoft_Samples.GenericHost_Sample.ConsoleApp.Interfaces
{
    public interface IMyDependency
    {
        Task WriteMessage(string message);
    }
}
