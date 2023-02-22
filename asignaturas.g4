grammar asignaturas;

// Parsing Rules:
program : (entry)+ EOF ;

entry : asignatura fecha hora duracion tema ;

asignatura : ASI_LBL SEP TEXT SP?;
fecha : FEC_LBL SEP DATE SP? ;
hora : HOR_LBL SEP TIME SP? ;
duracion : DUR_LBL SEP NUMBER SP? ;
tema : TEM_LBL SEP TEXT SP? ;

// Lexer Rules:
/* 
Las reglas del lexer se ejecutan primero.
Es muy importante colocar las reglas más específicas primero y las más generales de último
puesto que si un string hace match con 2 reglas, el lexer asignará según la primera regla que aplique.
*/
ASI_LBL : 'ASIGNATURA' ;
FEC_LBL : 'FECHA' ;
HOR_LBL : 'HORA' ;
DUR_LBL : 'DURACION' ;
TEM_LBL : 'TEMA' ;

SEP : SP? ':' SP? ;
SP : ' '+ ;

DATE :   [0-9][0-9][0-9][0-9] '-' [0-9][0-9] '-' [0-9][0-9] ;
TIME :   [0-9][0-9] ':' [0-9][0-9];
NUMBER : [0-9]+ ; 
TEXT :   WORD (SP WORD)* ;
WORD :   [A-Za-z0-9_]+ ;

/* Esto hace que el lexer elimine los fines de línea y tabs antes de pasarselo al parser.
No estoy eliminando los espacios, porque los nombres de asignatura y temas tienen que
soportar los espacios */
WS: [\n\r\t] -> skip ; 
