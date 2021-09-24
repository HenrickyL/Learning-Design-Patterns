import { User } from '../interfaces/user';

const users: User[] = [];

export const myDBModule = {
  add(user: User): void {
    users.push(user);
  },

  remove(index: number): void {
    users.splice(index, 1);
  },

  show(): void {
    for (const user of this.users) {
      console.log(user);
    }
  },
};
