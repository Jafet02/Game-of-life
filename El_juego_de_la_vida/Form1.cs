using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace El_juego_de_la_vida
{
    public partial class Form1 : Form
    {
        const int T=16;
        public Form1()
        {
            InitializeComponent();
        }


        PictureBox[,] matrix = new PictureBox[T, T];
        int[,] vida = new int[T, T];
        int[,] sig_gen = new int[T, T];
        int[,] vecino = new int[T, T];


        //Metodo para inicializar los picturesBox
        public void inicializar_tablero()
        {
            int i, j;
            for (i = 0; i <= 15; i++)
            {
                for(j = 0; j <= 15; j++)
                {
                    matrix[i, j] = new PictureBox();
                    Controls.Add(matrix[i, j]);
                    matrix[i, j].Width = 40;
                    matrix[i, j].Height =40;
                    matrix[i, j].Click += new EventHandler(this.Cambio_Click);
                    if(j == 0)
                        matrix[i, j].Left = 100;
                    matrix[i, j].Top = 40 * i;
                    matrix[i, j].Left = 100 + (40 * j);
                }
            }
        }


        //Establecer posiciones iniciales (imagenes)
        private void Cambio_Click(object sender, EventArgs e)
        {

            string index;
            PictureBox clickedPicture = (PictureBox)sender;
            index = clickedPicture.BackColor.ToString();

            switch(index)
            {
                case "Color [White]": clickedPicture.BackColor = Color.Blue;
                    clickedPicture.Image = Image.FromFile("vivo.png");
                    break;

                case "Color [Blue]":  clickedPicture.BackColor = Color.Green;
                    clickedPicture.Image = Image.FromFile("feliz.png");
                    break;

                case "Color [Green]":
                    clickedPicture.BackColor = Color.White;
                    clickedPicture.Image = Image.FromFile("muerto.png");
                    break;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inicializar_tablero();
            Vida_inicio();
        }

        //Estado inicial       (imagenes)
        public void Vida_inicio()
        {
            int i, j;
            for (i = 0; i <= 15; i++)
            {
                for (j = 0; j <= 15; j++)
                {
                    vida[i, j] = 0;
                    matrix[i, j].BackColor = Color.White;
                    matrix[i, j].Image = Image.FromFile("muerto.png");
                }
            }
        }


        public void Evaluar_vecinos()
        {
            int indicer, indicec;
            int i, j;
            for (i = 0; i <= 15; i++)
            {
                for (j = 0; j <= 15; j++)
                {
                    //4 reglas
                    indicer = i;
                    indicec = j;

                    //8 vecinos a evaluar
                    vecino[i, j] = 0;

                    if (i == 0) 
                    {
                        if (j == 0) 
                        {
                            //5, 7, 8
                            //5
                            if (vida[indicer, indicec + 1] == 1 || vida[indicer, indicec + 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //7
                            if (vida[indicer + 1, indicec] == 1 || vida[indicer + 1, indicec] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //8
                            if (vida[indicer + 1, indicec + 1] == 1 || vida[indicer + 1, indicec + 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                        }
                        if (j == 15) 
                        {
                            //4, 6, 7
                            //4
                            if (vida[indicer, indicec - 1] == 1 || vida[indicer, indicec - 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //6
                            if (vida[indicer + 1, indicec - 1] == 1 || vida[indicer + 1, indicec - 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //7
                            if (vida[indicer + 1, indicec] == 1 || vida[indicer + 1, indicec] == 2)
                            {
                                vecino[i, j]++;
                            }

                        }
                        if (j != 0 && j != 15) 
                        {
                            ////4, 5, 6, 7, 8
                            //4
                            if (vida[indicer, indicec - 1] == 1 || vida[indicer, indicec - 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //5
                            if (vida[indicer, indicec + 1] == 1 || vida[indicer, indicec + 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //6
                            if (vida[indicer + 1, indicec - 1] == 1 || vida[indicer + 1, indicec - 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //7
                            if (vida[indicer + 1, indicec] == 1 || vida[indicer + 1, indicec] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //8
                            if (vida[indicer + 1, indicec + 1] == 1 || vida[indicer + 1, indicec + 1] == 2)
                            {
                                vecino[i, j]++;
                            }

                        }
                    }
                    if (i == 15)
                    {
                        if (j == 0)
                        {
                            //2, 3, 5
                            //2
                            if (vida[indicer - 1, indicec] == 1 || vida[indicer - 1, indicec] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //3
                            if (vida[indicer - 1, indicec + 1] == 1 || vida[indicer - 1, indicec + 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //5
                            if (vida[indicer, indicec + 1] == 1 || vida[indicer, indicec + 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                        }
                        if (j == 15)
                        {
                            //1, 2, 4
                            //1
                            if (vida[indicer - 1, indicec - 1] == 1 || vida[indicer - 1, indicec - 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //2
                            if (vida[indicer - 1, indicec] == 1 || vida[indicer - 1, indicec] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //4
                            if (vida[indicer, indicec - 1] == 1 || vida[indicer, indicec - 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                        }
                        if (j != 0 && j != 15)
                        {
                            ////1, 2, 3, 4, 5
                            //1
                            if (vida[indicer - 1, indicec - 1] == 1 || vida[indicer - 1, indicec - 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //2
                            if (vida[indicer - 1, indicec] == 1 || vida[indicer - 1, indicec] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //3
                            if (vida[indicer - 1, indicec + 1] == 1 || vida[indicer - 1, indicec + 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //4
                            if (vida[indicer, indicec - 1] == 1 || vida[indicer, indicec - 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                            //5
                            if (vida[indicer, indicec + 1] == 1 || vida[indicer, indicec + 1] == 2)
                            {
                                vecino[i, j]++;
                            }
                        }
                    }

                    if (j == 0 && i != 0 && i != 15)
                    {
                        //2, 3, 5, 7, 8
                        //2
                        if (vida[indicer - 1, indicec] == 1 || vida[indicer - 1, indicec] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //3
                        if (vida[indicer - 1, indicec + 1] == 1 || vida[indicer - 1, indicec + 1] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //5
                        if (vida[indicer, indicec + 1] == 1 || vida[indicer, indicec + 1] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //7
                        if (vida[indicer + 1, indicec] == 1 || vida[indicer + 1, indicec] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //8
                        if (vida[indicer + 1, indicec + 1] == 1 || vida[indicer + 1, indicec + 1] == 2)
                        {
                            vecino[i, j]++;
                        }
                    }

                    if(j==15 && i!=0 && i!=15)
                    {
                        //1, 2, 4, 6, 7
                        //1
                        if (vida[indicer - 1, indicec - 1] == 1 || vida[indicer - 1, indicec - 1] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //2
                        if (vida[indicer - 1, indicec] == 1 || vida[indicer - 1, indicec] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //4
                        if (vida[indicer, indicec - 1] == 1 || vida[indicer, indicec - 1] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //6
                        if (vida[indicer + 1, indicec - 1] == 1 || vida[indicer + 1, indicec - 1] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //7
                        if (vida[indicer + 1, indicec] == 1 || vida[indicer + 1, indicec] == 2)
                        {
                            vecino[i, j]++;
                        }
                    }

                    if (i != 0 && i != 15 && j != 0 && j != 15)
                    {
                        //todas
                        //1
                        if (vida[indicer - 1, indicec - 1] == 1 || vida[indicer - 1, indicec - 1] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //2
                        if (vida[indicer - 1, indicec] == 1 || vida[indicer - 1, indicec] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //3
                        if (vida[indicer - 1, indicec + 1] == 1 || vida[indicer - 1, indicec + 1] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //4
                        if (vida[indicer, indicec - 1] == 1 || vida[indicer, indicec - 1] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //5
                        if (vida[indicer, indicec + 1] == 1 || vida[indicer, indicec + 1] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //6
                        if (vida[indicer + 1, indicec - 1] == 1 || vida[indicer + 1, indicec - 1] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //7
                        if (vida[indicer + 1, indicec] == 1 || vida[indicer + 1, indicec] == 2)
                        {
                            vecino[i, j]++;
                        }
                        //8
                        if (vida[indicer + 1, indicec + 1] == 1 || vida[indicer + 1, indicec + 1] == 2)
                        {
                            vecino[i, j]++;
                        }
                    }
                }//for j
            }//For i

        }

        public void Evaluar_estado()
        {
            string index;
            int i, j;
            for (i = 0; i <= 15; i++)
            {
                for (j = 0; j <= 15; j++)
                {
                    index = matrix[i, j].BackColor.ToString();
                    switch( index )
                    {
                        case "Color [White]":
                            vida[i, j] = 0;
                            break;

                        case "Color [Blue]":
                            vida[i, j] = 1;
                            break;

                        case "Color [Green]":
                            vida[i, j] = 2;
                            break;
                        default:
                            vida[i, j] = 0;
                            break;
                    }

                }
            }
        }

        //Imagenes
        public void Nueva_generacion()
        {
            int i, j;
            int listo = 0;
            for (i = 0; i <= 15; i++)
            {
                for (j = 0; j <= 15; j++)
                {

                    //Regla 1
                    if (vida[i, j] == 0 && vecino[i, j] == 3 && listo == 0)
                    {
                        vida[i, j] = 1;
                        matrix[i, j].BackColor = Color.Blue;
                        matrix[i, j].Image = Image.FromFile("vivo.png");
                        listo = 1;
                    }

                    //Regla 2
                    //Si esta feliz permanece vivo a la siguiente
                    if (vida[i, j] == 1 && (vecino[i, j] == 2 || vecino[i, j] == 3) && listo == 0)
                    {
                        vida[i, j] = 2;
                        matrix[i, j].BackColor = Color.Green;
                        matrix[i, j].Image = Image.FromFile("feliz.png");
                        listo = 1;
                    }
                    if (vida[i, j] == 2 && listo == 0)
                    {
                        vida[i, j] = 1;
                        matrix[i, j].BackColor = Color.Blue;
                        matrix[i, j].Image = Image.FromFile("vivo.png");
                        listo = 1;
                    }
                    //Regla 3
                    if (vida[i, j] == 1 && vecino[i, j] < 2 && listo == 0)
                    {
                        vida[i, j] = 0;
                        matrix[i, j].BackColor = Color.White;
                        matrix[i, j].Image = Image.FromFile("muerto.png");
                        listo = 1;
                    }

                    //Regla 4
                    if (vida[i, j] == 1 && vecino[i, j] > 3 && listo == 0)
                    {
                        vida[i, j] = 0;
                        matrix[i, j].BackColor = Color.White;
                        matrix[i, j].Image = Image.FromFile("muerto.png");
                        listo = 1;
                    }
                    listo = 0;
                }
            }
        }

        private void button_ngen_Click(object sender, EventArgs e)
        {
            Evaluar_estado();
            Evaluar_vecinos();
            Nueva_generacion();
        }

        private void buttonreinicio_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Vida_inicio();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Evaluar_estado();
            Evaluar_vecinos();
            Nueva_generacion();
        }

        private void ButtonSucesivas_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonpase_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
