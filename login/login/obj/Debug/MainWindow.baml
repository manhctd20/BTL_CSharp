   M S B A M L   `   `   `  ����@  <login, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:loginlogin  5   	       login.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:login     5   	   g cMahApps.Metro.IconPacks.Material, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137ac _MahApps.Metro.IconPacks.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=0c0d510f9915137a?	iconPacks-http://metro.mahapps.com/winfx/xaml/iconpacks   5   	   -   5          � Title$  
MainWindow��5	   	   $	��450��6   $	��378��6)    � AllowsTransparency . 
������  � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6   .��5      � .+�5   
   �  � RowDefinitions 5      �� 5      �� 5      .+�5      ��  �� CornerRadius$ 10��6   $��2��6'   ��5      �� 5      .��5      �  � Color$ MediumSlateBlue��6'    � Offset$	 0.0Q�6?   � 5      $
 Gray��6'   $ 1Q�64   5      5      �� 5      $��Center=�6   .+�5       �� $ ��Đăng nhập hệ thống��6   $��
UltraBlack"�5!      $��	helvetica)�5"      $��22(�5#      
�������$��Center=�5%      5&      �� 5*      $��1��6   .+�5+      ��  �� Orientation$ 
Horizontal=�6   .+�5,      �� -   5        	 ��Name$	 username_txt��5,      $��	Helvetica)�64   $��Light"�5-      $��Username��5.      $��20(�5/      $��Center=�50      
�������
������ $��0q�53      $	��235��54      $
��Left=�55      
 J� Opacity$	
 0.5Q�56      $��25��57      $��63,0,0,0q�58      .  (MahApps.Metro.IconPacks.PackIconMaterial  59         Kind$ Account=�61   $��Center=�5:   1   $��Center=�5;   1   
�������5<   1   5=      �� 5>      $	��250��6   $��2��5?      
�������$	
 0.5Q�5A      �� 5E      $ 
Horizontal=�6   $��0,20,0,0q�66   .+�5F      G� -   5         G�Name$ password_txt��5F   "   $��	Helvetica)�68   $��Light"�5G       G� Password$ Password��5H      $��20(�5I      $��Center=�5J      
�������
������ $��0q�5M      $	��235��5N      $
��Left=�5O      $	
 0.5Q�5P      $��25��5Q      $��63,0,0,0q�5R        5S      $ FormTextboxPassword=�61   $��Center=�5T   1   $��Center=�5U   1   
�������5V   1   5W      �� 5X      $	��250��6   $��2��5Y      
�������$	
 0.5Q�5[      �� 5^      $ 
Horizontal=�6   $��0,50,0,0q�66    � 	Resources 5_       �� 
TargetType �� Property �� Value��%�   '��       �� 5`      " ��6    .�5a      ��  � ��
 �  ��6;   �� 5b       � ��$ 14(�69   �� 5c       � ��$ 	45,5,50,0q�67   5d      5e      .+�5f      �� -   5         ��Name$ Login��5f      $	��100��6,   $��40��68   $��LOGIN��6D   6T   �� 5g      -   5        $ Register��5g      $	��100��6/   $��40��6;   $��REGISTER��6G   6Z   5i      5j      �� 5k      -   5        $��X��5k      $��353,0,0,200q�64   ��5l      �� 5m       �� 
TargetType" ��6&   .R�5n      � .+�5o      A� 
�������6&   �� 5p      $��Center=�6/   $��Center=�6L   5q      5r      5t      5u      5v      5w      