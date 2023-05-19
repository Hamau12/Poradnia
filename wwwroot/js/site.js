// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
window.addEventListener('scroll', handleScroll);
function handleScroll() {
    var currentScroll = getCurrentScroll();

    //Handles vertical scroll
    var diffY = window.scrollData.top != currentScroll.top;
    window.scrollData.top = currentScroll.top;
    if (diffY) {
        document.getElementById('scheduleUsers').scrollTop = window.scrollData.top;
        document.getElementById('scheduleMatrix').scrollTop = window.scrollData.top;
    }

    //Handles horizontal scroll
    var diffX = window.scrollData.left != currentScroll.left;
    window.scrollData.left = currentScroll.left;
    if (diffX) {
        document.getElementById('calendarRow').scrollLeft = window.scrollData.left;
        document.getElementById('scheduleMatrix').scrollLeft = window.scrollData.left;
    }
}
function getCurrentScroll() {
    return { top: window.scrollY, left: window.scrollX };
    //return { top: document.documentElement.scrollTop, left: document.documentElement.scrollLeft };
}
function updateScrollAnchor() {
    document.getElementById('gridOverlay').style.height = document.getElementById('scheduleUsers').scrollHeight + 'px';
    document.getElementById('gridOverlay').style.width = document.getElementById('scheduleUsers').scrollWidth + 'px';
    document.getElementById('scrollAnchor').style.top = document.getElementById('scheduleUsers').scrollHeight - document.getElementById('scheduleUsers').clientHeight + window.innerHeight + 'px';
    document.getElementById('scrollAnchor').style.left = document.getElementById('calendarRow').scrollWidth - document.getElementById('calendarRow').clientWidth + window.innerWidth + 'px';
}

function getOffset(element, recursion) {
    recursion = recursion || 1;
    var offset = { top: 0, left: 0, parent: element.offsetParent };
    for (i = 0; i < recursion; i++) {
        offset.top += element.offsetTop;
        offset.left += element.offsetLeft;
        offset.parent = element.offsetParent;
        element = element.offsetParent;
    }
    return offset;
}

function closeScheduleInfoBox() {
    console.log('close', window.currentFloatBox);
    if (window.currentFloatBox) {
        window.currentFloatBox.style.opacity = 0;
        setTimeout((box) => {
            box.parentElement.removeChild(box);
        }, 300, window.currentFloatBox);
        window.currentFloatBox = null;
    }
}
function showScheduleInfoBox(holder) {
    if (window.currentFloatBoxHolder == holder)
        return;

    if (window.currentFloatBox) {
        window.currentFloatBox.style.opacity = 0;
        setTimeout((box) => {
            box.parentElement.removeChild(box);
        }, 300, window.currentFloatBox);
        window.currentFloatBox = null;
    }

    window.currentFloatBoxHolder = holder;

    var floatElement = document.createElement('div');
    floatElement.className = 'schedule-info-box';
    var offset = getOffset(holder, 4);
    floatElement.style.top = offset.top + 'px';
    floatElement.style.left = offset.left + 'px';
    floatElement.style.opacity = 0.0;
    floatElement.innerHTML = '<span class="float-box-close-button" onclick="closeScheduleInfoBox()"><i class="fa fa-times" style="cursor: pointer;"></i></span><div class="inner-float">' + document.getElementById('scheduleItemBox').innerHTML + '</div>';
    offset.parent.appendChild(floatElement);
    window.currentFloatBox = floatElement;

    setTimeout((floatElement) => {
        floatElement.style.opacity = 1.0;
    }, 300, floatElement);

}
function showActionBox(actionBoxId) {
    var actionBoxes = Array.from(window.currentFloatBox.querySelectorAll('.action-box'));
    console.log('showActionBox', actionBoxId, window.currentFloatBox);
    actionBoxes.forEach(x => {
        console.log(x, x.getAttribute('data-id'));
        if (x.getAttribute('data-id') == actionBoxId) {
            console.log('opa');
            x.style.display = 'block';
            window.currentFloatBox.style.height = window.actionBoxHeight + x.scrollHeight + 10 + 'px';
            x.style.maxHeight = '100%';
        }
        else {
            x.style.display = 'none';
            x.style.maxHeight = '1px';
        }
    });
}
function closeActionBox() {
    showActionBox('');
    window.currentFloatBox.style.height = '';
}
window.actionBoxHeight = 100;
window.scrollData = getCurrentScroll();
setTimeout(updateScrollAnchor, 500);