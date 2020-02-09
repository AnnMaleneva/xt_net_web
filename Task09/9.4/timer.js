var sec=07;
// выставляем минуты
var min=00;

function refresh()
{
	sec--;
 	if(sec==-01){
        sec=59; min=min-1;
    }
	else{
        min=min;
    }
	if(sec<=9){
        sec="0" + sec;
    }
    time=(min<=9 ? "0"+min : min) + ":" + sec;
    
	if(document.getElementById){
        timer.innerHTML=time;
    }

	inter=setTimeout("refresh()", 1000);
	
	if(min=='00' && sec=='00'){
		sec="00";
		clearInterval(inter);
	
     window.location='page2.html';
                
    }        
   

}