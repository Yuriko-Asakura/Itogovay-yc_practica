   M S B A M L   `   `   `  ����I  Eitog-yc-proect, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:itog_yc_proect.Sotrudniki.Yslygi itog_yc_proect.Sotrudniki.Yslygi  5   	   2    ,itog_yc_proect.Sotrudniki.Yslygi.nach_Ysluga   5   	   _ [MaterialDesignThemes.Wpf, Version=4.8.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:itog_yc_proect.Sotrudniki.Yslygi     5   	     � Title$  nach_Ysluga��5	   	   $	��450��6   $	��800��6*   .��5
      �  � ColumnDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      �� 5       � RowDefinitions 5   
   �� 5      �� 5      �� 5      �� 5      �� 5      �� 5      .+�5   
   �� -   5         ��Name$	 dob��5      $��6��6   $��Добавить��6.   $
��Left=�6A   $��2��6\   $	��176��6p   $��	22,19,0,0q�6|   6�   �� 5   
   -   5        $	 del��5      $��6��6   $��Удалить��6.   $
��Left=�6@   $��1��6[   $	��Top=�6h    J� RenderTransformOrigin$ 0.428,0.662&�6�   $��2��6�   $	��174��6�   $��55��6�   $��	22,18,0,0q�6�   $��2��6�   6�   �� 5   
   -   5        $	 izm��5      $��6��6   $��Изменить��6.   $
��Left=�6A   $��2��6\   $	��Top=�6i   $��2��6�   $��52��6�   $	��180��6�   $��	22,20,0,0q�6�   6�   �� 5    
   -   5        $ Vernutsa��5       $��6��6#   $,��&Вернуться на главную��63   $
��Left=�6R   $��5��6m   $	��Top=�6z   $��2��6�   $��52��6�   $	��180��6�   $��	20,20,0,0q�6�   6�   &   System.Windows.Controls.DataGrid  5!   
   -   5          Name$ spisok��5!      $��6��6n   $��
35,36,10,0q�6�   $��4��6�   ��6$   �� *Users+6�   �� 5"   
   -   5         ��Name$ yslugi��5"      )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ Услуга��6"   $��2��6�   $
��Left=�6�   $��37��6�   $��	65,22,0,0q�6�   $��4��6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6  $	��135��6  ���	#FFD4DCFB��6J   �� 	 �� Path$8	 2SelectedItem.Наименование_услуги�
 �� ElementName$
 spisok��6(  �� 5#   
   -   5         ��Name$ 	sotrudnik��5#      $ Сотрудник��6&   $��2��6�   $
��Left=�6�   $��	82,24,0,0q�6�   $��4��6�   $	��Top=�6�   $	��106��6�   $��37��6  ���	#FFD4DCFB$��3��6+   �� Text 6Q   �� $(	 "SelectedItem.Сотрудник_id�$
 spisok��6+  �� 5$   
   -   5        $ chena��5$      $��2��6!   $ Цена��65   $
��Left=�6�   $��37��6�   $��	15,22,0,0q�6�   $��4��6�   $
 Wrap=�6�   $	��Top=�6�   $	��135��6
  ���	#FFD4DCFB$��2��6-  ��6[   �� $	 SelectedItem.Цена�$
 spisok��6-  5%      5'      