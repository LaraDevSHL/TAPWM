// 1. Retornar o maior de três números
function encontrarMaior(a, b, c) {
    return Math.max(a, b, c);
}

// 2. Retornar três números em ordem crescente
function ordenarNumeros(a, b, c) {
    let numeros = [a, b, c];
    numeros.sort((x, y) => x - y); // Ordenação numérica
    return numeros.join(", ");
}

// 3. Verificar Palíndromo
function verificarPalindromo(texto) {
    // Converter para minúsculas e remover espaços usando Regex
    let limpo = texto.toLowerCase().replace(/\s+/g, '');
    let invertido = limpo.split('').reverse().join('');
    
    return limpo === invertido ? "É um palíndromo" : "Não é um palíndromo";
}

// 4. Verificar Subconjunto (String contida em outra)
function verificarSubconjunto(p1, p2) {
    if (!p1 || !p2 || p1.trim() === "" || p2.trim() === "") {
        return "erro";
    }
    
    // Verifica se p2 está dentro de p1
    if (p1.includes(p2)) {
        return "é um subconjunto";
    } else {
        return "não é um subconjunto";
    }
}

// 5. Receber data e devolver dia da semana
function obterDiaSemana(dataString) {
    const dias = ["Domingo", "Segunda-feira", "Terça-feira", "Quarta-feira", "Quinta-feira", "Sexta-feira", "Sábado"];
    
    // Ajuste para evitar problema de fuso horário local ao instanciar data
    let data = new Date(dataString + 'T00:00:00'); 
    return dias[data.getDay()];
}

// --- FUNÇÕES DE INTERFACE (Para ligar o HTML ao JS) ---

function testarMaior() {
    let n1 = Number(document.getElementById('n1').value);
    let n2 = Number(document.getElementById('n2').value);
    let n3 = Number(document.getElementById('n3').value);
    document.getElementById('res1').innerText = "O maior é: " + encontrarMaior(n1, n2, n3);
}

function testarOrdem() {
    let n1 = Number(document.getElementById('n1').value);
    let n2 = Number(document.getElementById('n2').value);
    let n3 = Number(document.getElementById('n3').value);
    document.getElementById('res1').innerText = "Ordem: " + ordenarNumeros(n1, n2, n3);
}

function testarPalindromo() {
    let txt = document.getElementById('inputPalindromo').value;
    document.getElementById('res3').innerText = verificarPalindromo(txt);
}

function testarSubconjunto() {
    let p1 = document.getElementById('palavra1').value;
    let p2 = document.getElementById('palavra2').value;
    document.getElementById('res4').innerText = verificarSubconjunto(p1, p2);
}

function testarData() {
    let dataVal = document.getElementById('inputData').value;
    if(dataVal) {
        document.getElementById('res5').innerText = "Dia: " + obterDiaSemana(dataVal);
    } else {
        document.getElementById('res5').innerText = "Selecione uma data.";
    }
}