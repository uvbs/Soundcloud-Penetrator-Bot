   M S B A M L   `   `   `  ����T  PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  5   	   T PCefSharp.Wpf, Version=55.0.0.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138A0clr-namespace:CefSharp.Wpf;assembly=CefSharp.WpfCefSharp.Wpf 5   	   P LSoundcloud Penetrator, Version=0.7.2.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MPBMPB 5   	   >/clr-namespace:ControlzEx;assembly=MahApps.Metro
ControlzEx  5	   	      MPB.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     5   	   @wpf0clr-namespace:CefSharp.Wpf;assembly=CefSharp.Wpf     5   	   #localclr-namespace:MPB     5   	   F
ControlzEx/clr-namespace:ControlzEx;assembly=MahApps.Metro     5	   	     � WindowState$  Normal=�5   	    � Icon$ icon.ico��5   	   $��0q�5   	   (   "MahApps.Metro.Controls.MetroWindow   	GlowBrush
 �   � � 
ResizeMode$ CanResizeWithGrip=�5   	      WindowTransitionsEnabled .   � WindowStartupLocation$ CenterScreen=�5   	    � Title$' !Soundcloud Penetrator v0.7.2alpha��5   	      	TitleCaps .    ShowIconOnTitleBar . 	   ShowTitleBar	 . 
 �� ClearTypeHint$
 Enabled=�5   	   &   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�5   	   $	��800��62   $
��1232��6?   $	��800��6L   $
��1232��6\   $��Center=�6l      Flyouts 5      +   %MahApps.Metro.Controls.FlyoutsControl  5   
   .@�5      #   MahApps.Metro.Controls.Flyout  -   5          Name$ Helpdesk��5         Header$ HelpDesk��60      Position$ Right=�6B   $	��400��6S      AnimateOpacity . .��5      �� -   5         ��Name$ helpDeskDoc��5      $	��Top=�63   $	��350��6K   $	��640��6W   
�������" �� VerticalScrollBarVisibility$ Visible=�6w   $ �� HorizontalScrollBarVisibility$ Disabled=�6�   5      5         RightWindowCommands 5"      +   %MahApps.Metro.Controls.WindowCommands  5#   
   .@�5$      �� -   5         ��Name$ soundcloudViewButton��5$      .��5%      ��  �� Orientation$ 
Horizontal=�6   .+�5&      �� $��40��6    $��20��5'      ��5(      ��  �� RelativeSource ��  �� AncestorType$ ButtonL� �� Path$ 
Foreground� J� OpacityMask 5)      !� 5*         appbar_social_soundcloud !� Visual# [  6*   5,      �� 5-      $��4 0 0 0q�6    $��Center=�5.      $��
Soundcloud��5/      50      51      �� 52      -   5        .��53      �� $ 
Horizontal=�6   .+�54      �� $��20��6    $��20��55      ��56      ��  �� $ ButtonL�$ 
Foreground� 57      !� 58        appbar_settings# [ 6*   5:      �� 5;      $��4 0 0 0q�6    $��Center=�5<      $��Settings��5=      5>      5?      �� 5@      -   5        .��5A      �� $ 
Horizontal=�6   .+�5B      �� $��15��6    $��20��5C      ��5D      ��  �� $ ButtonL�$ 
Foreground� 5E      !� 5F        appbar_question# [ 6*   5H      �� 5I      $��4 0 0 0q�6    $��Center=�5J      $
��Help��5K      5L      5M      5N      .��5W      � -   5         �Name$ MPB_Main��5W       � UseLayoutRounding .  � RowDefinitions 5Y   
   �� 5Z      �� 5[      $
��Auto �6   .+�5]   
   � -   5        $ soundcloudView��5]      $��0,0,-20,584q�6'   $��Disabled=�6<    K� ZIndex$ -1��6p   $��Center=�6�     � ColumnDefinitions  5^      �� 5_      $
��300* �6#   �� 5`      $	��13* �6#   .+�5c      �� -   5        ! ��Name$! txtBox_songUrl��5c      $
��Left=�6.   $��23��6I   $��4,21,0,0q�6U   " �� TextWrapping$
" Wrap=�6g   $	��Top=�6{   $	��324��6�   4  .System.Windows.Automation.AutomationProperties#   HelpText$-# 'Please type in your soundcloud song url��6�   $��Segoe UI Light)�6   �� 5d      -	   5        $ loadPageButton��5d      $
��LOAD��6-   $
��Left=�6<   $��
333,21,0,0q�6W   $	��Top=�6k   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   �� 5e      $��Soundcloud Link��6   $
��Left=�6.   $	��Top=�6I   $��30��6a   $��Segoe WP Light)�6m   �� 5f      -
   5        $ genPlaysButton��5f      $
