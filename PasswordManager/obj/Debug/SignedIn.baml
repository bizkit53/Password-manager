   M S B A M L   `   `   `  ����J  FPasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PasswordManagerPasswordManager  5   	       PasswordManager.SignedIn   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PasswordManager     5   	     � Title$  Password manager��5   	    � WindowStartupLocation$ CenterScreen=�6"   $	��450��6G   $	��600��6T   .��5	      � .+�5
   
   ]� $��Stretch=�6   .+�5      ]� $	��Top=�6   ���	#FFDDDDDD.+�5      �� -   5         ��Name$ button_logout��5      $��Logout��60   $	��Top=�6]   $
��Left=�6r   $��50��6�   
������ 
������ $
��Bold"�6�   5      ]� 5      $��Right=�6   ���	#FFD1F5F4.+�5      �� -   5         ��Name$ textBox_user��5      {�.  ���	#FF94EA9C���	#FF94EA9C$��	0,-22,0,0q�6q   $
��Bold"�6�   $��16(�6�   $��22��6�   $	��Top=�6�   5      �� 5      ���	#FFD1F5F462   5      �� 5   
   -   5         ��Name$ listBox_records��5      $��Stretch=�6+   $��
140,20,0,0q�6I   $��Stretch=�6]   ���	#FFFBFBE06z   �� 5   
   -   5        $ button_show��5      $
��Show��6@   $
��Left=�6O   $��
15,204,0,0q�6j   $	��Top=�6~   $	��111��6�    �� 	IsDefault . $��25��6�   ���	#FF94EA9C6�   �� 5   
   -   5        $ 
button_add��5      $	��Add��6?   $
��Left=�6M   $��
15,244,0,0q�6h   $	��Top=�6|   $	��111��6�   $��25��6�   ���	#FF94EA9C6�   �� 5   
   -   5        $ button_edit��5      $
��Edit��6@   $
��Left=�6O   $��
15,284,0,0q�6j   $	��Top=�6~   $	��111��6�   $��25��6�   ���	#FF94EA9C6�   �� 5   
   -   5        $ button_copy��5      $
��Copy��6@   $
��Left=�6O   $��
15,324,0,0q�6j   $	��Top=�6~   $	��111��6�   $��25��6�   ���	#FF94EA9C6�   �� 5   
   -   5        $ button_delete��5      $��Delete��6D   $
��Left=�6U   $��
15,364,0,0q�6p   $	��Top=�6�   ���	#FF94EA9C$	��111��6�   $��25��6�   �� 5   
   -	   5         ��Name$ comboBox_category��5      $
��Left=�6.   $��	15,50,0,0q�6I   $	��Top=�6\   $	��111��6t   $��25��6�   .@�5      �� -
   5         ��Name$
 None��5      .��6)   None6/   �� 5      -   5        $ Business��5      .��6-   
Business67   �� 5      -   5        $ Email��5      .��6*   Email61   �� 5      -   5        $ Finance��5      .��6,   	Finance65   �� 5       -   5        $ Games��5       .��6*   Games61   �� 5!      -   5        $ Health��5!      .��6+   Health63   �� 5"      -   5        $ Productivity��5"      .��61   Productivity6?   �� 5#      -   5        $ Shopping��5#      .��6-   
Shopping67   �� 5$      -   5        $ Social��5$      .��6+   Social63   �� 5%      -   5        $	 All��5%      
���/���.��6A   All6F   5&      �� 5'   
   -   5        $ button_filterCategory��5'      $��Filter category��6T   $
��Left=�6n   $��	15,90,0,0q�6�   $	��Top=�6�   $	��111��6�   $��25��6�   ���	#FFEBEBEB���	#FFACACAC6�   5)      5*      