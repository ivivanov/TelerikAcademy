var controls = (function() {

	function Accordion(selector) {
		var items = [];
		var accordion = document.querySelector(selector);
		var list = document.createElement('ul');


		this.add = function(title) {
			var newItem = new Item(title);
			items.push(newItem);
			return newItem;
		};

		this.render = function() {
			for (var i = 0; i < items.length; i++) {
				var currentItem = items[i].render();
				list.appendChild(currentItem);
			}
			accordion.appendChild(list);
		};

		this.serialize = function() {
			var serializedItems = [];
			for (var i = 0; i < items.length; i++) {
				serializedItems.push(items[i].serialize());
			}
			return serializedItems;
		};

		accordion.addEventListener('click',

		function(ev) {
			ev.stopPropagation();
			ev.preventDefault();
			var clickedItem = ev.target;
			if (clickedItem instanceof HTMLAnchorElement) {
				var nestedList = clickedItem.nextElementSibling;

				if (nestedList.style.display === 'none') {
					nestedList.style.display = 'block';
				} else {
					nestedList.style.display = 'none';
				}
			}
			hidePrevious(clickedItem);
			hideNext(clickedItem);
		});

		function hidePrevious(element) {
			var li = element.parentNode;
			var previous = li.previousElementSibling;
			while (previous) {
				var ul = previous.querySelector('ul');
				if (ul) {
					ul.style.display = 'none';
				}
				previous = previous.previousElementSibling;
			}
		}

		function hideNext(element) {
			var li = element.parentNode;
			var next = li.nextElementSibling;
			while (next) {
				var ul = next.querySelector('ul');
				if (ul) {
					ul.style.display = 'none';
				}
				next = next.nextElementSibling;
			}
		}

	}

	function Item(title) {

		var subItems = [];

		this.add = function(title) {
			var newItem = new Item(title);
			subItems.push(newItem);
			return newItem;
		};

		this.render = function() {
			var item = document.createElement('li');
			item.innerHTML = '<a href="a">' + title + '</a>';

			if (subItems.length > 0) {
				var nestedList = document.createElement('ul');
				nestedList.style.display = 'none';
				for (var i = 0; i < subItems.length; i++) {
					var newItem = subItems[i].render();
					nestedList.appendChild(newItem);
				}
				item.appendChild(nestedList);
			}

			return item;
		};

		this.serialize = function() {
			var thisItem = {};
			thisItem.title = title;

			if (subItems.length > 0) {
				var serializedItems = [];
				for (var i = 0; i < subItems.length; i++) {
					serializedItems.push(subItems[i].serialize());
				}
				thisItem.subItems = serializedItems;
			}
			return thisItem;
		};
	}

	function getAccordion(selector) {
		return new Accordion(selector);
	}

	function addDeserializedItem(item, data) {
		var deserializedObj = item.add(data.title);
		if (data.subItems) {
			for (var i = 0; i < data.subItems.length; i++) {
				addDeserializedItem(deserializedObj, data.subItems[i]);
			}
		}

		return deserializedObj;
	}

	function setAccordion(selector, data) {
		var accordion = this.getAccordion(selector);

		if (data) {
			for (var i = 0; i < data.length; i++) {
				addDeserializedItem(accordion, data[i]);
			}
		}

		return accordion;
	}

	return {
		getAccordion: getAccordion,
		setAccordion: setAccordion
	};
})();