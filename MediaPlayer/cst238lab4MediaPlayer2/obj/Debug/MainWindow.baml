   M S B A M L   `   `   `  ����F  BMediaPlayer, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null)clr-namespace:MediaPlayerMediaPlayer  5   	       MediaPlayer.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   (mbclr-namespace:MediaPlayer     5   	     � Title$  I Needed Some Videos��5   	   $	��600��6&   $	��800��63   $	��600��6?   $	��800��6O    J� CommandBindings 5      )  #System.Windows.Input.CommandBinding  5   
   -   5           Command$ MediaCommands.Play��5      6X     5	   
   -   5        $! MediaCommands.PreviousTrack��5	      6a     5
   
   -   5        $ MediaCommands.NextTrack��5
      6]     5   
   -   5        $ MediaCommands.Stop��5      6S   .��5      � -   5        $��10q�5       � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   �� 5      $
��Auto �6   .+�5   
   r� -   5        $��mePlayer��5   <   $��0��6    r� LoadedBehavior$ Manual=�6$    J� RenderTransformOrigin$ 0.5,0.5&�6L   6l      MediaPlayer.MusicBar  5   
   -   5          Name$ mbMenu��5      $��1��6&   �� 5   
   $��2��6   ��5      �� 5      .R�5      �  � ColumnDefinitions 5      �� 5      $
��Auto �6/   �� 5      $��* �6/   �� 5      $
��Auto �6/   5       5!      .@�5$      �� $��0��6   .��5%      �� -   5        $��lblProgressStatus��5%      $��00:00:00.00��65   5&      �� 5(      $��1��6   $��Stretch=�6,   .��5)      �� -	   5        $��sliProgress��5)      6�   5*      �� 5,      $��2��6   .��5-      � -
   5        $��pbVolume��5-      $��50��6.   $��12��69    � Maximum$ 1Q�6E   	 � Value	 6Q   �� 
 �� ElementName$
 mePlayer�� �� Path$ Volume�5.      5/      50      51      