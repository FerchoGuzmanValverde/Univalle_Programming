   M S B A M L   `   `   `  ����C  ?TabMenu2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:TabMenu2TabMenu2  5   	   E ADragablz, Version=0.0.3.203, Culture=neutral, PublicKeyToken=null5(clr-namespace:Dragablz;assembly=DragablzDragablz 5   	       TabMenu2.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:TabMenu2     5   	   =dragablz(clr-namespace:Dragablz;assembly=Dragablz     5   	   V RMaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5	   	   $	��600��5
   	   $
��1080��6     � 
ResizeMode$  NoResize=�6#    � WindowStartupLocation$ CenterScreen=�69    � WindowStyle$
 None=�6^   .��5      � .+�5   
   � $��60��6   $	��Top=�6   ���	#FF9C27B0.+�5      �� $��PIZZAS��6   
�������$��Center=�69   $��Center=�6V   $��22(�6q   $��Champagne & Limousines)�6   �� 5      -   5        $��Right=�5      $��Center=�61   ��6L   Z� ��6b   Z� .��5      '  !MaterialDesignThemes.Wpf.PackIcon  �  �ControlzEx.PackIconBase`1[[MaterialDesignThemes.Wpf.PackIconKind, MaterialDesignThemes.Wpf, Version=2.4.1.1101, Culture=neutral, PublicKeyToken=null]]   Kind$ Close=�6*   5      5      � 5   
   $��0 60 0 0q�6   .+�5        Dragablz.TabablzControl     InterTabController 5      !  Dragablz.InterTabController  5      .@�5      �� $��Inicio��6   .��5      #  MaterialDesignThemes.Wpf.Card  ���#FFC107$��185,33,135,0q�6?   $	��449��6U   .��5      ��  �� Orientation$ 
Horizontal=�6%   $��Bottom=�6>   $	��439��6Y   .+�5      �� .+�5   "   �� $��Comida Rapida��6,   $��Cooper Black)�6A   ���	#FFC000006[   �� 5   "   $	��300��6-   $��10q�6:   .+�5   &   �� $��PIZZAS��60   $��50(�6>   $��Cooper Black)�6L   ���	#FFC000006f   �� 5   &   $��Tasty��60   $��25(�6=   $��Champagne & Limousines)�6K   $
��Bold"�6s   $��5q�6�   �� 5   &   $-��'Estamos para brindar el mejor servicio.��60   $��20(�6_   $��Champagne & Limousines)�6m   $��5q�6�   �� 5    &   $��18(�60   $	��250��6>   $��Champagne & Limousines)�6J   $��5q�6r   $
��Wrap=�6}    �� TextAlignment$ Justify=�6�   �� 6�   $���Nuestro trabajo es brindar un calido y rapido servicio a nuestros clientes, brindandoles la mejor calidad de pizzas posibles en tiempos record. El cliente siempre tiene la razon.��6�   6k  5!   #   5"      �� 5#      $��10q�6$   $	��355��60   $	��282��6<   $��Imagenes/logo.jpg��6I   $��UniformToFill=�6d   5$      5%      5&      �� 5'      $
��Menu��6   .��5(      � -   5         � ColumnDefinitions 5)      �� 5*      $��* �6/   �� 5+      $��* �6/   �� 5,      $��* �6/   .+�5.      � $��0��6   $	��300��6/   ���#FFC107$��10q�6Q    J� Effect 5/      3  -System.Windows.Media.Effects.DropShadowEffect  50   "   	   
BlurRadius$	 20Q�63   
   Color$
 	#FFDEDEDE��6C      ShadowDepth$ 1Q�6U   .+�53      �� $	��200��6)   .+�54   "   �� -   5         ��Name$ 	txbPizza1��54   ,   $��10q�6?   $��Showcard Gothic)�6K   $��12(�6h   ���	#FFC000006v   �� 55   "   -   5         ��Name$ 	imgPizza1��55   (   $	��200��6;   $	��150��6G   $��UniformToFill=�6T   �� 56   "   -   5        $ txbDescripcionPizza1��56   ,   $��8(�6J   $��5q�6W   $
