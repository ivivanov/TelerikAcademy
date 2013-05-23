var todoModule = (function() {
	var todoList = document.getElementById("todo");

	function addTask() {
		var value = document.getElementById("inputtext").value;
		var item = document.createElement("li");
		item.innerHTML = value;
		item.onclick = markItem;
		todoList.appendChild(item);
	}

	function removeTask() {
		for (var i = 0; i < todoList.childNodes.length; i++) {
			var current = todoList.childNodes[i];

			if (current.style.color == "red") {
				todoList.removeChild(current);
				i--;
			}
		}
	}

	function markItem(ev) {
		if (!ev) ev = window.event;

		var target = ev.srcElement;

		if (target.style.color == "red") target.style.color = "black";
		else {
			target.style.color = "red";
		}
	}


	function hideSelected() {
		for (var i = 0; i < todoList.childNodes.length; i++) {
			var current = todoList.childNodes[i];

			if (current.style.color == "red") {
				current.style.display = "none";
			}
		}
	}

	function showAll() {
		for (var i = 0; i < todoList.childNodes.length; i++) {
			var current = todoList.childNodes[i];

			if (current.style.display == "none") current.style.display = "list-item";
		}
	}

	return {
		add: addTask,
		remove: removeTask,
		hide: hideSelected,
		show: showAll
	};
})();