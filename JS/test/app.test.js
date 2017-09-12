const app = require("../src/app");

test("it should print hello world", () => {
  expect(app.helloWorld()).toBe("hello world");
});
