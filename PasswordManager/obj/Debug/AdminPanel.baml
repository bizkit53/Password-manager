   M S B A M L   `   `   `  ����J  FPasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PasswordManagerPasswordManager  5   	        PasswordManager.AdminPanel   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PasswordManager     5   	     � Title$#  Password manager: Admin panel��5   	    � WindowStartupLocation$ CenterScreen=�6/   $	��450��6T   $	��600��6a   .��5	      � .+�5
   
   ]� $��Stretch=�6   .+�5      ]� $	��Top=�6   ���	#FFDDDDDD.+�5      �� -   5         ��Name$ button_logout��5      $��Logout��60   $	��Top=�6]   $
��Left=�6r   $��50��6�   
������ 
������ $
��Bold"�6�   5      ]� 5      $��Right=�6   ���	#FFD1F5F4.+�5      �� -   5         ��Name$ textBox_user��5      {�.  ���	#FF94EA9C���	#FF94EA9C$��	0,-22,0,0q�6q   $
��Bold"�6�   $��16(�6�   $��22��6�   $	��Top=�6�   5      �� 5      ���	#FFD1F5F462   5      �� 5   
   -   5         ��Name$ listBox_users��5      $��Stretch=�6)   $��
140,20,0,0q�6G   $��Stretch=�6[   ���	#FFFBFBE06x   �� 5   
   -   5        $ button_show��5      $
��Show��6@   $��
15,244,0,0q�6O   $	��Top=�6c    �� 	IsDefault . $��25��6�   ���	#FF94EA9C$
��Bold"�6�   $
��Left=�6�   $	��111��6�   �� 5   
   -   5        $ button_addAdmin��5      $��	Add admin��6I   $
��Left=�6]   $��
15,284,0,0q�6x   $	��Top=�6�   $	��111��6�   $��25��6�   $
��Bold"�6�   ���	#FF94EA9C6�   �� 5   
   -   5        $ button_edit��5      $
��Edit��6@   $
��Left=�6O   $��
15,324,0,0q�6j   $	��Top=�6~   $	��111��6�   $��25��6�   $
��Bold"�6�   ���	#FF94EA9C6�   �� 5   
   -   5        $ button_delete��5      $��Delete��6D   $
��Left=�6U   $��
15,364,0,0q�6p   $	��111��6�   $
��Bold"�6�   ���	#FF94EA9C$��25��6�   $	��Top=�6�   5      5      