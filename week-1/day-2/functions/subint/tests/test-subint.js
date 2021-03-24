'use strict';

const test = require('tape');
const subint = require('../subint.js');

test('test subint() with number which exists in the list', t => {
  const listOfNumbers = [1, 11, 34, 52, 61];
  const expected = [0, 1, 4];

  t.deepEqual(subint(1, [1, 11, 34, 52, 61]), expected);
  t.end();
});

test('test subint() with number which doesn\'t exist in the list', t => {
  const listOfNumbers = [1, 11, 34, 52, 61];
  const expected = [];

  t.deepEqual(subint(9, [1, 11, 34, 52, 61]), expected);
  t.end();
});

test('test subint() with empty list', t => {
  t.deepEqual(subint([]), []);
  t.end();
});
