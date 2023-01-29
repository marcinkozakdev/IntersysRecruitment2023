function fixage(numbers){

    const array = numbers.filter(number => (number >= 18 && number <= 60 ));
    
    if (array.length > 1){
        console.log("Result = " + array);
    }
    
    else{
        console.log("NAN");
    }
}


