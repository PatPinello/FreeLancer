   M S B A M L   `   `   `  ����G  CFreePlantcer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:FreePlantcerFreePlantcer  5   	       FreePlantcer.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   ,localclr-namespace:FreePlantcer     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)   .��5	      � .+�5
   
   �� $��50(�6   $��200,-12,175,258q�6"    J� RenderTransformOrigin$ 1.443,0.195&�6;   Timer6f   �� 5   
   -   5         ��Name$ clocktxtblock��5      $��70(�6+   $��118,38,37,183q�69   6R   �� 5   
   -   5         ��Name$ startbtn��5      $��38,137,682,197q�6#   
��� � �$��Start��6N   $��20(�6^   6�   �� 5   
   -   5        $ stopbtn��5      $��118,137,602,197q�6"   
���E��$
��Stop��6T   $��20(�6c   6�   �� 5   
   -   5        $ resetbtn��5      $��118,237,602,121q�6#   
���z���$��Reset��6T   $��15(�6d   6�   �� 5   
   -   5        $ logbtn��5      $��198,137,518,197q�6!   
���?���$	��Log��6L   $��20(�6Z   6�   �� 5   
   -   5         ��Name$ elapsedtimeitem��5      $
��Left=�6+   $	��100��6F   $	��Top=�6S   $	��389��6k   $��374,295,0,0q�6w   �� 5   
   $��button1��6   $
��Left=�6#   $��374,179,0,0q�6>   $	��Top=�6S   �� 5   
   $��450,17,78,93q�6   .+�5      &   System.Windows.Controls.Calendar  -   5          Name$ 	calendar1��5         SelectionMode$ MultipleRange=�6*      SelectedDate$ 3/1/2022X�6H   �� 5      $	��163��6   $��Selected date:��6    �� 5      -   5        $ datetxtblock��5      
�������$	��164��6�   ��6D   �� *SelectedDate+ �� ElementName$ 	calendar1��	 �� StringFormat$	 d��
 �� UpdateSourceTrigger$
 PropertyChanged=�6�   �� 5      -	   5        $ ratebox��5      $��15.00��6'   $	��164��64   
������6@   �� 5      -
   5        $ 
timelogged��5      $��Logged Time��6*   
��� ���$	��164��6R   �� 5      -   5        $ 	incomebox��5      $��Income��6)   
�����p�$	��164��6O   5      5       5!      