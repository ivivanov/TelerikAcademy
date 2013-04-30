function generateTagCloud(tags, minSize, maxSize) {
	//statistic keep information for all occurrences of the words
	var statistic = {};

	// checks if a tag is already added and increments its count, if not add it to statistic

	function addTag(tag) {
		if (statistic[tags[i]]) {
			statistic[tags[i]]++;
		} else {
			statistic[tags[i]] = 1;
		}
	}

	//fill statistics
	for (var i = 0; i < tags.length; i++) {
		addTag(tags[i]);
	}

	//find min and max occurrences
	var minCount = 10000000;
	var maxCount = -10000000;
	for (i in statistic) {
		if (minCount > statistic[i]) {
			minCount = statistic[i];
		}
		if (maxCount < statistic[i]) {
			maxCount = statistic[i];
		}
	}

	// calculate the increment step
	var fontSizesRange = maxSize - minSize;
	var occurrencesRange = maxCount - minCount;
	var fontSizeIncrement = parseInt(fontSizesRange / occurrencesRange);

	//create the tag cloud
	var cloud = document.createElement('div');
	for (i in statistic) {
		var span = document.createElement('span');
		if (statistic[i] == maxCount) {
			span.style.fontSize = maxSize;
		} else {
			if (statistic[i] == minCount) {
				span.style.fontSize = minSize;
			} else {
				span.style.fontSize = minSize + (statistic[i] - minCount) * fontSizeIncrement;
			}
		}
		span.innerHTML = i;
		cloud.appendChild(span);
	}

	return cloud;
};

function clearAll() {
	var items = document.querySelectorAll("span");
	for (var i = 0; i < items.length; i++) {
		var parent = items[i].parentNode;
		parent.removeChild(items[i]);
	}
}

function generateFromInput() {
	clearAll();
	var minFontSize = parseInt(document.getElementById('minFont').value);
	var maxFontSize = parseInt(document.getElementById('maxFont').value);
	var allWords = document.getElementById('sampleTags').value.split(', ');
	var tagCloud = generateTagCloud(allWords, minFontSize, maxFontSize);
	document.getElementById('cloud').appendChild(tagCloud);

	var x = 1;
}