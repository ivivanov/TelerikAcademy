function loadPairs() {
    if (!localStorage.length || localStorage.length === 0) {
        document.getElementById("topPlayers").innerHTML = "Sorry, there are no high scores :(";
        return;
    }

    var sortedTimes = {};
    for (var i = 0; i < localStorage.length; i++) {
        var time = localStorage.key(i).split(':');
        sortedTimes[localStorage.key(i)] = parseFloat(time[1]);
    }

    var tuples = [];
    for (var key in sortedTimes) {
        tuples.push([key, sortedTimes[key]]);
    }
    tuples.sort(function(a, b) {
        a = a[1];
        b = b[1];

        return a < b ? -1 : (a > b ? 1 : 0);
    });

    var resultHTML = "<table>";
    for (i = 0; i < 5 && i < tuples.length; i++) {
        var key = tuples[i][0]; // full time also and key for localStorage
        var value = tuples[i][1]; // short time parsed to float
        var keyStorage = localStorage[key]; // name of the player
        resultHTML += '<tr>' + '<td>' + (i+1) + '</td>' + '<td>' + keyStorage + '</td>' + '<td>' + key + '</td>' + '<tr>';
    }
    resultHTML += "</table>";
    document.getElementById("topPlayers").innerHTML = resultHTML;
}

function onSaveButtonClick() {
    var value = document.getElementById('username').value;
    var key = document.timeform.timetextarea.value;
    localStorage.setItem(key, value);
    loadPairs();
    document.getElementById('newScore').style.display = 'none';
}

function onLoadButtonClick() {
    var key = document.getElementById("tb-key").value;
    document.getElementById("value-text").value = localStorage.getItem(key);
}

function onRemoveButtonClick() {
    var key = document.getElementById("tb-key").value;
    localStorage.removeItem(key);
    loadPairs();
}

function onClearStorageButtonClick() {
    localStorage.clear();
    loadPairs();
}