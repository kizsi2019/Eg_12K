function vesz(){
	let nev = document.getElementById('nev').value;
	let db = document.getElementById('kacsa').value;
	let kacsaar = 5000;
	let ar = db * kacsaar;

	document.getElementById('eredmeny').innerHTML = nev + " most vesz " + db + " darab kacsát " + ar + " forintért. ";
}