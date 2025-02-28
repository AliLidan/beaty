using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using WpfBeauty.Models;

namespace WpfBeauty
{
    public class Helper
    {
        public static beautyEntities ent;
        public static beautyEntities GetContext()
        {
            if (ent == null)
            {
                ent = new beautyEntities();
            }
            return ent;
        }
    }
}
