

function validarFormulario(){

    let elementos = document.nomeform.elements;

    let nome = elementos[0].value.trim();
    let email = elementos[1].value.trim();
    let comentario = elementos[2].value.trim();

    if(nome.length < 10){

        alert("O nome deve possuir pelo menos 10 caracteres.");
        elementos[0].focus();
        return false;

    }

    if(email == ""){

        alert("Informe um e-mail.");
        elementos[1].focus();
        return false;

    }

    if(comentario.length < 20){

        alert("O comentário deve possuir no mínimo 20 caracteres.");
        elementos[2].focus();
        return false;

    }

    let pesquisa = document.getElementsByName("pesquisa");
    let respondeu = false;
    let valor = "";

    for(let radio of pesquisa){

        if(radio.checked){

            respondeu = true;
            valor = radio.value;

        }

    }

    if(!respondeu){

        alert("Selecione uma opção na pesquisa.");
        return false;

    }

    if(valor == "sim"){

        alert("Que bom que você voltou a visitar esta página!");

    }else{

        alert("Volte sempre à esta página!");

    }

    return true;

}
