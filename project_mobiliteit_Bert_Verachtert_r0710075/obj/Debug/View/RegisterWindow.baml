   M S B A M L   `   `   `  ����f  bproject_mobiliteit_Bert_Verachtert_r0710075, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nulls>clr-namespace:project_mobiliteit_Bert_Verachtert_r0710075.View0project_mobiliteit_Bert_Verachtert_r0710075.View  5   	   E    ?project_mobiliteit_Bert_Verachtert_r0710075.View.RegisterWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Plocal>clr-namespace:project_mobiliteit_Bert_Verachtert_r0710075.View     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$  ��5
   	   $	��570��6   $	��550��6    � DataContext 5	   	   �� *RegisterViewModel+   Locator �� Source# [  .��5      � ���#f7be92 � ColumnDefinitions 5   
   �� 5      $��* �6   6+   �� 5      $��* �6   6+    � RowDefinitions 5   
   �� 5      6   �� 5      6   �� 5      6   �� 5      6   �� 5      6   .+�5   
   �� $��Registreren��6   $��2��6'   $��Center=�6;   $��Center=�6X   $��25(�6s   6�   �� 5   
   $��1��6   $��0��6   $��Center=�6-   $	��Top=�6J   $��0,10,0,0q�6b   $��17(�6t   $
��Bold"�6�   .��6�   
Voornaam6�   �� 5   
   $��1��6,   $��0��69   $��Center=�6I   $��Center=�6f   $	��200��6�   $��15(�6�   ��6   �� *
Voornaam+6�   �� 5   
   $��1��6   $��1��6   $��Center=�6-   $	��Top=�6J   $��0,10,0,0q�6b   $��17(�6t   $
��Bold"�6�   .��6�   Naam6�   �� 5   
   $��1��6(   $��1��65   $��Center=�6E   $��Center=�6b   $	��200��6}   $��15(�6�   ��6   �� *Naam+6�   �� 5   
   $��2��6   $��0��6   $��Center=�6-   $	��Top=�6J   $��0,10,0,0q�6b   $��17(�6t   $
��Bold"�6�   .��6�   Email6�   �� 5   
   $��2��65   $��0��6B   $��Center=�6R   $��Center=�6o   $	��200��6�   $��15(�6�   ��6   �� *Email+ �� Mode$ TwoWay=�6�   �� 5   
   $��2��6   $��1��6   $��Center=�6-   $	��Top=�6J   $��0,10,0,0q�6b   $��17(�6t   $
��Bold"�6�   .��6�   
Wachtwoord6�   �� 5   
   $��2��6:   $��1��6G   $��Center=�6W   $��Center=�6t   $	��210��6�   $��15(�6�   ��6   �� *
Wachtwoord+$ TwoWay=�6�   �� 5    
   $��3��6   $��0��6   $��Center=�6-   $	��Top=�6J   $��0,10,0,0q�6b   $��17(�6t   $
��Bold"�6�   .��6�   Straat6�   �� 5!   
   $��3��66   $��0��6C   $��Center=�6S   $��Center=�6p   $	��170��6�   $��15(�6�   ��6   �� *Straat+$ TwoWay=�6�   �� 5"   
   $��3��6   $��2��6   $��Center=�61   $	��Top=�6N   $��0,10,0,0q�6f   $��17(�6x   $
��Bold"�6�   .��6�   Nummer6�   �� 5#   
   $��3��6:   $��2��6G   $��Center=�6[   $��Center=�6x   $��35��6�   $��15(�6�   ��6   �� *
Huisnummer+$ TwoWay=�6�   �� 5$   
   $��3��6   $��1��6   $��Center=�6-   $	��Top=�6J   $��0,10,0,0q�6b   $��17(�6t   $
��Bold"�6�   .��6�   
Gemeente6�   �� 5%   
   $��3��68   $��1��6E   $��Center=�6U   $��Center=�6r   $	��170��6�   $��15(�6�   ��6   �� *
Gemeente+$ TwoWay=�6�   �� 5&   
   $��4��6   $��1��6   $��Center=�6.   $��Center=�6I   $��25(�6f   $��45��6t   ���#c3dbf7
���   ���6�   �� *InsertGebruikerCommand+.��6�   Registreren6�   5'      5(      