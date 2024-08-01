# Keyof - "as const"

## Keyof
- can be String or Numeric.
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

### Documentation
const person = { name: 'John', age: 30, hobbies: ['reading', 'coding' 'gaming'] as const};

