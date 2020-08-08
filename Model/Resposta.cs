namespace psa_server_dotnetcore.Model
{
    public class Resposta
    {
        public Resposta(string v1, bool v2)
        {
            resposta= v1;
            correta = v2;
        }

        public string resposta { get; set; }

        public bool correta { get; set; }
    }
}
