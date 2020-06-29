import { Component, OnInit, ViewChild } from '@angular/core';
import * as fromApp from '../store/app.reducer';
import * as TodoActions from '../todo/store/todo.action';
import { Todo } from './todo.model';
import { Store } from '@ngrx/store';
import { NgForm } from '@angular/forms';

@Component({
  selector: 'app-todo',
  templateUrl: './todo.component.html',
  styleUrls: ['./todo.component.scss']
})
export class TodoComponent implements OnInit {
  @ViewChild('form') todoForm: NgForm;
  todos: Todo[];
  selectedTodo: Todo;

  constructor(private store: Store<fromApp.AppState>) {

  }

  ngOnInit(): void {
    this.store.select('todo').subscribe(todoState => {
      this.todos = todoState.todos;
    });
    this.store.dispatch(new TodoActions.GetTodos());
  }

  submit() {
    if (this.selectedTodo) {
      this.store.dispatch(new TodoActions.UpdateTodo({
        id: this.selectedTodo.id,
        note: this.todoForm.value.note
      }));
      this.selectedTodo = null;
    } else {
      this.store.dispatch(new TodoActions.CreateTodo({ note: this.todoForm.value.note }));
    }
    this.todoForm.reset();
  }

  deleteTodo(id: string) {
    this.store.dispatch(new TodoActions.DeleteTodo({ id: id }));
    if (this.selectedTodo?.id === id) {
      this.selectedTodo = null;
    }
  }

  selectTodo(todo: Todo) {
    this.selectedTodo = todo;
    const a = new Date();
    console.log(a);
    console.log(a.toJSON());
    a.setTime(a.getTime() + 3600000 * 8);
    console.log(a);
    console.log(a.toJSON());
  }

  unselectTodo() {
    this.selectedTodo = null;
  }
}
