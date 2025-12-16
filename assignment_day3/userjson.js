let user = { name: "Aman", age: 21, course: "JS" };

// Object → JSON
let jsonData = JSON.stringify(user);
console.log(jsonData);

// JSON → Object
let newUser = JSON.parse(jsonData);
console.log(newUser);
