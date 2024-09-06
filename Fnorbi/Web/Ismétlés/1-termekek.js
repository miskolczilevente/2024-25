const products = [
    {
        name: "Televízió",
        price: 80000,
        category: "Elektronika"
    },
    {
        name: "Hűtőszekrény",
        price: 120000,
        category: "Háztartási gépek"
    },
    {
        name: "Mosógép",
        price: 100000,
        category: "Háztartási gépek"
    },
    { 
        name: "Laptop",
        price: 150000,
        category: "Elektronika"
    },
    {
        name: "Kávéfőző",
        price: 25000,
        category: "Konyhai eszközök"
    }
];

function cheapest() {
    let min = Infinity;
    let termek = products.name[0]
    for (const element of products) {
        if (element.price < min) {
            min = element.price
        }
    }
    
    
    console.log("Cheapest product is:" , min )
}


function countABPairs(text) {
    let db = 0;
    for (let i = 0; i < text.length-1; i++) {
        if (text[i] === "a" && text[i+1] === "b"){
            db++;
        }
    }
    return db;
}