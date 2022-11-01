using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cApp
{
    public class clsSpar
    {
         /*ATRIBUTOS*/
       
        const int Max=1000;                         // Maxima Cantidad de elementos en el arreglo V alternativo
        public int[,] V = new int[Max,3];           // Vector donde se almacena los datos de las Matris A original
        public int Cant = 0;                        // Cantidad de celdas llenas en el vector V
        public int m = 0;                           // Cantidad de columnas de la Matriz A original
        public int n = 0;                           // Cantidad de filas de la Matriz A original
     

        /*CONSTRUCTORES*/
        public clsSpar() 
        { 
            Cant = 0;
            n= 0;
            m = 0;
            int i = 0;
            while (i < Max)
            {
               V[i, 0] = 0;
               V[i, 1] = 0;
               V[i, 2] = 0;  
               i++;
            }
        }
        
        public clsSpar(clsSpar x)
        {
            Cant = x.Cant;
            n = x.n;
            m = x.m;
            int i = 0;  
            while (i < Max)
            {
               V[i, 0] = x.V[i, 0];
               V[i, 1] = x.V[i, 1];
               V[i, 2] = x.V[i, 2];
               i++;
            }
        }

        // Limpiar el Arreglo V 
        public void ClearArreglo()
        {
            int i = 0; Cant = 0;
            while (i < Max)
            {
                V[i, 0] = 0;
                V[i, 1] = 0;
                V[i, 2] = 0;  
                i++;
            }
        }
     
        // Funcion para mostrar la Matriz A 
        public string MostraArreglo(int[,] M)
        {
            int i, j = 0;
            string cad = "";
            for (i = 0; i < n; i++)
            {
                cad += "\n";
                for (j = 0; j < m; j++)
                    cad += "[" + M[i, j] + "]";
            }
            return cad;
        }


 	// Funcion para mostrar Vector V 
        public string MostrarVector()
        {
            string s = "";
            
            for (int i = 0; i <= Cant; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                s += " [" + V[i,j] + "]" ; 
                }
                s += "\n";
            }
            return s;
        }





        //Escriba AQUI las funciones solictadas
        //
        public clsSpar CopyAtoV(int[,] A)
        {
           
            clsSpar S = new clsSpar();
            S.n = A.GetLength(0);//filas
            S.m = A.GetLength(1);//columnas
            S.Cant = 1;

            S.V[0, 0] = S.n;
            S.V[0, 1] = S.m;
            //Recorremos las filas
            for (int i = 0; i < S.n; i++)
            {
                //Recorremos las columnas
                for (int j = 0; j < S.m; j++)
                {
                    if(A[i,j]!=0 && A[i, j] > 0)
                    {
                        S.V[S.Cant, 0] = i;  // filas
                        S.V[S.Cant, 1] = j;//columnas
                        S.V[S.Cant, 2] = A[i, j];//datos o valores
                        S.Cant++;
                    }
                }
            }
            S.Cant = S.Cant - 1;
            S.V[0, 2] = S.Cant;


            return S;
        }
        //matrizSparcida va de orden de las filas
        //matrizSparcidaTranspuesta va de orden de las columnas

        public clsSpar Traspose(clsSpar A)
        {   //primero hacemos copia
            clsSpar S =  new clsSpar();
            S.n = A.n;//filas
            S.m = A.m;//columnas
            S.Cant = A.Cant;

            S.V[0, 0] = S.m;
            S.V[0, 1] = S.n;
            S.V[0, 2] = S.Cant;
            int pos = 1;
            //Recorremos las columnas
            for (int j = 0; j < S.m; j++)
            {
                //Recorremos las filas
                for (int i = 0; i < S.n; i++)
                {
                    for (int k = 1; k <=S.Cant; k++)
                    {
                        if (i == A.V[k, 0] && j == A.V[k, 1])
                        {
                            //Asigna Valores a las casillas
                            S.V[pos, 0] = j;//columnas
                            S.V[pos, 1] = i; //filas
                            S.V[pos, 2] = A.V[k, 2];
                            pos++;

                        }
                    }

                }

            }



            return S;
        }
        
    }
    }