��Wrap=�6b   $��Champagne & Limousines)�6v   58   #   �� 59   "   $ 
Horizontal=�6-   $��Center=�6F   .+�5:   &   �� -   5        $ txbPrecioPizza1��5:   0   $��Center=�6I   $��10q�6d   $��20(�6p   $��Champagne & Limousines)�6~   �� 5;   &   -   5         ��Name$ btnDetallePizza1��5;   -   $	��100��6G   $��Leer mas��6S   $��Champagne & Limousines)�6f   $��10q�6�   5<   #   5=      5>      � 5?      $��1��6   $	��300��6/   ���#FFC107$��10q�6Q    5@        5A   "   $	 20Q�63   $
 	#FFDEDEDE��6C   $ 1Q�6U   .+�5D      �� $	��200��6)   .+�5E   "   �� -   5        $ 	txbPizza2��5E   ,   $��10q�6?   $��Showcard Gothic)�6K   $��12(�6h   ���	#FFC000006v   �� 5F   "   -	   5        $ 	imgPizza2��5F   (   $	��200��6;   $	��150��6G   $��UniformToFill=�6T   �� 5G   "   -
   5        $ txbDescripcionPizza2��5G   ,   $��8(�6J   $��5q�6W   $
��Wrap=�6b   $��Champagne & Limousines)�6v   5I   #   �� 5J   "   $ 
Horizontal=�6-   $��Center=�6F   .+�5K   &   �� -   5        $ txbPrecioPizza2��5K   0   $��Center=�6I   $��10q�6d   $��20(�6p   $��Champagne & Limousines)�6~   �� 5L   &   -   5        $ btnDetallePizza2��5L   -   $	��100��6G   $��Leer mas��6S   $��Champagne & Limousines)�6f   $��10q�6�   5M   #   5N      5O      � 5P      $��2��6   $	��300��6/   ���#FFC107$��10q�6Q    5Q        5R   "   $	 20Q�63   $
 	#FFDEDEDE��6C   $ 1Q�6U   .+�5U      �� $	��200��6)   .+�5V   "   �� -   5        $ 	txbPizza3��5V   ,   $��10q�6?   $��Showcard Gothic)�6K   $��12(�6h   ���	#FFC000006v   �� 5W   "   -   5        $ 	imgPizza3��5W   (   $	��200��6;   $	��150��6G   $��UniformToFill=�6T   �� 5X   "   -   5        $ txbDescripcionPizza3��5X   ,   $��8(�6J   $��5q�6W   $
