import Image from "next/image";
import styles from "./page.modules.css"
import{Header} from "./component/Header"

interface User{

  name:string;
  age:number;
  email: string;

}

export default function Home() {

  const userName: string = "Michael";

  const sum = (a:number, b:number) => {
    return a + b;
  }

  const UserList: User[] = [


  ]

  return (
    <main>

        <h1>id = {styles.myHeading} Hey {userName}</h1>
        <p>Calculation: {sum(12,20)}</p>

        {
          UserList.map((user, index) => (
            <div key = {index}>
              <h3>Index{index}</h3>
              <h4>{user.name}</h4>
              <p>Age: {user.age}</p>
              <p>Email: {user.age}</p>
            </div>
          ))
        }

        <Header></Header>

    </main>
    
  );
}
