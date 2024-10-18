
let m = []

function randint(a,b) {
    return Math.floor(Math.random() * (b-a+1))+a
}


function generate() {
    generateMatrix()
    showTable()
}

function showTable(Oszto) {
    const table = document.querySelector("table")
    let data = ""
    for (let i = 0; i < m.length; i++) {
        data += "<tr>"
        for (let j = 0; j < m[i].length; j++) {
            
            data += `<td>${m[i][j]}</td>`
        }
        data += "</tr>"
        
    }
    table.innerHTML = data
}

function generateMatrix() {
    m = [];
    
    for (let i = 0; i < 10; i++) {
        const row = []
        for (let j = 0; j < 10; j++) {
            const r = randint(10,99)
            row.push(r)
            
        }
        m.push(row)
    }
    localStorage.setItem("numbers",JSON.stringify(m))
}

function handleLoad() {
    m = JSON.parse(localStorage.getItem("numbers"))
    if (!m) {return;}
    showTable();
}

function setClickHandlers() {
    for (let i = 0; i < m.length; i++) {
        for (let j = 0; j < m[i].length; j++) {
            const element = array[j];
            
        }
        
    }
}

const button = document.querySelector("button")
button.addEventListener("click", generate)

window.addEventListener("load", handleLoad)