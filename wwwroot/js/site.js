
var slideIndex = 1;
var slideIndex2 = 0;
//showSlides(slideIndex);
showSlidesAutomatic();

// Controle de Próximo/Anterior
function plusSlides(n) {
    showSlides(slideIndex += n);
}

// Controles de imagem em miniatura
function currentSlide(n) {
    showSlides(slideIndex = n);
}

// Função para exibir as imagens
function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
    if (n > slides.length) { slideIndex = 1 }
    if (n < 1) { slideIndex = slides.length }
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex - 1].style.display = "block";
    dots[slideIndex - 1].className += " active";
}

function showSlidesAutomatic() {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("dot");
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    slideIndex2++;
    if (slideIndex2 > slides.length) { slideIndex2 = 1 }

    for (i = 0; i < dots.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }

    slides[slideIndex2 - 1].style.display = "block";
    dots[slideIndex2 - 1].className += " active";
    setTimeout(showSlidesAutomatic, 3000);
}

function checarPass() {
    var campoNumb = document.getElementById("txtPass");
    var valorNumb = campoNumb.value;

    //if(document.getElementById("txSenha").value.length < 6)
    if (valorNumb.length < 6) {

        document.getElementById("txtPass").style.color = "red";
        alert("Você precisa digitar um mínino de 6 dígitos!");
        return false;
    }
    else if (valorNumb.length == 0) {

        alert("Você precisa digitar uma senha!")
        return false;
    }
    else {
        document.getElementById("txtPass").style.color = "black";
        return true;
    }


}


function checarName() {
    var campoText = document.getElementById("txtName");
    var valorText = campoText.value;

    //if(document.getElementById("txSenha").value.length < 6)
    if (valorText.length <= 1) {

        document.getElementById("txtName").style.color = "red";
        alert("Você precisa digitar um nome válido!");
        return false;
    }
    else if (valorText.length == 0) {

        alert("Você precisa digitar um nome!")
        return false;
    }
    else {
        document.getElementById("txtName").style.color = "black";
        return true;
    }


}


function checarUser() {
    var campoText = document.getElementById("txtUser");
    var valorText = campoText.value;

    //if(document.getElementById("txSenha").value.length < 6)
    if (valorText.length <= 1) {

        document.getElementById("txtUser").style.color = "red";
        alert("Você precisa digitar um nome de usuário válido!");
        return false;
    }
    else if (valorText.length == 0) {

        alert("Você precisa digitar um nome de usuário!")
        return false;
    }
    else {
        document.getElementById("txtUser").style.color = "black";
        return true;
    }


}

function checarFone() {
    var campoFone = document.getElementById("txtFone");
    var valorFone = campoFone.value;
  
    //if(document.getElementById("txSenha").value.length < 6)
    if (valorFone.length < 9) {
  
      document.getElementById("txtFone").style.color = "red";
      alert("Você precisa digitar um número de telefone válido!");
      return false;
    }
    else if(valorFone.length == 0) {
  
      alert("Digite um número de telefone!")
      return false;
    }
    else
  {
    document.getElementById("txtFone").style.color = "black";
      return true;
    }
    }
    

function checarEmail() {
    var email = document.getElementById("txtEmail");
    //if(document.getElementById("txSenha").value.length < 6)
    if (email.value == "" || email.value.indexOf('@') == -1 || email.value.indexOf('.') == -1) {
        alert("Preencha seu e-mail corretamente!");
        return false;
    }
    else {

        return true;

    }

}