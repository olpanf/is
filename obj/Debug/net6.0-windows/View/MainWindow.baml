   M S B A M L   `   `   `  ����B  >WpfApp7, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp7WpfApp7  5   	   5clr-namespace:WpfApp7.ViewModelWpfApp7.ViewModel  6-   E'clr-namespace:WpfApp7.ViewModel.HelpersWpfApp7.ViewModel.Helpers  6_       WpfApp7.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp7     5   	   5	viewmodelclr-namespace:WpfApp7.ViewModel     6-   ;helpers'clr-namespace:WpfApp7.ViewModel.Helpers     6_     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � ���	#FFA277AF � RowDefinitions 5
   
   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6   �� 5      $��* �6    � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$	 txt��5      $��0��6!   $��1��61   $ ��Введите логин:��6>   $��22q�6T   $��23(�6`   6p   �� 5   
   -   5        $
 txt1��5      $��0��6"   $��3��62   $"��Введите пароль:��6?   $��22q�6V   $��23(�6b   6r   �� 5   
   -   5         ��Name$ text1��5      $��1��6!   $��1��61   
�������$��25(�6U   ��6c   �� *
Login_bx+ �� Mode$ OneWayToSource=�6�   �� 5   
   -   5        $ text2��5      $��1��6!   $��3��61   
�������$��25(�6V   ��6d   �� *Password_bx+$ OneWayToSource=��� 5   
   -   5         ��Name$
 kno1��5      $��1��6   $��4��6/   $&�� Авторизироваться��6<   $��15q�6W   $��20(�6�   ��6c   �� *
AutCommand+6�   5      5      