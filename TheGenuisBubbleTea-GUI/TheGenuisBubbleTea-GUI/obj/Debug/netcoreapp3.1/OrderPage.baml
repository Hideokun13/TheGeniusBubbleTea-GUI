   M S B A M L   `   `   `  ����Q  MTheGenuisBubbleTea-GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TheGenuisBubbleTea_GUITheGenuisBubbleTea_GUI  5   	   &     TheGenuisBubbleTea_GUI.OrderPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:TheGenuisBubbleTea_GUI     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	   $��0q�5
   	    � AllowsTransparency$
 True��5   	    � Title$ HomeMenu��5   	   $	��550��6   $	��950��6'   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��220 �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      ��  
  MenuBG#��[  6   �� 5        
LogoBorder#��[ 6   �� 5      $'��!image/TheGenuisBubbleTea-Logo.png��6     	LogoImage#��[ 6?   �� 5      -   5         ��Name$ 
HomeButton��5      $��	0,0,0,297q�6)     
MenuButton#��[ 6<   .��5      ��  �� Orientation$ 
Horizontal=�6   .+�5      �� $
��Home��6     TextMenuButton#��[ 6+   5      5      �� 5      -   5        $ OrderButton��5      $��	0,0,0,242q�6*   #��[ 6=   .��5      �� $ 
Horizontal=�6   .+�5      �� $��Order��6   #��[ 6,   5       5!      �� 5"      -   5        $ OrderStatusButton��5"      $��	0,0,0,182q�60   #��[ 6C   .��5#      �� $ 
Horizontal=�6   .+�5$      �� $��Order Status��6   #��[ 63   5%      5&      �� 5'      -   5        $ MemberButton��5'      $��	0,0,0,122q�6+   #��[ 6>   .��5(      �� $ 
Horizontal=�6   .+�5)      �� $��The Genuis Member��6   #��[ 68   5*      5+      5,      � 5/   
   $��1��6   .+�50      �  � RowDefinitions 51      �� 52      $��50 �6$   �� 53      $��* �6$   �� 54      $��60 �6$   .+�58      � $��0��6   .+�59      �  5:      �� 5;      $��9* �6/   �� 5<      $��* �6/   .+�5>      � $��0��6   .+�5?      ��   
HeaderText#��[ 6(   $��
Order Menu��6M   5@      � 5A      $��1��6   .+�5B      �� -   5        $ 
exitButton��5B   %     HeadMenuButton#��[ 69   .��5C   "   �� $ 
Horizontal=�6-   .+�5D   &   �� $%��Image/UI/exit-to-app-button.png��6,   5E   #   5F      5G      5H      5I      � 5L      $��1��6   .+�5M      � .+�5N      � .+�5O      �� $��0q�6'   $��	10,0,10,0q�63   $	��680��6F   .@�5P   "   � $	��645��6'    5Q   &   �� 5R   *   $��* �68   �� 5S   *   $��* �68   .+�5U   &   � $��0��6+   .+�5V   *   �� $$��image/MenuSelector/MilkTea.jpg��60   $	��400��6X   5W   '   � 5X   &   $��1��6+   .+�5Y   *   �� -   5        $ SelectButton��5Y   1   $��10,20q�6H   $��Center=�6W   .��5Z   .   �� .+�5[   2   �� $��Select!��68   $��Center=�6J   $��Center=�6g   5\   /   5]   +   5^   '   5_   #   5`      5a      5b      5c      � 5f      $��2��6    5g      �� 5h      $��* �6+   �� 5i      $��* �6+   .+�5k      �� -   5        $ 
BackButton��5k   -   $��0��6   $
��Back��6A     ControlButton#��[ 6P   6w   �� 5l      -   5        $ 
NextButton��5l   -   $��1��6   $
��Next��6A   #��[ 6P   6w   5m      5n      5o      5p      5q      