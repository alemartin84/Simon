using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simon
{
    enum Estados
    {
        Arriba, 
        Abajo, 
        Derecha,
        Izquierda

    }
    public partial class Form1 : Form
    {

        Juego mySimon = new Juego();
                
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mySimon.posActual = 0;
            ArmarJuego();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //ACA TENGO QUE CAPTURAR LA TECLA APRETADA Y VER SI ERA LA ESPERADA EN LA LIST mySimon.estados
            //PRIMERO DEBERIA CONTAR HASTA QUE SE PRODUZCA UN ERROR, PARA CHEQUEAR LA POS DE LA LIST

           

            if ((timer1.Enabled == false)&&(mySimon.Ocupado==false)&&(mySimon.estados.Count>0))
            {
                if (keyData == Keys.Left)
                {
                    mySimon.estadoSolicitado = Estados.Izquierda;
                    timer1.Start();
                    buttonLeft.BackColor = Color.Orange;
                    SoundPlayer snd = new SoundPlayer(@"C:\Users\Ale\source\repos\Simon\Sonidos\4.wav");
                    snd.Play();
                    Chequear();

                    return true;

                }

                else if (keyData == Keys.Right)
                {
                    mySimon.estadoSolicitado = Estados.Derecha;
                    timer1.Start();
                    buttonRight.BackColor = Color.Green;
                    SoundPlayer snd = new SoundPlayer(@"C:\Users\Ale\source\repos\Simon\Sonidos\3.wav");
                    snd.Play();
                    Chequear();
                    return true;
                }

                else if (keyData == Keys.Up)
                {
                    mySimon.estadoSolicitado = Estados.Arriba;
                    timer1.Start();
                    buttonUp.BackColor = Color.Red;
                    SoundPlayer snd = new SoundPlayer(@"C:\Users\Ale\source\repos\Simon\Sonidos\1.wav");
                    snd.Play();
                    Chequear();
                    return true;
                }

                else if (keyData == Keys.Down)
                {
                    mySimon.estadoSolicitado = Estados.Abajo;
                    timer1.Start();
                    buttonDown.BackColor = Color.Yellow;
                    SoundPlayer snd = new SoundPlayer(@"C:\Users\Ale\source\repos\Simon\Sonidos\2.wav");
                    snd.Play();
                    Chequear();
                    return true;
                }
                return base.ProcessCmdKey(ref msg, keyData);
            }
            return true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (mySimon.estadoSolicitado == Estados.Izquierda)
            {
                buttonLeft.BackColor = Color.FromArgb(255, 192, 128);
                timer1.Stop();
            }

            else if (mySimon.estadoSolicitado == Estados.Derecha)
            {
                buttonRight.BackColor = Color.FromArgb(128, 255, 128);
                timer1.Stop();
            }

            else if (mySimon.estadoSolicitado == Estados.Arriba)
            {
                buttonUp.BackColor = Color.FromArgb(255, 128, 128);
                timer1.Stop();
            }

            else if (mySimon.estadoSolicitado == Estados.Abajo)
            {
                buttonDown.BackColor = Color.FromArgb(255, 255, 128);
                timer1.Stop();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
           

            if (mySimon.Ocupado)
            {
                if (mySimon.estados[mySimon.Mostrando] == Estados.Arriba) 
                {
                    buttonUp.BackColor = Color.Red;
                    buttonDown.BackColor = Color.FromArgb(255, 255, 128);
                    buttonRight.BackColor = Color.FromArgb(128, 255, 128);
                    buttonLeft.BackColor = Color.FromArgb(255, 192, 128);
                    SoundPlayer snd = new SoundPlayer(@"C:\Users\Ale\source\repos\Simon\Sonidos\1.wav");
                    snd.Play();
                    timerApagador.Start();
                }

                else if (mySimon.estados[mySimon.Mostrando] == Estados.Abajo)
                {
                    buttonUp.BackColor = Color.FromArgb(255, 128, 128);
                    buttonDown.BackColor = Color.Yellow;
                    buttonRight.BackColor = Color.FromArgb(128, 255, 128);
                    buttonLeft.BackColor = Color.FromArgb(255, 192, 128);
                    SoundPlayer snd = new SoundPlayer(@"C:\Users\Ale\source\repos\Simon\Sonidos\2.wav");
                    snd.Play();
                    timerApagador.Start();
                }
                else if (mySimon.estados[mySimon.Mostrando] == Estados.Derecha)
                {
                    buttonUp.BackColor = Color.FromArgb(255, 128, 128);
                    buttonDown.BackColor = Color.FromArgb(255, 255, 128);
                    buttonRight.BackColor = Color.Green;
                    buttonLeft.BackColor = Color.FromArgb(255, 192, 128);
                    SoundPlayer snd = new SoundPlayer(@"C:\Users\Ale\source\repos\Simon\Sonidos\3.wav");
                    snd.Play();
                    timerApagador.Start();
                }
                else if (mySimon.estados[mySimon.Mostrando] == Estados.Izquierda)
                {
                    buttonUp.BackColor = Color.FromArgb(255, 128, 128);
                    buttonDown.BackColor = Color.FromArgb(255, 255, 128);
                    buttonRight.BackColor = Color.FromArgb(128, 255, 128);
                    buttonLeft.BackColor = Color.Orange;
                    SoundPlayer snd = new SoundPlayer(@"C:\Users\Ale\source\repos\Simon\Sonidos\4.wav");
                    snd.Play();
                    timerApagador.Start();
                }
                
                


            }
            else
            {
                buttonUp.BackColor = Color.FromArgb(255, 128, 128);
                buttonDown.BackColor = Color.FromArgb(255, 255, 128);
                buttonRight.BackColor = Color.FromArgb(128, 255, 128);
                buttonLeft.BackColor = Color.FromArgb(255, 192, 128);
                timer2.Stop();
            }

            if (mySimon.Mostrando < mySimon.estados.Count() - 1)
            {
                mySimon.Mostrando++;
               
            }
            else
            {
                mySimon.Mostrando = 0;
                mySimon.Ocupado = false;
                /*
               
                */
            }
            
            
            
            //timer2.Stop();
        }

        private void ArmarJuego()
        {
            mySimon.Añadir();
            timer2.Start();
        }

        private void timerApagador_Tick(object sender, EventArgs e)
        {
            buttonUp.BackColor = Color.FromArgb(255, 128, 128);
            buttonDown.BackColor = Color.FromArgb(255, 255, 128);
            buttonRight.BackColor = Color.FromArgb(128, 255, 128);
            buttonLeft.BackColor = Color.FromArgb(255, 192, 128);
            timerApagador.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArmarJuego();
            
        }

        private void Chequear()
        {
            if (mySimon.estados[mySimon.posActual] == mySimon.estadoSolicitado)
            {
                //discernir si es el ultimo o uno intermedio para agregar o recorrer
                if (mySimon.posActual == mySimon.estados.Count() - 1) ArmarJuego(); //es el ultimo
                else mySimon.posActual++; //coincide pero no es el ultimo
            }
            else
            {
                mySimon.Reiniciar();
                MessageBox.Show("Perdiste! Dale a reiniciar");

            }


        }
    }
}
//TODO:
//IR RECORRIENDO EL ARRAY DE ESTADOS CON EL TIMER 2 PARA IR ILUMINANDO LAS TECLAS QUE CORRESPONDEN
//LUEGO DE ESO EN REALIDAD IR GENERANDO Y AGREGANDO A MEDIDA QUE SE APRETAN LAS SECUENCIAS