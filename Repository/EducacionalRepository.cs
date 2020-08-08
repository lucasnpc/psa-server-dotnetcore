using psa_server_dotnetcore.Model;
using System.Collections.Generic;

namespace psa_server_dotnetcore.Repository
{
    public class EducacionalRepository
    {
        public Educacional Get()
        {
            var l1 = new List<EducacionalData>();
            var lista = new Educacional();
            l1.AddRange(new[] {
                new EducacionalData("1", "O que é PSA?","Pagamento por serviços ambientais (PSA)" +
                " é um programa em que o dono das terras" +
                " se dispõe a 'abrir mão' do uso direto de uma determinada área em sua propriedade em favor de sua conservação" +
                ", garantindo as condições necessárias para a manutenção dos serviços prestados por aquele ambiente natural." +
                "<br>O proprietário recebe um pagamento de incentivos ou uma compensação fiannceira para perservar as nascentes," +
                " margens de rios e matas de sua propriedade.<br>Estas práticas visam recuperar e preservar diversos ecossistemas" +
                " e toda sua biodiversidade, sendo aplicados principalmente para a preservação das águas e florestas.",
                "http://www.valeverde.org.br/ft-home/ft-home-1.jpg"),
                new EducacionalData("2", "Para que serve o PSA?", "Serve para a preservação, manutenção ou recuperação da qualidade das águas e terras. Além disso," +
                " representa alternativa na geração de renda dos beneficiários (proprietários).",
                "http://www.valeverde.org.br/img/valeverde.png"), 
                new EducacionalData("3","De onde vem o dinheiro ou recurso?",
                "Os pagamentos desses incentivos financeiros vem de recursos gerados em parte pela cobrança do uso da água" +
                " (PSA hídrico) e em alguns estados existe o ICMS(imposto) ecológico. Pode haver também provedores da iniciativa" +
                " privada (destacando concessionárias de abastecimento público e empresas que são grandes usuárias de água).",
                "http://www.valeverde.org.br/imagemdim.php?img_larg=200&img_alt=150&imagem=arqmateria/15284289205b19f9785dffa.jpg"),
                new EducacionalData("4", "Como é pago?",
                "Ocorre por meio de entidades de confiança. São os mediadores que por meio de um órgão do governo"+
                " (Comité de Bacia Hidrográfica, Universidades ou até ONGs que irão fazer as partes (proprietários e os responsáveis"+
                " pelo projeto) entrarem em comum acordo.",
                "http://www.valeverde.org.br/imagemdim.php?img_larg=200&img_alt=150&imagem=arqmateria/15284289205b19f9785dffa.jpg"),
                new EducacionalData("5", "Como participar?", 
                "Na Serra da Mantiqueira o PSA ainda está em fase de estudos para implantação.Quando estiver implantado"+
                " os proprietários serão contactados para fazer a inscrição e seguir os regulamentos do PSA de acordo com a legislação.",
                "http://www.valeverde.org.br/imagemdim.php?img_larg=200&img_alt=150&imagem=arqmateria/15284289205b19f9785dffa.jpg")
            });
            lista.data = l1;
            return lista;
        }
    }
}
