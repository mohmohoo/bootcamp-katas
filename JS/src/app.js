function helloWorld() {
  return "hello world";
}

module.exports = {
  helloWorld: helloWorld,
  printNumbers: printNumbers
};


function printNumbers() {
  let numbers = [];

  for(let i = 1; i<=100; i++){
    if (i % 3 == 0) {
      numbers.push("fizz");
    } else {
      numbers.push(i);
    }
  }

  return numbers;
}