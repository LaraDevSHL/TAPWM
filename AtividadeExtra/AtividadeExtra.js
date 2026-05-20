// 1. Objeto literal
const pessoa1 = {
  nome: "Ana",
  idade: 25,
  hobby: "Pintura",
  apresentar() {
    return `Olá, meu nome é ${this.nome}, tenho ${this.idade} anos e meu hobby é ${this.hobby}.`;
  }
};

console.log(pessoa1.apresentar());


// 2. Usando new Object()
const pessoa2 = new Object();

pessoa2.nome = "Carlos";
pessoa2.idade = 30;
pessoa2.hobby = "Futebol";

pessoa2.apresentar = function () {
  return `Olá, meu nome é ${this.nome}, tenho ${this.idade} anos e meu hobby é ${this.hobby}.`;
};

console.log(pessoa2.apresentar());


// 3. Função construtora
function Pessoa(nome, idade, hobby) {
  this.nome = nome;
  this.idade = idade;
  this.hobby = hobby;

  this.apresentar = function () {
    return `Olá, meu nome é ${this.nome}, tenho ${this.idade} anos e meu hobby é ${this.hobby}.`;
  };
}

const pessoa3 = new Pessoa("Mariana", 22, "Leitura");

console.log(pessoa3.apresentar());


// 4. Classe (class)
class PessoaClasse {
  constructor(nome, idade, hobby) {
    this.nome = nome;
    this.idade = idade;
    this.hobby = hobby;
  }

  apresentar() {
    return `Olá, meu nome é ${this.nome}, tenho ${this.idade} anos e meu hobby é ${this.hobby}.`;
  }
}

const pessoa4 = new PessoaClasse("João", 28, "Música");

console.log(pessoa4.apresentar());


// 5. Object.create()
const modeloPessoa = {
  apresentar() {
    return `Olá, meu nome é ${this.nome}, tenho ${this.idade} anos e meu hobby é ${this.hobby}.`;
  }
};

const pessoa5 = Object.create(modeloPessoa);

pessoa5.nome = "Fernanda";
pessoa5.idade = 35;
pessoa5.hobby = "Culinária";

console.log(pessoa5.apresentar());