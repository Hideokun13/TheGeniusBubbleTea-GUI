   M S B A M L   `   `   `  ����Q  MTheGenuisBubbleTea-GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TheGenuisBubbleTea_GUITheGenuisBubbleTea_GUI  5   	   '    !TheGenuisBubbleTea_GUI.MemberPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:TheGenuisBubbleTea_GUI     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	   $��0q�5
   	    � AllowsTransparency$
 True��5   	    � Title$ HomeMenu��5   	   $	��550��6   $	��950��6'   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��220 �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      ��  
  MenuBG#��[  6   �� 5        
LogoBorder#��[ 6   �� 5        	LogoImage#��[ 6   �� 5      -   5         ��Name$ 
HomeButton��5      $��	0,0,0,297q�6)     
MenuButton#��[ 6<   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $
��Home��6     TextMenuButton#��[ 6+   5      5      �� 5      -   5        $ OrderButton��5      $��	0,0,0,242q�6*   #��[ 6=   .��5      �� $ 
Horizontal=�6   .+�5      �� $��Order��6   #��[ 6,   5      5      �� 5       -   5        $ OrderStatusButton��5       $��	0,0,0,182q�60   #��[ 6C   .��5!      �� $ 
Horizontal=�6   .+�5"      �� $��Order Status��6   #��[ 63   5#      5$      �� 5%      -   5        $ MemberButton��5%      $��	0,0,0,122q�6+   #��[ 6>   .��5&      �� $ 
Horizontal=�6   .+�5'      �� $��The Genuis Member��6   #��[ 68   5(      5)      5*      � 5+   
   $��1��6   .+�5,      �  � RowDefinitions 5-      �� 5.      $��50 �6$   �� 5/      $��* �6$   .+�51      � $��0��6   .+�52      �  53      �� 54      $��8* �6/   �� 55      $��* �6/   .+�57      � $��0��6   .+�58      ��   
HeaderText#��[ 6(   $��The Genuis Member��6M   59      5:      5;      � 5<      $��1��6   .+�5=      �� $��Center=�6!   .+�5>      �� $ 
Horizontal=�6%   $��Center=�6>   $
��0,10q�6[   .+�5?      �� $��
Tel Number��6(     	LoginText#��[ 6:   �� 5@      -   5         ��Name$ telNumberEntity��5@   &   $	��200��6?   $��20��6K   $
��20,0q�6W   5A      �� 5B      -   5        	 ��Name$	 	nameStack��5B   %   $ 
Horizontal=�68   $��Center=�6Q   $
��0,10q�6n   $y�	Collapsed=�6|   .+�5C      �� $
��Name��6(   #��[ 64   �� 5D      -   5        $ nameBox��5D   &   $	��200��67   $��20��6C   $
��20,0q�6O   ${�False��6]   5E      �� 5F      -   5        $	 surnameStack��5F   %   $ 
Horizontal=�6;   $��Center=�6T   $
��0,10q�6q   $y�	Collapsed=�6   .+�5G      �� $��Surname��6(   #��[ 67   �� 5H      -	   5        $ 
surnameBox��5H   &   $	��200��6:   $��20��6F   $
��20,0q�6R   ${�False��6`   5I      �� 5J      -
   5        $	 registerStack��5J   %   $ 
Horizontal=�6<   $��Center=�6U   $
��0,10q�6r   $y�	Collapsed=�6�   .+�5K      �� $��Register Date��6(   #��[ 6=   �� 5L      -   5        $ registerDateBox��5L   &   $	��200��6?   $��20��6K   $
��20,0q�6W   ${�False��6e   5M      �� 5N      $ 
Horizontal=�6%   $��Center=�6>   $
��0,10q�6[   .+�5O      �� -   5        $ checkButton��5O   %   $��Check��6:     LoginButton#��[ 6J   $��
0,10,50,10q�6o   6�   �� 5P      -   5        $ ClearButton��5P   %   $��Clear��6:   #��[ 6J   $��	0,10,0,10q�6o   6�   �� 5Q      -   5        $ registerButton��5Q   %   $��Register��6=   #��[ 6P   $��
50,10,0,10q�6u   6�   5R      5S      5T      5U      5V      5W      5X      