��AUTO��6-   $
��Left=�6<   $��	4,142,0,0q�6W   $	��Top=�6j   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   �� 5g      $��plays:��6   $
��Left=�6%   $��161,141,0,0q�6@   $	��Top=�6U   $��30��6m   $��Segoe WP Light)�6y   �� 5h      -   5        $ ��Name$$ genPlaysNumber��5h      $��0��6,   $
��Left=�68   $��193,142,0,0q�6S   $	��Top=�6h   $��30��6�   $��Segoe WP Light)�6�   $��53��6�   �� 5i      -   5        $! maxPlays��5i      $
��Left=�6(   $��23��6C   $��5,66,0,0q�6O   $
" Wrap=�6a   $	��100��6u   $	��Top=�6�   $��59��6�   �� 5j      $��
Max. Plays��6   $
��Left=�6)   $��0,44,0,0q�6D   $	��Top=�6V   $��30��6n   $��Segoe WP Light)�6z   �� 5k      -   5        $ genPlaysCancel��5k      $��Cancel��6-   $
��Left=�6>   $��
86,142,0,0q�6Y   $	��Top=�6m   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   �� 5l      $��TbP (in Sec.)��6   $
��Left=�6,   $��0,88,0,0q�6G   $	��Top=�6Y   $��30��6q   $��Segoe WP Light)�6}   �� 5m      -   5        $! tbPlays��5m      $
��Left=�6'   $��23��6B   $��	6,110,0,0q�6N   $
" Wrap=�6a   $	��100��6u   $	��Top=�6�   $��59��6�   �� 5n      -   5        % ��Name$% proxyChechbox��5n      $��	Proxylist��6.   $
��Left=�6B   $��333,115,0,0q�6]   $	��Top=�6r   $��Segoe UI Light)�6�   6�   �� 5o      -   5        $ loadProxies��5o      $��GET PROXIES��6*   $
��Left=�6@   $��
333,51,0,0q�6[   $	��Top=�6o   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   �� 5p      -   5        & ��Name$& proxyListbox��5p      $
��Left=�6,   $	��159��6G   $��
414,21,0,0q�6T   $	��Top=�6h   $	��113��6�   ���	#FF2D2D30$��10(�6�   $��Segoe UI Semilight)�6�   $��Visible=�6�   ' �� SelectedIndex$' 0��6  $��Disabled=�6  ��5q      �� 5r      ( �� 
TargetType"( ��6   .�5s      �� ) �� Property) � ��* �� Value$* 14��63   �� 5t      ) � ��$* Visible=�6U   5u      5w      �� 5x      -   5        $$ proxylistLabel��5x      $��
Proxy list��6,   $
��Left=�6A   $��	409,0,0,0q�6\   $	��Top=�6o   $��30��6�   $��Segoe WP Light)�6�   �� 5y      -   5        $ accountLoginButton��5y      $��LOGIN��61   $
��Left=�6A   $��
660,21,0,0q�6\   $	��Top=�6p   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   �� 5z      -   5        $ accountLogoutButton��5z      $��SIGN OUT��62   $
��Left=�6E   $��
660,51,0,0q�6`   $	��Top=�6t   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   �� 5{      -   5        $! 
userNameTb��5{      $
��Left=�6*   $��23��6E   $��
535,21,0,0q�6Q   $
" Wrap=�6e   $	��Top=�6y   $	��120��6�   $��Segoe UI Light)�6�   �� 5|      -   5        $$ accountNameLabel��5|      $��Accountname��6.   $
��Left=�6D   $��	530,0,0,0q�6_   $	��Top=�6r   $��30��6�   $��Segoe WP Light)�6�   �� 5}      -   5        $! 
passwordTb��5}      $
��Left=�6*   $��23��6E   $��
535,66,0,0q�6Q   $
" Wrap=�6e   $	��Top=�6y   $	��120��6�   $��Segoe UI Light)�6�   �� 5~      -   5        $$ passwordLabel��5~      $��Password��6+   $
��Left=�6>   $��
530,45,0,0q�6Y   $	��Top=�6m   $��30��6�   $��Segoe WP Light)�6�   &   System.Windows.Controls.DataGrid  5      -   5        +  Name$+ accountListDataGrid��5      $
��Left=�64   $	��158��6O   $��
740,21,0,0q�6\   $	��Top=�6p   ,   GridLinesVisibility$, 
Horizontal=�6�   -   ColumnHeaderHeight$- 5Q�6�   .   HeadersVisibility$
. None=�6�   $ -1��6�   $��10(�6�   $��Segoe UI Semilight)�6�   $	��296��6R  $/   HorizontalScrollBarVisibility$/ Disabled=�6^  ���	#FF2D2D300   SelectionMode$0 Single=�6�  1   CanUserReorderColumns1 .  2   CanUserResizeColumns2 .  3   CanUserSortColumns3 .  4   HorizontalGridLinesBrush4 �	#FF6868685   VerticalGridLinesBrush5 �	#FF6868686   RowHeaderWidth$6 5Q�6T  ���	#FF2D2D30"7   VerticalScrollBarVisibility$7 Visible=�6~  $��0q�6�  8 � ContextMenu8 5�      �� 5�      .@�5�      m� -   5        $��Delete��5�   #   5�      5�      5�      �� 5�      -   5        $ saveAccounts��5�      $��	SAVE LIST��6+   $
��Left=�6?   $��1041,13,0,0q�6Z   $	��Top=�6o   $��75��6�   $��23��6�   $��Segoe UI Light)�6�     5�      -   5        $+ additionalSongs��5�      $
��Left=�60   $��82��6K   $��	70,51,0,0q�6W   $	��Top=�6j   $	��258��6�   $
. None=�6�   $/ Disabled=�6�   $7 Disabled=�6�   $��10(�6�   $��Segoe UI Semilight)�6  $, 
Horizontal=�6%  ���	#FFFEFEFF���	#FF2D2D309   	RowHeight$9 4Q�6�  $0 Single=�6�  :   CanUserResizeRows: .  ;   RowDetailsVisibilityMode$; Visible=�6�  1 .  2 .  3 .  8 5�      �� 5�      .@�5�      m� -   5        $��Delete��5�   #   5�      5�      5�      �� 5�      $�� ��6   $
��Left=�6   $��	65,44,0,0q�6:   $	��Top=�6M   $��30��6e   $��Segoe WP Light)�6q   �� 5�      -   5        $% rotationCheckBox��5�      $��Rotation��61   $
��Left=�6D   $��333,137,0,0q�6_   $	��Top=�6t   $��Segoe UI Light)�6�   �� 5�      -   5        $ genPlaysCancel_Copy��5�      $��	SAVE LIST��62   $
��Left=�6F   $��251,142,0,0q�6a   $	��Top=�6v   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   �� 5�      -    5        $ autoFollowButt��5�      $��	FOLLOWBOT��6-   $
��Left=�6A   $��
660,82,0,0q�6\   $	��Top=�6p   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   $��10(�6�   �� 5�      -!   5        $ autoFollowButt_Copy��5�      $��♥ HELICOPTER��62   $
��Left=�6I   $��660,113,0,0q�6d   $	��Top=�6y   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   $��10(�6�   �� 5�      -"   5        $$ accountListLabel��5�      $��Accountlist��6.   $
��Left=�6D   $��	735,0,0,0q�6_   $	��Top=�6r   $��30��6�   $��Segoe WP Light)�6�   �� 5�      ���	#FF333337$
��Left=�6)   $��2��6D   $��
804,13,0,0q�6O   $	��Top=�6c   $	��232��6{   �� 5�      ���	#FF333337$
��Left=�6)   $��2��6D   $��
613,13,0,0q�6O   $	��Top=�6c   $	��122��6{   �� 5�      ���	#FF333337$
��Left=�6)   $��2��6D   $��
466,13,0,0q�6O   $	��Top=�6c   $��59��6{   �� 5�      ���	#FF333337$
��Left=�6)   $��2��6D   $��	94,13,0,0q�6O   $	��Top=�6b   $	��314��6z   � 5�      -#   5        $ 
Max_Counts��5�      $��529,89,465,52q�6'   .+�5�      �� -$   5        $! maxFollowAccountsTxtBox��5�      $
��Left=�6;   $��5,18,0,0q�6V   $
" Wrap=�6h   $	��Top=�6|   $��35��6�   $��Segoe UI Semilight)�6�   $��23��6�   �� 5�      -%   5        $$ maxFollowLabel��5�      $��Follows��60   $
��Left=�6B   $	��Top=�6]   $��Segoe UI Semilight)�6u   $��10(�6�   �� 5�      -&   5        $! maxLikesTxtBox��5�      $
��Left=�62   $��	45,18,0,0q�6M   $
" Wrap=�6`   $	��Top=�6t   $��35��6�   $��Segoe UI Semilight)�6�   $��23��6�   �� 5�      -'   5        $$ maxFollowLabel_Copy1��5�      $��Likes��66   $
��Left=�6F   $��40,0,0,0q�6a   $	��Top=�6s   $��Segoe UI Semilight)�6�   $��10(�6�   �� 5�      -(   5        $! maxRepostsTxt��5�      $
��Left=�61   $��	85,18,0,0q�6L   $
" Wrap=�6_   $	��Top=�6s   $��35��6�   $��Segoe UI Semilight)�6�   $��23��6�   �� 5�      -)   5        $$ maxFollowLabel_Copy4��5�      $��Reposts��66   $
��Left=�6H   $��80,0,0,0q�6c   $	��Top=�6u   $��Segoe UI Semilight)�6�   $��10(�6�   5�      � 5�      -*   5        $ Counter_Labels��5�      $��529,131,522,3q�6+   .+�5�      �� -+   5        $$ maxFollowLabel_Copy��5�      $��	followed:��65   $
��Left=�6I   $	��Top=�6d   $��30��6|   $��Segoe WP Light)�6�   �� 5�      -,   5        $$ followedAccountsL��5�      $��0��63   $
��Left=�6?   $��
48,1,-54,0q�6Z   $	��Top=�6n   $��30��6�   $��Segoe WP Light)�6�   $��71��6�   �� 5�      --   5        $$ maxFollowLabel_Copy2��5�      $��liked:��66   $
��Left=�6G   $��	20,15,0,0q�6b   $	��Top=�6u   $��30��6�   $��Segoe WP Light)�6�   �� 5�      -.   5        $$ 
likedLabel��5�      $��0��6,   $
��Left=�68   $��48,15,-54,0q�6S   $	��Top=�6h   $��30��6�   $��Segoe WP Light)�6�   $��71��6�   �� 5�      -/   5        $$ maxFollowLabel_Copy3��5�      $��reposts:��66   $
��Left=�6I   $��5,29,0,0q�6d   $	��Top=�6v   $��30��6�   $��Segoe WP Light)�6�   �� 5�      -0   5        $$ repostsLabel��5�      $��0��6.   $
��Left=�6:   $��48,30,-54,-9q�6U   $	��Top=�6k   $��30��6�   $��Segoe WP Light)�6�   $��71��6�   5�      �� 5�      -1   5        $ autoRepostButton��5�      $��
REPOSTOMAT��6/   $
��Left=�6D   $��660,144,0,0q�6_   $	��Top=�6t   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   $��10(�6�   �� 5�      -2   5        $ loadProxies_Copy��5�      $
��EDIT��6/   $
��Left=�6>   $��
333,81,0,0q�6Y   $	��Top=�6m   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   5�      � 5�   
   -3   5        $ settingsView��5�      $��10,0,10,589q�6%   $��Center=�6:   $
��1204��6W   .+�5�      �� -4   5        $ devToolsButton��5�      $��	DEV TOOLS��6-   $
��Left=�6A   $��1026,47,0,0q�6\   $	��Top=�6q   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   $��10(�6�   �� 5�      $��Center=�6   $��0,19,0,0q�65   $
��Wrap=�6G   $	��Top=�6[   $��17��6s   $	��270��6   $��Segoe UI Semilight)�6�   $8��2Copyright 2017 - Soundcloud Penetrator 0.7.2 alpha��6�   �� 5�      ���	#FF333337$
��Left=�6)   $��2��6D   $��	10,38,0,0q�6O   $	��Top=�6b   $
��1184��6z   �� 5�      -5   5        $ devToolsButton_Copy��5�      $��GANGBANG��62   $
��Left=�6E   $��1116,47,0,0q�6`   $	��Top=�6u   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   $��10(�6�   � 5�      -6   5        $ License_Grid��5�      $��0,20,0,0q�6)   $��Center=�6;   $	��564��6X   $��Center=�6d   .+�5�      �� -7   5        $! publicKeyTb��5�      $
��Left=�6/   $��76��6J   $��3,20,0,0q�6V   $
" Wrap=�6h   $	��Top=�6|   $	��270��6�   $��Segoe UI Semilight)�6�   �� 5�      $��Enter the public key:��6   $
��Left=�68   $	��Top=�6S   $��Segoe UI Semilight)�6k   �� 5�      -8   5        $! 	licenseTb��5�      $
��Left=�6-   $��76��6H   $��
283,20,0,0q�6T   $
" Wrap=�6h   $	��Top=�6|   $	��270��6�   $��Segoe UI Semilight)�6�   < �� 
IsReadOnly< . 6�   �� 5�      $ ��License Validation result:��6   $
��Left=�6=   $��	280,0,0,0q�6X   $	��Top=�6k   $��Segoe UI Semilight)�6�   �� 5�      -9   5        $ validateLicenseButton��5�      $��VALIDATE��68   $
��Left=�6K   $��198,102,0,0q�6f   $	��Top=�6{   $��75��6�   $��23��6�   $��Segoe UI Light)�6�   $��10(�6�   5�      5�      %  CefSharp.Wpf.ChromiumWebBrowser  5�   
   -:   5        =  Name$= Browser��5�   !   $��0��5�   !   $��	0,185,0,0q�5�   !   %	   ControlzEx.KeyboardNavigationEx> 	  AlwaysShowFocusVisual> . $��Stretch=�5�   J   ��5�   !   Z� 5�   J   5�      5�      