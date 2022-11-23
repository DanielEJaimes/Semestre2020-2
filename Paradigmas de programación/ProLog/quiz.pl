heroe(batman).
heroe(superman).
heroe(constantine).

villano(darkseid).
villano(trigon).
villano(catwoman).
villano(blackmask).

enemigo(batman , catwoman).
enemigo(batman , blackmask).
enemigo(superman, darkseid).
enemigo(batman, darkseid).
enemigo(constantine, trigon).
enemigo(trigon, darkside).
enemigo(catwoman, blackmask).

amigo(X,Y) :- enemigo(Z,X) , enemigo(Z,Y).

archivillano(X) :- enemigo(Y,X) , enemigo(Z,X) , villano(X).

mente_maestra(X,Y) :- enemigo(X,Y) , not(enemigo(Y,X)) , villano(X).

