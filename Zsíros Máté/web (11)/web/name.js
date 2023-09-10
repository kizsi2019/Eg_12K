function Szamolas(){
	let num1 = document.getElementById("num1").value;
	let diff = num1 - 1987;
	if(diff < 0){
		document.getElementById("szoveg").innerHTML = "Ekkor még nem született meg a valaha volt legjobb játékos!";
	}
	else{
		document.getElementById("szoveg").innerHTML = "Ebben az évben: " + num1 + ", " + " éves volt Lionel Messi!";
	}
}