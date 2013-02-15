function insertAfter(newChild, refChild) {
    refChild.parentNode.insertBefore(newChild, refChild.nextSibling);
}

function splitList(list1) {
    var list1Arr = list1.innerHTML.split("<li>");
    if (list1Arr[0]) {
        var list1Arr = list1.innerHTML.split("<LI>");
    }
    var totalCount = list1Arr.length;
    var firstColumnCount = Math.ceil(totalCount / 2);

    var list2 = document.createElement('ul');
    insertAfter(list2, list1);

    list1.className = "list-split";
    list2.className = "list-split second";

    function populateLists(list1, list2, list1Arr, firstColumnCount, totalCount) {
        list1.innerHTML = list2.innerHTML = "";
        for (var i = 1; i < totalCount; i++) {
            if (i < firstColumnCount) {
                list1.innerHTML += "<li>" + list1Arr[i];
            } else {
                list2.innerHTML += "<li>" + list1Arr[i];
            }
        }
    }

    populateLists(list1, list2, list1Arr, firstColumnCount, totalCount);

    while (list2.offsetHeight > list1.offsetHeight) {
        firstColumnCount++;
        populateLists(list1, list2, list1Arr, firstColumnCount, totalCount);
    }
}

//cookie functions
function createCookie(name, value, days) {
    var expires = '';
    if (days) {
        var date = new Date();
        date.setTime(date.getTime() + (days * 24 * 60 * 60 * 1000));
        var expires = '; expires=' + date.toGMTString();
    }
    document.cookie = name + '=' + value + expires + '; path=/';
}

function readCookie(name) {
    var cookieCrumbs = document.cookie.split(';');
    var nameToFind = name + '=';
    for (var i = 0; i < cookieCrumbs.length; i++) {
        var crumb = cookieCrumbs[i];
        while (crumb.charAt(0) == ' ') {
            crumb = crumb.substring(1, crumb.length); /* delete spaces */
        }
        if (crumb.indexOf(nameToFind) == 0) {
            return crumb.substring(nameToFind.length, crumb.length);
        }
    }
    return null;
}

function eraseCookie(name) {
    createCookie(name, '', -1);
}

//set globalization preference
function setGeoPref(value) {
    if (document.getElementById("chk_rememberGeo").checked) {
        createCookie("geopreference", value, 30);
    } else {
        eraseCookie("geopreference");
    }
}

function onInputClick(inputElement) {
    inputElement.oldValue = inputElement.value;
    inputElement.value = '';
}
function onInputBlur(inputElement) {
    if (inputElement.value == '') {
        inputElement.value = inputElement.oldValue;
    }
}

// Tabbed navigation on product detail pages
function showTab(id) {
    for (i = 0; i < 15; i++) {
        $("#tab-" + i).removeClass("visible");
        $("#tab-button-" + i).parent().removeClass("selected");
    }
    $("#tab-" + id).addClass("visible");
    $("#tab-button-" + id).parent().addClass("selected");
}

// set tab content area high as the highest tab content, so the page length does not change when navigating through tabs
function setTabsHeight() {
    var currentTab;
    var currentTallestHeight = 0;
    var currentContentHeight = 0;
    for (i = 1; i < 15; i++) {
        currentTab = document.getElementById("tab-" + i);
        if (currentTab) {
            currentContentHeight = currentTab.offsetHeight;
            if (currentContentHeight > currentTallestHeight) {
                currentTallestHeight = currentContentHeight;
            }
        }
    }
    document.getElementById("content-tabs").style.height = currentTallestHeight + "px";
}

function hideUnusedTabs() {
    var currentTab;
    for (i = 1; i < 15; i++) {
        currentTab = document.getElementById("tab-" + i);
        if (currentTab) {
            if (!currentTab.innerHTML) {
                $("#tab-button-" + i).parent().remove();
            }
        }
    }
}

// window size and scrolling functions
function f_clientWidth() {
    return f_filterResults(
		window.innerWidth ? window.innerWidth : 0,
		document.documentElement ? document.documentElement.clientWidth : 0,
		document.body ? document.body.clientWidth : 0
	);
}
function f_clientHeight() {
    return f_filterResults(
		window.innerHeight ? window.innerHeight : 0,
		document.documentElement ? document.documentElement.clientHeight : 0,
		document.body ? document.body.clientHeight : 0
	);
}
function f_scrollLeft() {
    return f_filterResults(
		window.pageXOffset ? window.pageXOffset : 0,
		document.documentElement ? document.documentElement.scrollLeft : 0,
		document.body ? document.body.scrollLeft : 0
	);
}
function f_scrollTop() {
    return f_filterResults(
		window.pageYOffset ? window.pageYOffset : 0,
		document.documentElement ? document.documentElement.scrollTop : 0,
		document.body ? document.body.scrollTop : 0
	);
}
function f_filterResults(n_win, n_docel, n_body) {
    var n_result = n_win ? n_win : 0;
    if (n_docel && (!n_result || (n_result > n_docel)))
        n_result = n_docel;
    return n_body && (!n_result || (n_result > n_body)) ? n_body : n_result;
}

//center modal by its id
function centerModal(id) {
    var obj = document.getElementById(id);
    obj.style.left = (f_clientWidth() - obj.offsetWidth) / 2 + "px";
}
function closeModal(id) {
    document.getElementById("modal-background").style.display = "none";
    document.getElementById(id).style.display = "none";
}


$(document).ready(function () {

    $('a').filter(function () {
        return this.hostname && this.hostname !== location.hostname;
    })

    jQuery("a.leaving").click(function () {
        var x = window.confirm('You are now leaving coleman.com. Click OK to proceed, or CANCEL to remain on coleman.com');
        var val = false;
        if (x)
            val = true;
        else
            val = false;
        return val;
    });
});

