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
        Boolean submitCalon(String kode, String nama, String partai);
        String nomorBaru();
    }
}
