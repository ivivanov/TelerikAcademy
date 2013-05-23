var gameModule = (function() {
	'use strict';

	//returns jason object with top and left positions.
	//top and left are determined based on maxTop and maxLeft

	function randomPosition(maxTop, maxLeft) {
		function getRandomInt(min, max) {
			return Math.floor(Math.random() * (max - min + 1)) + min;
		}
		var top = getRandomInt(0, maxTop);
		var left = getRandomInt(0, maxLeft);
		return {
			top: top,
			left: left
		};
	}

	//parentSelector: used to determine trash abosolute positioning
	//count: number of trashes to be generated in the parent	

	function generateDivs(parentSelector, count) {
		var parent = document.querySelector(parentSelector);
		var docFragment = document.createDocumentFragment();
		var parentWidth = parseInt(document.defaultView.getComputedStyle(parent, null).getPropertyValue("width"), 10) - 150;
		var parentHeight = parseInt(document.defaultView.getComputedStyle(parent, null).getPropertyValue("height"), 10) - 150;

		for (var i = 0; i < count; i++) {
			var div = document.createElement('div');
			var positions = randomPosition(parentHeight, parentWidth);
			div.style.top = positions.top;
			div.style.left = positions.left;
			div.id = "id-" + i;
			docFragment.appendChild(div);
		}
		parent.appendChild(docFragment);

	}

	function setClass(elementsSelector, className) {
		var elements = document.querySelectorAll(elementsSelector);
		for (var i = 0; i < elements.length; i++) {
			elements[i].className = className;
		}
	}

	function createDraggable(elementsSelector) {
		var elements = document.querySelectorAll(elementsSelector);
		for (var i = 0; i < elements.length; i++) {
			elements[i].setAttribute('draggable', 'true');
			elements[i].addEventListener('dragstart', handleDragStart, false);
		}
	}

	function createDroppableArea(elementsSelector) {
		var elements = document.querySelectorAll(elementsSelector);
		for (var i = 0; i < elements.length; i++) {
			elements[i].setAttribute('draggable', 'false');
			elements[i].addEventListener('dragover', handleDragOver, false);
			elements[i].addEventListener('drop', handleDrop, false);
			elements[i].addEventListener('dragenter', handleDragEnter, false);
			elements[i].addEventListener('dragleave', handleDragLeave, false);
		}
	}

	function clearDivs(parentSelector) {
		var contentDiv = document.getElementById(parentSelector);
		while (contentDiv.firstChild) {
			contentDiv.removeChild(contentDiv.firstChild);
		}
	}

	return {
		createDivs: generateDivs,
		setClass: setClass,
		createDraggable: createDraggable,
		createDroppableArea: createDroppableArea,
		clearDivs: clearDivs
	};
})();