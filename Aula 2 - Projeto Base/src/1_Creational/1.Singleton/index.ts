export class Singleton {
  private static _instance: Singleton | null = null;
  private constructor() {}
  static get instance(): Singleton {
    if (Singleton._instance === null) Singleton._instance == new Singleton();
    return Singleton._instance;
  }
}

// eslint-disable-next-line prettier/prettier

const instance1 = Singleton.instance;
const instance2 = Singleton.instance;

console.log(instance1 === instance2);
