function solve(){
  	return function(selector){
	    var i,
			len,
			currentOption,
			currentItemToAdd;

	    var $selectedList = $(selector)
	            .hide();

	    var options = $selectedList.find('option');

    	var result = $('<div />')
    		.addClass('dropdown-list');

    	var $currentDiv = $('<div />')
    		.addClass('current')
    		.attr('data-value', '')
    		.text('Select value');

    	var $optionsContainer = $('<div />')
    		.addClass('options-container')
    		.css({
    			'position': 'absolute',
    			'display': 'none'
    		});

    	for (i = 0, len = options.length; i < len; i += 1) {
    		currentOption = $(options[i]);
    		currentItemToAdd = $('<div />')
    			.addClass('dropdown-item')
    			.attr('data-value', currentOption.val())
    			.attr('data-index', i)
    			.text(currentOption.text());

    		$optionsContainer.append(currentItemToAdd);
    	}

    	$currentDiv.on('click', function () {
            var $container = $('.options-container');
            $container.css('display', 'inline-block');
        });

        $optionsContainer.on('click', function (ev) {
            var $clicked = $(ev.target);
            var $divToDisplay = $('.current');
            $divToDisplay.text($clicked.html());
            $selectedList.val($clicked.attr('data-value'));

            var $container = $(this)
                .css('display', 'none');
        });

    	result
    		.append($selectedList)
    		.append($currentDiv)
    		.append($optionsContainer)
    		.appendTo('body');

    };
}

module.exports = solve;