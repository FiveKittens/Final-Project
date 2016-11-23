using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace FrmLogin.Interface
{
    interface IntCalon
    {
        Boolean submitCalon(Entity.EntCalon e);
        int nomorBaru();
    }
}
