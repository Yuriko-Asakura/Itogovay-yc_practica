   M S B A M L   `   `   `  ����I  Eitog-yc-proect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:itog_yc_proectitog_yc_proect  5   	       itog_yc_proect.Status   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   .localclr-namespace:itog_yc_proect     5   	     � Title$  Status��5	   	   $	��450��6   $	��800��6%   .��5
      � ��5   
   �� 5       �� EndPoint$ 0.5,1&�6"    �� 
StartPoint$ 0.5,0&�63   .��5      �  � Color$ 	#FFD6A6DE��6   � 5      $ 	#FFD09EE4��6    � Offset$ 1Q�61   � 5      $ 	#FFCAFDF3��6   $
 0.49Q�61   5       � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5       .+�5"   
   &   System.Windows.Controls.DataGrid  -   5          Name$ spisok��5"      $��4��6l   $��
39,19,10,0q�6�   $��4��6�   ��6N   �� *Users+6�   �� 5#   
   -   5         ��Name$	 dob��5#      $��4��6   $��Добавить��6.   $
��Left=�6A   $��
114,65,0,0q�6\   $��2��6p   $	��Top=�6�   $��3��6�   $��40��6�   $	��153��6�   6�   �� 5$   
   -   5        $	 del��5$      $��4��6   $��Удалить��6.   $
��Left=�6@   $��
114,37,0,0q�6[   $	��Top=�6o   $��3��6�   $��40��6�   $	��153��6�   $��1��6�   6�   �� 5%   
   -   5        $	 izm��5%      $��4��6   $��Изменить��6.   $
��Left=�6A   $��
114,10,0,0q�6\   $	��Top=�6p   $��3��6�   $��40��6�   $	��153��6�   $��2��6�   	 � Cursor$
	 Hand��6�   6�   �� 5&   
   -   5        $ nazad��5&      $��4��6    $#��Вернуться назад��60   $
��Left=�6J   $��	114,4,0,0q�6e   $	��Top=�6x   $��3��6�   $��40��6�   $	��153��6�   $��3��6�   6�   �� 5'   
   -   5        
 ��Name$
 Rolsot��5'      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Статус��6^   $��2��6�   $
��Left=�6�   $��37��6�   $��84,0,0,0q�6�   $��4��6�    �� TextWrapping$
 Wrap=�6�   $��Center=�6�   $	��135��6  
�������$��1��6.  ��6"   ��  �� Path$ SelectedItem.Роль� �� ElementName$ spisok��6.  5(      5)      