import * as THREE from 'three';
import {scene} from './script.js';
import kep1 from '../kepek/2-nature.jpg'

const textureLoader = new THREE.TextureLoader();
const boxGeometry = new THREE.BoxGeometry(4,4,4);
const boxMaterial = new THREE.MeshBasicMaterial({
    map: textureLoader.load(kep1)
});

const box = new THREE.Mesh(boxGeometry,boxMaterial)
scene.add(box);