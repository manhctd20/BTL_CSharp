   M S B A M L   `   `   `  ����@  <login, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:loginlogin  5   	       login.hienthi   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:login     5   	     � Title$  dangnhap��5   	   $	��450��6   $	��800��6'    � 
ResizeMode$ NoResize=�63   .��5	      � .+�5
   
   ��  �� CornerRadius$ 10��6   $��2��6#   ��5      �� 5      .��5      �  � Color$ 
LightCoral��6#    � Offset$	 0.0Q�66   � 5      $
 Gray��6#   $ 1Q�60   5      5      �� 5   
   .@�5      �� $��HIỂN THỊ��6   
���?���.��5      � 
�������.+�5      �� $��Danh sách dữ liệu��6   $��7��68   $��16(�6L   $��Cascadia Code SemiBold)�6Z   $��	0,0,120,0q�6~   &   System.Windows.Controls.DataGrid  5      -   5          Name$ datagrid��5      $��10,29,120,29q�62   $��6��6H   $��1��6\   5      5      �� 5      $��CHỨC NĂNG��6   
���?���.��5      � 
������� � ColumnDefinitions 5      �� 5      $	��19* �6+   �� 5       $
��776* �6+   .+�5"      �� -   5         ��Name$ insert��5"      $��+ Thêm dữ liệu��6-   $
��Left=�6F   $��
6,72,0,288q�6a   $	��133��6u   $��1��6�   �� 5#      -   5        $ delete��5#      $��Xóa dữ liệu��6-   $
��Left=�6C   $��6,236,0,125q�6^   $	��133��6s   $��1��6�   �� 5$      -   5        $ update��5$      $��Sửa dữ liệu��6-   $
��Left=�6C   $��6,158,0,203q�6^   $	��133��6s   $��1��6�   �� 5%      -   5        $ export��5%      $��Export��6-   $
��Left=�6>   $��
6,309,0,52q�6Y   $	��133��6m   $��1��6�   5&      5'      5(      �� 5)   
   -   5        $ LogOut��5)      $��LogOut��6!   $��700,27,10,364q�62   6I   5*      5+      