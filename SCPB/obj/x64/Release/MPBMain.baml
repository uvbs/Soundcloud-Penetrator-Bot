   M S B A M L   `   `   `  ���� T  PMahApps.Metro, Version=1.4.3.0, Culture=neutral, PublicKeyToken=f4fb5a3c4d1e5b4fV;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.MetroMahApps.Metro.Controls  T PCefSharp.Wpf, Version=55.0.0.0, Culture=neutral, PublicKeyToken=40c4b6fc221f4138A0clr-namespace:CefSharp.Wpf;assembly=CefSharp.WpfCefSharp.Wpf P LSoundcloud Penetrator, Version=0.7.2.0, Culture=neutral, PublicKeyToken=nullclr-namespace:MPBMPB >/clr-namespace:ControlzEx;assembly=MahApps.Metro
ControlzEx     MPB.MainWindow   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     PControls;clr-namespace:MahApps.Metro.Controls;assembly=MahApps.Metro     @wpf0clr-namespace:CefSharp.Wpf;assembly=CefSharp.Wpf     #localclr-namespace:MPB     F
ControlzEx/clr-namespace:ControlzEx;assembly=MahApps.Metro       � WindowState$  Normal=� � Icon$ icon.ico��$��0q�(   "MahApps.Metro.Controls.MetroWindow   	GlowBrush
 �   � � 
ResizeMode$ CanResizeWithGrip=�   WindowTransitionsEnabled .   � WindowStartupLocation$ CenterScreen=� � Title$' !Soundcloud Penetrator v0.7.2alpha��   	TitleCaps .    ShowIconOnTitleBar . 	   ShowTitleBar	 . 
 �� ClearTypeHint$
 Enabled=�&   System.Windows.Media.TextOptions   TextFormattingMode$ Display=�$	��800��$
��1232��$	��800��$
��1232��$��Center=�   Flyouts +   %MahApps.Metro.Controls.FlyoutsControl  .@�#   MahApps.Metro.Controls.Flyout  -     Name$ Helpdesk��   Header$ HelpDesk��   Position$ Right=�$	��400��   AnimateOpacity . .���� -    ��Name$ helpDeskDoc��$	��Top=�$	��350��$	��640��
�������" �� VerticalScrollBarVisibility$ Visible=�$ �� HorizontalScrollBarVisibility$ Disabled=�   RightWindowCommands +   %MahApps.Metro.Controls.WindowCommands  .@��� -    ��Name$ soundcloudViewButton��.����  �� Orientation$ 
Horizontal=�.+��� $��40��$��20������  �� RelativeSource ��  �� AncestorType$ ButtonL� �� Path$ 
Foreground� J� OpacityMask !�    appbar_social_soundcloud !� Visual# [  �� $��4 0 0 0q�$��Center=�$��
Soundcloud���� -   .���� $ 
Horizontal=�.+��� $��20��$��20������  �� $ ButtonL�$ 
Foreground� !�   appbar_settings# [ �� $��4 0 0 0q�$��Center=�$��Settings���� -   .���� $ 
Horizontal=�.+��� $��15��$��20������  �� $ ButtonL�$ 
Foreground� !�   appbar_question# [ �� $��4 0 0 0q�$��Center=�$
��Help��.��� -    �Name$ MPB_Main�� � UseLayoutRounding .  � RowDefinitions �� �� $
��Auto �.+�� -   $ soundcloudView��$��0,0,-20,584q�$��Disabled=� K� ZIndex$ -1��$��Center=�  � ColumnDefinitions  �� $
��300* ��� $	��13* �.+��� -   ! ��Name$! txtBox_songUrl��$
��Left=�$��23��$��4,21,0,0q�" �� TextWrapping$
" Wrap=�$	��Top=�$	��324��4  .System.Windows.Automation.AutomationProperties#   HelpText$-# 'Please type in your soundcloud song url��$��Segoe UI Light)��� -	   $ loadPageButton��$
��LOAD��$
��Left=�$��
333,21,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)��� $��Soundcloud Link��$
��Left=�$	��Top=�$��30��$��Segoe WP Light)��� -
   $ genPlaysButton��$
��AUTO��$
��Left=�$��	4,142,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)��� $��plays:��$
��Left=�$��161,141,0,0q�$	��Top=�$��30��$��Segoe WP Light)��� -   $ ��Name$$ genPlaysNumber��$��0��$
��Left=�$��193,142,0,0q�$	��Top=�$��30��$��Segoe WP Light)�$��53���� -   $! maxPlays��$
��Left=�$��23��$��5,66,0,0q�$
" Wrap=�$	��100��$	��Top=�$��59���� $��
Max. Plays��$
��Left=�$��0,44,0,0q�$	��Top=�$��30��$��Segoe WP Light)��� -   $ genPlaysCancel��$��Cancel��$
��Left=�$��
86,142,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)��� $��TbP (in Sec.)��$
��Left=�$��0,88,0,0q�$	��Top=�$��30��$��Segoe WP Light)��� -   $! tbPlays��$
��Left=�$��23��$��	6,110,0,0q�$
" Wrap=�$	��100��$	��Top=�$��59���� -   % ��Name$% proxyChechbox��$��	Proxylist��$
��Left=�$��333,115,0,0q�$	��Top=�$��Segoe UI Light)��� -   $ loadProxies��$��GET PROXIES��$
��Left=�$��
333,51,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)��� -   & ��Name$& proxyListbox��$
��Left=�$	��159��$��
414,21,0,0q�$	��Top=�$	��113�����	#FF2D2D30$��10(�$��Segoe UI Semilight)�$��Visible=�' �� SelectedIndex$' 0��$��Disabled=����� ( �� 
TargetType"( ��.��� ) �� Property) � ��* �� Value$* 14���� ) � ��$* Visible=��� -   $$ proxylistLabel��$��
Proxy list��$
��Left=�$��	409,0,0,0q�$	��Top=�$��30��$��Segoe WP Light)��� -   $ accountLoginButton��$��LOGIN��$
��Left=�$��
660,21,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)��� -   $ accountLogoutButton��$��SIGN OUT��$
��Left=�$��
660,51,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)��� -   $! 
userNameTb��$
��Left=�$��23��$��
535,21,0,0q�$
" Wrap=�$	��Top=�$	��120��$��Segoe UI Light)��� -   $$ accountNameLabel��$��Accountname��$
��Left=�$��	530,0,0,0q�$	��Top=�$��30��$��Segoe WP Light)��� -   $! 
passwordTb��$
��Left=�$��23��$��
535,66,0,0q�$
" Wrap=�$	��Top=�$	��120��$��Segoe UI Light)��� -   $$ passwordLabel��$��Password��$
��Left=�$��
530,45,0,0q�$	��Top=�$��30��$��Segoe WP Light)�&   System.Windows.Controls.DataGrid  -   +  Name$+ accountListDataGrid��$
��Left=�$	��158��$��
740,21,0,0q�$	��Top=�,   GridLinesVisibility$, 
Horizontal=�-   ColumnHeaderHeight$- 5Q�.   HeadersVisibility$
. None=�$ -1��$��10(�$��Segoe UI Semilight)�$	��296��$/   HorizontalScrollBarVisibility$/ Disabled=����	#FF2D2D300   SelectionMode$0 Single=�1   CanUserReorderColumns1 .  2   CanUserResizeColumns2 .  3   CanUserSortColumns3 .  4   HorizontalGridLinesBrush4 �	#FF6868685   VerticalGridLinesBrush5 �	#FF6868686   RowHeaderWidth$6 5Q����	#FF2D2D30"7   VerticalScrollBarVisibility$7 Visible=�$��0q�8 � ContextMenu8 �� .@�m� -   $��Delete���� -   $ saveAccounts��$��	SAVE LIST��$
��Left=�$��1041,13,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)�  -   $+ additionalSongs��$
��Left=�$��82��$��	70,51,0,0q�$	��Top=�$	��258��$
. None=�$/ Disabled=�$7 Disabled=�$��10(�$��Segoe UI Semilight)�$, 
Horizontal=����	#FFFEFEFF���	#FF2D2D309   	RowHeight$9 4Q�$0 Single=�:   CanUserResizeRows: .  ;   RowDetailsVisibilityMode$; Visible=�1 .  2 .  3 .  8 �� .@�m� -   $��Delete���� $�� ��$
��Left=�$��	65,44,0,0q�$	��Top=�$��30��$��Segoe WP Light)��� -   $% rotationCheckBox��$��Rotation��$
��Left=�$��333,137,0,0q�$	��Top=�$��Segoe UI Light)��� -   $ genPlaysCancel_Copy��$��	SAVE LIST��$
��Left=�$��251,142,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)��� -    $ autoFollowButt��$��	FOLLOWBOT��$
��Left=�$��
660,82,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)�$��10(��� -!   $ autoFollowButt_Copy��$��♥ HELICOPTER��$
��Left=�$��660,113,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)�$��10(��� -"   $$ accountListLabel��$��Accountlist��$
��Left=�$��	735,0,0,0q�$	��Top=�$��30��$��Segoe WP Light)��� ���	#FF333337$
��Left=�$��2��$��
804,13,0,0q�$	��Top=�$	��232���� ���	#FF333337$
��Left=�$��2��$��
613,13,0,0q�$	��Top=�$	��122���� ���	#FF333337$
��Left=�$��2��$��
466,13,0,0q�$	��Top=�$��59���� ���	#FF333337$
��Left=�$��2��$��	94,13,0,0q�$	��Top=�$	��314��� -#   $ 
Max_Counts��$��529,89,465,52q�.+��� -$   $! maxFollowAccountsTxtBox��$
��Left=�$��5,18,0,0q�$
" Wrap=�$	��Top=�$��35��$��Segoe UI Semilight)�$��23���� -%   $$ maxFollowLabel��$��Follows��$
��Left=�$	��Top=�$��Segoe UI Semilight)�$��10(��� -&   $! maxLikesTxtBox��$
��Left=�$��	45,18,0,0q�$
" Wrap=�$	��Top=�$��35��$��Segoe UI Semilight)�$��23���� -'   $$ maxFollowLabel_Copy1��$��Likes��$
��Left=�$��40,0,0,0q�$	��Top=�$��Segoe UI Semilight)�$��10(��� -(   $! maxRepostsTxt��$
��Left=�$��	85,18,0,0q�$
" Wrap=�$	��Top=�$��35��$��Segoe UI Semilight)�$��23���� -)   $$ maxFollowLabel_Copy4��$��Reposts��$
��Left=�$��80,0,0,0q�$	��Top=�$��Segoe UI Semilight)�$��10(�� -*   $ Counter_Labels��$��529,131,522,3q�.+��� -+   $$ maxFollowLabel_Copy��$��	followed:��$
��Left=�$	��Top=�$��30��$��Segoe WP Light)��� -,   $$ followedAccountsL��$��0��$
��Left=�$��
48,1,-54,0q�$	��Top=�$��30��$��Segoe WP Light)�$��71���� --   $$ maxFollowLabel_Copy2��$��liked:��$
��Left=�$��	20,15,0,0q�$	��Top=�$��30��$��Segoe WP Light)��� -.   $$ 
likedLabel��$��0��$
��Left=�$��48,15,-54,0q�$	��Top=�$��30��$��Segoe WP Light)�$��71���� -/   $$ maxFollowLabel_Copy3��$��reposts:��$
��Left=�$��5,29,0,0q�$	��Top=�$��30��$��Segoe WP Light)��� -0   $$ repostsLabel��$��0��$
��Left=�$��48,30,-54,-9q�$	��Top=�$��30��$��Segoe WP Light)�$��71���� -1   $ autoRepostButton��$��
REPOSTOMAT��$
��Left=�$��660,144,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)�$��10(��� -2   $ loadProxies_Copy��$
��EDIT��$
��Left=�$��
333,81,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)�� -3   $ settingsView��$��10,0,10,589q�$��Center=�$
��1204��.+��� -4   $ devToolsButton��$��	DEV TOOLS��$
��Left=�$��1026,47,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)�$��10(��� $��Center=�$��0,19,0,0q�$
��Wrap=�$	��Top=�$��17��$	��270��$��Segoe UI Semilight)�$8��2Copyright 2017 - Soundcloud Penetrator 0.7.2 alpha���� ���	#FF333337$
��Left=�$��2��$��	10,38,0,0q�$	��Top=�$
��1184���� -5   $ devToolsButton_Copy��$��GANGBANG��$
��Left=�$��1116,47,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)�$��10(�� -6   $ License_Grid��$��0,20,0,0q�$��Center=�$	��564��$��Center=�.+��� -7   $! publicKeyTb��$
��Left=�$��76��$��3,20,0,0q�$
" Wrap=�$	��Top=�$	��270��$��Segoe UI Semilight)��� $��Enter the public key:��$
��Left=�$	��Top=�$��Segoe UI Semilight)��� -8   $! 	licenseTb��$
��Left=�$��76��$��
283,20,0,0q�$
" Wrap=�$	��Top=�$	��270��$��Segoe UI Semilight)�< �� 
IsReadOnly< . �� $ ��License Validation result:��$
��Left=�$��	280,0,0,0q�$	��Top=�$��Segoe UI Semilight)��� -9   $ validateLicenseButton��$��VALIDATE��$
��Left=�$��198,102,0,0q�$	��Top=�$��75��$��23��$��Segoe UI Light)�$��10(�%  CefSharp.Wpf.ChromiumWebBrowser  -:   =  Name$= Browser��$��0��$��	0,185,0,0q�%	   ControlzEx.KeyboardNavigationEx> 	  AlwaysShowFocusVisual> . $��Stretch=���Z� 