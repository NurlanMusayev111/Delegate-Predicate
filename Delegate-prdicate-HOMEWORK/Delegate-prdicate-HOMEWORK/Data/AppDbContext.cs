using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_prdicate_HOMEWORK.Data
{
    public class AppDbContext<T>
    {
        public static List<T> Datas;

        static AppDbContext()
        {
            Datas = new List<T>();
        }
    }
}
