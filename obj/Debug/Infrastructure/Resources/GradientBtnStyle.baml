   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   GradientBtn �� Property �� Value �� 
StartPoint �� EndPoint � Color � Offset �� Triggers :� RoutedEvent	 ��Name
 �� 
TargetName �� TargetProperty �� From	 �� To g� Duration g� AutoReverse g� RepeatBehavior W� From	 W� To �� BeginStoryboardName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %�  &	        �� 5      "  ��6   .�5   
   ��  � �� 5      �� 5      .R�5      � .+�5      �� ��5	      �� 5
   "   $	 0,0&�66   $	 1,1&�6G   .��5   &   � 	grad1��$	 Red��6B   $ 0Q�6N   6[   � 5   &   	grad2��$ Orange��6B   $
 0.25Q�6Q   6a   � 5   &   	grad3��$ Purple��6B   $
 0.50Q�6Q   6a   � 5   &   	grad4��$ Brown��6B   $
 0.75Q�6P   6`   5   #   5      5       5      :� 5      $ Button.Click��6'   .[�5      �� $	 gradient��6.   .��5   "   �� .��5   &   �� $
 grad1��65   $ Color�5   5   $	 RedX�5   5   $ OrangeX�6@   $ 0:0:10D�5   5    . $ Forever��5   5   5   '   5   #   5      �� 5!      .��5"   "   �� .��5#   &   �� $
 grad2��65   $ Color�5$   5   $ OrangeX�5%   5   $ PurpleX�6C   $ 0:0:10D�5&   5    . $ Forever��5'   5   5)   '   5*   #   5+      �� 5-      .��5.   "   �� .��5/   &   �� $
 grad3��65   $ Color�50   5   $ PurpleX�51   5   $ BrownX�6C   $ 0:0:10D�52   5    . $ Forever��53   5   55   '   56   #   57      �� 5A      $	 	gradient2��6.   .��5B   "   �� .��5C   &   W� $
 grad4��66   $ Offset�5D   6   $
 0.75X�5E   6   $	 0.0X�6B   $ 0:0:5D�5F   6    . $ Forever��5G   6   5J   '   5K   #   5L      5M      :� 5O      $ Button.MouseLeave��6'   .[�5P      �� $ 	gradient2��6-   5R      5S      5U      5W      5X      5Y      