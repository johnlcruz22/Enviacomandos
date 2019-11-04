using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using Npgsql;
using System.Xml;
using System.IO;


namespace enviacomandos
{
    public partial class Form1 : Form
    {
       public List<string> parametros = new List<string>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {


             listBoxParam.Items.Clear();

            foreach (string listacom in Lerxml())
            {
                comboBox1.Items.Add(listacom);
            }
            

        }



        public static NpgsqlConnection Conectarpg(string ip,
                                          string porta,
                                          string usuario,
                                          string senha,
                                          string database)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server="+ ip + ";Port=" + porta + ";User Id=" + usuario + ";Password=" + senha + ";Database=" + database + ";");

            try
            {
                conn.Open();
                return conn;
            }
            catch (Exception erro)
            {
                MessageBox.Show("ERRO AO CONECTAR VERIFIQUE OS DADOS" + erro);
                //Console.WriteLine("ERRO AO CONECTAR VERIFIQUE OS DADOS" + erro);
                return conn;
            }

        }

        public static List<string> Consultar_banco(NpgsqlConnection conexao, string consulta)
        {
            int i;
            List<string> comandos_disponiveis = new List<string>();
            //NpgsqlCommand cmd = new NpgsqlCommand("select distinct(logccomando_enviado) from log_comando where logceveprojeto=87;",conexao);
            NpgsqlCommand cmd = new NpgsqlCommand(consulta, conexao);
            try
            {
                NpgsqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    for (i = 0; i < rd.FieldCount; i++)
                    {
                        //Console.Write("{0} \t", rd[i]);
                        comandos_disponiveis.Add(rd[i].ToString());
                    }
                }
            }
            catch (NpgsqlException e)
            {
                Console.WriteLine("Erro " + e);
            }
            cmd.Dispose();
            //conn.Close();
            return comandos_disponiveis;
        }



        public static void Xml_gravar(string chamada, string strcomando, string parametros)
        {

            try
            {
                if (File.Exists(Environment.CurrentDirectory + "\\config.xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    // Create a new book element. 
                    doc.Load(Environment.CurrentDirectory + "\\config.xml");
                    Console.WriteLine(doc.InnerText);


                    XmlNode novocomando = doc.CreateElement("COMANDOS");

                    XmlElement xmlchamada = doc.CreateElement("chamada");
                    xmlchamada.InnerText = chamada;
                    novocomando.AppendChild(xmlchamada);

                    XmlElement xmlcomando = doc.CreateElement("stringcomando");
                    xmlcomando.InnerText = strcomando;
                    novocomando.AppendChild(xmlcomando);

                    XmlElement xmlparametro = doc.CreateElement("parametros");
                    xmlparametro.InnerText = parametros;
                    novocomando.AppendChild(xmlparametro);

                    XmlNode nodoRaiz = doc.DocumentElement;
                    nodoRaiz.InsertAfter(novocomando, nodoRaiz.LastChild);


                    Console.WriteLine(doc.InnerText);

                    doc.Save(Environment.CurrentDirectory + "\\config.xml");

                }
                else
                {
                    XmlTextWriter comandos = new XmlTextWriter(Environment.CurrentDirectory + "\\config.xml", Encoding.UTF8);
                    comandos.WriteStartDocument();

                    comandos.WriteStartElement("SERVIDORCOMANDOS");
                    comandos.WriteStartElement("COMANDOS");
                    comandos.WriteElementString("chamada", chamada.ToUpper());
                    comandos.WriteElementString("stringcomando", strcomando.ToUpper());
                    comandos.WriteElementString("parametros", parametros);
                    comandos.WriteEndElement();
                    comandos.WriteEndElement();
                    comandos.WriteEndDocument();

                    comandos.Close();
                    Console.WriteLine("XML CRIADO COM SUCESSO");
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao criar xml de comandos " + ex.Message);
            }

        }

        public static List<string> Lerxml()
        {
            XmlDocument doc = new XmlDocument();
            List<string> listacombo = new List<string>();
            doc.Load(Environment.CurrentDirectory + "\\config.xml");
            string comando;
            string qtdeparam;

            XmlNodeList listadecomandos = doc.SelectNodes("SERVIDORCOMANDOS/COMANDOS");
            XmlNode comandosxml;


            for (int i = 0; i < listadecomandos.Count; i++)
            {
                comandosxml = listadecomandos.Item(i);

                comando = comandosxml.SelectSingleNode("stringcomando").InnerText;
                listacombo.Add(comandosxml.SelectSingleNode("stringcomando").InnerText);
                qtdeparam = comandosxml.SelectSingleNode("parametros").InnerText;

                Console.Write("String do Comando: {0}, Qtde de Parametros: {1}, ID comando: {2}\n", comando, qtdeparam, i + 1);
            }

            return listacombo;
        }

        public static List<string> Lerxmlparam()
        {
            XmlDocument doc = new XmlDocument();
            List<string> listacombo = new List<string>();
            doc.Load(Environment.CurrentDirectory + "\\config.xml");
            string comando = "";
            string qtdeparam = "";

            XmlNodeList listadecomandos = doc.SelectNodes("SERVIDORCOMANDOS/COMANDOS");
            XmlNode comandosxml;


            for (int i = 0; i < listadecomandos.Count; i++)
            {
                comandosxml = listadecomandos.Item(i);

                comando = comandosxml.SelectSingleNode("stringcomando").InnerText;
                listacombo.Add(comandosxml.SelectSingleNode("parametros").InnerText);
                qtdeparam = comandosxml.SelectSingleNode("parametros").InnerText;

                //Console.Write("String do Comando: {0}, Qtde de Parametros: {1}, ID comando: {2}\n", comando, qtdeparam, i + 1);
            }

            return listacombo;
        }

        public static bool Cadastrarcomando()
        {
            bool parar = true;

            while (parar)
            {

                Console.WriteLine("PARA SAIR DIGITE 'EXIT' A QUALQUER MOMENTO" + "\r\n ______");

                Console.WriteLine("Digite a chamada do comando");
                string chamada = Console.ReadLine();

                if (chamada.ToUpper().CompareTo("EXIT") == 0)
                {
                    parar = false;
                }

                Console.WriteLine("Digite a string do comando");
                string comando = Console.ReadLine();

                if (comando.ToUpper().CompareTo("EXIT") == 0)
                {
                    parar = false;
                }

                Console.WriteLine("Digite a quantidade de parametros");
                string parametro = Console.ReadLine();

                if (parametro.ToUpper().CompareTo("EXIT") == 0)
                {
                    parar = false;
                }

                if (chamada != null && comando != null && parametro != null &&
                    chamada.ToUpper().CompareTo("EXIT") != 0 && comando.ToUpper().CompareTo("EXIT") != 0 && parametro.ToUpper().CompareTo("EXIT") != 0)
                {
                    Xml_gravar(chamada, comando, parametro);
                }

            }
            return true;
        }

        public void Enviacomando()
        {
            if (comboBox1.SelectedIndex >= 0 && textBoxip.Text.Length > 0 && textBoxporta.Text.Length > 0)
            {

                XmlDocument doc = new XmlDocument();
                TcpClient cliente = new TcpClient();
                List<string> listacomandosid = new List<string>();
                List<string> listaparametrosid = new List<string>();
                List<string> receberparamusu = new List<string>();
                string porta;


                doc.Load(Environment.CurrentDirectory + "\\config.xml");
                string linhacomandook = "";
                string retornodoservidor = "";
                XmlNodeList listadecomandos = doc.SelectNodes("SERVIDORCOMANDOS/COMANDOS");
                XmlNode comandosxml;

                string esn = labelesn.Text.Count() > 14 ? labelesn.Text : "359856070260130";

                for (int i = 0; i < listadecomandos.Count; i++)
                {
                    comandosxml = listadecomandos.Item(i);
                    listacomandosid.Add(comandosxml.SelectSingleNode("stringcomando").InnerText);
                    listaparametrosid.Add(comandosxml.SelectSingleNode("parametros").InnerText);
                }

                int iddigitado = comboBox1.SelectedIndex;

                string strenviarcomando = listacomandosid[iddigitado].ToUpper();
                int lerparametros = Convert.ToInt16(listaparametrosid[iddigitado]);

                if (listBoxParam.Items.Count != lerparametros)
                {
                    MessageBox.Show("VERIFIQUE OS PARAMETROS");
                }
                else
                {

                    if (lerparametros >= 1)
                    {
                        string todoparametro = "\r\n";
                        foreach (string paramtmp in listBoxParam.Items)
                        {
                            todoparametro += paramtmp + "\r\n";
                        }

                        linhacomandook = esn + " 12133 0 1 0 " + strenviarcomando + todoparametro;

                    }
                    else
                    {
                        linhacomandook = esn + " 12133 0 1 0 " + strenviarcomando + "\r\n\r\n ";
                    }

                }
                string ip = textBoxip.Text;
                porta = textBoxporta.Text;

                /*if (ip.ToUpper().CompareTo("DESENV") != 0)
                {
                Console.WriteLine("Digite a porta do quarto range");
                porta = Console.ReadLine();
                }*/

                try
                {
                    if (ip.ToUpper().CompareTo("DESENV") == 0)
                    {
                        cliente.Connect("10.1.110.20", 22224);
                    }
                    else
                    {
                        cliente.Connect(ip, Convert.ToInt32(porta));
                    }
                }
                catch (ArgumentNullException)
                {
                    MessageBox.Show("Argumento Nulo");
                    throw;
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Fora do Range");
                    throw;
                }
                catch (SocketException)
                {
                    MessageBox.Show("Erro ao abrir o Socket");
                    throw;
                }
                finally
                {

                    string V = linhacomandook;
                    byte[] comando;
                    byte[] retorno = new byte[28880];

                    ASCIIEncoding encoding = new ASCIIEncoding();
                    comando = encoding.GetBytes(V);

                    try
                    {
                        NetworkStream Comunicacao = cliente.GetStream();
                        textBoxretorno.Text += "Enviando comando " + V + "\r\n";
                        Comunicacao.Write(comando, 0, comando.Length);

                        Int32 tamby = Comunicacao.Read(retorno, 0, retorno.Length);

                        retornodoservidor = encoding.GetString(retorno, 0, tamby);


                        //Console.WriteLine(retornodoservidor);
                        textBoxretorno.Text += retornodoservidor + "\r\n";
                        Comunicacao.Close();

                        if (retornodoservidor == "7" || retornodoservidor.Contains("xml"))
                        {
                            textBoxretorno.Text += "saiu sem erros";
                        }
                        else
                        {
                            textBoxretorno.Text += "Verifique os erros";
                        }



                        
                    }
                    catch (Exception ex)
                    {
                        textBoxretorno.Text = ex.Message + "\r\n";
                    }

                    cliente.Dispose();
                    //if(a==10) Console.WriteLine(a);
                    //string v = a <= Convert.ToInt32(e) ? "imprimir A": "imprimir B";
                }

            }
            else
            {
                MessageBox.Show("Verifique o preenchimento dos campos");
            }


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show("id =" + comboBox1.SelectedIndex.ToString());

            if (Convert.ToInt32(Lerxmlparam()[comboBox1.SelectedIndex]) > 0)
            {
                MessageBox.Show("Esse comando precisa de " + Lerxmlparam()[comboBox1.SelectedIndex] + "\r\nparametros, adicione na lista abaixo");
            }
            else
            {
                MessageBox.Show("Esse comando não necessita de parametros");
            }
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Enviacomando();
        }

        
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBoxParam.Text != null && textBoxParam.Text != "")
            {
                listBoxParam.Items.Add(textBoxParam.Text);
                textBoxParam.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBoxParam.Items.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<string> consulaesn = new List<string>();
            consulaesn = Consultar_banco(Conectarpg("10.1.110.2", "5432", "postgres", "", "bdcentral")
            ,"select vscequesn from veiculo_sincroniza  where vscveiplaca like upper('" + textBoxplaca.Text + "');");
            labelesn.Text = consulaesn[0].ToString();
        }
    }
}
