   M S B A M L   `   `   `  ����I  EWpfDataBinding, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:WpfDataBindingWpfDataBinding  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5          WpfDataBinding.MainWindow   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      .localclr-namespace:WpfDataBinding     5      a ]DevExpress.Xpf.Core.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  5      c _DevExpress.Xpf.Ribbon.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxr4http://schemas.devexpress.com/winfx/2008/xaml/ribbon  5      <dxb2http://schemas.devexpress.com/winfx/2008/xaml/bars  5      Fdxbh;http://schemas.devexpress.com/winfx/2008/xaml/bars/internal  5	      ?dxe5http://schemas.devexpress.com/winfx/2008/xaml/editors  5
      d `DevExpress.Xpf.Docking.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a?dxd5http://schemas.devexpress.com/winfx/2008/xaml/docking  5      a	 ]DevExpress.Xpf.Grid.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49af
 bDevExpress.Xpf.Grid.v14.1.Core, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxg2http://schemas.devexpress.com/winfx/2008/xaml/grid 	 
 5      Fcollections2clr-namespace:System.Collections;assembly=mscorlib 	 
 5      c _DevExpress.Xpf.NavBar.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a?dxnb4http://schemas.devexpress.com/winfx/2008/xaml/navbar  5      c _DevExpress.Xpf.Charts.v14.1, Version=14.1.8.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a>dxc4http://schemas.devexpress.com/winfx/2008/xaml/charts  5        � Title$  DXApplication��5      $	��700��6   $
��1100��6(    J� SnapsToDevicePixels .  � UseLayoutRounding . &   DevExpress.Xpf.Core.ThemeManager   	ThemeName0  *DevExpress.Xpf.Core.ThemeNameTypeConverter$ DeepBlue 5       � 	Resources 5      ��%    5      .��5      $  DevExpress.Xpf.Bars.BarManager  -   5          Name$ 
barManager��5      =  7DevExpress.Xpf.Bars.Helpers.BlendHelperForBarsAndRibbon   IsDesignControl .    Items 5   
   '  !DevExpress.Xpf.Bars.BarButtonItem  5      -   5          Name$ bHelp��5       !  DevExpress.Xpf.Bars.BarItem	   Content)  #DevExpress.Xpf.Core.ObjectConverter$
	 Help 6/   
   Glyph$"
 Images/Icons/index-16x16.png��6>      
LargeGlyph$" Images/Icons/index-32x32.png��6c     5      -   5        $ bCopy��5       $
	 Copy 6/   $!
 Images/Icons/copy-16x16.png��6>   $! Images/Icons/copy-32x32.png��6b     5      -   5        $ bPaste��5       $	 Paste 60   $"
 Images/Icons/paste-16x16.png��6@   $" Images/Icons/paste-32x32.png��6e     5      -   5        $
 bNew��5       $		 New 6.   $ 
 Images/Icons/new-16x16.png��6<   $  Images/Icons/New-32x32.png��6_     5      -   5        $ bPrint��5       $	 Print 60   $"
 Images/Icons/print-16x16.png��6@   $" Images/Icons/print-32x32.png��6e     5      -   5        $ bOpen��5       $
	 Open 6/   $!
 Images/Icons/open-16x16.png��6>   $! Images/Icons/open-32x32.png��6b   $  DevExpress.Xpf.Bars.BarSubItem  5       -   5          Name$ mmFile��5       $
	 File 6-   $!
 Images/Icons/zoom-16x16.png��6<   $! Images/Icons/zoom-32x32.png��6`      	ItemLinks 5!      +	  %DevExpress.Xpf.Bars.BarButtonItemLink	  5"      %
  DevExpress.Xpf.Bars.BarItemLink 
  BarItemName$
 bNew��6,   	  5#      $ bOpen��6,   5%      ._�5'   
   ]� .+�5(      )  #DevExpress.Xpf.Ribbon.RibbonControl  -	   5          Name$ ribbonControl1��5(          RibbonStyle$ 
Office2010=�68    . $	��Top=�6�   $��0,0,0,0q�6�      ApplicationMenu 5)      +  %DevExpress.Xpf.Ribbon.ApplicationMenu  5*         RightPaneWidth$	 280Q�6*      ShowRightPane . #  DevExpress.Xpf.Bars.PopupMenu   	ItemLinks 5+      	  5,      $
 bNew��64   	  5-      $ bOpen��64   	  5.      $ bHelp��64      	RightPane 51      �� 52      $��
Right Pane��6%      
BottomPane 54      �� 55       �� Orientation$ 
Horizontal=�6)   .+�56   "   �� $��	OK button��6)   57      59         PageHeaderItemLinks 5;      	  5<      $
 bNew��6,   	  5=      $ bOpen��6,   	  5>      $ bHelp��6,      
Categories. 5@      5  /DevExpress.Xpf.Ribbon.RibbonDefaultPageCategory  2  ,DevExpress.Xpf.Ribbon.RibbonPageCategoryBase   Pages. 5A      &   DevExpress.Xpf.Ribbon.RibbonPage  -
   5         �Name$
 Home��5A   %      Caption$
 Home 61      Groups. 5B      +  %DevExpress.Xpf.Ribbon.RibbonPageGroup     Caption$ Buttons��6.      	ItemLinks 5C      	  5D   "   $
 bNew��68   (  "DevExpress.Xpf.Bars.BarSubItemLink  5E   "   $ mmFile��65     
  RibbonStyle$  Large=�6J   	  5F   "   $ bOpen��68   $  SmallWithText=�6L     5G   "   $ mmFile��65   $  SmallWithText=�6J   	  5H   "   $ bPrint��68   $  SmallWithText=�6M   .  (DevExpress.Xpf.Bars.BarItemLinkSeparator  5I   "   	  5J   "   $ bOpen��68   $  SmallWithoutText=�6L     5K   "   $ mmFile��65   $  SmallWithoutText=�6J   	  5L   "   $ bPrint��68   $  SmallWithoutText=�6M   5N        5O      $ Second Page Group��6.   5P      5Q        5R      -   5        $ Second��5R   %   $ Second Page 63   5S      5T      !   ToolbarItemLinks! 5U      	  5V      $
 bNew��6,   	  5W      $ bOpen��6,     5X      	  5Y      $ bCopy��6,   	  5Z      $ bPaste��6,   5\      .  (DevExpress.Xpf.Docking.DockLayoutManager  5]      -   5        "  Name$" dockLayoutManager��5]   $   #   
LayoutRoot.# 5^      (  "DevExpress.Xpf.Docking.LayoutGroup  $   Items.$ 5_      (  "DevExpress.Xpf.Docking.LayoutPanel  +  %DevExpress.Xpf.Docking.BaseLayoutItem%   	ItemWidth$	% 200 �6&   &   Caption$& 
Navigation��66   '   ShowCaption' .  (   
ShowBorder( .  )   
Background
) ���� (  "DevExpress.Xpf.Docking.ContentItem*   Content.* 5`      )  #DevExpress.Xpf.NavBar.NavBarControl  -   5        $��navBarControl��5`   -   $��Stretch=�6B   $��Stretch=�6`   $��1q�6|   +   Groups+ 5a      '  !DevExpress.Xpf.NavBar.NavBarGroup  5b   "   ,   Header$, kpx_data 63   -   ImageSource$- Images/Icons/Group.png��6E   .   Items.. 5c   &   &   DevExpress.Xpf.NavBar.NavBarItem  -   5        /  Name$/ nav_Smp��5c   6   0   Content$	0 smp 6G   1   ImageSource$1 Images/Icons/Item.png��6U   6y     5d   &   -   5        $/ nav_Load��5d   6   $
0 load 6H   $1 Images/Icons/Item.png��6W   5e   #   2   View2 5g      .  (DevExpress.Xpf.NavBar.NavigationPaneView  5h   "   3   IsExpandButtonVisible3 . 6:   5j      5k        5l      4   Orientation$4 
Horizontal=�6&   $% 4* �6?   .$ 5m        $& MainView��6*   5   
ItemHeight$5 3* �6=   .* 5n      % 	 DevExpress.Xpf.Grid.GridControl  -   5        6  Name$6 gridControl1��5n   .   ) 
 #DevExpress.Xpf.Grid.DataControlBase7   AutoGenerateColumns$7 AddNew=�6D   8   
