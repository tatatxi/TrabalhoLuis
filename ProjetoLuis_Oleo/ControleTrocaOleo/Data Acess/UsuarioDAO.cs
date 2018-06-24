using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleTrocaOleo.Data_Acess
{
    class UsuarioDAO
    {
        Con01.ConnectionString = Properties.Settings.Default.con01;
            try
            {
                Con.Open();
                SqlCommand cmdo = new SqlCommand();
        cmdo.CommandText = "select * from funcionario";
                cmdo.CommandType = CommandType.Text;
                cmdo.Connection = Con;
    }
}
