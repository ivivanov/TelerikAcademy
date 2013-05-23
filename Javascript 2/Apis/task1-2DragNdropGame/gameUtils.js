function displayHighscores() {
	var scoretable = document.getElementById('scoretable');
	if (scoretable.style.display == 'block') {
		scoretable.style.display = 'none';
	} else {
		scoretable.style.display = 'block';
	}
	loadPairs();
}

function closeNewScore() {
	newScore.style.display = 'none';
}

function updateGameState() {
	var garbageCount = (document.querySelectorAll('#garbageArea div')).length;
	var collected = document.getElementById('collected');
	collected.innerHTML = 'left:' + garbageCount;
	if (garbageCount == 0) {
		timerStop();
		var time = document.getElementById('time');
		time.innerHTML = document.timeform.timetextarea.value;
		document.getElementById('newScore').style.display = 'block';
	}

}

function startGame() {
	var level = parseInt(document.getElementById('level').value);
	gameModule.clearDivs('garbageArea');
	gameModule.createDivs('#garbageArea', level);
	gameModule.setClass('#garbageArea div:nth-child(2n)', 'beer1');
	gameModule.setClass('#garbageArea div:nth-child(2n+1)', 'beer2');
	gameModule.setClass('#garbageArea div:nth-child(3n)', 'beer3');
	gameModule.createDraggable('#garbageArea div');
	gameModule.createDroppableArea('#trashcan');
	updateGameState();
	timerReset();
	timerStart();
}