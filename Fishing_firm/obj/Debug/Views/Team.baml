   M S B A M L   `   `   `  ????G  CFishing_firm, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:Fishing_firm.ViewsFishing_firm.Views  5   	       Fishing_firm.Views.Team   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:Fishing_firm.Views     5   	     ? Title$
  Team??5   	   $	??543??6   $	??914??6#    ? 
ResizeMode$ NoResize=?6/   ???#566374 ? WindowStartupLocation$ CenterScreen=?6Z    ? WindowStyle$
 None=?6   .??5	      ?? 
???????$??20q?6     ?? CornerRadius$ 20??6,   ._?5
   
   ? .+?5      ?? $??20q?6   .+?5      ? .+?5      ?? -   5        $??X??5   1   $??33??6=   $??Right=?6H   $??20(?6d   $??DemiBold"?6r   $??36??6?   ?? 5      $?? Команда??6   
???   ?$??30(?6B   $
??Bold"?6P   $
??Left=?6b   5      ?? 5      $
??00 0q?6   $??26??6*   68   ?? 5      -   5         ??Name$ addHuman??5      $??Right=?6+   ???#566374
???????
?????? $??DemiBold"?6?   $??	00 40 0 0q?6?   $??16(?6?   $??Добавить??6?   $??43??6?   $	??247??6?   6  ?? 5      -   5        $ deleteHuman??5      $??Right=?6.   ???#566374
???????
?????? $??DemiBold"?6?   $
??0 10q?6?   $??16(?6?   $??Удалить??6?   $??43??6?   $	??247??6?   6  ?? 5      -   5        $ updateHuman??5      $??Right=?6.   ???#566374
???????
?????? $??DemiBold"?6?   $
??00 0q?6?   $??16(?6?   $??Обновить??6?   $??43??6?   $	??247??6?   6  5      ?? 5      $??30,130,342,44q?6   .+?5      &   System.Windows.Controls.DataGrid  -   5          Name$ 	humanGrid??5   8      AutoGenerateColumns .  $	??496??6K      HorizontalGridLinesBrush ?#566374	   VerticalGridLinesBrush	 ?#566374$
??Bold"?6?   $	??291??6?   
   CanUserReorderColumns
 .     CanUserResizeColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ID??6D      Width5  /System.Windows.Controls.DataGridLengthConverter$ 50 6P   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6-   ?? *Id+6P     5      $ Команда??6F   $	 100 6W    6-   ?? *Name+6W   5      5       5!      5"      5#      