   M S B A M L   `   `   `  ���� S  OWindows tools (17140015), Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullC&clr-namespace:Windows_tools__17140015_Windows_tools__17140015_  %    Windows_tools__17140015_.ipSect   W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     8local&clr-namespace:Windows_tools__17140015_       N� Title$  ipSect��.��� $��	0,0,10,10q����	#FF1F1736.+��� $
��Left=�$	��235��$��	8,160,0,0q�
�������$	��Top=�$	��470���� $
��Left=�$	��100��$��
17,223,0,0q�$	��Top=�$	��200���� $
��Left=�$��55��$��8,51,0,0q�
�������$	��Top=�$	��470���� -    ��Name$ label��$��Your IP��$
��Left=�$��8,9,0,0q�$	��Top=�$��42��$	��144��$��
Code Light)�$��36(�
��������� -    ��Name$ txtIP��$
��Left=�$��
226,51,0,0q�$
��Wrap=�$
��Null��$	��Top=�$��24��$	��238��
�������$��Global Monospace)�$��24(��� -    ��Name$ 
btnRefInfo�� � ToolTip$ Untuk check IP local��$��Check Local��$
��Left=�$��	55,55,0,0q�$	��Top=�$��86���� -   $ 	txtIP_pub��$
��Left=�$��
226,78,0,0q�$
��Wrap=�$
��Null��$	��Top=�$��24��$	��238��
�������$��Global Monospace)�$��24(��� -   $ txtUN1��$
��Left=�$��
166,62,0,0q�$
��Wrap=�$��Local��$	��Top=�$��24��$��79��
�������$��Global Monospace)��� -   $ txtUN2��$
��Left=�$��
166,89,0,0q�$
��Wrap=�$��Public��$	��Top=�$��17��$��60��
�������$��Global Monospace)��� -   $ 	btnIP_pub��$� �Check Public IP 
Harus terkoneksi internet !!! 
Bila tidak ada internet program akan crash 
Data di ambil dari http://checkip.dyndns.org��$��Check Public��$
��Left=�$��	55,80,0,0q�$	��Top=�$��86���� -   $ 
label_Copy��$��Change Network��$
��Left=�$��	8,118,0,0q�$	��Top=�$��42��$	��332��$��
Code Light)�$��36(�
��������� -	    ��Name$ boxIP��$
��Left=�$��17��$��
81,170,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$	��120��$- 'Setting local IP 
Contoh : 192.168.70.2���� -
   $ boxGate��$
��Left=�$��17��$��
81,192,0,0q�$
 Wrap=�$	��Top=�$	��120�� J� RenderTransformOrigin$ 1.083,0.043&�$4 .Setting default gateway 
contoh : 192.168.70.1���� -   $ 	boxSubnet��$7 1Setting subnet 
Tidak usah di ganti untuk default��$
��Left=�$��17��$��
81,214,0,0q�$
 Wrap=�$	��Top=�$	��120��$��255.255.255.0���� $
��Left=�$��
17,171,0,0q�$
��Wrap=�$��IP��$	��Top=�
��������� $
��Left=�$��
17,192,0,0q�$
��Wrap=�$��Gateway��$	��Top=�
��������� $
��Left=�$��
17,213,0,0q�$
��Wrap=�$��Subnet��$	��Top=�
��������� -   $ 	btn_setIP��$, &Untuk menyimpan data yang sudah di isi��$	��Set��$
��Left=�$��126,245,0,0q�$	��Top=�$��75���� -   $ btn_clearForm��$ Untuk membersihkan input��$��
Clear form��$
��Left=�$��
17,245,0,0q�$	��Top=�$��75���� -   $��?��$
��Left=�$��
166,26,0,0q�$	��Top=�$��19��$ 
0.421,1.25&��� -   $ helpIP��$��?��$
��Left=�$��206,169,0,0q�$	��Top=�$��19��$ 
0.421,1.25&��� -    ��Name$ listBox1��$* $Untuk sementara fitur belum tersedia��$
��Left=�$	��100��$��247,190,0,0q�$	��Top=�$	��217���� $
��Left=�$	��100��$��128,228,0,0q�$	��Top=�$	��213��$ 0.5,0.5&�z�V� .~��� �� �� 	 �� Angle$	 89.926Q�T� �� -   $ label_Copy1��$��Set to DHCP��$
��Left=�$��247,165,0,0q�$	��Top=�$��24��$	��133��$��
Code Light)�$��16(�
��������� -   $ 
texPilihan��$
��Left=�$��345,295,0,0q�$
��Wrap=�$��Pilih adapter di atas !��$	��Top=�$	��119��
��������� $��Kamu memilih :��$
��Left=�$��247,290,0,0q�$	��Top=�$��93��
��������� -   $ setDHCP��$Z TTombol untuk setting network ip,dns,gateway dan subnet automatis 
(Network saat ini)��$��	Set DHCP ��$
��Left=�$��247,353,0,0q�$	��Top=�$	��217���� $
��Left=�$��239,316,0,0q�$
��Wrap=�$8��2*Memilih adapter untuk setting dhcp belum tersedia��$	��Top=�
�������$��9(��� $
��Left=�$��
17,300,0,0q�$
��Wrap=�$	��DNS��$	��Top=�
��������� -   $ boxDNS��
 �� AcceptsReturn
 .  �� MaxLines$ 2�� �� MinLines$ 1��$&  DNS GOOGLE 
 8.8.8.8 dan 8.8.4.4��$
��Left=�$��32��$��
81,291,0,0q�$
 Wrap=�$	��Top=�$	��120��$��8.8.8.8
8.8.4.4���� $
��Left=�$��
17,325,0,0q�$
��Wrap=�$	��Top=�$��9(�
��������� $,�&*Set dns seperti di atas  dengan enter���� �� $� untuk dns ke dua���� -   $��SET DNS��$ Simpan Setingan DNS��$
��Left=�$��
17,353,0,0q�$	��Top=�$	��200��