   M S B A M L   `   `   `  ����F  BAddressBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AddressBookAddressBook  5   	       AddressBook.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   +localclr-namespace:AddressBook     5   	     � Title$  	通讯录��5   	   $
��1000��6   $	��800��6#   .��5
      �� .+�5   
   �  � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� -   5        $��	MyListBox��5       �� SelectionMode$ Single=�6'   $
��Auto��6j   $��0��6w   
���������5      �� 5      .R�5      �  � Orientation$ 
Horizontal=�6$    K� IsItemsHost . 6=   5      .@�5      �� -   5        $��Login��5      .��5      ��  �� Orientation$ 
Horizontal=�6!   $��0,0,10,0q�6:   .+�5      �� $��Segoe MDL2 Assets)�6$   $��36(�6C   $	����6Q   5      5      �� 5      -   5        $��Search��5      .��5      �� $ 
Horizontal=�6!   $��0,0,10,0q�6:   .+�5      �� $��Segoe MDL2 Assets)�6$   $��36(�6C   $	����6Q   5      5      �� 5       -   5        $	��Add��5       .��5!      �� $ 
Horizontal=�6!   $��0,0,10,0q�6:   .+�5"      �� $��Segoe MDL2 Assets)�6$   $��36(�6C   $	����6Q   5#      5$      �� 5%      -   5        $
��Drop��5%      .��5&      �� $ 
Horizontal=�6!   $��0,0,10,0q�6:   .+�5'      �� $��Segoe MDL2 Assets)�6$   $��36(�6C   $	����6Q   5(      5)      5*      �� 5,      -   5        $��userTB��5,      $��	未登录��6&   $��20(�61   
�������$��0,0,20,0q�6R   $��Right=�6d   $��Center=�6�   $��1��6�   5-      �� 5.   
   
���   �6    � 5/   
   -   5        $��frame��5/        � NavigationUIVisibility$ Hidden=�6   51      54      