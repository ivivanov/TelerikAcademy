function handleDragOver(ev) {
	if (ev.preventDefault) {
		ev.preventDefault(); // Necessary. Allows us to drop.
	}
	// e.dataTransfer.dropEffect = 'move'; // See the section on the DataTransfer object.

	// return false;
}

function handleDragStart(ev) {
	var dragIcon = document.createElement('img');
	dragIcon.src = 'imgs/recycle.png';
	ev.dataTransfer.setDragImage(dragIcon, 20, 20);

	ev.dataTransfer.setData("dragged-id", ev.target.id);
}

function handleDrop(ev) {
	//You'll need to prevent the browser's default behavior for drops,
	//which is typically some sort of annoying redirect. You can prevent the event from bubbling 
	//up the DOM by calling e.stopPropagation().
	ev.stopPropagation();

	if (ev.preventDefault) {
		ev.preventDefault(); // Necessary. Allows us to drop.
	}
	var data = ev.dataTransfer.getData("dragged-id");
	var element = document.getElementById(data);
	var parent = document.getElementById('garbageArea');
	parent.removeChild(element);
	this.setAttribute('src', 'imgs/trash_close.png');
	updateGameState();
	// return false;
}

function handleDragEnter(e) {
	this.setAttribute('src', 'imgs/trash_open.png');
}

function handleDragLeave(e) {
	this.setAttribute('src', 'imgs/trash_close.png');
}