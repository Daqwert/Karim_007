   M S B A M L   `   `   `  ����D  @CasionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CasionApp.PagesCasionApp.Pages  5      !    CasionApp.Pages.ProfilePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:CasionApp.Pages     5      -   5          N� Title$  ProfilePage��5	      .��5      �  � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      .+�5   
   �� .+�5      �� -   5         ��Name$ BBack��5      $��
Назад��5      �� 5      $��
Логин��6   �� 5      ��6   �� *Login+�� 5      $��Пароль��6   �� 5      ��6   �� *
Password+�� 5      -   5        $ BEdit��5      $��Изменить��5      �� 5      -   5        $ BTopUp��5      $#��Пополнить/Снять��5      5      �� 5    
   $��1��6   .@�5!      �� $��Операции��6   .��5"      �  5#      �� 5$      $
��Auto �6,   �� 5%      .+�5'      ��  �� Orientation$ 
Horizontal=�6%   .+�5(      �� -   5        $ BPrintTransaction��5(   %   $��Печать��5*   %   5+      �� 5,      -   5         ��Name$ LVTransaction��5,   0   $��1��6#   ��5-      �� 5.   "   .R�5/   &   �� .+�50   *   �� ��64   �� *
DataTime+ �� StringFormat$ HH:mm dd.MM.yyyy ���� 51   *   ��64   �� *ColorTransaction+��52      �� *AmountMoney+53   '   54   #   56      57      58      �� 59      $��Игры��6   .��5:      �  5;      �� 5<      $
��Auto �6(   �� 5=      .+�5?      �� $ 
Horizontal=�6!   .+�5@      �� -   5        $ BPrintGames��5@   %   $��Печать��5B   %   5C      �� 5D      -   5        $ LVGames��5F   #   $��1��5D   #   $��Disabled=�5E   #   ��5G      �� 5H   "   .R�5I   &   �� .+�5J   *   �� $��24(�5K   4   ��5J   4   �� *Name+5K   4   �� 5L   *   ��64   �� *
ResultGame+��5M   4   �� *ColorResult+�� 5N   *   ��64   �� *StartSession+$% Началось в HH:mm dd.MM���� 5O   *   ��64   �� *
EndSession+$+ %Закончилось в HH:mm dd.MM��9� 5P   *   .��5Q   .   �� $��Disabled=�5R   7   ��5Q   7   �� *	RoundGame+��5S   2   �� 5T   6   .R�5U   :   �� .+�5V   >   �� ��6H   �� *
DataTime+$ HH:mm dd.MM.yyyy ���� 5W   >   $ 
Horizontal=�6I   .+�5X   B   �� ��6L   �� *ResultNumber+A� 5Y   B   $��10��6J   ��5Z   J   �� *ColorNumber+5[   ?   �� 5]   >   ��6H   �� *
ColorWin+��5^      �� *ReslutMoney+5_   ;   5`   7   5b   /   5c   +   5g   '   5h   #   5j      5k      5l      5n      5q      5r      