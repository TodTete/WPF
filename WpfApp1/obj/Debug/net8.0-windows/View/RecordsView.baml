   M S B A M L   `   `   `  ����B  >WpfApp1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:WpfApp1.ViewModelsWpfApp1.ViewModels  5          WpfApp1.View.RecordsView   5      W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      7
viewmodels clr-namespace:WpfApp1.ViewModels     5        � 	Resources  5
      &   WpfApp1.ViewModels.UserViewModel   userViewModel��%   &	          5   
   6#   5      .��5      �  � DataContext 6   ��  �� Source# [   � ColumnDefinitions 5   
   �� 5      $��* �6    � RowDefinitions 5   
   �� 5      $
��auto �6   �� 5      $
��auto �6   �� 5      $��* �6   .+�5   
   �� $��0��6   $��0��5      $��Center=�5      $
��0 10q�5      $��User Information��5      $��Bahnschrift)�5      $��17(�5      $
��Bold"�5       �� 5"   
   $��0��6   $��1��5#      ���#0d0d0d���#fdfdfd$��1q�5&      $	��360��5'       �� Padding$ 10q�5(      $��Center=�5)      ._�5*      ��  �� Orientation$ Vertical=�6   .+�5+      �� $��Name:��6   �� 5,      $	��5 0q�6   $	��300��5-      $
��Left=�5.      ��5/      �� *	User.Name+ �� Mode$ TwoWay=��� 51      $��	Surnames:��6   �� 52      $	��5 0q�6   $	��300��53      $
��Left=�54      ��55      �� *User.Surnames+$ TwoWay=��� 57      $��Email:��6   �� 58      $	��5 0q�6   $	��300��59      $
��Left=�5:      ��5;      �� *
User.Email+$ TwoWay=��� 5=      $��	Password:��6   �� 5>      $	��5 0q�6   $	��300��5?      $
��Left=�5@      ��5A      �� *User.Password+$ TwoWay=�� 5C      $��0 0 0 10q�6   .+�5D      �� $	��Add��6   $��	10 0 0 10q�5E      $
��10 3q�5F        PrimaryBrush#��[ 5G        SuccessBrush#��[ 5H      $��0q�5I      ��5J      �� *
AddCommand+5K      5L      5M      �� 5O   
   -   5        $��lstUsers��5Q      $��2��5O      ��5P      �� *Users+ �� View 5R      �� 5S      .P�5T      �� $
��Name��6%   	 �� CellTemplate	 5U      �� 5V      .R�5W   "   �� ��6,   �� *Name+5X      5Z      �� 5[      $��Surnames��6%   	 5\      �� 5]      .R�5^   "   �� ��6,   �� *
Surnames+5_      5a      �� 5b      $��Email��6%   	 5c      �� 5d      .R�5e   "   �� ��6,   �� *Email+5f      5h      5i      5k      5l      5m      