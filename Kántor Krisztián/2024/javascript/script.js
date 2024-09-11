//Objektum létrehozás
/*
var odon ={
    nev: "Ödön",
    szuletesiEv:1978,
    foglalkozas: "grafikus"
}

var Szemely=function(nev, szuletesiEv, foglalkozas){
    this.nev=nev
    this.szuletesiEv=szuletesiEv
    this.foglalkozas=foglalkozas
}

Szemely.prototype.korSzamitas=function(){
    console.log(2024-this.szuletesiEv)
}
Szemely.prototype.teszt="teszt"

var odon=new Szemely("Ödön", 1978, "grafikus")
odon.korSzamitas()

var erzsi=new Szemely("Erzsi",1950,"nyugdíjas")
erzsi.korSzamitas()

console.log(Szemely)
console.log(odon)
console.log(erzsi)
*/

var SzemelyProto={
    korszamitas: function(){
        console.log(2024-this.szuletesiEv)
    }
}

var odon=Object.create(SzemelyProto)
odon.nev="ödön"
odon.szuletesiEv=1978
odon.foglalkozas="pék"

var kati=create(SzemelyProto,{
    nev:{value:"Kati"},
    szuletesiEv:{value:1990},
    foglalkozas: {value:"kozmetikus"}
})
