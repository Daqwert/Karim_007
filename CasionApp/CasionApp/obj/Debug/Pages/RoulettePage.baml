   M S B A M L   `   `   `  ����D  @CasionApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CasionApp.PagesCasionApp.Pages  5      "    CasionApp.Pages.RoulettePage   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      /localclr-namespace:CasionApp.Pages     5        N� Title$  RoulettePage��5	      .��5      � -   5         �Name$ GContent��5       � RowDefinitions 5   
   �� 5      �� 5      .+�5   
   � ���#003b01 5      �� 5      �� 5      $
��auto �6    .+�5      �� -   5         ��Name$ IRoulete��5      $��Uniform=�5       J� RenderTransformOrigin$ 0.5,0.5&�5      $ ��/Resourses/CasinoImage.jpg��5      z�5      �� 5      -   5        ImageScaleTransform�� �� ScaleX$ 1Q�5   B    �� ScaleY$ 1Q�6M   5      �� 5      $��1��5      
�������$��Center=�5       ��5      �� *Result+5       5!      � 5"   
   -   5        $ Table��5"      $��1��5#       5$      �� 5%      $
��auto �6    �� 5&      .+�5(      �� -   5         ��Name$ 
SPDataGame��5(      .+�5)      �� ��6   �� *
ResultGame+ �� StringFormat$ Выигрыш {0} RUB��5*      �� 5,      $��1��6   .+�5-      �� $c��]Выберите число, на которое хотите поставить ставку��6   �� 5.      -   5        	 ��Name$
	 Bets��5.      
 �� DisplayMemberPath$

 Name��5/       �� SelectedItem 50      �� *	SelectBet+�� 51      $!��Введите ставку��6   �� 52      ��6   �� *
BetMoney+�� 54      -   5         ��Name$ BSpin��54      $��Крутить��56      �� 58      -   5        $ BEndGame��58      $!��Закончить игру��5:      5=      5@      5A      5B      