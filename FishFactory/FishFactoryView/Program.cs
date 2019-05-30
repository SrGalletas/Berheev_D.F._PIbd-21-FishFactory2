using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FishFactoryServiceDAL.Interfaces;
using FishFactoryServiceImplementList.Implementations;
using FishFactoryServiceImplementDataBase;
using AbstractGarmentFactoryServiceImplementDataBase.Implementations;
using FishFactoryServiceImplementDataBase.Implementations;

namespace FishFactoryView
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
        
    }
}
