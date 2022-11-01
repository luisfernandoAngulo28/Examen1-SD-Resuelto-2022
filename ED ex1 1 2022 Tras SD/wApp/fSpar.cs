using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cApp;

namespace wApp
{
    public partial class fSpar : Form
    {
        public fSpar()
        {
            InitializeComponent();
        }

        int[,] M = {
                     { 0, 4, 0 , 0, 0, 0 , 0},           
                     { 0, 0, 5 , 0, 0, 8 , 0}, 
                     { 0, 0, 0 , 3, 0, 0 , 6},
                     { 0, 0, 0 , 0, 0, 0 , 2},
                     { 0, 0, 3 , 5, 0, 0 , 0},
                     { 0, 0, 0 , 0, 0, 4 , 0},
                     { 9, 0, 0 , 0, 0, 0 , 0},
                   };

        clsSpar A = new clsSpar();
        clsSpar B = new clsSpar();
        private void fSpar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            A.n = 7;       // Fila de la matriz
            A.m = 7;       // Columna la matriz
            label1.Text=A.MostraArreglo(M);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            A = A.CopyAtoV(M);
            label2.Text = A.MostrarVector();
            label7.Text = "Ayudantia";
            
        }

        private void button5_Click_1(object sender, EventArgs e)

        {
            B = B.Traspose(A);                // Obtiene la matriz traspuesta en B a partir de A Sparce
            label3.Text = B.MostrarVector();
        }

    }
}
