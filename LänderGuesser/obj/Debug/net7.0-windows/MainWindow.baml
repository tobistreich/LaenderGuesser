   M S B A M L   `   `   `  ����I  ELänderGuesser, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:LänderGuesserLänderGuesser  5   	       LänderGuesser.MainWindow   5   	   W SPresentationCore, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=7.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:LänderGuesser     5   	     � 
ResizeMode$  NoResize=�5   	    � Title$ 
MainWindow��5	   	   $	��450��6   $	��800��6)   .��5
      �  � RowDefinitions 5   
   �� 5      $��300px �6   �� 5      $��135px �6   .+�5   
   �� -   5         ��Name$ Image_StackPanel��5      $��0��6/   .+�5      �� -   5         ��Name$ 
LevelImage��5      $	��270��6(   �� 5      -   5        $
��Help��5      $��70��6$   $��25��6/   $��Right=�6;    � 	Resources 5       �� 
TargetType �� Property �� Value��%_   '��       �� 5      " ��6   .�5      ��  �@��CornerRadius$ 10��69   5      5      5      5      �� 5   
   -   5        $ Controls_StackPanel��5      $��1��62   	 �� Orientation$	 
Horizontal=�6?   .+�5      � 
 � ColumnDefinitions
 5      �� 5      �� 5      .+�5"      �� -   5         ��Name$ Input_TextBox��5"      $��35(�61    �� CharacterCasing$ Upper=�6?   $��0��6W    �� TextAlignment$ Center=�6g   $��Center=�6~   $��50��6�   $	��400��6�   $��30, 0, 0, 25q�6�   .��6�    5#      ��%_   '��       �� 5$      " ��6    .�5%      ��  �@��CornerRadius$ 15��6=   5&      5'      .��6)   5(      �� 5)      -   5         ��Name$ Guess_Button��5)      $��Guess��6/   $��40(�6?   $��50��6M   $	��200��6Y   $��130, 0, 30, 25q�6e   $��1��6}    �� 	IsDefault$
 True��6�   $��Center=�6�   $��Center=�6�    5*      ��%_   '��       �� 5+      " ��6    .�5,      ��  �@��CornerRadius$ 15��6=   5-      5.      5/      �� 50      -   5        $ Heart1��50      $��1��6)   $
��Left=�69   $��Center=�6T   $��
10,0,30,45q�6o   $��30��6�   $��30��6�   6�   �� 51      -   5        $ Heart2��51      $��1��6)   $
��Left=�69   $��Center=�6T   $��
45,0,30,45q�6o   $��30��6�   $��30��6�   6�   �� 52      -	   5        $ Heart3��52      $��1��6)   $
��Left=�69   $��Center=�6T   $��
80,0,30,45q�6o   $��30��6�   $��30��6�   6�   �� 54      -
   5        $ Next_Button��54      $
��Next��6.   
��� � �$��40(�6P   $��Center=�6^   $��50��6�   $	��200��6�   $��130, 0, 30, 25q�6�   $��1��6�   $y�	Collapsed=�6�   $
 True��6�    55      ��%_   '��       �� 56      " ��6    .�57      ��  �@��CornerRadius$ 15��6=   58      59      5:      5;      5<      5=      5>      