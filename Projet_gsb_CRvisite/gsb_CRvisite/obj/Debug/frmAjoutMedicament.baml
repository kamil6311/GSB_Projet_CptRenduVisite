   M S B A M L   `   `   `  ����G  Cgsb_CRvisite, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:gsb_CRvisitegsb_CRvisite  5      %    gsb_CRvisite.frmAjoutMedicament   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      ,localclr-namespace:gsb_CRvisite     5      
�������.��5	      ��   �� Orientation$  Vertical=�6   .+�5
   
   �� $��Liste des médecins��6   $��Center=�6.   $
��0,10q�6K   � 5   
   $��90,40q�6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      �� $��Id��6   �� 5      -   5         ��Name$ newId��5   p   $	��120��6   $��Right=�6"   $
��15,0q�6>   $��20��6L   $	��Top=�6X   6p   �� 5      $��Effets��6   $��1��6&   �� 5      -   5        $ 	newEffets��5   �   $	��120��6   $��1��6"   $��Right=�62   $
��15,0q�6N   $��60��6\   $	��Top=�6h   6�   5      � 5   
   $��90,20q�6    5      �� 5      �� 5      .+�5      �� $��Nom Commercial��6   �� 5      -   5        $ newNomC��5   p   $	��120��6   $��Right=�6"   $
��15,0q�6>   $��20��6L   $	��Top=�6X   6p   �� 5      $��Contre Indications��6   $��1��62   �� 5      -   5        $ newContreIndications��5   �   $	��120��6   $��1��6"   $��Right=�62   $
��15,0q�6N   $��60��6\   $	��Top=�6h   6�   5      � 5    
   $��90,20q�6    5!      �� 5"      �� 5#      .+�5%      �� $��Composition��6   �� 5&      -   5        $ newComposition��5&   p   $	��120��6   $��Right=�6"   $
��15,0q�6>   $��60��6L   $	��Top=�6X   6p   �� 5'      $��Famille��6   $��1��6'   �� 5(      -   5         ��Name$ listeFamille��5(   �   $	��170��6   $��1��6#   $��Right=�63   $
��15,0q�6O   $��21��6]   $	��Top=�6i   6�   5)      �� 5*   
   -   5        $��Créer��5*      $��55��6!   $
��Left=�6,   $
��90,0q�6G   6U   5+      5,      