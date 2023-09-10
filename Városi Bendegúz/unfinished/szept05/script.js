function teruletszamitas() {
	let a_oldal = document.getElementById("oldal").value;
	let b_oldal = document.getElementById("masik_oldal").value;

	let eredmeny = a_oldal * b_oldal;
	document.getElementById("terulet_eredmeny").innerHTML = eredmeny;
}