grammar arbol;

arbol : hijos EOF ;

hijos : '{' familia (',' familia)* '}' ;

familia : persona    #jamon
        | matrimonio #pareja
        ;

matrimonio : persona '+' persona        #matrimonioSinHijos
           | persona '+' persona hijos  #matrimonioConHijos;

persona : TEXTO     #vivo
        | TEXTO '#' #fallecido
        ;

TEXTO: [A-Za-z]+ ;
ESPACIOS : [ \n\r\t]+ -> skip ;