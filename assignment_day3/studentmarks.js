let marks = [80, 90, 70, 85, 95];

let total = marks.reduce((sum, m) => sum + m, 0);
let average = total / marks.length;

console.log("Average Marks:", average);
