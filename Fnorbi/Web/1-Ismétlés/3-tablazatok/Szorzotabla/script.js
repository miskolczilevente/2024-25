const input = document.querySelector("input[type=range]")
input.addEventListener("input", generateTable)
const span = document.querySelector("h2 span")

const table = document.querySelector("table")

function generateTable() {
    let n = parseInt(input.value);
    span.innerText = n

    
    table.innerHTML = ""
    for (let i = 1; i < n+1; i++) {
        const tr = document.createElement("tr")
        for (let j = 1; j < n+1; j++) {
            const td = document.createElement("td")
            td.innerText = (i)*j
            tr.appendChild(td)
            
        }
        table.appendChild(tr)
    }
}