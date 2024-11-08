
let m = []
const table = document.querySelector("table")

function randint(a,b) {
    return Math.floor(Math.random() * (b-a+1))+a
}


function generate() {
    generateMatrix()
    showTable()
    setClickHandlers()
}

function showTable(Oszto) {
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
    const rows = table.rows
    for (const row of rows) {
        const cells = row.cells
        for (const cell of cells) {
            cell.addEventListener("click", handleClick)
        }
}
}

function selectNumber() {
    const d = parseInt(input.value)
    const rows = table.rows
    for (const row of rows) {
        const cells = row.cells
        for (const cell of cells) {
            
            cell.classList.toggle("oszthato", parseInt(cell.innerText) % d === 0)
            
             
        }
}
}



function handleClick() {
    this.classList.toggle("oszthato")
    
}


const input = document.querySelector("input")
input.addEventListener("input", selectNumber)
const button = document.querySelector("button")
button.addEventListener("click", generate)

window.addEventListener("load", handleLoad)