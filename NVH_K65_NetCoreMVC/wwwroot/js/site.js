// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
let slideIndex=1;
showSlide(slideIndex);
function plusSlide(n){
    showSlide(slideIndex+=n);
}
function currentSlide(n){
    showSlide(slideIndex=n);
}
function showSlide(n){
    let i;
    let slides= document.getElementsByClassName("Slide");
    let dots= document.getElementsByClassName("dot");
    if(n>slides.length) slideIndex=1;
    if(n<1) slideIndex= slides.length;
    for(i=0;i<slides.length;i++){
        slides[i].style.display="none";
    }
    for(i=0;i<dots.length;i++){
        dots[i].className=dots[i].className.replace(" active", "");
    }
    slides[slideIndex-1].style.display="block";
    dots[slideIndex-1].className+=" active";
}