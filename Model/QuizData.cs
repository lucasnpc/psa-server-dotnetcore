using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace psa_server_dotnetcore.Model
{
    public class QuizData
    {
        public int id { get; set; }

        public string titulo { get; set; }
        public List<Resposta> respostas { get; set; }

    }
}
