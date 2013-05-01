var specialConsole = (function() {
	'use strict';

	function writeLine(msg) {
		if (arguments.length > 1) {
			console.log(stringFormat.apply(null, arguments));
		} else {
			console.log(msg);
		}
	}

	function writeError(msg) {
		if (arguments.length > 1) {
			console.error(stringFormat.apply(null, arguments));
		} else {
			console.error(msg);
		}
	}

	function writeWarning(msg) {
		if (arguments.length > 1) {
			console.warn(stringFormat.apply(null, arguments));
		} else {
			console.warn(msg);
		}
	}
	//Example: console.log(stringFormat.call("{0} {1} {2}", "ggg", "dddd", "rrr"));
	//Returns "ggg dddd rrr"

	function stringFormat(msg) {
		var formatedString = arguments[0];
		var selfArgs = arguments;

		function replacer(match, position) {
			var placeholderNum = parseInt(formatedString[position + 1]) + 1;
			return selfArgs[placeholderNum];
		}

		var newString = formatedString.replace(/\{\d+?\}/g, replacer);
		return newString;
	}


	return {
		writeLine: writeLine,
		writeError: writeError,
		writeWarning: writeWarning
	}
})();