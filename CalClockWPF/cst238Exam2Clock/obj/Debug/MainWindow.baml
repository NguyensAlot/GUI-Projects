   M S B A M L   `   `   `  ����  cst238Exam2Clock!    cst238Exam2Clock.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5          �Name$  
mainWindow��5   	    � Title$ Clock Anthony��5   	   $	��250��6   $	��350��6,   .��5      � -   5         �Name$ spDateTimeAndOption��5      $��Center=�6(   $��Center=�6E   .+�5   
   �� -   5         ��Name$ spCalAndTime��5      $
��Left=�6+   $��0q�6F   $	��Top=�6Q    �� Orientation$ 
Horizontal=�6i   .+�5      &   System.Windows.Controls.Calendar  -   5          Name$ calendarMain��5      $
��Left=�6-   $	��Top=�6H   �� 5      -   5         ��Name$ 
gsSplitter��5      $��Stretch=�6/   $��5��6M   �� 5	      -   5        $ spClockAndTime��5	      $
��Left=�61   $	��168��6L   $	��Top=�6Y   $	��125��6q   .+�5
      �� -   5         ��Name$ canvasClock��5
      $	��125��6.   $	��125��6;   .+�5      �� -   5         ��Name$ lblBottomHour��5      $��6��63   	 �� Left$	 54��6?   

 �� Top$	
 105��6P   $��8(�6a   �� 5      -	   5        $ lblRightHour��5      $��3��62   $		 110��6>   $
 54��6P   $��8(�6`   �� 5      -
   5        $ lblLeftHour��5      $��9��61   $	 0��6=   $
 54��6M   $��8(�6]   $��Center=�6j   �� 5      -   5        $ 
lblTopHour��5      $��12��60   $	 54��6=   $
 0��6N   $��8(�6]   5      �� 5      -   5        $ 
lblTimeBox��5      $��#Insert_Time��6,   $��Center=�6C   $	��Top=�6`    J� RenderTransformOrigin$ -2.551,2.115&�6x   5      5      �� 5   
   -   5         ��Name$ cbMilitaryTime��5      $��Military Time��6+   $
��Left=�6C   $��107,173,0,0q�6^   $	��Top=�6s    � ToolTip$$ Change clock to 24-hour format��6�   6�   5      5      