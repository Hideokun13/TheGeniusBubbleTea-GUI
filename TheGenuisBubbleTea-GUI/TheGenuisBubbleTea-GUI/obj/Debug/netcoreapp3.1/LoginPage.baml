   M S B A M L   `   `   `  ����Q  MTheGenuisBubbleTea-GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TheGenuisBubbleTea_GUITheGenuisBubbleTea_GUI  5   	   &     TheGenuisBubbleTea_GUI.LoginPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:TheGenuisBubbleTea_GUI     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
 None=�5	   	   $��0q�5
   	    � AllowsTransparency$
 True��5   	    � Title$ 	LoginPage��5   	   $	��550��6   $	��950��6(   .��5      �  � ColumnDefinitions 5   
   �� 5      $	��220 �6   �� 5      $��* �6   .+�5   
   � $��0��6   .+�5      ��  
  MenuBG#��[  6   �� 5        
LogoBorder#��[ 6   �� 5        	LogoImage#��[ 6   5      � 5   
   $��1��6   .+�5      �  � RowDefinitions 5      �� 5      $��50 �6$   �� 5      $��* �6$   .+�5#      � $��0��6   .+�5$      �  5%      �� 5&      $��9* �6/   �� 5'      $��50 �6/   .+�5)      � $��0��6   .+�5*      ��   
HeaderText#��[ 6(   $��Login��6M   5+      � 5,      $��1��6   .+�5-      �� -   5         ��Name$ 
exitButton��5-   %     HeadMenuButton#��[ 69   .��5.   "   ��  �� Orientation$ 
Horizontal=�6-   .+�5/   &   �� $��Image/UI/Close-button.png��6,   $��16��6O   $��16��6Z   50   #   51      52      53      54      � 57      $��1��6   .+�58      �� $��Center=�6!   .+�59      �� $ 
Horizontal=�6%   $��Center=�6>   $
��0,10q�6[   .+�5:      �� $��Username��6(     	LoginText#��[ 68   �� 5;      -   5         ��Name$ usernameEntity��5;   &   $	��200��6>   $��20��6J   $
��20,0q�6V   5<      �� 5=      $ 
Horizontal=�6%   $��Center=�6>   $
��0,10q�6[   .+�5>      �� $��Password��6(   #��[ 68   G� 5?      -   5        	 G�Name$	 passwordEntity��5?   *   $	��200��6B   $��20��6N   $
��20,0q�6Z   6h   5@      �� 5A      -   5        $ loginButton��5A   !   $��Login��66     LoginButton#��[ 6F   $
��0,10q�6k   6y   5C      5D      5E      5F      5G      5H      