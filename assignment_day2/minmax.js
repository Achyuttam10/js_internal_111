function minMax(arr) {
  return {
    min: Math.min(...arr),
    max: Math.max(...arr)
  };
}
console.log(minMax([5, 2, 9, 1]));
