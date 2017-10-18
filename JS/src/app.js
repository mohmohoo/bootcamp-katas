function helloWorld() {
  return "hello world";
}

module.exports = {
  helloWorld: helloWorld,
  printNumbers: printNumbers
};


function printNumbers() {
  let numbers = [];

  for(let i = 1; i <= 100; i++){
    if (i % 3 === 0) {
      numbers.push("fizz");
    } 
    else if (i % 5 === 0) {
      numbers.push("buzz");
    }
    else {
      numbers.push(i);
    }
  }

  return numbers;
}