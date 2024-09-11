
/*var odon = {
nev: 'Ödön',
szuletesiEv: 1978,
foglalkozas: 'grafikus'
};
*/

/*var Szemely = function (nev, szuletesiEv, foglalkozas) {
this.nev = nev;
this.szuletesiEv = szuletesiEv;
this.foglalkozas = foglalkozas;
this.korszamitas = function() {
console.log(2021 - this.szuletesiEv);
}
};

var odon = new Szemely('ödön', 1978, 'grafikus');
odon.korSzamitas();

var erzsi = new Szemely('Erzsi', 1950, 'nyugdíjas');
erzsi.korszamitas();
console.log(Szemely);

console.log(odon);
console.log(odon.teszt); 
// Object.create

var szemelyProto = {
korSzamitas: function() {
console.log(2021 - this.szuletesiEv);
}

};

var odon = Object.create(szemelyProto);
odon.nev = 'Ödön';
odon.szuletesiEv = '1960';
odon.foglalkozas = 'pék';

var kati = Object.create(szemelyProto, {
    nev: { value: 'Kati'},
    szuletesiEv: { value: 1990 },
    foglalkozas: { value: 'kozmetikus' }
    });

    */

var x = 10;
var y = x;
x = 100;
console.log(x);
console.log(y);
var o1 = {
sz: 100,
m: 200
};
var o2 = o1;
o1.sz = 150;


console.log(o1.sz);
console.log(o2.sz);
var a = 10;
var o = {
nev: 'Ödön',
kor: 35
};
function modosit(a, b) {
a = 40;
b.nev= 'Lajos'
}
modosit(a, o); I
console.log(a);
console.log(o.nev)


// Függvények
/*
- a függvény az Object típusnak egy példánya
emiatt a fv úgy viselkedik, mint bármelyik más obj
egyetlen változóban tárolhatunk egy egész fv-tudunk
egy függvényt átadhatunk egy másik fv-nek, mint paramétert
ez utóbbihoz hasonló, hogy egy függvény visszatérési értéke lehet egy függvény is, nem csak egy szimpla érték, vagy objektum vagy éppen semmi
*/
var evek = [ 1954, 1990, 1963, 2000, 2010];
function tombMuvelet (tomb, fv) {
var eredmeny = [];
for(var i=0; i < tomb.length; i++) {
eredmeny.push(fv(tomb[i]));
}
return eredmeny;
}
function korszamitas (elem) {
return 2021 - elem;
}
var korok = tombMuvelet (evek, korSzamitas); I
console.log(korok);
