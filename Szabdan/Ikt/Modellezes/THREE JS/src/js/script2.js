import * as THREE from 'three';
import { OrbitControls } from 'three/examples/jsm/controls/OrbitControls.js';

const renderer = new THREE.WebGLRenderer();

renderer.setSize(window.innerWidth,window.innerHeight);

document.body.appendChild(renderer.domElement);

const scene = new THREE.Scene();

const camera = new THREE.PerspectiveCamera(
    75,
    window.innerWidth/window.innerHeight,
    0.1,
    1000
);
const orbit = new OrbitControls(camera, renderer.domElement);

const axesHelper = new THREE.AxesHelper(3);
scene.add(axesHelper);

const gridHelper = new THREE.GridHelper(30);
scene.add(gridHelper);

camera.position.set(1,1,30);
orbit.update();


const boxGeometry = new THREE.BoxGeometry(2, 2, 2);
const boxMaterial = new THREE.MeshBasicMaterial({color: "red", wireframe: true});
const box = new THREE.Mesh(boxGeometry, boxMaterial);
box.position.set(0,1,0)
scene.add(box);

const sphereGeometry = new THREE.SphereGeometry(1,20,20);
const sphereMaterial = new THREE.MeshBasicMaterial({
//const sphereMaterial = new THREE.MeshLambertMaterial({
    color: "blue",
    wireframe: true
});
const sphere = new THREE.Mesh(sphereGeometry,sphereMaterial);
//sphere.position.x = -10;
sphere.position.set(0,1,0);
scene.add(sphere);


const planeGeometry = new THREE.PlaneGeometry(30,30);
const planeMatrial = new THREE.MeshBasicMaterial({color: "white"});
const plane = new THREE.Mesh(planeGeometry, planeMatrial);
plane.rotation.x = -0.5*Math.PI;
scene.add(plane);


//renderer.render(scene, camera);

function animate(){
    renderer.render(scene,camera);
}
renderer.setAnimationLoop(animate);