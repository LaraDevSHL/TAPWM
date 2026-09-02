
let app = require('./app/config/server');//executando o express
let rotaHome = require('./app/routes/home');
rotaHome(app);

let rotaAdicionarUsuario = require('./app/routes/adicionar_usuario');
rotaCursos(app);

 
app.set('view engine', 'ejs');
app.get('/', function (req, res) {
 res.render("home/index")
});



app.listen(3000, function () {
    console.log("servidor iniciado");
 
});
 