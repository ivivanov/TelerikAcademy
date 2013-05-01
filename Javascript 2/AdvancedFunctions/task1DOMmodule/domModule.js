/*
Create a module for working to work with DOM. The module should have the following functionality
Add element to parent element by given selector
Remove element from the DOM  by given selector
Attach event to given selector by given event type and event hander
Add elements to buffer, which appends them to the DOM when their for some selector count becomes 100
The buffer contains elements for each selector it gets
Get elements by CSS selector
The module should reveal only the methods
Create a module for working to work with DOM.

The module should have the following functionality
var domModule = …
var div = document.createElement("div");
//change the div
domModule.appendChild(div,"#wrapper");
domModule.removeChild("ul","li:first"); 
//remove the first li from each ul
domModule.addHandler("a.button", 'click',        
                     function(){alert("Clicked")});
domModule.appendToBuffer("container", div.cloneNode(true));
domModule.appendToBuffer("#main-nav ul", navItem);
*/
var domModule = (function() {
	'use strict';

	var buffer = {};
	var MAX_BUFFER_FRAGMENT_SIZE = 100;

	function appendChild(element, selector) {
		var parent = document.querySelector(selector);
		parent.appendChild(element);
	}

	function removeChild(parentSelector, childSelector) {
		var parents = document.querySelectorAll(parentSelector);
		for (var i = 0; i < parents.length; i++) {
			var itemsToRemove = parents[i].querySelectorAll(childSelector);
			for (var j = 0; j < itemsToRemove.length; j++) {
				parents[i].removeChild(itemsToRemove[j]);
			}
		}
	}

	function addHandler(elementSelector, ev, handler) {
		var elements = document.querySelectorAll(elementSelector);
		for (var i = 0; i < elements.length; i++) {
			// add event listener to 'element'
			elements[i].addEventListener(ev, handler, false);
		}
	}

	function appendToBuffer(parentSelector, element) {
		if (!buffer[parentSelector]) {
			buffer[parentSelector] = document.createDocumentFragment();
		}
		buffer[parentSelector].appendChild(element);


		if (buffer[parentSelector].childNodes.length >= MAX_BUFFER_FRAGMENT_SIZE) {
			var parent = document.querySelector(parentSelector);
			parent.appendChild(buffer[parentSelector]);
			buffer[parentSelector] = null;
		}
	}

	return {
		appendChild: appendChild,
		removeChild: removeChild,
		addHandler: addHandler,
		appendToBuffer: appendToBuffer
	};
})();