�3
OD:\OneDrive\Benner\Visual Studio 2015\Projects\WFTesteFila\WFTesteFila\Form1.cs
	namespace
WFTesteFila
 
{ 
public 

partial 
class 
Form1 
:  
Form! %
{ 
MessageQueue 
mQ 
; 
System 
. 
	Messaging 
. 
Message  
msg! $
;$ %
BinaryReader 
br 
; 
public 
Form1 
( 
) 
{ 	
InitializeComponent 
(  
)  !
;! "
} 	
private 
void 
btnEnviar_Click $
($ %
object% +
sender, 2
,2 3
	EventArgs4 =
e> ?
)? @
{ 	
string 
textoMsg 
= 
DateTime &
.& '
Now' *
.* +
	TimeOfDay+ 4
.4 5
ToString5 =
(= >
)> ?
+@ A
$strB E
+F G
txtMensagemH S
.S T
TextT X
;X Y
if 
( 
MessageQueue 
. 
Exists #
(# $
$str$ ;
); <
)< =
{ 
mQ 
= 
new 
MessageQueue %
(% &
$str& =
)= >
;> ?
}   
else!! 
{"" 
mQ## 
=## 
MessageQueue## !
.##! "
Create##" (
(##( )
$str##) @
)##@ A
;##A B
}$$ 
mQ%% 
.%% 
Send%% 
(%% 
textoMsg%% 
,%% 
$str%% )
)%%) *
;%%* +
lstMSMQ&& 
.&& 
Items&& 
.&& 
Add&& 
(&& 
string&& $
.&&$ %
Format&&% +
(&&+ ,
$str&&, U
,&&U V
DateTime&&W _
.&&_ `
Now&&` c
.&&c d
	TimeOfDay&&d m
.&&m n
ToString&&n v
(&&v w
)&&w x
)&&x y
)&&y z
;&&z {
}'' 	
private)) 
void)) 
btnLer_Click)) !
())! "
object))" (
sender))) /
,))/ 0
	EventArgs))1 :
e)); <
)))< =
{** 	
string++ 
texto++ 
;++ 
try,, 
{-- 
msg.. 
=.. 
mQ.. 
... 
Receive..  
(..  !
new..! $
TimeSpan..% -
(..- .
$num... /
,../ 0
$num..1 2
,..2 3
$num..4 5
)..5 6
)..6 7
;..7 8
br// 
=// 
new// 
BinaryReader// %
(//% &
msg//& )
.//) *

BodyStream//* 4
)//4 5
;//5 6
texto00 
=00 
new00 
string00 "
(00" #
br00# %
.00% &
	ReadChars00& /
(00/ 0
Convert000 7
.007 8
ToInt32008 ?
(00? @
msg00@ C
.00C D

BodyStream00D N
.00N O
Length00O U
)00U V
)00V W
)00W X
;00X Y
lstMSMQ11 
.11 
Items11 
.11 
Add11 !
(11! "
string11" (
.11( )
Format11) /
(11/ 0
$str110 ;
,11; <
texto11= B
)11B C
)11C D
;11D E
}22 
catch33 
{44 
lstMSMQ55 
.55 
Items55 
.55 
Add55 !
(55! "
$str55" A
)55A B
;55B C
}66 
}77 	
private99 
void99 

