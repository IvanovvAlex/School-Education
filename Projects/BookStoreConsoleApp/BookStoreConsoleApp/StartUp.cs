using System;
using System.Collections.Generic;
using System.Text;
using BookStoreConsoleApp.Core;
using BookStoreConsoleApp.Core.Contracts;
using BookStoreConsoleApp.Models;
using Microsoft.EntityFrameworkCore.SqlServer;


namespace BookStoreConsoleApp
{
    class StartUp
    {
        static void Main()
        {
            IEngine engine = new Engine();
            engine.Run();            
        }
    }
}
