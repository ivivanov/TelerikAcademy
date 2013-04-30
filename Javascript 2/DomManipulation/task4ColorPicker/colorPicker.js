function changeFontColor() {
	var fontColor = document.getElementById('cp2').value;
	var textArea = document.getElementById('ta');
	textArea.style.color = fontColor;
};
function changeBackColor() {
	var backgroungColor = document.getElementById('cp1').value;
	var textArea = document.getElementById('ta');
	textArea.style.background = backgroungColor;
};