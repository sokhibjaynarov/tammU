   M S B A M L   `   `   `  ����H  DtammU.Desktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:tammU.Desktop.PagestammU.Desktop.Pages  5      e aMicrosoft.Web.WebView2.Wpf, Version=1.0.1245.22, Culture=neutral, PublicKeyToken=2a8ab48044d2601ekLclr-namespace:Microsoft.Web.WebView2.Wpf;assembly=Microsoft.Web.WebView2.WpfMicrosoft.Web.WebView2.Wpf 5      "    tammU.Desktop.Pages.HomePage   5      W SPresentationCore, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=5.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=5.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      _ [MaterialDesignThemes.Wpf, Version=4.5.0.0, Culture=neutral, PublicKeyToken=df2a72020bd7962aFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      -local!clr-namespace:tammU.Desktop.Pages  5      VwpfLclr-namespace:Microsoft.Web.WebView2.Wpf;assembly=Microsoft.Web.WebView2.Wpf  5        N� Title$  HomePage��5      .��5      � 
������� � RowDefinitions 5   
   �� 5      $��9* �6   �� 5      .+�5   
   � $��0��6    � ColumnDefinitions 5      �� 5      �� 5      .+�5      � $��1��6   
�������.+�5      )  #Microsoft.Web.WebView2.Wpf.WebView2  -   5          Name$ WebView��5      $��1��60      Source$8 2file:///C:/Users/jayna/Desktop/tammU/AI/index.html?�6=   5      � 5      $��0��6   
���� ��.+�5      A� 
 �� Top$	 100��5       �� Left$	 100��5      
���� ��$	��500��5      $	��500��5       $��5��5!      ���	#FF0000FF5"      � 5#      $	��200��6   $	��500��6$   
������ .+�5$      �� $��50(�6    $��Center=�6.    J� RenderTransformOrigin$ 1.443,0.195&�6K   Timer6v   �� 5%      -   5         ��Name$ clocktxtblock��5%   ,   $��50q�6    	 �� TextAlignment$	 Center=�6C   $��70(�6Z   $��Center=�6h   $	��350��6�   $	��150��6�   6�   5&      5'      5(      � 5)   
   $��1��6    5*      �� 5+      �� 5,      .+�5.      � $��0��6   
���� �� 5/      �� 50      �� 51      �� 52      .+�54      �� -   5        
 ��Name$
 startbtn��54   5   $��0��6   $��50��6)   
����·�$��Start��6\   $��30(�6l   6�   �� 55      -   5        $
 stopbtn��55   5   $��1��6   $��50��6)   
����·�$
��Stop��6[   $��30(�6j   6�   �� 56      -   5        $
 resetbtn��56   5   $��2��6   $��50��6)   
����·�$��Reset��6\   $��30(�6l   6�   57      � 58      $��1��6    59      �� 5:      �� 5;      .+�5=      �� $��Start��5>      $��0��5?      $��10q�5@      $��50��5A      �� 5B      $
��Stop��5C      $��1��5D      $��10q�5E      $��50��5F      5G      5H      5I      5K      