const form = document.getElementById("form");
const textarea = document.querySelector(".button-form_msg");
const inputName = document.querySelector(".button-form");
const inputEmail = document.querySelector(".button-form_e");
const message_sent = document.getElementById("message_sent");


(function() {
      emailjs.init("M-8xIu9gMuctakLjM");
    })();

form.addEventListener("submit", function (e) {
    e.preventDefault();
    emailjs.sendForm("service_7s70dqh", "template_mo9eyoq", this)
        .then(function() {
           message_sent.style.display = "block";
            setTimeout(() => {
            message_sent.style.display = "none";
            }, 2000);
            form.reset();
        }, function(error) {
          alert("Erro ao enviar mensagem. Tente novamente.");
          console.error("Erro:", error);
        });

});




