import { Component, OnInit } from '@angular/core';
import { TodoService } from '../../Services/todo.service';
import { Todo } from '../../Models/Todo';

@Component({
  selector: 'app-todos',
  templateUrl: './todos.component.html',
  styleUrls: ['./todos.component.css']
})
export class TodosComponent implements OnInit {

  todos: Todo[];

  constructor(private todoService:TodoService) { }

  ngOnInit() {
    //this.todos = this.todoService.getTodos
  }

}
