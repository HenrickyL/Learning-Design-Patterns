import { User } from '../interfaces/user';

export class MyDBClassic {
  private static _instance: MyDBClassic | null = null;
  private users: User[] = [];
  private constructor() {}

  public static get instance(): MyDBClassic {
    if (MyDBClassic.instance === null)
      MyDBClassic._instance = new MyDBClassic();
    return MyDBClassic.instance;
  }

  public add(user: User): void {
    this.users.push(user);
  }

  public remove(index: number): void {
    this.users.splice(index, 1);
  }

  show(): void {
    for (const user of this.users) {
      console.log(user);
    }
  }
}
