   M S B A M L   `   `   `  ����Q  MTheGenuisBubbleTea-GUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null?$clr-namespace:TheGenuisBubbleTea_GUITheGenuisBubbleTea_GUI  5   	   ,    &TheGenuisBubbleTea_GUI.OrderStatusPage   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   6local$clr-namespace:TheGenuisBubbleTea_GUI     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � WindowStyle$
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
   $��1��6   .+�5,      �  � RowDefinitions 5-      �� 5.      $��50 �6$   �� 5/      $��* �6$   .+�51      � $��0��6   .+�52      �  53      �� 54      $��9* �6/   �� 55      $��* �6/   .+�57      � $��0��6   .+�58      ��   
HeaderText#��[ 6(   $��Order Status��6M   59      5:      5;      � 5<      $��1��6    5=      �� 5>      $��8* �6+   �� 5?      $��2* �6+   .+�5A      �� -   5         ��Name$ OrderStatusList��5A      $��0��68   $��
25,25,0,25q�6H   $	��560��6\   	 �� View	 5B      �� 5C      .P�5D   "   �� $3��-ชื่อเครื่องดื่ม��61   
 �� Width$	
 190��6u    �� DisplayMemberBinding 6J   �� *	NameWater+6u   �� 5E   "   $��ท็อปปิ้ง��61   $	
 100��6l    6C   �� *	Topping+6l   �� 5F   "   $��ความหวาน��61   $	
 100��6o    6C   �� *
SweetLevel+6o   �� 5G   "   $��ไซส์แก้ว��61   $	
 100��6i    6C   �� *Size+6i   5H      5J      �� 5K      $��1��6!   .+�5L      �� -   5        $ RefreshDataButton��5L   !   $��Refresh��6<   $��40��6N   $��10,50,10,10q�6Z   6o   �� 5M      -   5        $ ClearhButton��5M   !   $��Clear��67   $��40��6G   $��10,10q�6S   6b   5N      5O      5P      5Q      5R      5S      