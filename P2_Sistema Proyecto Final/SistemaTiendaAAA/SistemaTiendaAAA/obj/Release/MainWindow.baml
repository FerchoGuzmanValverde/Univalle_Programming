   M S B A M L   `   `   `  ���� K  GSistemaTiendaAAA, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:SistemaTiendaAAASistemaTiendaAAA  !    SistemaTiendaAAA.MainWindow   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     0localclr-namespace:SistemaTiendaAAA     -     � Title$  Multiservicios��$	��776��$
��1138�� � Icon$# Imagenes/onlineshop_78377.ico��.��� ����  �� ImageSource$ Imagenes/1.jpg�� � RowDefinitions �� $��1* ��� $	��10* ��� $��1* �.+��� $��Multiservicios��$��Center=�$��Center=�$��46��$	��325��$��Rockwell Extra Bold)�$��36(�$��1��$��307,6,310,10q�
��������� $��1��$��Segoe UI Black)�$��3��
������ 
�������.@��� $��Ventas��$��Center=�$��14(�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.���  � Color$ Black�� � Offset$ 0Q�� $ 	#FF28F9F9��$ 1Q�� $ 	#FEFFFFFF��.��� -   .+��� $��Producto��$
��Left=�$	��305��$��3,10,0,0q�$	��Top=�$	��424��$��1��
�������$��Arial Black)�$��16(�.��� $
��Left=�$	��271��$��
10,10,-2,0q�$	��Top=�$	��404��.+��� $��Tipo Producto:��$
��Left=�$��30,8,0,0q�$	��Top=�
�������$��Arial Black)�$��16(��� -    ��Name$ cbxtipoProducto��$
��Left=�$��
205,10,0,0q�$	��Top=�$	��177��$��26��$��Arial Narrow)�$��14(�.@��� 	 �� 
IsSelected	 . .��Videos�� .��	Gadgets�� .��Ropa�� .��	Bijuteria�� .��Accesorios Hogar�� .��Comics�� .��	Golosinas�� .��Otros�� $��	Cantidad:��$
��Left=�$��
30,110,0,0q�$	��Top=�
�������$��Arial Black)�$��16(��� -   
 ��Name$
 txtCantidadItems��$
��Left=�$��23��$��205,115,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��177��$��Arial Narrow)�$��14(��� -    ��Name$ btnAgregarItem��$��Agregar��$
��Left=�$��
70,221,0,0q�$	��Top=�$��98��$��40��$��Arial Black)�$��16(� � UseLayoutRounding .  $��0,1,1,1q� J� RenderTransformOrigin$ 0.5,0.5&����� $ 0.5,1&�$ 0.5,0&�.��� $ White��$ 0Q�� $ 	#FF0FF4FF��$ 1Q� � LayoutTransform V� .~��� �� �� T�  T� X$ 50Q� T� Y$ 50Q��� $��Nombre Producto:��$
��Left=�$��	30,58,0,0q�$	��Top=�
�������$��Arial Black)�$��16(��� -   $
 txtNombreProducto��$
��Left=�$��23��$��
205,63,0,0q�$
 Wrap=�$	��Top=�$	��177��$��Arial Narrow)�$��14(��� $��Precio:��$
��Left=�$��
30,172,0,0q�$	��Top=�
�������$��Arial Black)�$��16(��� -   $
 txtPrecioProducto��$
��Left=�$��23��$��205,177,0,0q�$
 Wrap=�$	��Top=�$	��177��$��Arial Narrow)�$��14(��� -   $ btnEliminarProducto��$��Eliminar��$
��Left=�$��240,221,0,0q�$	��Top=�$��98��$��40������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF50E5F3��$ 0.935Q�� $ White��&   System.Windows.Controls.DataGrid  -	     Name$ dtgProducto��$
��Left=�$	��167��$��	3,346,0,0q�$	��Top=�$	��458��   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$	 Nro��   Width5  /System.Windows.Controls.DataGridLengthConverter$ 1*    
FontFamily$ Arial Narrow)�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *Numero+  $ Tipo Producto��$ 2* $ Arial Narrow)� �� *TipoProducto+  $ Nombre Producto��$ 2* $ Arial Narrow)� �� *NombreProducto+  $ Precio��$ 2* $ Arial Narrow)� �� *PrecioUnitario+�� $��Total Venta:��$
��Left=�$��355,518,0,0q�$	��Top=�$��1��
�������$��Arial Black)�$��16(��� -
    ��Name$ lblTotalVenta��$	��---��$
��Left=�$��493,518,0,0q�$	��Top=�
�������$��Arial Black)�$��16(�$	��174���� -   $ btnNuevaVenta��$��Nueva Venta��$
��Left=�$��721,384,0,0q�$	��Top=�$	��176��$��82��$��Arial Black)�$��16(�$	 1,1&����� $ 0.5,1&�$ 0.5,0&�.��� $ White��$ 0Q�� $ 	#FF0FF4FF��$ 1Q� V� .~��� �� �� T� $ 50Q�$ 50Q��� $��Cliente��$
��Left=�$	��305��$��
493,10,0,0q�$	��Top=�$	��428��$��1��
�������$��Arial Black)�$��16(�.��� $
��Left=�$	��266��$��	10,10,0,0q�$	��Top=�$	��394��.+��� $��	Telefono:��$
��Left=�$��	32,44,0,0q�$	��Top=�
�������$��Arial Black)�$��16(��� -   $
 txtTelfCliente��$
��Left=�$��23��$��
144,49,0,0q�$
 Wrap=�$	��Top=�$	��192��$��Arial Narrow)�$��14(��� $��Nombre:��$
��Left=�$��	32,97,0,0q�$	��Top=�$��88��
�������$��Arial Black)�$��16(��� -   $ btnVerificarCliente��$��	Verificar��$
��Left=�$��
64,175,0,0q�$	��Top=�$	��108��$��41��$��Arial Black)�$��16(�$	 1,1&����� $ 0.5,1&�$ 0.5,0&�.��� $ White��$ 0Q�� $ 	#FF0FF4FF��$ 1Q� V� .~��� �� �� T� $ 50Q�$ 50Q��� -   $ btnRegistrarCliente��$��	Registrar��$
��Left=�$��222,175,0,0q�$	��Top=�$	��114��$��41��$��Arial Black)�$��16(�$	 1,1&����� $ 0.5,1&�$ 0.5,0&�.��� $ White��$ 0Q�� $ 	#FF0FF4FF��$ 1Q� V� .~��� �� �� T� $ 50Q�$ 50Q��� -   $
 txtNombreCliente��$
��Left=�$��23��$��144,102,0,0q�$
 Wrap=�$	��Top=�$	��192��$��Arial Narrow)�$��14(�  -   $ 
dtgDetalle��$
��Left=�$	��167��$��461,346,0,0q�$	��Top=�$	��206��   $ Cantidad��$ 2* $ Arial Narrow)� �� *
Cantidad+  $ Total��$ 2* $ Arial Narrow)� �� *TotalProducto+�� $��
Gift Cards��$��Center=�$��14(����� $ 0.5,1&�$ 0.5,0&�.��� $ Black��$ 0Q�� $ 	#FF28F9F9��$ 1Q�� $ 	#FEFFFFFF��.��� -   .+��� $��	Gift Card��$
��Left=�$	��298��$��8,26,0,0q�$	��Top=�$	��424��
�������$��Arial Black)�$��16(�.��� $
��Left=�$	��258��$��
10,10,-2,0q�$	��Top=�$	��404��.+��� $��Tipo Tarjeta:��$
��Left=�$��	15,32,0,0q�$	��Top=�
��������� -   $ cbxTipoTarjeta��$
��Left=�$��
155,34,0,0q�$	��Top=�$	��216��$��26��$��Arial Narrow)�$��14(�.@��� 	 . .��Google Play�� .��iTunes�� .��Steam�� .��PlayStation�� .��XBox�� .��	Minecraft�� .��
Blizzard�� $��Codigo:��$
��Left=�$��
15,141,0,0q�$	��Top=�
��������� -   $
 txtCodigoTarjeta��$
��Left=�$��23��$��155,146,0,0q�$
 Wrap=�$	��Top=�$	��216��$��Arial Narrow)�$��14(� �� CharacterCasing$ Upper=��� -   $ btnAgregarTarjeta��$��Agregar��$
��Left=�$��
58,190,0,0q�$	��Top=�$��98��$��40������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF50E5F3��$ 0.935Q�� $ White���� $��Valor:��$
��Left=�$��	15,90,0,0q�$	��Top=�
��������� -   $ cbxValorTarjeta��$
��Left=�$��
155,94,0,0q�$	��Top=�$	��216��$��Arial Narrow)�$��14(�.@��� 	 . .��10$�� .��15$�� .��20$�� .��25$�� .��50$�� .��100$�� .��Plus 3 Meses�� .��Plus 12 Meses�� .��Gold 3 Meses�� .��Gold 12 Meses�� .��Premium 26.95$�� -   $ btnEliminarTarjeta��$��Eliminar��$
��Left=�$��216,190,0,0q�$	��Top=�$��98��$��40������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF50E5F3��$ 0.935Q�� $ White��  -   $ dtgDetalleCard��$
��Left=�$	��167��$��	8,347,0,0q�$	��Top=�$	��768��$��1��   $	 Nro��$ 1*  �� *Numero+  $ Tipo Tarjeta��$ 2* $ Arial Narrow)� �� *TipoTarjeta+  $ Valor��$ 2* $ Arial Narrow)� �� *Valor+  $ Codigo��$ 2* $ Arial Narrow)� �� *Codigo+  $ Costo Bs��$ 2* $ Arial Narrow)� �� *
PrecioBS+  $ Comision��$ 2* $ Arial Narrow)� �� *
Comision+�� $��Total Venta:��$
��Left=�$��504,519,0,0q�$	��Top=�$��1��
�������$��Arial Black)�$��16(��� -   $ lblTotalCodigos��$	��---��$
��Left=�$��628,519,0,0q�$	��Top=�
�������$��Arial Black)�$��16(�$	��148���� -   $ btnNuevaVentaCard��$��Nueva Venta��$
��Left=�$��792,381,0,0q�$	��Top=�$	��166��$��78������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF50E5F3��$ 0.935Q�� $ White���� $��Cliente��$
��Left=�$	��298��$��
472,26,0,0q�$	��Top=�$	��414��
�������$��Arial Black)�$��16(�.��� $
��Left=�$	��262��$��
10,10,-2,0q�$	��Top=�$	��394��.+��� $��	Telefono:��$
��Left=�$��	57,37,0,0q�$	��Top=�
��������� -   $
 txtTelfClienteCard��$
��Left=�$��23��$��
153,40,0,0q�$
 Wrap=�$	��Top=�$	��176��$��Arial Narrow)�$��14(��� $��Nombre:��$
��Left=�$��	57,90,0,0q�$	��Top=�$��88��
��������� -   $ btnVerificarClienteCard��$��	Verificar��$
��Left=�$��
57,166,0,0q�$	��Top=�$	��108��$��41������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF50E5F3��$ 0.935Q�� $ White���� -   $ btnRegistrarClienteCard��$��	Registrar��$
��Left=�$��215,166,0,0q�$	��Top=�$	��114��$��41������ $ 0.5,1&�$ 0.5,0&�.��� $ 	#FF50E5F3��$ 0.935Q�� $ White���� -   $
 txtNombreClienteCard��$
��Left=�$��23��$��
153,93,0,0q�$
 Wrap=�$	��Top=�$	��176��$��Arial Narrow)�$��14(��� -   $ lblFecha��$�� ��$
��Left=�$��
793,10,0,0q�$��2��$	��Top=�$	��222��
�������$��Arial Black)�$��16(