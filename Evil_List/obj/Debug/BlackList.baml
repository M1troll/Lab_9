   M S B A M L   `   `   `  ����D  @Evil_List, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Evil_List	Evil_List  5   	       Evil_List.BlackList   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Evil_List     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ Черный список��5	   	   $	��350��6   $	��600��6,   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5       � RowDefinitions 5   
   �� 5      $��30 �6   �� 5      $	��220 �6   �� 5      �� 5      .+�5   
   �� $��Список мести :��6   $
��Bold"�6)   $��15(�6;   
���  ��6I   �� 5   
   $1��+Добавить ещё одну цель :��6   $��1��63   $
��Bold"�6C   $��15(�6U   
���  ��6c   �� 5   
   $��1��6   $��2��6"   $��0��63   $��5q�6C   
��� E��$��3q�6f   .��5      �� $��10q�6   ��6"   �� *MyBlackList+5      � 5   
   $��0��6   $��3��6    5      �� 5      �� 5      .+�5      �� $��Открыть файл��6   $��5q�6,   $��0��6Y   ��67   �� *OpenBlackList+6Y   �� 5       $#��Обновить список��6   $��5q�6/   $��1��6Z   ��6:   �� *RestartText+6Z   5!      �� 5"   
   $��1��6   $��1��6    $��5q�60   
��� E��$��3q�6S   .��5#      � $��10q�6    5$      �� 5%      �� 5&      �� 5'      �� 5(      �� 5)      .+�5+      �� $"��Преподаватель :��6   $��0��62   $��Bottom=�6?   �� 5,      $��1��6   $��5q�6(   ��63   �� *
Teachers+ �� SelectedItem 6T   �� *HateTeacherName+�� 5-      $��Предмет :��6   $��2��6,   $��Bottom=�69   �� 5.      $��3��6   $��5q�6(   ��63   �� *
Subjects+ 6T   �� *HateSubjectTitle+�� 5/      $��Добвать��6   $��4��6+   $��5q�68   ��6C   �� *AddNewPerson+50      51      �� 52   
   -   5        $��ExitBtn��52   i   $��2��6   $��2��6   $��
Выход��6/   $��1��6?   $��10q�6O   $��25(�6[   6i   53      54      