// this: eseményt kiváltó objektum
function handleChoose() {
    // this.className = "active"; ROSSZ!
    // this.className += " active";
    for (const image of images) {
        image.classList.remove("active");
    }
    this.classList.add("active");
}
const images = document.querySelectorAll("img");
for (const image of images) {
    image.addEventListener("click", handleChoose);
}

// this.classList.add("active")
// this.classList.remove("active")
// this.classList.contains("active")

function decideWinner(human, computer) {
    if (human === computer)
        return "Döntetlen"
    else if (humman === "ko" && computer === "ollo")
        return "Játékos nyert"
    else if (humman === "papir" && computer === "ko")
        return "Játékos nyert"
    else if (humman === "ollo" && computer === "papir")
        return "Játékos nyert"
    else 
        return "Számitogép nyert!"
}

// randint(1, 3):
// Math.floor(Math.random() * 3) + 1;

function randint(a, b) {
    return Math.floor(Math.random() * (b-a+1)) + a;
}

// "ko", "papir", "ollo"
function randomItem() {
    // Nagy Ádám
    // const r = randint(1, 3);
    // if (r === 1) {
    //     return "ko";
    // } else if (r === 2) {
    //     return "papir";
    // } else {
    //     return "ollo";
    // }

    // Petró Ádám + Murár Bálint
    // return r === 1 ? "ko" : r === 2 ? "papir" : "ollo";

    // Timár Szabolcs
    const items = ["ko", "papir", "ollo"];
    const r = randint(0, 2);
    return items[r];
}

function endGame(computer, human) {
    button.removeEventListener("click", handleStart);
    for (const image of images) {
        image.removeEventListener("click", handleChoose);
    }
    decideWinner(computer, human)
    const result = document.querySelector("#eredmeny")
}

function insertImage(item) {
    const img = document.createElement("img");
    img.src = `images/${item}.png`;
    img.classList.add("img-height");
    return img;
}

function saveImage(img) {
    const eredmeny = document.querySelector("#eredmeny");
    const body = document.body;
    body.insertBefore(img, eredmeny); // szulo.insertBefore(gyerek, testver)
}

function handleStart() {
    const human = document.querySelectorAll(".active")
    if (human.length === 0) {
        return;
    }
    if (document.querySelectorAll(".active").length === 0) {
        return;
    }
    const computer = randomItem();
    const img = createImage(computer);
    insertImage(img);

    endGame(human[0].alt, human);
}
const button = document.querySelector("button");
button.addEventListener("click", handleStart);