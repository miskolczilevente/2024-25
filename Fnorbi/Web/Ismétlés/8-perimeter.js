const points = [
    {x: 1, y: -1},
    {x: 4, y: 0},
    {x: 5, y: 3},
    {x: 3, y: 4},
    {x: -1, y: 2}
];

function distance(A, B) {
    const elso = (A.x-B.x)**2;
    const masodik = (A.y-B.y)**2;
    
    return Math.sqrt(elso + masodik)
}

function perimeter(points) {
    let add = 0;
    const n = points.length;
    for (let i = 1; i < n; i++) {
        add += distance(points[i-1],points[i]); 
    }
    add += distance(points[n-1],points[0]);

    return add;
}


perimeter(points) === 16.638310528300117;