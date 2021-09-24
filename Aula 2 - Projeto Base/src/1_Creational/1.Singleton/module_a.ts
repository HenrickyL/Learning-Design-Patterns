import { MyDBClassic } from './db/my-db-classic';

const db1 = MyDBClassic.instance;
db1.add({ name: 'henricky', age: 25 });
db1.add({ name: 'Maria', age: 21 });
db1.add({ name: 'Pedro', age: 22 });

db1.show();
