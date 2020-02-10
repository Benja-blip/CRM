var Table = document.getElementById("tbl");
var Row = document.getElementsByTagName("tr");
var rowDisplay = document.getElementsByTagName("td");

function fillBar() {

    //console.log(taskName);

const interval = setInterval(() => {

    var i;
    //var bar = document.querySelectorAll('.bar'), i;

    for (i = 1; i < Table.rows.length; i += 1) {
        var taskName = Table.rows[i].cells[0].innerText;
        var rawDeadline = Table.rows[i].cells[1].innerText;
        var rawStartTime = Table.rows[i].cells[2].innerText;
        var bar = Table.rows[i].cells[6].getElementsByClassName("bar").item(0);
        console.log(bar)
        //var bar = document.querySelectorAll('.bar');
        var now = new Date();
        var startTime = new Date(rawStartTime.replace(/(am|pm)/, ''));
        //console.log('Start time is', startTime);
        var deadline = new Date(rawDeadline.replace(/(am|pm)/, ''));
        var timeTotal = Math.abs(deadline - startTime);
        var timeTotalPercent = Math.abs(timeTotal / 60000);
        console.log('value for total time in minutes of', taskName, 'is', timeTotalPercent);
        var nowTillDeadline = Math.abs(deadline - now);
        var nowTillDeadlinePercent = Math.abs(nowTillDeadline / 60000);
        var timeElapsed = Math.abs(timeTotalPercent - nowTillDeadlinePercent);
        var timeElapsedPercent = Math.abs((timeElapsed / timeTotalPercent) * 100);
            
        bar.style.width = timeElapsedPercent + '%';
        
        if (timeElapsedPercent >= 99) {
            bar.style.width = '100%';
            clearInterval(interval);
        }
    }
}, (1*1000))
}

fillBar()