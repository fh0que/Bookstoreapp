   M S B A M L   `   `   `  ���� E  ABooksStore, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:BooksStore
BooksStore      BooksStore.MainWindow   W SPresentationCore, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=8.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     @d2http://schemas.microsoft.com/expression/blend/2008     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     *localclr-namespace:BooksStore       � Title$  BooksStoreApp��$	��700��$	��800��.��� -    �Name$ vat_textBox��$��	0,9,0,-25q�����  j� Stretch$ Uniform=�.+�� $��0,-12,0,604q�����  �� EndPoint$ 0.5,1&� �� 
StartPoint$ 0.5,0&�.��� �  � Color$ 	#FF8DE9E3�� � Offset$ 0.929Q�� $��	0,592,0,0q����� $ 0.5,1&�$ 0.5,0&�.��� � $ 	#7F0FF045��$ 0.929Q�.+��� $��Author Name
��$
��Left=�$��134,-450,0,0q�$	��Top=� J� RenderTransformOrigin$ -5.172,-11.701&�$��32��$
��Bold"�$��Italic$� J� OpacityMask �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��� $ White��$ 1Q��� $��	Book Name��$
��Left=�$��137,105,0,0q�$	��Top=�$
��Bold"�$��Italic$� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��� $ White��$ 1Q��� $��Publication Name��$
��Left=�$��105,177,0,0q�$	��Top=�$	��114��$
��Bold"�$��Italic$� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��� $ White��$ 1Q��� $��Price  P.U  *��$
��Left=�$��135,213,0,0q�$	��Top=�$
��Bold"�$��Italic$� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��� $ White��$ 1Q��� $��Quantity  *��$
��Left=�$��137,245,0,0q�$	��Top=�$
��Bold"�$��Italic$� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��� $ White��$ 1Q��� $
��Date��$
��Left=�$��135,281,0,0q�$	��Top=�$ -0.276,-0.237&�$
��Bold"�$��Italic$� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��� $ White��$ 1Q��� $��Total��$
��Left=�$��132,346,0,0q�$	��Top=�$
��Bold"�$��Italic$� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��� $ White��$ 1Q��� -   	 ��Name$	 bookName_textbox��$
��Left=�$��280,113,0,0q�
 �� TextWrapping$

 Wrap=�$��Enter book name:��$	��Top=�$	��120��$
��Bold"� J� Opacity$ 0.995Q��� $
��Left=�$��1114,549,0,0q�$

 Wrap=�$��TextBox��$	��Top=�$	��120���� -   $	 authorName_textbox��$
��Left=�$��280,149,0,0q�$

 Wrap=�$��Enter Author Name��$	��Top=�$	��120��$
��Bold"�$ 0.995Q��� -   $	 price_textbox��$
��Left=�$��280,220,0,0q�$

 Wrap=�$��Enter book price��$	��Top=�$	��120��$
��Bold"�$ 0.995Q��� -   $	 bookQuantity_textbox��$
��Left=�$��280,250,0,0q�$

 Wrap=�$��Quantity��$	��Top=�$	��120��$
��Bold"�$ 0.995Q��� -   $	 bookPurchase_date_textbox��$
��Left=�$��274,285,0,0q�$

 Wrap=�$��Please enter Date��$	��Top=�$	��120��$
��Bold"�$ 0.995Q����	#FFEBA0A0�� -    ��Name$ total_textblock��$
��Left=�$��274,346,0,0q�$
��Wrap=�$��Total Priice��$	��Top=�$��28��$	��112�����	#FF59A442�� -    ��Name$	 vat��$	��Vat��$
��Left=�$��132,315,0,0q�$	��Top=�$ -0.276,-0.237&�$
��Bold"�$��Italic$� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��� $ White��$ 1Q��� -	   $ vat_Copy��$��+ 5% Vat��$
��Left=�$��441,313,0,0q�$	��Top=�$ -0.276,-0.237&�$
��Bold"�$��Italic$� �� $ 0.5,1&�$ 0.5,0&�.��� $ Black��� $ White��$ 1Q��� -
    ��Name$ authorName_ComboBox��$
��Left=�$��280,181,0,0q�$	��Top=�$	��120��&   System.Windows.Controls.DataGrid  -     Name$ dataGridview_datagrid��$��28,423,28,0q����	#FFC9A58D$	��105��$	��Top=�   AutoGenerateColumns$ False��   CanUserAddRows$ False��"   VerticalScrollBarVisibility$
 Auto=�$
��True��$��Visible=�   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Item ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *ItemID+  $
 Name��$ *  �� *
BookName+  $ Author��$ *  �� *
AuthorName+  $ Publications��$ *  �� *PublicationsName+  $ Price��$ *  �� *Price+  $ Quantity��$ *  �� *
Quantity+  $ Total Price��$ *  �� *
TotalPrice+  $ Created Date��$ *  �� *	Created+�� -    ��Name$ 
add_button��$	��Add��$
��Left=�$��567,367,0,0q�$	��Top=�$	��109�����	#FF4FBE27���	#FF4ACE78$
��Bold"�$��Italic$��� -   $ cancel_button��$��Clear��$
��Left=�$��
28,378,0,0q�$	��Top=�$	��109�����	#FFFFD8D8$
��Bold"��� -   $ saveData_button��$
��Save��$
��Left=�$��651,555,0,0q�$	��Top=�$��32��$��96�����	#FFD9F08E$
��Bold"��� -   $	 vat_textbox��$
��Left=�$��274,317,0,0q�$

 Wrap=�$	��Top=�$	��120��$
��Bold"�$ 0.995Q