function randint(a, b) {
    return Math.floor(Math.random() * (b-a+1)) + a;
}


function generatePoints() {
    let points = [];
    for (let i = 0; i < 1001; i++) {
        let point = { x: randint(-50, 51), y: randint(-50,51)}
        points.push(point)
    }
    return points;
}