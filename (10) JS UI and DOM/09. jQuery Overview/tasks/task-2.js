/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"       
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string` 

*/
function solve() {
  return function (selector) {
    var buttons,
      contents,
      containerElement;

    

    containerElement = $(selector);
    if (typeof(selector) !== 'string' || $(selector).size() === 0) {
      throw new Error();
    }

    buttons = containerElement.find('.button').html('hide');
    contents = containerElement.find('.content');

    $(containerElement).click('.button', function(ev) {
      var clickedButton = $(ev.target);
      var nextElement = clickedButton.next();


      // console.log(clickedButton);
      // console.log(nextElement);
      while(!nextElement.hasClass('.button, .content') && nextElement.size() > 0) {
        nextElement = nextElement.next();
      }
      if (nextElement.hasClass('.button')) {
        return;
      } else {
        if (nextElement.css('display') === 'none') {
          nextElement.css('display', '');
          clickedButton.html('hide');
        } else {
          nextElement.css('display', 'none');
          clickedButton.html('show');
        }

        return;
      }
    });

  };
}

module.exports = solve;