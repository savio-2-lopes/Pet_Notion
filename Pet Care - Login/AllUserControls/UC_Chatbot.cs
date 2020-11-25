using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Xml;
using System.Text.RegularExpressions;

namespace Pet_Care___Login.AllUserControls
{
    public partial class UC_Chatbot : UserControl
    {
        private ChatBot chatbot = new ChatBot();
        private string resp;
        private Texto texto;
        private TextBox[] caixaTexto = null;
        private bool falar = true;

        public UC_Chatbot()
        {
            InitializeComponent();
            texto = new Texto();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e){}

        private void guna2Button1_Click(object sender, EventArgs e){}

        private void textBox1_TextChanged(object sender, EventArgs e){}

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            int index;

            if (caixaTexto == null)
                index = 0;
            else
                index = caixaTexto.Length;

            if ((e.KeyCode == Keys.Enter) && textBox1.Text != "")
            {
                if (index == 0)
                    texto.InsertLine("", -1);
                else
                    texto.InsertLine(textBox1.Text, index);

                resp = chatbot.categoria(textBox1.Text, falar);
                pTexto.VerticalScroll.Value = 0;
                DrawText(true, textBox1.Text);
                texto.InsertLine(resp, caixaTexto.Length);
                DrawText(false, resp);
                pTexto.ScrollControlIntoView(caixaTexto[index + 1]);
                textBox1.Clear();
                SendKeys.Send("{BS}");
            }

        }

        private void DrawText(bool usr, string frase)
        {
            caixaTexto = new TextBox[texto.NumLines];
            LinkedListNode<string> n = texto.FirstLine;
            int i = 0;


            while (n != null)
            {
                caixaTexto[i] = new TextBox();
                if (usr)
                {
                    caixaTexto[i].BackColor = Color.FromKnownColor(KnownColor.Control);
                    caixaTexto[i].ForeColor = Color.Blue;
                    caixaTexto[i].Text += "Dono: ";
                }
                else
                {
                    caixaTexto[i].BackColor = Color.FromKnownColor(KnownColor.Control);
                    caixaTexto[i].ForeColor = Color.Green;
                    caixaTexto[i].Text += "PetBot: ";
                }
                caixaTexto[i].Multiline = true;
                if (i == 0)
                    caixaTexto[i].Location = new Point(3, 3);
                else
                    caixaTexto[i].Location = new Point(3, (3 * 10 * i));
                caixaTexto[i].Font = new Font("Arial", 11);
                caixaTexto[i].Width = 420;
                caixaTexto[i].Height = 25;
                caixaTexto[i].BorderStyle = BorderStyle.None;
                caixaTexto[i].Font = new Font(caixaTexto[i].Font, FontStyle.Bold);
                caixaTexto[i].Text += frase;
                caixaTexto[i].Tag = i.ToString();
                caixaTexto[i].ReadOnly = true;

                pTexto.Controls.Add(caixaTexto[i]);

                n = n.Next;
                i++;
            }
        }

        private void button1_Click(object sender, EventArgs e){}

        private void btnLogin_Click(object sender, EventArgs e)
        {
            falar = !falar;
            if (falar)
                btnLogin.Text = "Voz: ligado";
            else
                btnLogin.Text = "Voz: desligado";
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Output.Text = searchWikipedia(Input.Text);
        }

        private string searchWikipedia(string artigo)
        {
            WebClient wc = new WebClient();
            string archivo = wc.DownloadString("https://pt.wikipedia.org/w/api.php?format=xml&action=query&prop=extracts&titles=" + artigo + "&redirects=true");

            XmlDocument xml = new XmlDocument();
            xml.LoadXml(archivo);

            XmlNode nodo = xml.GetElementsByTagName("extract")[0];

            try
            {
                string t = nodo.InnerText;
                Regex rx = new Regex("\\<[^\\>]*\\>");
                t = rx.Replace(t, "");

                t = t.Replace("Ã£", "ã");
                t = t.Replace("Ã©", "é");
                t = t.Replace("í§", "í");
                t = t.Replace("Ã³", "ó");
                t = t.Replace("Ã§", "ç");
                t = t.Replace("Ã¡", "á");
                t = t.Replace("Ãº", "ú");
                t = t.Replace("Ã­", "í");
                t = t.Replace("Ãµ", "õ");
                t = t.Replace("Ã‰ ", "É");
                t = t.Replace("Ã", "Á");
                t = t.Replace("Ãª", "ê");
                t = t.Replace("Ã¢", "â");

                return t;
            }
            catch (Exception e)
            {
                return "Artigo não encontrado";
            }
        }
        private void Input_TextChanged(object sender, EventArgs e){}

        private void Output_TextChanged(object sender, EventArgs e){}
    }
}