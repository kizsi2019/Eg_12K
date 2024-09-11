// objektum létrehozás

/*
var odon = { 
    nev: 'Ödön',
    szuletesiEv: 1978,
    foglalkozas: 'grafikus'
};



var szemely=function (nev, szuletesiEv, foglalkozas) {
    this.nev = nev;
    this.szuletesiEv = szuletesiEv;
    this.foglalkozas = foglalkozas;

    this.korszamitas=function() {
    console.log(2021 - this.szuletesiEv);
    }
};

Szemely.prototype.korszamitas = function() {
    console.log(2021 - this.szuletesiEv);
};

var erzsi = new Szemely('erzsi', 1950, 'nyugdijas');
erzsi.korszamitas();

var odon = new Szemely('ödön', 1978, 'grafikus'); 
odon.korszamitas();

console.log(Szemely);
console.log(odon); */

//object.create

var szemelyProto = {
    korszamitas: function() {
    console.log(2021---this.szuletesiEv);
    }
    };

    var odon=object.create(szemelyProto);
    odon.nev = 'Ödön';
    odon.szuletesiEV = '1960';
    odon.foglalkozas = 'pék';
    var kati = Object.create(szemelyProto, { 
        nev: { value: 'Kati'}, 
        szuletesiEv: { value: 1990 },
        foglalkozas: { value: 'kozmetikus' }
    });