   M S B A M L   `   `   `  ����B  >WpfApp4, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp4WpfApp4  5   	       WpfApp4.Jurnal   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp4     5   	   -   5          � Title$  Журнал��5   	   $	��450��6   $	��800��6%    � 
ResizeMode$ NoResize=�5	   	   .��5
      � .+�5   
   �� .+�5      ��  �� Orientation$ 
Horizontal=�6   $	��180��62   $
��Left=�6>   .+�5      �� $��Группа:��6   �� 5      -   5         ��Name$ GroupComboBox��5      $	��120��62   $��24��6�    �� Text 6p   �� *Group+��5      �� 5      .R�5      �� $ 
Horizontal=�6)   .+�5   "   �� ��6,   �� *Year+�� 5   "   $��-��6,   �� 5   "   ��6,   �� *
SubGroup+�� 5   "   ��6,   �� *Litire+�� 5   "   ��6,   �� *
CountClass+5      5      5      5      �� 5      $ 
Horizontal=�6   $
��Left=�62   $	��180��6M   .+�5      �� $��Учебный год:��6   $��85��6/   �� 5      -   5        $ AcademicYearBox��5      $��24��6h   $��90��6t   ��5      �� 5       .R�5!      �� .+�5"   "   �� �� 5#   &   �6*   �� *	StartYear+ �� 5$   &   $�-��6*    �� 5%   &   �6*   �� *	EndYear+5&   #   5'      5(      5*      5+      �� 5,      &   System.Windows.Controls.DataGrid  5-      -   5          Name$ peoplegroup��5-   ?   $	��400��6      AutoGenerateColumns .     Columns 5.      0  *System.Windows.Controls.DataGridTextColumn  5/      ,  &System.Windows.Controls.DataGridColumn   Header$ Фамилия��6L   	   Width5  /System.Windows.Controls.DataGridLengthConverter$	 * 6]   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 6)   �� *People.SurName+6]     50      $ Имя��6I   $	 * 6V   
 6)   �� *People.Name+6V     51      $ Отчество��6O   $	 * 6a   
 6)   �� *People.SecondName+6a   53      54      55      56      