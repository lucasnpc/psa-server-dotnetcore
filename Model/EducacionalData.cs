using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace psa_server_dotnetcore.Model
{
    public class EducacionalData
    {

        public EducacionalData(string p1, string p2, string p3, string p4)
        {
            id = p1;
            titulo = p2;
            descricao = p3;
            capa = p4;
        }

        public string id { get; set; }

        public string titulo { get; set; }

        public string descricao { get; set; }
        public string capa { get; set; }
    }
}
