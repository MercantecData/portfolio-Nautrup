function ChangeMeText() {
	document.getElementById('meText').innerHTML = "Jeg hedder Tornado Toben og jeg er helt tosset med vindruer!";
}


function ChangeButtonText() {
	document.getElementById("demo").innerHTML = "Vildt!";
}
//Adds new text to a paragraph
document.getElementById("newElement").innerHTML = "Jeg er fra JavaScript!";

function RemoveElement(obj) {
	document.getElementById("btnRemove").remove();
	
}


var fruit = ["Apple","Banana","Pear"];
for (var i = 0; i < fruit.length; i++) {
	document.getElementById("fruitArray").innerHTML += fruit[i]+ "<br>";
}

function MakeElementWithTextBox() {

}