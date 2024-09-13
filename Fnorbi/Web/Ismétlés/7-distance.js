function distance(A, B) {
    const elso = (A.x-B.x)**2;
    const masodik = (A.y-B.y)**2;
    
    return Math.sqrt(elso + masodik)
}