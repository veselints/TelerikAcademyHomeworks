/* globals $ */

/* 

Create a function that takes an id or DOM element and:
  

*/

function solve(){
	return function (selector) {
		var elementToOperate,
			selectedByIdElement = document.getElementById(selector),
			buttonElements,
			contentElements,
			i,
			len;

		if (selectedByIdElement) {
			elementToOperate = selectedByIdElement;
		} else if (!document.body.contains(selector)) {
			elementToOperate = selector;
		} else {
			throw new Error();
		}

		buttonElements = elementToOperate.getElementsByClassName('button');
		contentElements = elementToOperate.getElementsByClassName('content');

		for (i = 0, len = buttonElements.length; i < len; i++) {
			buttonElements[i].innerHTML = 'hide';
		}

		elementToOperate.addEventListener('click', function(ev) {
			var targetButton = ev.target,
				nextElement;

			if (targetButton.className !== 'button') {
				return;
			}

			nextElement = targetButton.nextElementSibling;
			while (nextElement.className !== 'button') {
				if (nextElement.className === 'content') {
					if (nextElement.style.display !== 'none') {
						nextElement.style.display = 'none';
						targetButton.innerHTML = 'show';
					} else {
						nextElement.style.display = '';
						targetButton.innerHTML = 'hide';
					}
					return;
				}
				nextElement = nextElement.nextElementSibling;
			}

			return;
		}, false);
	};
}

module.exports = solve;