   M S B A M L   `   `   `  ����>  :CA2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:CA2CA2  5   	       CA2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   #localclr-namespace:CA2     5   	   -   5          � Title$  
MainWindow��5   	   $	��450��6   $��890.4��6)   .��5	      �  � ColumnDefinitions 5
   
   �� 5      $��9* �6   �� 5      $	��59* �6   .+�5   
   �� -   5         ��Name$ btnAdd��5      $	��Add��6!   $
��Left=�6/   $��310.6,163,0,0q�6J   $	��Top=�6a   $��75��6y   $��1��6�   �� 5   
   -   5        $ 	btnRemove��5      $��Remove��6$   $
��Left=�65   $��310.6,238,0,0q�6P   $	��Top=�6g   $��75��6   $��1��6�   �� 5   
   -   5         ��Name$ lbxAllActivities��5      $
��Left=�6,   $	��250��6G   $��
7.6,96,0,0q�6T   $	��Top=�6h   $	��250��6�   $��1��6�   �� 5   
   -   5        $ lbxSelectedActivities��5      $
��Left=�61   $	��250��6L   $��425.6,96,0,0q�6Y   $	��Top=�6o   $	��250��6�   $��1��6�   	� 5   
   -   5         	�Name$ radioAll��5      $	��All��6(   $
��Left=�66   $��
24,120,0,0q�6Q   $	��Top=�6e    d� 	IsChecked$
 TrueY�6�   6�   	� 5   
   -   5        $ 	radioLand��5      $
��Land��6)   $
��Left=�68   $��
22,165,0,0q�6S   $	��Top=�6g   6   	� 5   
   -   5        $ radioAir��5      $	��Air��6(   $
��Left=�66   $��
22,254,0,0q�6Q   $	��Top=�6e   6}   	� 5   
   -	   5        $ 
radioWater��5      $��Water��6*   $
��Left=�6:   $��
22,212,0,0q�6U   $	��Top=�6i   6�   �� 5   
   -
   5         ��Name$ lblAllActivities��5      $��All Activities��6*   $��1��6C   $
��Left=�6S   $��10.2,70,0,0q�6n   $	��Top=�6�   �� 5   
   -   5        $ lblSelectedActivities��5      $��Selected Activities��6/   $��1��6M   $
��Left=�6]   $��425.2,70,0,0q�6x   $	��Top=�6�   �� 5   
   -   5        $ lblActivityPlanner��5      $��Activity Planner��6,   $
��Left=�6G   $	��Top=�6b   $��1��6z   $��
0.2,20,0,0q�6�   $��32(�6�   ���	#FF28A9D96�   �� 5   
   -   5        $ lblTotalCost��5      $��Total Cost:��6&   $��1��6<   $
��Left=�6L   $��587.2,42,0,0q�6g   $	��Top=�6}   �� 5   
   -   5         ��Name$ tblkTotalCost��5      $��1��6+   $
��Left=�6;   $��665.2,46,0,0q�6V   $
��Wrap=�6l   $	��Top=�6�   6�   �� 5   
   -   5        $ lblDescription��5      $��Description : ��6(   $��1��6A   $
��Left=�6Q   $��10.2,371,0,0q�6l   $	��Top=�6�   �� 5   
   -   5        $ tblkDescription��5      $
��Left=�6-   $
��Wrap=�6H   $	��Top=�6\   $��1��6t   $��103.2,376,0,0q�6�   6�   5      5      