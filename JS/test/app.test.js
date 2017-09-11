const app = require('../src/app');

const should = require('chai').should();
const expect = require('chai').expect;
const assert = require('chai').assert;

describe('app.js', function() {
  describe('helloWorld()', function() {
    it('should return the "hello world" string when invoking the function', function() {
      let result = app.helloWorld();

      assert.equal(result, 'hello world');
      expect(result).to.equal('hello world');
      result.should.equal('hello world');
    });
  });
});
