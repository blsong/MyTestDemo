   M S B A M L   `   `   `  ����  WpfApplicationDemo#    WpfApplicationDemo.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	     � Title$  
MainWindow��5   	   $	��350��6   $	��525��6)   .��5      � $��	0,0,0,-45q�6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 	dataGrid1��5      $
��Left=�6&   $��	27,25,0,0q�6A   $	��Top=�6T   $	��181��6�   $	��361��6�      AutoGenerateColumns .  ��6l   �� *StudentList+ �� Mode$ TwoWay=�   Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      -   5        UserName��,  &System.Windows.Controls.DataGridColumn   Header$ UserName��5   7   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   ��  �� Path$ UserName�  5	      -   5        	Score��$ Score��5	   4    6C   �� $ Score�5      �� 5   
   $��新增一条数据��6   $
��Left=�6B   $��
27,211,0,0q�6]   $	��Top=�6q   $	��147��6�   $��28��6�   ��6"   �� *
AddCommand+6�   �� 5   
   $��修改一条数据��6   $
��Left=�6D   $��
27,244,0,0q�6_   $	��Top=�6s   $	��147��6�   $��29��6�   ��6"   �� *ModifyCommand+6�   �� 5   
   $��移除一条数据��6   $
��Left=�6D   $��
27,278,0,0q�6_   $	��Top=�6s   $	��147��6�   $��31��6�   ��6"   �� *RemoveCommand+6�   �� 5   
   -   5         ��Name$ chkPass��5      $��及格��6$   $
��Left=�62   $��246,218,0,0q�6M   $	��Top=�6b   $��28��6z   	 d� 	IsChecked	 6�   �� $ IsPassed�$ TwoWay=�5      5      