// (function() {
// 	var requestAnimationFrame = window.requestAnimationFrame || window.mozRequestAnimationFrame || window.webkitRequestAnimationFrame || window.msRequestAnimationFrame;
// 	window.requestAnimationFrame = requestAnimationFrame;
// })();
// (function loop() {
// 	changePosition();
// 	requestAnimationFrame(loop);
// })();

function pixelToInt(input) {
	var arr = input.split('px');
	var number = parseInt(arr[0]);
	return number;
}

function createDiv() {
	var div = document.createElement('div');
	div.style.width = '80px';
	div.style.height = '80px';
	div.style.background = 'rgba(100,100,200,0.3)';
	div.style.position = 'absolute';
	div.style.left = '0px';
	return div;
}

(function main() {
	var divWrapper = document.getElementById('wrapper');
	for (var i = 0; i < 5; i++) {
		var div = createDiv();
		div.style.top = i * 100 + 'px';
		div.setAttribute('id', i);
		divWrapper.appendChild(div);
	};

	var id = 4;
	var movingDown = [true, true, true, true, true];
	var movingRight = [false, false, false, false, false];
	var movingUp = [false, false, false, false, false];
	var movingLeft = [false, false, false, false, false];

	function changePosition() {
		for (var i = 0; i < 5; i++) {
			if (id == -1) {
				id = 4;
			}
			var elem = document.getElementById(id);
			var top = pixelToInt(document.defaultView.getComputedStyle(elem, null).getPropertyValue("top"));
			var left = pixelToInt(document.defaultView.getComputedStyle(elem, null).getPropertyValue("left"));
			if (movingDown[id]) {
				if (top < 500) {
					top += 10;
				} else {
					movingDown[id] = false;
					movingRight[id] = true;
				}
			}
			if (movingRight[id]) {
				if (left < 500) {
					left += 10;
				} else {
					movingRight[id] = false;
					movingUp[id] = true;
				}
			}
			if (movingUp[id]) {
				if (top > 0) {
					top -= 10;
				} else {
					movingUp[id] = false;
					movingLeft[id] = true;
				}
			}
			if (movingLeft[id]) {
				if (left > 0) {
					left -= 10;
				} else {
					movingLeft[id] = false;
					movingDown[id] = true;
				}
			}
			elem.style.top = top + 'px';
			elem.style.left = left + 'px';
			id--;
		}
	}
	setInterval(changePosition, 100);
})();