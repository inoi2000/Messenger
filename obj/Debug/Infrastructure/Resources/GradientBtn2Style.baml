   M S B A M L   `   `   `  ����R  NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� 
TargetType   GradientBtn2 �� Property �� Value �� 
StartPoint �� EndPoint � Color � Offset �� Triggers :� RoutedEvent	 ��Name
 �� 
TargetName �� TargetProperty �� From	 �� To g� Duration g� AutoReverse g� RepeatBehavior �� BeginStoryboardName�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      %?  &	        �� 5      "  ��6   .�5   
   ��  � �� 5      �� 5      .R�5      � .+�5      �� ��5	      �� 5
   "   $	 0,0&�66   $	 1,1&�6G   .��5   &   � 	grad1��$	 Red��6B   $	 0.0Q�6N   6]   � 5   &   	grad2��$ Orange��6B   $	 0.2Q�6Q   6`   � 5   &   	grad3��$ Yellow��6B   $	 0.4Q�6Q   6`   � 5   &   	grad4��$ Green��6B   $	 0.6Q�6P   6_   � 5   &   	grad5��$
 Blue��6B   $	 0.8Q�6O   6^   5   #   5      5       5      :� 5      $ Button.Click��6'   .[�5      �� $	 gradient��6.   .��5   "   �� .��5   &   �� $
 grad1��65   $ Color�5   )   $	 RedX�5   )   $ OrangeX�64   $ 0:0:5D�5   )    . $ Forever��5   )   5   '   �� 5   &   $
 grad2��65   $ Color�5    )   $ OrangeX�5!   )   $ YellowX�67   $ 0:0:5D�5"   )    . $ Forever��5#   )   5%   '   �� 5&   &   $
 grad3��65   $ Color�5'   )   $ YellowX�5(   )   $ GreenX�67   $ 0:0:5D�5)   )    . $ Forever��5*   )   5,   '   �� 5-   &   $
 grad4��65   $ Color�5.   )   $ GreenX�5/   )   $
 BlueX�66   $ 0:0:5D�50   )    . $ Forever��51   )   53   '   �� 54   &   $
 grad5��65   $ Color�55   )   $
 BlueX�56   )   $	 RedX�65   $ 0:0:5D�57   )    . $ Forever��58   )   5:   '   5;   #   5<      5=      :� 5?      $ Button.MouseEnter��6'   .[�5@      �� $ gradient��6/   5A      :� 5C      $ Button.MouseLeave��6'   .[�5D      ?� $ gradient��6.   5E      5G      5I      5J      5K      