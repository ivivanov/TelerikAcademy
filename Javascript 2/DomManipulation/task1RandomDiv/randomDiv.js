// Returns a random integer between min and max
function getRandomInt(min, max) {
    return Math.floor(Math.random() * (max - min + 1)) + min;
}

//Returns random styled and random positioned div
function getRandomDiv() {
    var divElement = document.createElement('div');
    var randomColor = '#' + getRandomInt(1, 255).toString('16') + getRandomInt(1, 255).toString('16') + getRandomInt(1, 255).toString('16');
    var r = getRandomInt(1, 255).toString();
    var g = getRandomInt(1, 255).toString();
    var b = getRandomInt(1, 255).toString();
    var a = (getRandomInt(1, 10) / 10).toString();
    divElement.style.backgroundColor = "rgba(" + r + "," + g + "," + b + "," + a + ")";
    divElement.style.position = 'absolute';
    divElement.style.top = getRandomInt(30, 900) + 'px';
    divElement.style.left = getRandomInt(0, 900) + 'px';
    divElement.innerHTML = '<strong>div</strong>';
    divElement.style.padding = '10px';
    divElement.style.width = getRandomInt(20, 100) + 'px';
    divElement.style.height = getRandomInt(20, 100) + 'px';
    divElement.style.border = getRandomInt(1, 20) + 'px solid' + randomColor;
    randomColor = '#' + getRandomInt(1, 255).toString('16') + getRandomInt(1, 255).toString('16') + getRandomInt(1, 255).toString('16');
    divElement.style.color = randomColor;
    divElement.style.borderRadius = getRandomInt(5, 20) + 'px';
    
    return divElement;
}

function clearDivs() {
    var contentDiv = document.getElementById("wrapper");
    while (contentDiv.firstChild) {
        contentDiv.removeChild(contentDiv.firstChild);
    }
}

//Appends 'count' number of random divs to div #wrapper 
function manyDivsGenerator() {
    clearDivs();
    var count = parseInt(document.getElementById('countTB').value);
    var divWrapper = document.getElementById('wrapper');
    for (var i = 0; i < count; i++) {
        divWrapper.appendChild(getRandomDiv());
    }
}