var timercount = 0;
var timestart = null;

function showTimer() {
    if (timercount) {
        clearTimeout(timercount);
        clockID = 0;
    }
    if (!timestart) {
        timestart = new Date();
    }
    var timeend = new Date();
    var timedifference = timeend.getTime() - timestart.getTime();
    timeend.setTime(timedifference);
    var minutes_passed = timeend.getMinutes();
    if (minutes_passed < 10) {
        minutes_passed = "0" + minutes_passed;
    }
    var seconds_passed = timeend.getSeconds();
    if (seconds_passed < 10) {
        seconds_passed = "0" + seconds_passed;
    }
    // document.getElementsByName('timetextarea').value = minutes_passed + ":" + seconds_passed;
    document.timeform.timetextarea.value = minutes_passed + ":" + seconds_passed;
    timercount = setTimeout("showTimer()", 1000);
}

function timerStart() {
    if (!timercount) {
        timestart = new Date();
        document.getElementsByName('timetextarea').value = "00:00";
        // document.timeform.timetextarea.value = "00:00";
        timercount = setTimeout("showTimer()", 1000);
    } else {
        var timeend = new Date();
        var timedifference = timeend.getTime() - timestart.getTime();
        timeend.setTime(timedifference);
        var minutes_passed = timeend.getMinutes();
        if (minutes_passed < 10) {
            minutes_passed = "0" + minutes_passed;
        }
        var seconds_passed = timeend.getSeconds();
        if (seconds_passed < 10) {
            seconds_passed = "0" + seconds_passed;
        }
        var milliseconds_passed = timeend.getMilliseconds();
        if (milliseconds_passed < 10) {
            milliseconds_passed = "00" + milliseconds_passed;
        } else if (milliseconds_passed < 100) {
            milliseconds_passed = "0" + milliseconds_passed;
        }
    }
}

function timerStop() {
    if (timercount) {
        clearTimeout(timercount);
        timercount = 0;
        var timeend = new Date();
        var timedifference = timeend.getTime() - timestart.getTime();
        timeend.setTime(timedifference);
        var minutes_passed = timeend.getMinutes();
        if (minutes_passed < 10) {
            minutes_passed = "0" + minutes_passed;
        }
        var seconds_passed = timeend.getSeconds();
        if (seconds_passed < 10) {
            seconds_passed = "0" + seconds_passed;
        }
        var milliseconds_passed = timeend.getMilliseconds();
        if (milliseconds_passed < 10) {
            milliseconds_passed = "00" + milliseconds_passed;
        } else if (milliseconds_passed < 100) {
            milliseconds_passed = "0" + milliseconds_passed;
        }
        // document.getElementsByName('timetextarea').value = minutes_passed + ":" + seconds_passed + "." + milliseconds_passed;
        document.timeform.timetextarea.value = minutes_passed + ":" + seconds_passed + "." + milliseconds_passed;
    }
    timestart = null;
}

function timerReset() {
    timestart = null;
    // document.getElementsByName('timetextarea').value = "00:00";
    document.timeform.timetextarea.value = "00:00";
}