ShowBorder8 .  9   ItemsSource9 6a   �� : �� Path$: kpx_data�;   View; 5o   "   # 	 DevExpress.Xpf.Grid.TableView  5p   &   5r      5s        5t      $& 
DetailView��6*   $5 2* �6?   .* 5u      � .+�5v   "   (   "DevExpress.Xpf.Charts.ChartControl   -   5        <   Name$< chartControl1��5v   3   $
��Left=�6J   $��0,0,0,0q�6e   $	��Top=�6v   =    CrosshairOptions= 5w   &   ,!  &DevExpress.Xpf.Charts.CrosshairOptions!  5x   *   > !  ShowArgumentLabels> . ? !  ShowValueLabels? . @ !  ShowValueLine@ . 6p   A    LegendA 5z   &   ""  DevExpress.Xpf.Charts.Legend"  5{   *   B    Diagram.B 5}   &   '#  !DevExpress.Xpf.Charts.XYDiagram2D#  #$  DevExpress.Xpf.Charts.DiagramC $  SeriesDataMember$C 
korea_zone��66   D $  Series.D 5~   *   1%  +DevExpress.Xpf.Charts.BarSideBySideSeries2D%  -   5        $��	SMPSeries��5~   D   "&  DevExpress.Xpf.Charts.SeriesE &  DisplayName$E 내륙��6U   F &  ArgumentDataMember$F op_date��6f   G &  ValueDataMember$	G smp��6�   %  5   *   -   5        $��
SMPSeries2��5   D   $E 제주��6V   $F op_date��6g   $	G smp��6�   5�   '   5�   #   5�      5�      5�      5�      5�      5�      5�      5�      