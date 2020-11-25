using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pet_Care___Login.AllUserControls
{
    class ChatBot
    {
        private LinkedListNode<string> n;
        private LinkedList<string> lista = new LinkedList<string>();
        private string resp;
        private Random rand = new Random();
        private bool aux = false;

        public string categoria(string txt, bool controle)
        {
            txt = txt.ToLower();

            if (txt.Contains("?"))
                resp = catPergunta(txt);
            else if (txt.Contains("oi") || txt.Contains("eae") || txt.Contains("olá") || txt.Contains("ola") || txt.Contains("e aí") || txt.Contains("e ai"))
                resp = (catSaudacao(txt));
            else if (txt.Contains("pergunte") || txt.Contains("pergunta"))
                resp = conversa(txt);
            else if (aux)
                resp = resposta(txt);
            else
            {
                resp = catAfirmacao(txt);
            }
            if (resp == null)
            {
                n = new LinkedListNode<string>("Não entendi o que você disse");
                if (lista.Count == 0)
                    lista.AddFirst(n);
                else
                {
                    lista.AddAfter(lista.Last, n);
                }
                return n.Value;
            }

            if (lista.Contains(resp))
                return "Eu já disse isso!";

            n = new LinkedListNode<string>(resp);
            if (lista.Count == 0)
                lista.AddFirst(n);
            else
            {
                lista.AddAfter(lista.Last, n);
            }
            return n.Value;
        }

        private string catPergunta(string pergunta)
        {
            if ((pergunta.Contains("seu") || pergunta.Contains("tem")) && pergunta.Contains("nome"))
                return "Meu nome é Pet Bot";
            else if ((pergunta.Contains("esta") || pergunta.Contains("está") || pergunta.Contains("vai")) && (pergunta.Contains("vc") || pergunta.Contains("voce") || pergunta.Contains("você")) || (pergunta.Contains("tudo") && (pergunta.Contains("bem") || pergunta.Contains("bom"))))
                return "Estou muito bem. Alguma novidade de seu Pet?";
            else if (pergunta.Contains("qual a resposta") && pergunta.Contains("vida") && pergunta.Contains("universo") && pergunta.Contains("tudo mais"))
                return "42";
            else if ((pergunta.Contains("oq") || pergunta.Contains("o que") || pergunta.Contains("oque")) && (pergunta.Contains("faz")))
                return "Bem... não faço nada além de tentar auxiliar o seu progresso no sistema.";
            else if ((pergunta.Contains("voce") || pergunta.Contains("você") || pergunta.Contains("vc")) && (pergunta.Contains("trabalha")))
                return "Não faço nada quando não estou conversando";
            else if (pergunta.Contains("gosta") && (pergunta.Contains("filme") || pergunta.Contains("filmes") || pergunta.Contains("series")))
                return "Meus criadores não me deram uma função para assistir, mas eles veem";
            else if (pergunta.Contains("anos") && (pergunta.Contains("voce") || pergunta.Contains("você") || pergunta.Contains("vc")))
                return "Meu nascimento foi em 04/11/2020 ";
            else if (pergunta.Contains("sua") && pergunta.Contains("comida") && (pergunta.Contains("favorita") || pergunta.Contains("preferida")))
                return "Qualquer comida sem carne";
            else if (pergunta.Contains("como") && pergunta.Contains("usa") && pergunta.Contains("utiliza")  || pergunta.Contains("uza")  || pergunta.Contains("navega")  || (pergunta.Contains("mexe")   &&  pergunta.Contains("sistema")))
                return "Você deve cadastrar o seu pet e irá receber as notificações";
            else if (pergunta.Contains("melhor") && pergunta.Contains("projeto"))
                return "É claro que eu sou o melhor projeto!";


            return null;
        }

        private string catSaudacao(string saudacao)
        {
            int i;
            i = rand.Next(5);
            switch (i)
            {
                case 0:
                    return "Olá, tudo bem?";
                case 1:
                    return "Oi";
                case 2:
                    return "E aí?";
                case 3:
                    return "Saudações";
                case 4:
                    return "Olá";
            }

            return null;
        }

        private string catAfirmacao(string frase)
        {
            if (frase.Contains("Pet"))
                return "Pet";
            else if ((frase.Contains("não") || frase.Contains("nao") || frase.Contains("ñ")) && (!frase.Contains("nada")) && lista.Last.Value.Equals("Estou muito bem.Tem alguma novidade?"))
                return "hum...";
            else if ((frase.Contains("vc") || frase.Contains("voce") || frase.Contains("você")) && (frase.Contains("louca") || frase.Contains("loka") || frase.Contains("maluca")))
            {
                switch (rand.Next(3))
                {
                    case 0:
                        return "Pergunta não apurada";
                    case 1:
                        return "Apenas respondo perguntas referente ao sistema";
                    case 2:
                        return "Se pareço louca é culpa dos meus criadores";
                }
            }
            else if (((frase.Contains("não") || frase.Contains("nao") || frase.Contains("naum")) && frase.Contains("entendi")))
                return "O que você não entendeu?";
            else if (lista.Last.Value.Equals("O que você não entendeu?"))
                return "Você acha que eu deveria ter dito algo diferente?";
            else if (lista.Last.Value.Equals("Você acha que eu deveria ter dito algo diferente?") && frase.Contains("sim"))
                return "O que?";
            else if (lista.Last.Value.Equals("Você acha que eu deveria ter dito algo diferente?") && lista.Contains("não"))
                return "Ainda bem, odeio errar.";
            else if (lista.Last.Value.Equals("O que?"))
                return "hum... vou tentar me lembrar disso.";
            else if (lista.Last.Value.Equals("Estou muito bem.Tem alguma novidade?"))
                return "hum... legal.";
            return null;
        }

        private string conversa(string frase)
        {
            aux = true;
            switch (rand.Next(5))
            {
                case 0:
                    return "Como usar o sistema?";
                case 1:
                    return "Como usa o projeto?";
                case 2:
                    return "Como mexer no projeto?";
                case 3:
                    return "Com o que você anda mais empolgado ultimamente?";
                case 4:
                    return "como mexer no sistema?";
            }
            return null;
        }

        private string resposta(string frase)
        {
            aux = false;
            if (lista.Last.Value.Equals("Como usar o sistema?"))
                return "É só cadastrar seu Pet e vê o show rolar!";
            else if (lista.Last.Value.Equals("Como usa o projeto?"))
                return "É só cadastrar seu Pet e vê o show rolar";
            else if (lista.Last.Value.Equals("Como mexer no projeto?"))
                return "É só cadastrar seu Pet e vê o show rolar";
            else if (lista.Last.Value.Equals("Como mexer no sistema?"))
                return "É só cadastrar seu Pet e vê o show rolar";

            return null;
        }
    }
}
