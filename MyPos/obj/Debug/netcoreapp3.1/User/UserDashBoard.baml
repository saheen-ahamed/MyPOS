   M S B A M L   `   `   `  ����@  <MyPos, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MyPosMyPos  5   	       MyPos.UserDashBoard   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   %localclr-namespace:MyPos     5   	   S OMaterialDesignThemes.Wpf, Version=1.0.1.0, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	     � WindowStyle$
  None=�5	   	    � WindowState$ 	Maximized=�6   .��5
      �  � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��* �6   �� 5      $��50 �6   .+�5   
   � $��0��6   ���#374047$
��auto��62   $��50��6?   .+�5      �� $��User Dashboard��6   $��Center=�6.   $
��Left=�6I   $��20 0 0 0q�6d   $��16(�6v   
�������6�   �� 5      $��Welcome��6   $	��Top=�6'   $��Right=�6?   $��	0 10 20 0q�6[   $��14(�6n   
�������6|   �� 5      $��@user��6   $��Bottom=�6%   $��Right=�6@   $��0 0 20 5q�6\   $��12(�6n   
�������6|   5      � 5   
   $��1��6   $
��auto��6   
�������$
��auto��6<   .+�5      � $	��150��6)   $
��auto��66   $��Center=�6C   $��Center=�6^   ��6   Z�  � ColumnDefinitions 5      �� 5      $	��150 �6'   �� 5      $	��150 �6'   �� 5      $	��150 �6'   �� 5      $	��150 �6'   .+�5       �� -   5         ��Name$ btnSales��5    3   $��0��6   0��
�������$	��140��6W   $	��140��6c   +  %MaterialDesignThemes.Wpf.ButtonAssist   CornerRadius$ 15��6�   +  %MaterialDesignThemes.Wpf.ShadowAssist   ShadowDepth$ Depth2=�6�   $��5,5,5,5q�6�   $��2��6�   .��5!      '  !MaterialDesignThemes.Wpf.PackIcon     Kind$ ShoppingCartArrowDown=�6.   $��50��6K   $��50��6V   
�������6b   5"      �� 5#      $��0��6   $��Sales��6,   $��0,0,0,15q�69   
�������$��Center=�6^   $��Bottom=�6{   $��14(�6�   �� 5$      -   5        $ 	btnReturn��5$   3   $��1��6   1��
�������$	��140��6X   $	��140��6d   $ 15��6�   $ Depth2=�6�   $��2��6�   .��5%        $ ShoppingCartArrowUp=�6.   $��50��6I   $��50��6T   
�������6`   5&      �� 5'      $��1��6   $��Return��6,   $��0,0,0,15q�6:   
�������$��Center=�6_   $��Bottom=�6|   $��14(�6�   �� 5)      -   5        $ btnStock��5)   3   $��2��6   2��
�������$	��140��6W   $	��140��6c   $ 15��6�   $ Depth2=�6�   $��2��6�   .��5*        $ Database=�6.   $��50��6?   $��50��6J   
�������6V   5+      �� 5,      $��2��6   $��Stock��6,   $��0,0,0,15q�69   
�������$��Center=�6^   $��Bottom=�6{   $��14(�6�   �� 5.      -   5        $ 	btnLogout��5.   )   $��3��6   
�������$	��140��6N   $	��140��6Z   $ 15��6g   $ Depth2=�6�   .��5/        $ 	ExitToApp=�6.   
�������$��50��6R   $��50��6]   50      �� 51      $��3��6   $��Logout��6-   $��0,0,0,15q�6;   
�������$��Center=�6`   $��Bottom=�6}   $��14(�6�   53      � 55      .+�56      � -   5         �Name$ gridswitcher1��56      � 57      -   5        $ gridswitcher2��57      � 58      -   5        $ gridswitcher3��58      59      5:      � 5<   
   $��2��6   ���#374047$
��auto��61   $��50��6>   .+�5=      �� $��footer��6   $��Center=�6&   $��Center=�6A   $��20 0 0 0q�6^   $��16(�6p   
�������6~   5>      5@      5A      