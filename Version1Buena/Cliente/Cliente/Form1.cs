using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace Cliente
{
    public partial class Form1 : Form
    {
        Socket server;
        string username;
        string username2;
        string password;
        string rusername, rpassword;
        bool finalizado = false;
       // int fila;
       // string invitacion;
        delegate void DelegadoParaEscribir(string text);
        delegate void DelegadoParaActualizarLista(string[] nombres, int num);
        delegate void DelegadoParaGroupBox();

        public void SetUsername(string usuario)
        {
            rusername = usuario;
        }
        public void SetPassword(string contraseña)
        {
            rpassword = contraseña;
        }

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {


        }


        private void conectar_Click(object sender, EventArgs e)
        {
            //Creamos un IPEndPoint con el ip del servidor y puerto del servidor 
            //al que deseamos conectarnos
            IPAddress direc = IPAddress.Parse("192.168.56.103");
            IPEndPoint ipep = new IPEndPoint(direc, 9211);


            //Creamos el socket 
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                server.Connect(ipep);//Intentamos conectar el socket
                this.BackColor = Color.Green;
                MessageBox.Show("Conectado");

            }
            catch (SocketException ex)
            {
                //Si hay excepcion imprimimos error y salimos del programa con return 
                MessageBox.Show("No he podido conectar con el servidor");
                return;
            }
        }

        private void desconectar_Click(object sender, EventArgs e)
        {
            //Mensaje de desconexión
            string mensaje = "0/";

            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            // Nos desconectamos
            this.BackColor = Color.Gray;
            server.Shutdown(SocketShutdown.Both);
            server.Close();

        }

        private void Registro_Click_1(object sender, EventArgs e)
        {
            while (finalizado == false)
            {
                Registro registro = new Registro();
                registro.eventousername += new Registro.DelegadoUsername(SetUsername);
                registro.eventopassword += new Registro.DelegadoPassword(SetPassword);
                registro.ShowDialog();

                string mensaje = "1/" + rusername + "/" + rpassword;
                // Enviamos al servidor el nombre tecleado
                byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
                server.Send(msg);
                byte[] msg2 = new byte[500];
                server.Receive(msg2);
                mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
                int registrado = Convert.ToInt32(mensaje);
                if (registrado == 1)
                {
                    MessageBox.Show("El nombre de usuario ya esta en uso");
                }
                else
                {
                    MessageBox.Show("Usuario registrado correctamente");
                    finalizado = true;
                }

            }
        }

        private void inicia_sesion_Click(object sender, EventArgs e)
        {
            username = nombre.Text;
            password = contraseña.Text;
            
            string mensaje = "2/" + username + "/" + password;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            byte[] msg2 = new byte[500];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            
            int registrado = Convert.ToInt32(mensaje);
            if (registrado == 1)
            {
                MessageBox.Show("Sesión iniciada correctamente");
            }
            else
            {
                MessageBox.Show("Datos incorrectos");
                finalizado = true;
            }

        }

        private void partidas_ganadas_Click_1(object sender, EventArgs e)
        {
            username = jugador1.Text;
            string mensaje = "3/" + username;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show(username+ " ha ganado: " + mensaje);
        }
        
        private void partida_maslarga_Click_1(object sender, EventArgs e)
        {
            username = jugador1.Text;
            string mensaje = "4/" + username;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show("La partida mas larga de " + username + " es la " + mensaje);

        }

        private void partida_compartidas_Click(object sender, EventArgs e)
        {
            username = jugador1.Text;
            username2 = jugador2.Text;

            string mensaje = "5/" + username + "/" + username2;
            byte[] msg = System.Text.Encoding.ASCII.GetBytes(mensaje);
            server.Send(msg);

            byte[] msg2 = new byte[80];
            server.Receive(msg2);
            mensaje = Encoding.ASCII.GetString(msg2).Split('\0')[0];
            MessageBox.Show("La partida compartida por " + username + " y " + username2 + " es: " + mensaje);

        }

        private void nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void contraseña_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
