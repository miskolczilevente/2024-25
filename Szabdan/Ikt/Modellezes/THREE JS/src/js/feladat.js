import * as THREE from 'three';
import {scene} from './script.js';



const boxGeometry = new THREE.BoxGeometry(4,4,4);
const boxMaterial = new THREE.MeshBasicMaterial({
    color: "grey"
});

const box = new THREE.Mesh(boxGeometry,boxMaterial)
scene.add(box);