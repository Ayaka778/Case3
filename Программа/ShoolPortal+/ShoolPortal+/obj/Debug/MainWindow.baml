   M S B A M L   `   `   `  ����G  CShoolPortal+, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:ShoolPortal_ShoolPortal_  5   	       ShoolPortal_.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:ShoolPortal_     5   	     � Title$@  :Форма для проверки всех функций��5   	   $��433.649��61   $��723.268��6B   $��800.068��6R   $��433.649��6e   $��800.068��6y   $��433.649��6�   .��5	      � $��
0,0,-6.4,0q�6   .+�5
   
   &   System.Windows.Controls.DataGrid  -   5          Name$	 dg1��5
         AutoGenerateColumns .  $
��Left=�6<   $	��376��6W   $	��Top=�6d   $	��631��6|   $��4,11,0,0q�6�      CanUserAddRows .     CanUserResizeRows .     CanUserSortColumns .     CanUserResizeColumns .     CanUserReorderColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 id��6%   
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 15 61      FontSize$ 15Q�6<   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6J   �� *
id_Student+  5      $	 Фамилия��6%   $
 59 66   $ 15Q�6A    6O   �� *	Last_name+  5      $	 Имя��6%   $
 60 62   $ 15Q�6=    6K   �� *
First_name+  5      $	 Отчество��6%   $
 65 67   $ 15Q�6B    6P   �� *Middle_name+  5      $	 Группа��6%   $
 58 65   $ 15Q�6@    6N   �� *Group_+  5      $!	 Номер телефона��6%   $	
 102 6=   $ 15Q�6I    6W   �� *Number_phone+  5      $	 
Почта��6%   $
 55 64   $ 15Q�6?    6M   �� *Mail+  5      $	 
Улица��6%   $
 60 64   $ 15Q�6?    6M   �� *Street_address+  5      $	 Поступил��6%   $
 69 67   $ 15Q�6B    6P   �� *Year_of_admission+  5      $	 Студен. билет��6%   $
 * 6<   $ 15Q�6F    6T   �� *College_ID_number+5      �� 5   
   -   5        $'��!Таблица студентов��5      $
��Left=�6-   $	��Top=�6H   $	��130��6`   $��
640,11,0,0q�6l   $��54��6�   6�   �� 5   
   -   5        $%��Оценки студентов��5      $
��Left=�6,   $	��Top=�6G   $	��130��6_   $��
640,90,0,0q�6k   $��57��6   6�   �� 5   
   -   5        $H��BГенерация оценок и
      посещаемости��5      $
��Left=�6J   $	��Top=�6e   $	��130��6}   $��640,174,0,0q�6�   $��60��6�   6�   �� 5   
   -   5        $��Вычисления��5      $
��Left=�6&   $	��Top=�6A   $	��130��6Y   $��640,259,0,0q�6e   $��53��6z   6�   �� 5   
   -   5        $h��b          Генирация 
             номера 
студенческого билета��5      $
��Left=�6l   $��640,336,0,0q�6�   $	��Top=�6�   $	��130��6�   6�     5   
   -   5        $	 dg2��5       .  $
��Left=�6<   $	��376��6W   $	��Top=�6d   $	��631��6|   $��4,11,0,0q�6�    .   .   .   .   .   5        5      $	 id��6%   $ 15Q�61   $
 30 6?    6J   �� *id+  5       $	 Дата��6%   $ 15Q�63   $
 80 6A    6L   �� *Date+  5!      $	 id Студента��6%   $ 15Q�6:   $
 72 6H    6S   �� *
id_Student+  5"      $	 Алгебра��6%   $ 15Q�66   $
 55 6D    6O   �� *	Algebra+  5#      $	 Геометрия��6%   $ 15Q�68   $
 70 6F    6Q   �� *
Geometry+  5$      $	 Литература��6%   $ 15Q�69   $
 74 6G    6R   �� *
Literature+  5%      $	 Физкультура��6%   $ 15Q�6:   $
 78 6H    6S   �� *Physical_education+  5&      $	 Русский язык��6%   $ 15Q�6;   $
 90 6I    6T   �� *Russian_language+  5'      $	 Технология��6%   $ 15Q�69   $
 * 6G    6Q   �� *Work_+5)      5+      5,      