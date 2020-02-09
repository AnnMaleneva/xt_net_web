function moveOne(from, to) {
    var optionsFrom = from.options;
    var selected = false;          

    for (var i=0; i<optionsFrom.length; i++) {
        if (optionsFrom[i].selected) {
            optionsFrom[i].selected = false;
            to.add(optionsFrom[i]);
            i--;
            selected = true;
        }
    }
    if (!selected) {
        alert("Please select an item to move!");
    }
}

function moveAll(from, to) {
    var optionsFrom = from.options;
    if (optionsFrom.length == 0) {
        alert("The list is empty. Moving is not possible.");
    }        
    for (var i=0; i<optionsFrom.length; i++) {
        optionsFrom[i].selected = false;
        to.add(optionsFrom[i]);
        i--;
    }    

}