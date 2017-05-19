const app = require('../src/app');

const should = require('chai').should();
const expect = require('chai').expect;
const assert = require('chai').assert;

describe('Test hello world', function() {
  describe('helloworld', function() {
    it('should return the hello world string invoking the helloworld function', function() {
      let helloWorldStr = app.helloWorld();

      assert.equal(helloWorldStr, 'hello world');
      expect(helloWorldStr).to.be.a('string');
      helloWorldStr.should.equal('hello world');
      helloWorldStr.should.have.lengthOf(11);
    });
  });
});
