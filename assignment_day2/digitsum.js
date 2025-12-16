let num1 = 123, s = 0;
while (num1 > 0) {
  s += num1 % 10;
  num1 = Math.floor(num1 / 10);
}
console.log(s);
