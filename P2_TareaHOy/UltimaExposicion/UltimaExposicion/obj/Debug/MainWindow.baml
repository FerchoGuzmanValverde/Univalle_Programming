   M S B A M L   `   `   `  ����K  GUltimaExposicion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:UltimaExposicionUltimaExposicion  5   	   !    UltimaExposicion.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:UltimaExposicion     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   R� $
��Left=�6   $	��117��6.   $��	24,10,0,0q�6;   $	��Top=�6N   $	��185��6f   .@�5      Q� ��5      �� 5       �� Orientation$ 
Horizontal=�6!   .+�5      �� $��Proyecto��6$   5      .@�5      Q� ��5      �� 5      $ 
Horizontal=�6%   .+�5      �� $��DateTimePicker��6(   5      5      Q� 5       Q� 
IsExpanded . ��5      �� 5      $ 
Horizontal=�6%   .+�5      �� $��DataGrid��6(   5      5      Q� 5      ��5       �� 5!      $ 
Horizontal=�6%   .+�5"      �� $��ListView��6(   5#      5%      5&      5'      &   System.Windows.Controls.DataGrid  5(   
   -   5          Name$ MiGrid��5(      $
��Left=�6#   $	��108��6>   $��
24,166,0,0q�6K   $	��Top=�6_   $	��261��6w      Columns 5)      0  *System.Windows.Controls.DataGridTextColumn  5*      ,  &System.Windows.Controls.DataGridColumn   Header$ Nombre��6%   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   �� *ID+5,      �� 5-   
   $��Nombre��6   $
��Left=�6!   $��
30,300,0,0q�6<   $	��Top=�6P   �� 5.   
   $��Primer Apellido��6   $
��Left=�6*   $��
30,331,0,0q�6E   $	��Top=�6Y   �� 5/   
   $��Segundo Apellido��6   $
��Left=�6+   $��
30,362,0,0q�6F   $	��Top=�6Z   �� 50   
   -   5         ��Name$ 	txtnombre��50      $
��Left=�6%   $��23��6@   $��165,304,0,0q�6L    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��120��6�   �� 51   
   -   5        $ 
txtprimero��51      $
��Left=�6&   $��23��6A   $��165,335,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 52   
   -   5        $ 
txtsegundo��52      $
��Left=�6&   $��23��6A   $��165,366,0,0q�6M   $
 Wrap=�6b   $	��Top=�6v   $	��120��6�   �� 53   
   -   5        	 ��Name$	 
btnagregar��53      $��Agregar��6%   $
��Left=�67   $��317,331,0,0q�6R   $	��Top=�6g   $��75��6   6�   �� 54   
   -   5        $	 btninsertar��54      $��Insertar��6&   $
��Left=�69   $��
393,25,0,0q�6T   $	��Top=�6h   $��75��6�   6�   �� 55   
   -   5        $ txtitem��55      $
��Left=�6#   $��23��6>   $��
487,25,0,0q�6J   $
 Wrap=�6^   $	��Top=�6r   $	��120��6�   �� 56   
   -   5        
 ��Name$
 MiView��56      $
��Left=�6#   $	��166��6>   $��
410,71,0,0q�6K   $	��Top=�6_   $	��168��6w    �� View 57      �� 58      .P�59      �� 5:      5<      (  "System.Windows.Controls.DatePicker  5=   
   -	   5          Name$ Midate��5=      $
��Left=�6%   $��505,304,0,0q�6@   $	��Top=�6U   $��54��6m   $	��173��6y   5?      �� 5@   
   -
   5        $	 
btnmostrar��5@      $��Mostrar��6%   $
��Left=�67   $��559,366,0,0q�6R   $	��Top=�6g   $��75��6   6�   5A      5B      