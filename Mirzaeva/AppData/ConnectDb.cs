using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mirzaeva.Model;

namespace Mirzaeva.AppData
{
    internal class ConnectDb
    {
        private static barberMIrzaevaEntities context;
        public static barberMIrzaevaEntities get_context()
        {
            if (context == null)
            {
                context = new barberMIrzaevaEntities();
                return context;
            }
            else return context;


        }
    }
}
