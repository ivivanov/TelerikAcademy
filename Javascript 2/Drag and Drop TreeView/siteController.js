(function() {
	window.addEventListener('load', function() {
		var button = document.querySelector('#createFolder');
		var folderContainer = document.querySelector('#folderContainer');
		createDroppableArea(folderContainer);

		var uniqueId = 0;
		button.addEventListener('click', function() {
			var title = document.getElementById('folderName').value;
			if (title) {
				var newFolderHolder = document.getElementById('newFolderHolder');
				var folder = document.createElement('div');
				folder.innerHTML = title;
				folder.className = 'trailingFolder';
				folder.id = "item-" + uniqueId;
				uniqueId++;
				createDraggable(folder);
				newFolderHolder.appendChild(folder);
			}
		}, false);

	});

	function handleDragStart(ev) {
		ev.dataTransfer.setData("dragged-id", ev.target.id);
	}

	function handleDrop(ev) {
		ev.stopPropagation();

		if (ev.preventDefault) {
			ev.preventDefault();
		}

		var dragged = ev.dataTransfer.getData("dragged-id");
		var element = document.getElementById(dragged);
		var newFolderHolder = document.getElementById('newFolderHolder');
		newFolderHolder.removeChild(element);

		var li = document.createElement('li');
		var ul = document.createElement('ul');
		if (this instanceof HTMLUListElement) {
			li.innerHTML = element.innerHTML;
			createDroppableArea(li);
			this.appendChild(li);
			li.style.backgroundColor = "white";
			this.style.backgroundColor = "white";
			
		} else {
			if (this instanceof HTMLLIElement) {
				li.innerHTML = element.innerHTML;
				createDroppableArea(li);
				ul.appendChild(li);
				this.appendChild(ul);
				li.style.backgroundColor = "white";
				this.style.backgroundColor = "white";
			}
		}

	}

	function handleDragOver(ev) {
		if (ev.preventDefault) {
			ev.preventDefault(); // Necessary. Allows us to drop.
		}
		ev.target.style.backgroundColor = "gray";
	}

	function handleDragLeave(ev) {
		ev.target.style.backgroundColor = "white";
	}

	function createDraggable(element) {
		element.setAttribute('draggable', 'true');
		element.addEventListener('dragstart', handleDragStart, false);
	}

	function createDroppableArea(element) {
		element.setAttribute('draggable', 'false');
		element.addEventListener('dragover', handleDragOver, false);
		element.addEventListener('drop', handleDrop, false);
		element.addEventListener('dragleave', handleDragLeave, false);
	}
})();