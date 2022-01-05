let leftTopButtonOne = document.getElementById("leftTopButtonClickOne");
let leftTopButtonTwo = document.getElementById("leftTopButtonClickTwo");
let leftTopButtonThree = document.getElementById("leftTopButtonClickThree");

let rightTopButtonOne=document.getElementById("rightTopButtonClickOne");
let rightTopButtonTwo=document.getElementById("rightTopButtonClickTwo");
let rightTopButtonThree=document.getElementById("rightTopButtonClickThree");

function leftTopAccordionButtonClickOne(){
    leftTopButtonOne.style.backgroundColor="rgb(243,79,63)";
    leftTopButtonOne.style.color="white";
    leftTopButtonTwo.style.backgroundColor="white";
    leftTopButtonTwo.style.color="black";
    leftTopButtonThree.style.backgroundColor="white"
    leftTopButtonThree.style.color="black";
}
function leftTopAccordionButtonClickTwo(){
    leftTopButtonTwo.style.backgroundColor="rgb(243,79,63)";
    leftTopButtonTwo.style.color="white";
    leftTopButtonOne.style.color="black";
    leftTopButtonOne.style.backgroundColor="white"
    leftTopButtonThree.style.backgroundColor="white"
    leftTopButtonThree.style.color="black";
}
function leftTopAccordionButtonClickThree(){
    leftTopButtonThree.style.backgroundColor="rgb(243,79,63)";
    leftTopButtonThree.style.color="white";
    leftTopButtonOne.style.color="black";
    leftTopButtonOne.style.backgroundColor="white";
    leftTopButtonTwo.style.color="black";
    leftTopButtonTwo.style.backgroundColor="white";
}
function rightTopAccordionButtonClickOne(){
    rightTopButtonOne.style.backgroundColor="rgb(243,79,63)";
    rightTopButtonOne.style.color="white";
    rightTopButtonTwo.style.backgroundColor="white";
    rightTopButtonTwo.style.color="black";
    rightTopButtonThree.style.backgroundColor="white"
    rightTopButtonThree.style.color="black";
}
function rightTopAccordionButtonClickTwo(){
    rightTopButtonTwo.style.backgroundColor="rgb(243,79,63)";
    rightTopButtonTwo.style.color="white";
    rightTopButtonOne.style.color="black";
    rightTopButtonOne.style.backgroundColor="white"
    rightTopButtonThree.style.backgroundColor="white"
    rightTopButtonThree.style.color="black";
}
function rightTopAccordionButtonClickThree(){
    rightTopButtonThree.style.backgroundColor="rgb(243,79,63)";
    rightTopButtonThree.style.color="white";
    rightTopButtonOne.style.color="black";
    rightTopButtonOne.style.backgroundColor="white";
    rightTopButtonTwo.style.color="black";
    rightTopButtonTwo.style.backgroundColor="white";
}
$(document).ready(function () {

    // START ACCORDION
$(".accordion-button").mouseenter(function(){
$(".minus").removeClass("d-none")
$(".plus").addClass("d-none")
});

$(".accordion-button").mouseleave(function(){
$(".minus").addClass("d-none")
$(".plus").removeClass("d-none")
});

$(".accordion").accordion();

      // END ACCORDION
        

});