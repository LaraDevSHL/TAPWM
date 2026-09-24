function abrirCurso(curso){

    if(curso=="")
        return;

    let confirmar = confirm("Deseja abrir a página deste curso?");

    if(confirmar){

        window.open(
            curso,
            "_blank",
            "width=600,height=300"
        );

    }

}