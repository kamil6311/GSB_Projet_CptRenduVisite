   M S B A M L   `   `   `  ����G  Cgsb_CRvisite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:gsb_CRvisitegsb_CRvisite  5           gsb_CRvisite.frmMedicament   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:gsb_CRvisite     5      .��5	      �� 
�������  �� Orientation$  Vertical=�6(   .+�5
   
   �� $��Liste des médicaments��6   $��Center=�61   $
��0,10q�6N   �� 5   
   -   5         ��Name$ listeMedicaments��5   .   $	��120��6   $��50,20q�6   6H   � 5   
   $
��50,0q�6    � ColumnDefinitions 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� $��Id��6   $��0��6"   $��0��6/   $	��Top=�6?   $��11(�6W   �� 5      -   5        $��AffichId��5   e   $��0��6   $��1��6#   $	��Top=�63   $��19��6K   $��11(�6W   |�.  6u   �� 5      $��Effets��6   $��0��6&   $��2��63   $	��Top=�6C   $
��Left=�6[   $
��20,0q�6v   $��11(�6�   �� 5      -   5        $��AffichEffets��5   �   |�.  $��0��6(   $��4��65   $	��150��6I   $��Right=�6U   $��Center=�6q   $��60��6�   $��11(�6�    �� TextWrapping$ WrapWithOverflow=�6�   5      � 5   
   $��50,14q�6    5       �� 5!      �� 5"      �� 5#      �� 5$      .+�5&      �� $��Nom Commercial��6   $��1��6.   $��0��6;   $	��Top=�6K   $��11(�6c   �� 5'      -   5        $��
AffichNomC��5'   w   |�.  $��1��6(   $��1��65   $	��Top=�6E   $��19��6]   $��11(�6i   6w   �� 5(      $��Contre Indications��6   $��1��62   $��2��6?   $	��Top=�6O   $
��Left=�6g   $
��20,0q�6�   $��11(�6�   �� 5)      -   5        $��AfficheContreIndic��5)   �   |�.  $��1��6(   $��4��65   $	��150��6I   $��Right=�6U   $	��Top=�6q   $��60��6�   $��11(�6�   $ WrapWithOverflow=�6�   5*      � 5,   
   $
��50,0q�6    5-      �� 5.      �� 5/      �� 50      �� 51      .+�53      �� $��Composition��6   $��2��6+   $��0��68   $	��Top=�6H   $��11(�6`   �� 54      -   5        $��AffichCompo��54   w   |�.  $��2��6(   $��1��65   $	��Top=�6E   $��55��6]   $��11(�6i   $ WrapWithOverflow=�6�   �� 55      $��Famille��6   $��2��6'   $��2��64   $	��Top=�6D   $
��Left=�6\   $
��20,0q�6w   $��11(�6�   �� 56      -   5        $��AffichFamille��56   �   |�.  $��2��6(   $��4��65   $	��150��6I   $��Right=�6U   $	��Top=�6q   $��60��6�   $��11(�6�   $ WrapWithOverflow=�6�   57      58      59      