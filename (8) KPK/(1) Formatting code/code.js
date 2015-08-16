
(function () {
	var pageWidth = 0,
		pageHeight = 0,
		browserName = navigator.appName,
		addScroll = false;

	function mouseMove(evn) {
		if (browserName == "Netscape") {
			pageWidth = evn.pageX - 5;
			pageHeight = evn.pageY;
		} else {
			pageWidth = event.x - 5;
			pageHeight = event.y;
		}

		if (browserName == "Netscape") {
			if (document.layers['ToolTip'].visibility == 'show') {
				PopTip();
			}
		} else {
			if (document.all['ToolTip'].style.visibility == 'visible') {
				PopTip();
			}
		}
	}

	function PopTip() {
		var theLayer;
		if (browserName == "Netscape") {
			theLayer = eval('document.layers[\'ToolTip\']');
			if ((pageWidth + 120) > window.innerWidth) {
				pageWidth = window.innerWidth - 150;
			}

			theLayer.left = pageWidth + 10;
			theLayer.top = pageHeight + 15;
			theLayer.visibility = 'show';	
		} else {
			theLayer = eval('document.all[\'ToolTip\']');
			if (theLayer) {
				pageWidth = event.x - 5;
				pageHeight = event.y;
				if (addScroll) {
					pageWidth = pageWidth + document.body.scrollLeft;
					pageHeight = pageHeight + document.body.scrollTop;
				}

				if ((pageWidth + 120) > document.body.clientWidth) {
					pageWidth = pageWidth - 150;
				}
				theLayer.style.pixelLeft = pageWidth + 10;
				theLayer.style.pixelTop = pageHeight + 15;
				theLayer.style.visibility = 'visible';
			}
		}
	}

	function HideTip() {
		var args = HideTip.arguments;
		if (browserName == "Netscape") {
			document.layers['ToolTip'].visibility = 'hide';
		} else {
			document.all['ToolTip'].style.visibility = 'hidden';
		}
	}

	function HideMenu1() {
		if (browserName == "Netscape") {
			document.layers['menu1'].visibility = 'hide';
		} else {
			document.all['menu1'].style.visibility = 'hidden';
		}
	}

	function ShowMenu1() {
		var theLayer;
		if (browserName == "Netscape") {
			theLayer = eval('document.layers[\'menu1\']');
			theLayer.visibility = 'show';
		} else {
			theLayer = eval('document.all[\'menu1\']');
			theLayer.style.visibility = 'visible';
		}
	}

	function HideMenu2() {
		if (browserName == "Netscape") {
			document.layers['menu2'].visibility = 'hide';
		} else {
			document.all['menu2'].style.visibility = 'hidden';
		}
	}

	function ShowMenu2() {
		var theLayer;
		if (browserName == "Netscape") {
			theLayer = eval('document.layers[\'menu2\']');
			theLayer.visibility = 'show';
		} else {
			theLayer = eval('document.all[\'menu2\']');
			theLayer.style.visibility = 'visible';
		}
	}

	document.onmousemove = mouseMove;

	if (browserName == "Netscape") {
		document.captureEvents(Event.MOUSEMOVE);
	}

	if ((navigator.userAgent.indexOf('MSIE 5') > 0) || (navigator.userAgent.indexOf('MSIE 6')) > 0) {
		addScroll = true;
	}
}());
