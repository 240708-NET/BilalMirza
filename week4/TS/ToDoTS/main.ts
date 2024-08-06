interface Task{
    description:string;
    dueDate : string;
}

const toDoList: Task[] = [];

const Form = document.querySelector<HTMLFormElement>('form');

// Create output for the result
const outputContainer = document.querySelector<HTMLUListElement>('#outputContainer');

// Create output for the result
const taskInput = document.querySelector<HTMLUListElement>('#outputContainer');

if (Form){
    Form.addEventListener('submit', (event: Event) => {
        event.preventDefault();
        console.log("test");

        
    })
}