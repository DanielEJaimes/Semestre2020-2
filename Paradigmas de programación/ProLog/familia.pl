%hombres
es_hombre(daniel).
es_hombre(ariel).

es_hombre(nicolas).
es_hombre(oswaldo).

es_hombre(rafael).
%mujeres
es_mujer(neyla).
es_mujer(vanessa).

es_mujer(paola).
es_mujer(gabriela).

es_mujer(cecilia).
%padres
es_padre(ariel,daniel).
es_padre(ariel,vanessa).

es_padre(oswaldo,nicolas).
es_padre(oswaldo,gabriela).

es_padre(rafael,neyla).
es_padre(rafael,paola).
%madres
es_madre(neyla,daniel).
es_madre(neyla,vanessa).

es_madre(paola,nicolas).
es_madre(paola,gabriela).

es_madre(cecilia,neyla).
es_madre(cecilia,paola).
%compromisos
es_esposo(oswaldo,paola).
es_esposo(rafael,cecilia).

es_esposa(paola,oswaldo).
es_esposa(cecilia,rafael).
%primera línea de sangre
es_hijo(X,Y) :- es_padre(Y,X), es_hombre(X) ; es_madre(Y,X), es_hombre(X).

es_hija(X,Y) :- es_padre(Y,X), es_mujer(X) ; es_madre(Y,X), es_mujer(X).

es_abuelo(X,Z) :- es_padre(X,Y), es_padre(Y,Z) ; es_padre(X,Y), es_madre(Y,Z).

es_abuela(X,Z) :- es_madre(X,Y), es_padre(Y,Z) ; es_madre(X,Y), es_madre(Y,Z).

es_nieto(X,Y) :- es_abuelo(Y,X) , es_hombre(X) ; es_abuela(Y,X) , es_hombre(X).

es_nieta(X,Y) :- es_abuelo(Y,X), es_mujer(X) ; es_abuela(Y,X) , es_mujer(X).

es_hermano(X,Y) :- es_madre(Z,X) , es_madre(Z,Y) , es_hombre(X) , X\=Y.

es_hermana(X,Y) :- es_madre(Z,X) , es_madre(Z,Y) , es_mujer(X) , X\=Y.
%segunda línea de sangre
es_ancestro(X,Y) :- es_padre(X,Y) ; es_madre(X,Y).
es_ancestro(X,Y) :- es_padre(Z,Y) , es_ancestro(X,Z) ; es_madre(Z,Y) , es_ancestro(X,Z).

es_descendiente(X,Y) :- es_padre(Y,X) ; es_madre(Y,X).

es_tio(X,Y) :- es_padre(Z,Y) , es_hermano(X,Z) ; es_madre(Z,Y) , es_hermano(X,Z).

es_tia(X,Y) :- es_padre(Z,Y) , es_hermana(X,Z) ; es_madre(Z,Y) , es_hermana(X,Z).

es_sobrino(X,Y) :- es_tia(Y,X) , es_hombre(X) ; es_tio(Y,X) , es_hombre(X).

es_sobrina(X,Y) :- es_tia(Y,X) , es_mujer(X) ; es_tio(Y,X) , es_mujer(X).

es_primo(X,Y) :- es_sobrino(X,Z) , es_padre(Z,Y) ; es_sobrino(X,Z) , es_madre(Z,Y).

es_prima(X,Y) :- es_sobrina(X,Z) , es_padre(Z,Y) ; es_sobrina(X,Z) , es_madre(Z,Y).
%relaciones
es_cunado(X,Y) :- es_esposo(X,Z) , es_hermana(Y,Z) ; es_esposo(X,Z) , es_hermano(Y,Z).

es_cunada(X,Y) :- es_esposo(Y,Z) , es_hermana(X,Z) ; es_esposa(Y,Z) , es_hermana(X,Z).

es_suegro(X,Y) :- es_padre(X,Z) , es_esposa(Y,Z) ; es_padre(X,Z) , es_esposo(Y,Z).

es_suegra(X,Y) :- es_madre(X,Z) , es_esposa(Y,Z) ; es_madre(X,Z) , es_esposo(Y,Z).

es_tio_politico(X,Y) :- es_esposo(X,Z) , es_tia(Z,Y).

es_tia_politica(X,Y) :- es_esposa(X,Z) , es_tio(Z,Y).
