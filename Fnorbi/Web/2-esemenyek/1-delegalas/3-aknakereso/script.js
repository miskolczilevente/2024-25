const n = 12;
const mineCount = 10;
let board = [];
let revealedCount = 0;

const table = document.querySelector("table");

// --------------------------------------------

function randint(a, b) {
    return Math.floor(Math.random() * (b-a+1)) + a;
}

function createBoard() {
    board = []
    for (let i = 0; i < n; i++) {
        board.push([])
        for (let j = 0; j < n; j++) {
            board[i].push({value: 0, isMine:false, isReveled: false})
            
        }
        
    }
}

function getText(field) {
    if (!field.isReveled) {
        return "";
    }
    else if(field.isMine){
        return "💣";
    }
    else if (field.value !== 0) {
        return field.value;
    }
}

function showBoard() {
    const table = document.querySelector("table")
    table.innerHTML = "";
    for (let i = 0; i < board.length; i++) {
        const tr = document.createElement("tr");
        for (let j = 0; j < board[i].length; j++) {
            const td = document.createElement("td")
            td.innerText = getText(board[i][j])
            
            tr.appendChild(td);
        }
        table.appendChild(tr);
    }
}

function generateValue(x,y) {
    for (let i = -1; i < 2; i++) {
        for (let j = -1; j < 2; j++) {
            if(!(i + x < 0 || j + y < 0 || i + x > n-1 || j + y > n-1)){
                board[x + i][y + j].value += 1;
            }
            
        }
        
    }
}

function generateNumbers() {
    let i = 0
    while(i < n){
        let randomxy = [(randint(0,n-1)),(randint(0,n-1))];
        if(board[randomxy[0]][randomxy[1]].isMine === false)
        {
            board[randomxy[0]][randomxy[1]].isMine = true
            generateValue(randomxy[0], randomxy[1])
            i++;
        }
        
    }
}

function startGame() {
    createBoard();
    generateNumbers();
    showBoard();
}

const button = document.querySelector("button");
button.addEventListener("click", startGame)