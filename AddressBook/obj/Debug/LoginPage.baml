   M S B A M L   `   `   `  ����F  BAddressBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AddressBookAddressBook  5          AddressBook.LoginPage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:AddressBook     5        N� Title$  	LoginPage��5	      .��5      ��  �� Orientation$ Vertical=�6   .+�5   
   � $
��Auto��6   $��Center=�6   $��	0,100,0,0q�69    � RowDefinitions 5      �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $
��Auto �6    �� 5      $��* �6     � ColumnDefinitions 5      �� 5      $��1* �6#   �� 5      $
��Auto �6#   $	��250��60   �� 5      $��1* �6#   .+�5      �� $��通 讯 录��6   $��Microsoft YaHei)�6%   $��60(�6B   
�������$��0��6b   $��3��6o   $��Center=�6�   $��0,0,0,50q�6�   �� 5      -   5        $��IDTextBlock��5   #   $��	用户名��6   $��20(�66   $��1��6D   $��0��6Q   $��
20,0,20,10q�6a   $��Right=�6u   �� 5      -   5        $��PWTextBlock��5   "   $��密码��6   $��20(�65   $��2��6C   $��0��6P   $��
20,0,30,10q�6`   $��Right=�6t   �� 5      -   5        $��	IDTextBox��5      $��20(�6'   $��1��65   $��1��6B   $��0,0,0,10q�6R   G� 5      -   5        $��	PWTextBox��5      $��20(�6+   $��2��69   $��1��6F   $��0,0,0,10q�6V   �� 5!      -   5         ��Name$ LoginButton��5!      $��登录��6*   $��20(�67   $��	0,20,70,0q�6E   $
��Auto��6X   $��Right=�6e   $��3��6�   $��1��6�   6�   �� 5"      -   5        $ LogoutButton��5"      $��退出��6+   $��20(�69   $
��Auto��6G   $��Right=�6T   $��0,20,0,0q�6p   $��3��6�   $��1��6�   6�   5$      �� 5%   
   -   5        $��LogStaTB��5%      $��Center=�6$   $��0,20,0,0q�6A   $��20(�6S   
���  ��6a   5&      5'      