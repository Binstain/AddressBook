   M S B A M L   `   `   `  ����F  BAddressBook, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:AddressBookAddressBook  5          AddressBook.changePage   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      +localclr-namespace:AddressBook     5        N� Title$  
changePage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $	��800��6   �� 5      �� 5      .+�5   
   &   System.Windows.Controls.DataGrid  -   5        $��AllDataGrid��5         AutoGenerateColumns .  $��18(�6Z   $��0q�6h      CanUserAddRows .     CanUserDeleteRows .     
IsReadOnly . ��6B   ��    Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ 操作��6)      Width5  /System.Windows.Controls.DataGridLengthConverter$
 Auto 65   	   CellTemplate	 5      �� 5      .R�5      �� -   5        5   '   5      5      0  *System.Windows.Controls.DataGridTextColumn  5      $ 姓名��6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   �� *Name+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�  5      $ 性别��6%   
 61   �� *Sex+$ TwoWay=�$ PropertyChanged=�  5      $ 出生年份��6%   
 63   �� *	Birthyear+$ TwoWay=�$ PropertyChanged=�  5      $ 联系方式��6%   
 63   �� *	Contact+$ TwoWay=�$ PropertyChanged=�  5       $ 地址��6%   $ * 6~   
 61   �� *	Address+$ TwoWay=�$ PropertyChanged=�6~   5"      �� 5#   
   $��1��6   .+�5$   
   ��  �� Orientation$ 
Horizontal=�6   $��0,20,0,0q�6/   $��Center=�6A   .+�5%      �� -   5        $��
editButton��5%      $��编辑��6+   $��0,0,0,0q�68   $��18(�6I   $��60��6W   6b   �� 5&      -   5        $��
saveButton��5&      $��保存��6+   $��30,0,0,0q�68   $��18(�6J   $��60��6X   6c   �� 5'      -   5        $��
dropButton��5'      $��删除��6+   $��30,0,0,0q�68   $��18(�6J   $��60��6X   6c   5(      5)      �� 5*   
   -   5        $��ErrorTextBlock��5*      $��2��6*   
���  ��$��20(�6H   $��Center=�6V   $��0,20,0,0q�6s   5+      5,      