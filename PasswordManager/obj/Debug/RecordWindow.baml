   M S B A M L   `   `   `  ����J  FPasswordManager, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:PasswordManagerPasswordManager  5   	   "    PasswordManager.RecordWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:PasswordManager     5   	     � Title$  Password manager: Record��5   	    � WindowStartupLocation$ CenterScreen=�6*   $	��450��6O   $	��600��6\   .��5	      � ���	#FFFBFBE0.+�5
   
   � $	��450��6   $	��600��6   $��Center=�6(   $��Center=�6C   .+�5      �� -   5         ��Name$ label_serviceName��5      $��Service name:��6/   $
��Left=�6G   $��	40,50,0,0q�6b   $	��Top=�6u   �� 5      -   5        $ label_category��5      $��	Category:��6,   $
��Left=�6@   $��
40,117,0,0q�6[   $	��Top=�6o   �� 5      -   5        $ 	label_URL��5      $��URL: (optional)��6'   $
��Left=�6A   $��
40,180,0,0q�6\   $	��Top=�6p   �� 5      -   5        $ label_login��5      $��Login��6)   $
��Left=�69   $��
40,245,0,0q�6T   $	��Top=�6h   �� 5      -   5        $ label_password��5      $��Password��6,   $
��Left=�6?   $	��Top=�6Z   $��
40,314,0,0q�6r   �� 5      -   5         ��Name$ textBox_serviceName��5      $
��Left=�63   $��23��6N   $��
200,53,0,0q�6Z    �� TextWrapping$
 Wrap=�6n   $�� ��6�   $	��Top=�6�   $	��285��6�   �� 5      -   5         ��Name$ comboBox_category��5       �� SelectedValuePath$ Content��62   $
��Left=�6N   $��200,121,0,0q�6i   $	��Top=�6~   $	��285��6�   .@�5      �� -   5         ��Name$
 None��5      .��6-   None63   �� 5      -	   5        $ Business��5      .��61   
Business6;   �� 5      -
   5        $ Email��5      .��6.   Email65   �� 5      -   5        $ Finance��5      .��60   	Finance69   �� 5      -   5        $ Games��5      .��6.   Games65   �� 5      -   5        $ Health��5      .��6/   Health67   �� 5      -   5        $ Productivity��5      .��65   Productivity6C   �� 5      -   5        $ Shopping��5      .��61   
Shopping6;   �� 5      -   5        $ Social��5      .��6/   Social67   5      �� 5      -   5        $ textBox_URL��5      $
��Left=�6+   $��23��6F   $��200,180,0,0q�6R   $
 Wrap=�6g   $�� ��6{   $	��Top=�6�   $	��285��6�   �� 5      -   5        $ textBox_login��5      $
��Left=�6-   $��23��6H   $��200,248,0,0q�6T   $
 Wrap=�6i   $�� ��6}   $	��Top=�6�   $	��285��6�   �� 5      -   5        $ textBox_password��5      $
��Left=�60   $��23��6K   $��200,314,0,0q�6W   $
 Wrap=�6l   $�� ��6�   $	��Top=�6�   $	��285��6�   �� 5      -   5         ��Name$ 
button_add��5      $	��Add��6B   $
��Left=�6P   $��200,371,0,0q�6k   $	��Top=�6�   $��80��6�   $��30��6�   ���	#FF94EA9C6�   �� 5       -   5        $ button_apply��5       $��Apply��6F   $
��Left=�6V   $��200,371,0,0q�6q   $	��Top=�6�   $��80��6�   $��30��6�   ���	#FF94EA9C6�   �� 5!      -   5        $ button_cancel��5!      $��Cancel��6H   $
��Left=�6Y   $��405,371,0,0q�6t   $	��Top=�6�   $��80��6�   $��30��6�   ���	#FF94EA9C6�   5"      5#      5$      