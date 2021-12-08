window.setup = (id, config) => {
    console.log('Graph setup ' + id + ' - Config -> ' + JSON.stringify(config));

    document.getElementById("chartcontainer" + id).style.display = 'none';
    document.getElementById("chartcontainer" + id).innerHTML = '&nbsp;';
    document.getElementById("chartcontainer" + id).innerHTML = '<canvas id="' + id + '"></canvas>';
    document.getElementById("chartcontainer" + id).style.display = '';

    var ctx = document.getElementById(id).getContext('2d');
    new Chart(ctx, eval(config));
}