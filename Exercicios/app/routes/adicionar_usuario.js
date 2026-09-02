module.exports = function(app) {
    app.get('/informacao/cursos', function(req, res){
        res.render('informacao/cursos');
    });
}

app.get('/formulario_adicionar_usuario', function (req, res) {
    res.render("admin/adicionar_usuario");
});