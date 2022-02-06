using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MergeSort
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] array1 = new int[10] { 5, 3, 4, 1, 3, 6, 8, 1, 10, 7 };
        int[] array2 = new int[10] { 9, 3, 8, 1, 3, 7, 8, 0, 2, 10 };
        public MainWindow()
        {
            InitializeComponent();
        }

        //Merge sort con recursividad
        private void btnOrdenar_Click(object sender, RoutedEventArgs e)
        {
            Stopwatch tiempo = Stopwatch.StartNew();
   
            int n=array1.Length;             //Agarramos el tamaño del array

            for (int i = 0; i < n; i++)     //Mostramos el array desordenado
            {
                txtmostrar.AppendText(" " + array1[i]);
            }

            merge_sort(0, n - 1);           //Ejecutamos merge_sort para ordenar el array.
                                            //Parametros(indice menor, indice mayor-1) del array.

            for (int i = 0; i < n; i++)     //Mostramos  el array  ordenado
            {
                txtmostrarO.AppendText(" " + array1[i]);
            }
            tiempo.Stop();
            MessageBox.Show("TIEMPO: " + tiempo.Elapsed.Milliseconds.ToString() + " ms");
        }

        public void merge_sort(int low, int high)
        {
            int mid;                            //Definimos una variable entera
            if (low != high)                    //El primer índice es menor al último índice?
            {
                mid = (low + high) / 2;         //la variable mid almacena el índice 
                                                //que se encuentra a la mitad de nuestro array
                merge_sort(low, mid);           //El método se incoca a si mismo para seguir dividiendo la primera mitad
                merge_sort(mid + 1, high);      //El método se invoca a si mismo para seguir dividiendo la segunda mitad
                merge(array1, low, mid, high);   //Llamamos al método merge() para ordenar el array
            }
        }

        public void merge(int[] array, int low, int mid, int high)
        {
	        int[] temp=new int[array.Length];   //creamos un arreglo temporal
	        int i = low;                        //iniciamos i con el valor del primer índice
	        int j = mid + 1;                    //iniciamos j con el valor del índice medio +1
	        int k = low;                        //iniciamos k con el valor del primer índice
      
	        while( (i <= mid) && (j <=high) )   //Iteramos miestras i sea menor del índice medio 
                                                //y j sea menor al último índice
	        {
		        if(array[i] <= array[j])        //Si el valor del array en la posicion i es menor o igual
                                                //al valor del array en la posicion j
			        temp[k++] = array[i++] ;    //le asiga el valor de array en la posicion i++ 
                                                //en nuestro arreglo temporal en la posicion k++
		        else
			        temp[k++] = array[j++] ;    //sino asigna el valor de array en la posicion j++
                                                //en el arreglo temporal en la posicion k++
	        }
	
	        while( i <= mid )               //mientras i sea menor o igual al índice el medio
            {
                temp[k++]=array[i++];       //asigna el valor de array en la posicion i++ en el arreglo temporal
            }
		        
	
	        while( j <= high )              //miestras j sea menor o igual al último índice
            {
                temp[k++]=array[j++];       //asigna el valor de array en la posicion j++ en el arreglo temporal
            }
		        

	        for(i= low; i <= high ; i++)    //mientras i sea menor o igual al valor del último índice
            {
                array[i]=temp[i];           //pasamos los elementos del arreglo temporal a array
            }
		        
	
        }

        //Merge Sort sin recursiva
        private void btnOrdenar1_Click(object sender, RoutedEventArgs e) 
        {
            TimeSpan stop;
            TimeSpan start = new TimeSpan(DateTime.Now.Ticks);

            
            int[] temp = new int[array2.Length];         //Creamos un arreglo temporal del mismmo tamaño que array
            int i,j,k,n=array2.Length,size,l1,h1,l2,h2;  //i,j,k,size son contadores de los ciclos.
                                                        //n agarra el tamaño del vector desordenado.
                                                        //l1,h1,l2,h2 son variables auxiliares.
            //Mostramos el array desordenado
	        for( i = 0 ; i<n ; i++)
            {
               txtmostrar1.AppendText(" " + array2[i]);
            }

            //size es un contador que repite este ciclo hasta que se encuentra en la mitad
	        for(size=1; size < n; size=size*2 )
	        {
                l1 = 0;                     //l1 es el primer índice del primer par y asi sucesivamente
		        k=0;                        //índice para el array temporal
		        while( l1+size < n)         //miestras el primer índice mas size sea menor al nro de elementos del array
		        {
			        h1=l1+size-1;           //
			        l2=h1+1;
			        h2=l2+size-1;
			        if( h2>=n )             //si h2 excede el límite del array
				        h2=n-1;             //se asigna el tamaño del array menos uno a h2
			
			        /*Merge the two pairs with lower limits l1 and l2*/
			        i=l1;
			        j=l2;
			
			        while(i<=h1 && j<=h2 )
			        {
				        if( array2[i] <= array2[j] )
					        temp[k++]=array2[i++];
				        else
					        temp[k++]=array2[j++];
			        }
			
			        while(i<=h1)
				        temp[k++]=array2[i++];
			        while(j<=h2)
				        temp[k++]=array2[j++];
			        /**Merging completed**/
			        /*Take the next two pairs for merging */
			        l1=h2+1; 
		        }/*End of while*/

		        /*any pair left */
		        for(i=l1; k<n; i++) 
			        temp[k++]=array2[i];

		        for(i=0;i<n;i++)
			        array2[i]=temp[i];

		
	        }

            for (i = 0; i < n; i++)
                txtmostrarO1.AppendText(" " + array2[i]);

            stop = new TimeSpan(DateTime.Now.Ticks);
            MessageBox.Show((stop.Subtract(start).TotalMilliseconds).ToString() +" ms");
        }
    }
}
