function calculate(a, b, op) {
  switch (op) {
    case '+': return a + b;
    case '-': return a - b;
    case '*': return a * b;
    case '/': return b !== 0 ? a / b : "Error";
    default: return "Invalid operator";
  }
}
console.log(calculate(10, 5, '*'));
