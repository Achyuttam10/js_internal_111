function isArmstrong(n) {
  let temp = n, sum = 0;
  let digits = n.toString().length;
  while (temp > 0) {
    let d = temp % 10;
    sum += d ** digits;
    temp = Math.floor(temp / 10);
  }
  return sum === n;
}
console.log(isArmstrong(153));
