var movingShapes = (function() {
	'use strict';

	(function() {
		var requestAnimationFrame = window.requestAnimationFrame || window.mozRequestAnimationFrame || window.webkitRequestAnimationFrame || window.msRequestAnimationFrame;
		window.requestAnimationFrame = requestAnimationFrame;
	})();

	// Returns a random integer between min and max

	function getRandomInt(min, max) {
		return Math.floor(Math.random() * (max - min + 1)) + min;
	}

	// Returns a random RGBA string e.g. rgba(1, 1, 1, 0.5);

	function getRandomRGBA() {
		var r = getRandomInt(1, 255).toString();
		var g = getRandomInt(1, 255).toString();
		var b = getRandomInt(1, 255).toString();
		var a = (getRandomInt(1, 10) / 10).toString();
		var randomRGBA = "rgba(" + r + "," + g + "," + b + "," + a + ")";

		return randomRGBA;
	}

	// Returns a random color string e.g. #F211FF

	function getRandomColor() {
		var pad = "00";
		var r = getRandomInt(1, 255).toString('16');
		var g = getRandomInt(1, 255).toString('16');
		var b = getRandomInt(1, 255).toString('16');
		var randomColor = '#' + r.substring(0, pad.length - r.length) + r + g.substring(0, pad.length - g.length) + g + b.substring(0, pad.length - b.length) + b;
		return randomColor;
	}

	// Returns a random styled div element

	function getRandomDiv() {
		var DIV_SIZE = '40px';
		var BORDER_SIZE = '5px';
		var divElement = document.createElement('div');


		divElement.style.backgroundColor = getRandomRGBA();
		divElement.style.position = 'absolute';
		divElement.innerHTML = '<strong>div</strong>';
		divElement.style.padding = '10px';
		divElement.style.width = DIV_SIZE;
		divElement.style.height = DIV_SIZE;
		divElement.style.border = BORDER_SIZE + ' solid' + getRandomColor();
		divElement.style.color = getRandomColor();

		return divElement;
	}

	function moveInCircle(element) {
		element.setAttribute('angle', 0);
		var parent = document.getElementById('circle');
		var parentWidth = parseInt(document.defaultView.getComputedStyle(parent, null).getPropertyValue("width"), 10);
		var parentR = parentWidth / 2;
		var parentX = parseInt(document.defaultView.getComputedStyle(parent, null).getPropertyValue("top"), 10);
		var parentY = parseInt(document.defaultView.getComputedStyle(parent, null).getPropertyValue("left"), 10);
		(function move() {
			var degrees = (parseFloat(element.getAttribute('angle'))) % 360;
			var x = parentX + parentR * Math.cos(degrees * Math.PI / 180);
			var y = parentY + parentR * Math.sin(degrees * Math.PI / 180);
			element.style.left = x - parseInt(element.style.width, 10) / 2 + 'px';
			element.style.top = y - parseInt(element.style.height, 10) / 2 + 'px';
			element.attributes.angle.nodeValue++;
			requestAnimationFrame(move);
		})();
	}

	function moveInRectangular(element) {
		var parent = document.getElementById('rectangular');
		var parentWidth = parseInt(document.defaultView.getComputedStyle(parent, null).getPropertyValue("width"), 10);
		var parentHeight = parseInt(document.defaultView.getComputedStyle(parent, null).getPropertyValue("width"), 10);
		var top = 0;
		var left = 0;
		var movingDown = true;
		var movingRight = false;
		var movingUp = false;
		var movingLeft = false;
		(function move() {


			if (movingDown) {
				if (top < parentHeight) {
					top++;
				} else {
					movingDown = false;
					movingRight = true;
				}
			}
			if (movingRight) {
				if (left < parentWidth) {
					left++;
				} else {
					movingRight = false;
					movingUp = true;
				}
			}
			if (movingUp) {
				if (top > 0) {
					top--;
				} else {
					movingUp = false;
					movingLeft = true;
				}
			}
			if (movingLeft) {
				if (left > 0) {
					left--;
				} else {
					movingLeft = false;
					movingDown = true;
				}
			}
			element.style.top = top + 'px';
			element.style.left = left + 'px';
			requestAnimationFrame(move);
		})();
	}

	function moveInEllipse(element) {
		element.setAttribute('angle', 0);
		(function move() {
			var theta = (parseFloat(element.getAttribute('angle'))) / 180;
			var centerLeft = 400;
			var left = parseInt(centerLeft + 400 * Math.sin(theta));
			element.style.left = left + "px";
			var centerTop = 200;
			var top = parseInt(centerTop - 200 * Math.cos(theta));
			element.style.top = top + "px";
			element.attributes.angle.nodeValue++;
			requestAnimationFrame(move);
		})();
	}

	// Adds div to the document which moves in the specified pattern (movementShape)

	function add(movementShape) {
		var div = getRandomDiv();
		if (movementShape == "circle") {
			div.style.borderRadius = '50px';
			document.getElementById('circle').appendChild(div);
			moveInCircle(div);
		}
		if (movementShape == "rectangular") {
			document.getElementById('rectangular').appendChild(div);
			moveInRectangular(div);
		}
		if (movementShape == "ellipse") {
			div.style.borderRadius = '50px';
			div.style.width = '70px';
			document.getElementById('ellipse').appendChild(div);
			moveInEllipse(div);
		}
	}

	return {
		addElement: add,
	}

})();