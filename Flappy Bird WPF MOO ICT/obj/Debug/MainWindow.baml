   M S B A M L   `   `   `  ����R  NFlappy Bird WPF MOO ICT, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullA%clr-namespace:Flappy_Bird_WPF_MOO_ICTFlappy_Bird_WPF_MOO_ICT  5   	   (    "Flappy_Bird_WPF_MOO_ICT.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   7local%clr-namespace:Flappy_Bird_WPF_MOO_ICT     5   	     � 
ResizeMode$  NoResize=�5   	    � WindowStartupLocation$ CenterScreen=�5	   	    � WindowStyle$ SingleBorderWindow=�5
   	    � Title$ Flappy Bird ��5   	   $	��590��6   $	��625��6+   .��5      �� -   5        $��MyCanvas��5      |�. ��5   
   �� 5       �� ImageSource$! images/background-night.png��6   .+�5   
   �� $	��145��6   $	��200��6   $��images/clouds.png��6)    �� Left$ 28��6D   
 �� Top$	 120��6U   
 � Tag$ clouds��6f   �� 5   
   $	��145��6   $	��200��6   $��images/clouds2.png��6)   $	 307��6E   $	 120��6W   $ clouds��6h   �� 5   
   $	��390��6   $��66��6   $��images/pipeBottom.png��6(   $
 obs1��6G   $ 76��6R   $	 270��6c   �� 5   
   $	��390��6   $��66��6   $��images/pipeTop.png��6(   $
 obs1��6D   $ 76��6O   $
 -236��6`   �� 5   
   $	��390��6   $��66��6   $��images/pipeBottom.png��6(   $
 obs2��6G   $	 228��6R   $	 416��6d   �� 5   
   $	��390��6   $��66��6   $��images/pipeTop.png��6(   $
 obs2��6D   $	 228��6O   $	 -90��6a   �� 5   
   $	��390��6   $��66��6   $��images/pipeBottom.png��6(   $
 obs3��6G   $	 426��6R   $	 292��6d   �� 5   
   $	��390��6   $��66��6   $��images/pipeTop.png��6(   $
 obs3��6D   $	 426��6O   $
 -214��6a   �� 5   
   -   5        $��
flappyBird��5      $��36��6"   $��50��6.   $��images/flappyBird.png��69   $
��Fill=�6X   $	 190��6g   $ 10��6x   �� 5    
   -   5        $��txtScore��5       $��22(�6    $��	ExtraBold"�6.   $��Score: 0��6E   5"      5#      