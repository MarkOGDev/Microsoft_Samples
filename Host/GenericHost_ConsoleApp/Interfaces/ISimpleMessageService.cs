using System;
using System.Collections.Generic;
using System.Text;

namespace MarkOGDev.Microsoft_Samples.GenericHost_ConsoleApp.Interfaces
{
    /// <summary>
    /// A singleton Service. Class has no properties or fields. DI AddSingleton(). 
    /// <see cref="https://docs.microsoft.com/en-us/aspnet/core/fundamentals/dependency-injection?view=aspnetcore-2.1#service-lifetimes"/>
    /// </summary>
    public interface ISimpleMessageService
    {
        /// <summary>
        /// Gets a plain Hello Message
        /// </summary>
        /// <returns></returns>
        string GetHelloMessage();
        /// <summary>
        /// Returns a Message containing the 'Name'.
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        string GetHelloMessage(string Name);
        /// <summary>
        /// Returns a message containing the 'Age'.
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        string GetHelloMessage(int age);
    }
}
