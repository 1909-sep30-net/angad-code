import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class TodoService {

  constructor() { }

  getTodos() {
    return [
      {
        id: 1,
        title: 'Do Something!',
        completed: false
      },
      {
        id: 2,
        title: 'Do Something More!!',
        completed: false
      },
      {
        id: 3,
        title: 'Done?!',
        completed: true
      }
    ]
  }
}
