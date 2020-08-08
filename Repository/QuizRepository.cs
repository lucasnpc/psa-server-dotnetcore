using psa_server_dotnetcore.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace psa_server_dotnetcore.Repository
{
    public class QuizRepository
    {
        public Quiz Get()
        {
            var quiz = new Quiz();
            var lista = new List<QuizData>();
            var l1 = new List<Resposta>();
            var l2 = new List<Resposta>();
            var l3 = new List<Resposta>();
            var l4 = new List<Resposta>();
            l1.AddRange(new[] {
                new Resposta("William Kidd", false), new Resposta("Pedro Alvarez Cabral", true),
                new Resposta("Barba Negra", false), new Resposta("Cristovão Colombo", false)
            });
            l2.AddRange(new[] {
                new Resposta("Alexandre o Grande", false), new Resposta("Júlio César", false),
                new Resposta("Horácio", false), new Resposta("César Augusto", true)
            });
            l3.AddRange(new[] {
                new Resposta("Mongóis com Genghis Khan", true), new Resposta("Romanos com Júlio César", false),
                new Resposta("Brasil com D.Pedro Segundo", false), new Resposta("Pérsia com Xérxes", false)
            });
            l4.AddRange(new[]
            {
                new Resposta("Joseph Stalin", false), new Resposta("Winston Churchill", false),
                new Resposta("Adolf Hitler", true), new Resposta("Franklin Roosevelt", false)
            });
            lista.Add(new QuizData
            {
                id = 1,
                titulo = "Quem descobriu o Brasil?",
                respostas = l1
            });
            lista.Add(new QuizData
            {
                id = 2,
                titulo = "Quem foi o primeiro imperador de Roma?",
                respostas = l2
            });
            lista.Add(new QuizData
            {
                id = 3,
                titulo = "Qual foi o maior império em extensão da história?",
                respostas = l3
            });
            lista.Add(new QuizData
            {
                id = 4,
                titulo = "Quem começou a segunda guerra mundial?",
                respostas = l4
            });
            quiz.data = lista;
            return quiz;
        }
    }
}
