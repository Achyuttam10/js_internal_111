let nTerms = 7;
let a = 0, b = 1;
for (let i = 1; i <= nTerms; i++) {
  console.log(a);
  let next = a + b;
  a = b;
  b = next;
}
