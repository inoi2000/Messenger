   M S B A M L   `   `   `  ����G  CTopMessenger, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null+clr-namespace:TopMessengerTopMessenger  5   	   A%clr-namespace:TopMessenger.ViewModelsTopMessenger.ViewModels  5	   	   #    TopMessenger.Views.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   Z VFontAwesome.WPF, Version=4.7.0.37774, Culture=neutral, PublicKeyToken=0758b07a11a4f466-fa$http://schemas.fontawesome.io/icons/  5   	   &localclr-namespace:TopMessenger  5   	   .vm%clr-namespace:TopMessenger.ViewModels  5	   	   -   5          � Title$  
MainWindow��5
   	   $	��600��6   $	��900��6)    � WindowStyle$
 None=�5   	    � 
ResizeMode$ CanResizeWithGrip=�5   	    � AllowsTransparency . ���#B6B0AE � DataContext 5      +   %TopMessenger.ViewModels.MainViewModel  5   
   -   5        
MainVM��5   -   .��5      ]� .+�5   
   �� $	��Top=�6      WindowBorder#��[  5      o� 5   
   ���#615E5E$	��Top=�6$   .@�5      m� $��Application��6   
�������.@�5      m� $��Close��6   
�������.  (System.Windows.Input.ApplicationCommands   Close m� Command# Z 5      5       5!      � 5"   
    � ColumnDefinitions 5#      �� 5$      $	��250 �6#   �� 5%      .+�5'      � $��1��6    � RowDefinitions 5(      �� 5)      $��80 �6$   62   �� 5*      6&   �� 5+      $	��100 �6$   64   .+�5-      �� $��0��6   ._�5/      � $��Stretch=�6   $��10,0,0,0q�50      .+�52      �� $
��Bold"�6$   $��20(�53       $��	10,10,0,0q�54       $��Center=�55       ��57      `� 58   "   	 �� StringFormat$	  {0} {1}��6/   .1�59   &   �� 
 �� Path$
 SelectedFriend.FirstName�6.   �� 5:   &   $
 SelectedFriend.LastName�6.   5;   #   5=      �� 5>       �� Orientation$ 
Horizontal=�6%   $��Right=�5?   %   .+�5A      "  FontAwesome.WPF.ImageAwesome     Icon$ VideoCamera=�6.   $��35��6A   $��0,0,15,0q�5B   .     5D      $ Phone=�6.   $��35��6;   $��0,0,10,0q�5E   .   5G      5H      5I      �� 5J      
������ $��1��5K      $��10,0,0,0q�5L        	ChatStyle#��[ 5N      ��5M      �� *ChatWithUser+5N      � 5P      $��2��6    5Q      �� 5R      6-   �� 5S      $��80 �6+   68   .+�5U      �� $��0��6   $�� ��5V        CustomTextBox#��[ 5W      �� 5Y      $��1��6   $��45��5Z      $��45��6(   $��0,0,10,0q�5[      ��5\      �� *SendMessageCommand+��5]      �� 5^      .R�5_   "     $
 Send=�62   5`      5b      5c      5d      � 5e      $��0��6    5f      �� 5g      $��80 �6$   �� 5h      .+�5j      A�  A� Columns$ 2��6   .+�5k      �� $��Friends��6   $��Center=�5l      $
��Bold"�5m      $��15,0,0,0q�5n      �� 5p      -   5        $��30��5p      $��30��6(   $��30(�5q      ��5s      �� 5t       �� 
TargetType" ��6.   .R�5u   "   !  FontAwesome.WPF.FontAwesome     Icon$ 
PlusSquare=�61   $��30��6C   $��30��6N   5w   #   5x      5z      5{      �� 5|      $��1��6   
������   FriendListStyle#��[ 5~      ��5      �� *	Friends+ �� SelectedItem 5�      �� *SelectedFriend+5�      5�      5�      5�      5�      