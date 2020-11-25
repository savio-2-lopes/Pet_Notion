using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pet_Care___Login
{
    class ControleCalendario
    {
        private String data;
        private String status;
        private String observacao;
        

        public string Data { get => data; set => data = value; }
        public string Status { get => status; set => status = value; }
        public string Observacao { get => observacao; set => observacao = value; }

        public void salvarDados()
        {
            List<String> dados = new List<String>();
            dados.Add(this.data);
            dados.Add(this.status);
            dados.Add(this.observacao);
            System.IO.File.WriteAllLines(@"C:\Users\Public\DataBase\Users\CalendarioNotif.txt",dados);




        }



    }
}
