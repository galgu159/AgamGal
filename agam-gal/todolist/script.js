document.querySelector('#myInput').addEventListener('keypress', function (e) {
    if (e.key === 'Enter') {
        newElement();
    }
});

// כפתור סגור
var myNodelist = document.getElementsByTagName("LI");
var i;
for (i = 0; i < myNodelist.length; i++) {
    var span = document.createElement("SPAN");
    var txt = document.createTextNode("\u00D7");
    span.className = "close";
    span.appendChild(txt);
    myNodelist[i].appendChild(span);
}

// הסתרת הרשימה
var close = document.getElementsByClassName("close");
var i;
for (i = 0; i < close.length; i++) {
    close[i].onclick = function () {
        var div = this.parentElement;
        div.style.display = "none";
    }
}

// Add a "checked" symbol when clicking on a list item
var list = document.querySelector('ul');
list.addEventListener('click', function (ev) {
    if (ev.target.tagName === 'LI') {
        ev.target.classList.toggle('checked');
        var target = newElement(ev.target.firstChild.textContent);
        if (ev.target.className === 'checked') {
            target.classList.toggle('checked');
            ev.target.parentElement.appendChild(target);
        } else {
            ev.target.parentElement.insertBefore(target, ev.target.parentElement.firstChild);
        }

        ev.target.remove()
    }
}, false);

// יצירת הרשימה שנוסף עוד ועוד משימות
function newElement(input) {
    var li = document.createElement("li");

    if (input === undefined) {
        var inputValue = document.getElementById("myInput").value;
    }
    else {
        var inputValue = input;
    }

    var sp = document.createElement("SPAN");
    var tx = document.createTextNode(inputValue);
    sp.appendChild(tx);
    sp.addEventListener('dblclick', (event) => {
        var inp = document.createElement('input');
        inp.value = sp.firstChild.data;
        sp.style.visibility = "hidden";
        inp.addEventListener('keyup', function (e) {
            if (e.key === "Escape") {
                inp.previousSibling.firstChild.data = inp.value;
                inp.previousSibling.style.visibility = "visible";
                inp.remove();
            }
        });
        sp.parentNode.insertBefore(inp, sp.nextSibling);
    });

    //var t = document.createTextNode(inputValue);
    li.appendChild(sp);
    if (inputValue === '') {
        alert("You must write something!");
    } else {
        document.getElementById("myUL").appendChild(li);
    }
    document.getElementById("myInput").value = "";

    var span = document.createElement("SPAN");
    var txt = document.createTextNode("\u00D7");
    span.className = "close";
    span.appendChild(txt);
    li.appendChild(span);

    for (i = 0; i < close.length; i++) {
        close[i].onclick = function () {
            var div = this.parentElement;
            div.style.display = "none";
        }
    }

    return li;
}
