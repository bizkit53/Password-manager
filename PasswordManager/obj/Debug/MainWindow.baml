   M S B A M L   `   `   `  ����J  FPasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PasswordManagerPasswordManager  5   	        PasswordManager.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PasswordManager     5   	     � Title$  Password Manager��5   	    � WindowStartupLocation$ CenterScreen=�6"   $	��450��6G   $	��400��6T   .��5	      � ���	#FFFBFBE0.+�5
   
   ]� $��2��6   .+�5      o� $	��Top=�6   .@�5      m� $��_File��6   .@�5      m� -   5        $��_Open��5      6.   m� 5      -   5        $��_Save��5      6.   m� 5      -   5        $��_Close��5      6/   5      5      �� 5      6   5      � 5   
   $	��450��6   $	��400��6   $��Center=�6(   $��Center=�6C   .+�5      �� -   5         ��Name$ label_welcome��5      $!��Welcome in password manager��6+   $��
107,74,0,0q�6Q   $	��Top=�6e   $
��Bold"�6}   $
��Left=�6�   $	��186��6�   �� 5      -   5         ��Name$ textBox_login��5      $
��Left=�6-   $��
75,182,0,0q�6H    �� TextWrapping$
 Wrap=�6\   $	��Top=�6p   $	��250��6�   $��26��6�   G� 5      -   5         G�Name$ passwordBox_password��5      $
��Left=�68   $��
75,284,0,0q�6S   $	��Top=�6g   $	��250��6   $��26��6�   �� 5      -   5        $ label_login��5      $��Login��6)   $��181,131,0,0q�69   $	��Top=�6N   $
��Left=�6f   $��39��6�   �� 5      -   5        $ label_password��5      $��Password��6,   $��170,233,0,0q�6?   $
��Left=�6T   $��60��6o   $��26��6z   $	��Top=�6�   �� 5      -	   5         ��Name$ button_signIn��5      $��Sign in��6H   $��75,345,237,0q�6Z   $	��Top=�6p   $��30��6�    �� 	IsDefault . ���	#FF94EA9C6�   �� 5      -
   5        $ button_register��5      $��Register��6L   $��237,345,75,0q�6_   $	��Top=�6u   $��30��6�   ���	#FF94EA9C6�   5      5      5      