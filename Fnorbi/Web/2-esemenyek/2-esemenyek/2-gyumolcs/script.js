const table = document.querySelector("table");

// Állapottér!
// field = {fruit: 🍎, value: 7}
const n = 9, m = 5;
let board = [];
const pos = { x: null, y: null };
let remainingSteps = 12;
let points = 0;


function randint(a, b) {
    return Math.floor(Math.random() * (b-a+1)) + a;
}

function createField() {
    
    let random = randint(1,100)
    if (11 > random)
    {
        field.fruit = "🍎"; 
        field.value = 7;
    }
    else if (31 > random)
    {
        field.fruit = "🍇";
        field.value = 5;
    } 
    else 
    {
        field.fruit = "";
        field.value = 0;
    }   
    return field;
}

function createBoard() {
    board = [];
    for (let i = 0; i < n; i++) {
        row = [];
        for (let j = 0; j < m; j++) {
            const field = createField();
            row.push(field);
        }
        board.push(row);
    }
}



function showBoard() {
    table.innerHTML = "";
    for (const row of board) {
        const tr = document.createElement("tr");
        for (const field of row) {
            const td = document.createElement("td");
            td.innerText = getText(field);
            tr.appendChild(td);
        }
        table.appendChild(tr);
    }
}

function getText(field) {
    if (field.fruit === "🍎") return "🍎";
    else if (field.fruit === "🍇") return "🍇";
    else return "";
}

function collectPoints(i, j) {

}

function move(dx, dy) {
    
}

function handleMove(e) {
    
}

function usePower(e) {

}

function choosePosition(e) {
    const td = e.target;
    if (!td.matches("td"))
        return;
    const j = td.cellIndex
    const tr = td.parentNode
    const i = tr.rowIndex
    pos.x = j;
    pos.y = i;
    td.classList.add("current-position");
    table.removeEventListener("click", choosePosition)
}

function startGame() {
    createBoard();
    showBoard();
    button.removeEventListener("click", startGame);
    table.addEventListener("click", choosePosition);
}
const button = document.querySelector("button");
button.addEventListener("click", startGame);

