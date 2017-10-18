const app = require("../src/app");

test("it should print hello world", () => {
  expect(app.helloWorld()).toBe("hello world");
});

test("It should print 1 as first number", () => {
  expect(app.printNumbers()[0]).toBe(1);
});

test("The length of the returned array should be 100", () => {
  expect(app.printNumbers().length).toBe(100);
});

test("It should print buzz instead of last number", () => {
  expect(app.printNumbers().pop()).toBe("buzz");
});

test("It should print fizz for the first 3rd number", () => {
  let allNumbers = app.printNumbers();
  expect(allNumbers[2]).toBe("fizz");
});

test("It should print buzz for every 5th number", () => {
  let allNumbers = app.printNumbers();
  
  for (let i = 0; i < allNumbers.length; i++) {
    if (allNumbers[i] % 5 == 0) {
      expect(allNumbers[i]).toBe("buzz");
    }
  }
});
