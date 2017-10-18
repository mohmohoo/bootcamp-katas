const app = require("../src/app");

test("it should print hello world", () => {
  expect(app.helloWorld()).toBe("hello world");
});

test("It should print 1 as first number", () => {
  expect(app.printNumbers()[0]).toBe(1);
});

test("It should print 100 as last number", () => {
  expect(app.printNumbers().pop()).toBe(100);
});