��Wrap=�6b   $��Champagne & Limousines)�6v   5Z   #   �� 5[   "   $ 
Horizontal=�6-   $��Center=�6F   .+�5\   &   �� -   5        $ txbPrecioPizza3��5\   0   $��Center=�6I   $��10q�6d   $��20(�6p   $��Champagne & Limousines)�6~   �� 5]   &   -   5        $ btnDetallePizza3��5]   -   $	��100��6G   $��Leer mas��6S   $��Champagne & Limousines)�6f   $��10q�6�   5^   #   5_      5`      5a      5b      �� 5c      $��Pedidos��6   .��5d        ���#FFC107$��185,33,135,0q�6?   $	��449��6U   .��5e      � .+�5f      �� $
��Left=�6(   $��
271,19,0,0q�6C   $
��Wrap=�6W   $��PEDIDOS��6k   $��36(�6z   $��Cooper Black)�6�   ���	#FFC00000$	��Top=�6�   $��49��6�   $	��178��6�   $ Center=�6�   �� 5g      $��Nombre Cliente:��6$   $
��Left=�6>   $��
169,73,0,0q�6Y   $	��Top=�6m   $��31��6�   $	��179��6�   
�������$��16(�6�   �� 5h      $��Pizza:��6$   $
��Left=�65   $��169,129,0,0q�6P   $	��Top=�6e   $��33��6}   $	��179��6�   
�������$��16(�6�   �� 5i      -   5        $��Ordenar��5i   %   $
��Left=�67   $��169,188,0,0q�6R   $	��Top=�6g   $	��183��6   $��52��6�   6�   �� 5j      -   5        $��	Entregado��5j   %   $
��Left=�69   $��377,188,0,0q�6T   $	��Top=�6i   $	��188��6�   $��52��6�   6�     5k      
�������$	��185��6E   $��121,254,135,0q�6R   .��5l   "   �� -   5         ��Name$ 
lstPedidos��5l   *   $
��Left=�6>   $	��165��6Y   $��	10,10,0,0q�6f   $	��Top=�6y   $	��482��6�   5m      �� 5n      -   5         ��Name$ 
txtCliente��5n   &   $
��Left=�6:   $��31��6U   $��
348,73,0,0q�6a    �� TextWrapping$
 Wrap=�6u   $	��Top=�6�   $	��217��6�   
�������6�   �� 5o      -   5         ��Name$ cbxPizza��5o   '   $
��Left=�69   $��348,129,0,0q�6T   $	��Top=�6i   $	��217��6�   ���#FFC107
�������.@�5p   "   ��  �� 
IsSelected . .��6A   Selccione Pizza6R   �� 5q   "   -   5        $
��Atun��5q   /   .��6;   Atun6A   �� 5r   "   -   5        $��Catalana��5r   /   .��6?   
Catalana6I   �� 5s   "   -   5        $��Rucula��5s   /   .��6=   Rucula6E   5t      5u      5v      5w      �� 5x      ��5y        5z      $ Message=�62      PrimaryHueLightBrush#���   6A   .��5|        ���#FFC107$	��392��6?   $��112,41,112,0q�6L   .��5}      � .+�5~      �� -   5        $ btnIniciarServidor��5~   %   $��Iniciar Servidor��6A   $
��Left=�6\   $��	35,59,0,0q�6w   $	��Top=�6�   $	��167��6�   $��45��6�   6�   �� 5      -   5        $ btnIniciarEscucha��5   %   $��Recibir Pedidos��6@   $
��Left=�6Z   $��
35,146,0,0q�6u   $	��Top=�6�   $	��167��6�   $��45��6�   6�   �� 5�      -   5        $ txtMsgRecibido��5�   &   $
��Left=�6>   $	��122��6Y   $��
305,34,0,0q�6f   $
 Wrap=�6z   $	��Top=�6�   $	��339��6�   
�������
�������6�   �� 5�      -   5        $ txtMsgEnviar��5�   &   $
��Left=�6<   $	��122��6W   $��305,187,0,0q�6d   $
 Wrap=�6y   $	��Top=�6�   $	��339��6�   
�������
�������6�   �� 5�      -   5        $ btnEnviarMensaje��5�   %   $��Enviar Mensaje��6?   $
��Left=�6X   $��384,334,0,0q�6s   $	��Top=�6�   $	��167��6�   $��48��6�   6�   �� 5�      -   5        $ btnDesconectar��5�   %   $��Apagar Servidor��6=   $
��Left=�6W   $��
35,239,0,0q�6r   $	��Top=�6�   $	��167��6�   $��48��6�   6�   �� 5�      -    5        $ tbStatus��5�   (   $
��Left=�6:   $��
35,317,0,0q�6U   $
��Wrap=�6i   $	��Top=�6}   $��65��6�   $	��167��6�   �� 5�      $��CLIENTE:��6$   $
��Left=�67   $��
305,10,0,0q�6R   $	��Top=�6f   $	��121��6~   
�������$��14(�6�   $��Segoe UI Black)�6�   �� 5�      $��	OPERADOR:��6$   $
��Left=�68   $��305,161,0,0q�6S   $	��Top=�6h   $	��121��6�   
�������$��14(�6�   $��Segoe UI Black)�6�   �� 5�      $
��Left=�6(   $��
666,34,0,0q�6C   $
��Wrap=�6W   $��PEDIDOS ONLINE��6k   $��36(�6�   $��Cooper Black)�6�   ���	#FFC00000$	��Top=�6�   $��97��6�   $	��178��6�   $ Center=�6�   �� 5�      $
��Left=�6(   $	��117��6C   $��684,131,0,0q�6P   $	��Top=�6e   $	��142��6}   ��5�   "   �� 5�   &    �� ImageSource$ Imagenes/atun.jpg��61   5�      �� 5�      $
��Left=�6(   $	��118��6C   $��684,248,0,0q�6P   $	��Top=�6e   $	��142��6}   ��5�   "   �� 5�   &   $ Imagenes/rucula.jpg��61   5�      5�      5�      5�      5�      5�      5�      5�      