(99" #
object99# )
sender99* 0
,990 1
	EventArgs992 ;
e99< =
)99= >
{:: 	
try;; 
{<< 
	treeView1== 
.== 
Nodes== 
.==  
Clear==  %
(==% &
)==& '
;==' (
	treeView1>> 
.>> 
BeginUpdate>> %
(>>% &
)>>& '
;>>' (
MessageQueue@@ 
[@@ 
]@@ 
filas@@ $
=@@% &
MessageQueue@@' 3
.@@3 4%
GetPrivateQueuesByMachine@@4 M
(@@M N
$str@@N Y
)@@Y Z
;@@Z [
foreachCC 
(CC 
MessageQueueCC %
filaCC& *
inCC+ -
filasCC. 3
)CC3 4
{DD 
TreeNodeEE 
qNodeEE "
=EE# $
newEE% (
TreeNodeEE) 1
(EE1 2
)EE2 3
;EE3 4
qNodeFF 
.FF 
TextFF 
=FF  
filaFF! %
.FF% &
	QueueNameFF& /
;FF/ 0
qNodeGG 
.GG 
TagGG 
=GG 
$strGG  &
;GG& '
	treeView1II 
.II 
NodesII #
.II# $
AddII$ '
(II' (
qNodeII( -
)II- .
;II. /
foreachKK 
(KK 
SystemKK #
.KK# $
	MessagingKK$ -
.KK- .
MessageKK. 5
mKK6 7
inKK8 :
filaKK; ?
)KK? @
{LL 
TreeNodeMM  
mNodeMM! &
=MM' (
newMM) ,
TreeNodeMM- 5
(MM5 6
)MM6 7
;MM7 8
mNodeNN 
.NN 
TagNN !
=NN" #
$strNN$ )
;NN) *
mNodeOO 
.OO 
TextOO "
=OO# $
mOO% &
.OO& '
LabelOO' ,
;OO, -
	treeView1PP !
.PP! "
NodesPP" '
[PP' (
ArrayPP( -
.PP- .
IndexOfPP. 5
(PP5 6
filasPP6 ;
,PP; <
filaPP= A
)PPA B
]PPB C
.PPC D
NodesPPD I
.PPI J
AddPPJ M
(PPM N
mNodePPN S
)PPS T
;PPT U
}QQ 
}RR 
	treeView1SS 
.SS 
	EndUpdateSS #
(SS# $
)SS$ %
;SS% &
}TT 
catchUU 
(UU 
	ExceptionUU 
exUU 
)UU  
{VV 
}XX 
}YY 	
}ZZ 
}[[ �
PD:\OneDrive\Benner\Visual Studio 2015\Projects\WFTesteFila\WFTesteFila\Pessoa.cs
	namespace 	
WFTesteFila
 
{ 
public		 

class		 
Pessoa		 
{

 
public 
Pessoa 
( 
string 
nome !
,! "
DateTime# +
aniversario, 7
)7 8
{ 	
Nome
=
nome
;
Aniversario 
= 
aniversario %
;% &
} 	
public 
string 
Nome 
{ 
get  
;  !
set" %
;% &
}' (
public 
DateTime 
Aniversario "
{# $
get% (
;( )
set* -
;- .
}/ 0
} 
} �
QD:\OneDrive\Benner\Visual Studio 2015\Projects\WFTesteFila\WFTesteFila\Program.cs
	namespace 	
WFTesteFila
 
{ 
static		 

class		 
Program		 
{

 
[ 	
	STAThread	 
] 
static 
void 
Main 
( 
) 
{ 	
Application 
. 
EnableVisualStyles *
(* +
)+ ,
;, -
Application 
. -
!SetCompatibleTextRenderingDefault 9
(9 :
false: ?
)? @
;@ A
Application 
. 
Run 
( 
new 
Form1  %
(% &
)& '
)' (
;( )
} 	
} 
} �
aD:\OneDrive\Benner\Visual Studio 2015\Projects\WFTesteFila\WFTesteFila\Properties\AssemblyInfo.cs
[ 
assembly 	
:	 


( 
$str &
)& '
]' (
[		 
assembly		 	
:			 

AssemblyDescription		 
(		 
$str		 !
)		! "
]		" #
[

 
assembly

 	
:

	 
!
AssemblyConfiguration

  
(

  !
$str

! #
)

# $
]

$ %
[ 
assembly 	
:	 

AssemblyCompany 
( 
$str 
) 
] 
[ 
assembly 	
:	 

AssemblyProduct 
( 
$str (
)( )
]) *
[
assembly
:

AssemblyCopyright
(
$str
)
]
[ 
assembly 	
:	 

AssemblyTrademark 
( 
$str 
)  
]  !
[ 
assembly 	
:	 

AssemblyCulture 
( 
$str 
) 
] 
[ 
assembly 	
:	 


ComVisible 
( 
false 
) 
] 
[ 
assembly 	
:	 

Guid 
( 
$str 6
)6 7
]7 8
[## 
assembly## 	
:##	 

AssemblyVersion## 
(## 
$str## $
)##$ %
]##% &
[$$ 
assembly$$ 	
:$$	 

AssemblyFileVersion$$ 
($$ 
$str$$ (
)$$( )
]$$) *