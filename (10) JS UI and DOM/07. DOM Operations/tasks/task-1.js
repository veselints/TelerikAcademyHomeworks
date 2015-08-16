/* globals $ */

/* 

Create a function that takes an id or DOM element and an array of contents

* if an id is provided, select the element
* Add divs to the element
  * Each div's content must be one of the items from the contents array
* The function must remove all previous content from the DOM element provided
* Throws if:
  * The provided first parameter is neither string or existing DOM element
  * The provided id does not select anything (there is no element that has such an id)
  * Any of the function params is missing
  * Any of the function params is not as described
  * Any of the contents is neight `string` or `number`
    * In that case, the content of the element **must not be** changed   
*/

module.exports = function () {
	return function (element, contents) {
	  	var elementById = document.getElementById(element),
	  		docFragment = document.createDocumentFragment(),
	  		createdDiv = document.createElement('div'),
	  		i,
	  		len,
	  		currentElementToAdd;

	  	if (!element || !contents) {
	  		throw new Error();
	  	}

	  	if (elementById) {
	  		element = elementById;
	  	} else if (!document.body.contains(element)) {
	  		throw new Error();
	  	}

	  	for (i = 0, len = contents.length; i < len; i++) {
	  		if (typeof contents[i] !== 'string' && typeof contents[i] !== 'number') {
	  			throw new Error();
	  		}
	  		currentElementToAdd = createdDiv.cloneNode(true);
	  		currentElementToAdd.innerHTML = contents[i].toString();
	  		docFragment.appendChild(currentElementToAdd);
	  	}

	  	element.innerHTML = '';
	  	element.appendChild(docFragment);
	};
};