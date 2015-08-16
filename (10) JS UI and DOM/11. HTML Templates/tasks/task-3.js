function solve(){
  return function(){
    $.fn.listview = function(data){
      var i,
      	len,
      	currentTemplateId,
      	template,
      	compiledTemplate,
      	$this;

      $this = $(this);

      currentTemplateId = $this.attr('data-template');
      template = $('#' + currentTemplateId).html();
      compiledTemplate = handlebars.compile(template);

      for (i = 0, len = data.length; i < len; i += 1) {
      	$this.append(compiledTemplate(data[i]));
      }
    
    	return this;
    };

  };
}

module.exports = solve;