function feliratkozas(){
    let email = document.getElementById('email');
    if(email.value != ""){
        email.value = "";
        alert("Sikeresen feliratkozott! Köszönjük szépen!");
    }else{
        alert("Kérem töltse ki az E-mail mezőt!");
    }
}

function hozzaszolas(){
    let nev = document.getElementById('nev').value;
    let uzenet = document.getElementById('szoveg').value;

    let kommentek = document.getElementById('kommentek');

    kommentek.innerHTML += '<p><span class="badge badge-success">'+nev+'</span> '+uzenet+'</p>';
}