# Keyof - "as const"

## Keyof
- Key can be String or Numeric.
- makes a unique identifier/ object, and creates a union between a collection of values.

### Documentation
Ex. 1
- type Point = { x: number; y: number };
- type P = keyof Point;
- so, P: x | y

Ex. 2
- type Example = {name: string; age: number; 42: boolean;};
- type Keys = keyof Example; // "name" | "age" | 42

## "as const"
- makes a collection immutable
- makes a collection readonly


### Documentation
Ex. 1
- const myArray = [1, 2, 3]; (myArray can be changed)
- const myArray = [1, 2, 3] as const; (myArray cannot be changed)

Ex. 2
- const person = { name: 'John', age: 30, hobbies: ['reading', 'coding' 'gaming'] as const};

