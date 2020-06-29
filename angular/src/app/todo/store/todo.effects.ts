import { Injectable } from '@angular/core';
import { Actions, Effect, ofType } from '@ngrx/effects';
import { switchMap, map } from 'rxjs/operators';
import { HttpClient } from '@angular/common/http';
import * as fromApp from '../../store/app.reducer';

import * as TodoActions from './todo.action';
import { Todo } from '../todo.model';
import { Store } from '@ngrx/store';

@Injectable({
  providedIn: 'root'
})
export class TodoEffects {
  @Effect()
  getTodos = this.actions$.pipe(
    ofType(TodoActions.GET_TODOS),
    switchMap((getTodosAction: TodoActions.GetTodos) => {
      return this.http.get<Todo[]>('https://localhost:44380/api/todos');
    }),
    map(todos => {
      return new TodoActions.SetTodos({ todos: todos });
    })
  );

  @Effect({
    dispatch: false
  })
  createTodo = this.actions$.pipe(
    ofType(TodoActions.CREATE_TODO),
    switchMap((createTodoAction: TodoActions.CreateTodo) => {
      return this.http.post('https://localhost:44380/api/todos', { note: createTodoAction.payload.note });
    }),
    map(() => {
      this.store.dispatch(new TodoActions.GetTodos());
    })
  );

  @Effect({
    dispatch: false
  })
  deleteTodo = this.actions$.pipe(
    ofType(TodoActions.DELETE_TODO),
    switchMap((deleteTodoAction: TodoActions.DeleteTodo) => {
      return this.http.delete(`https://localhost:44380/api/todos/${deleteTodoAction.payload.id}`);
    }),
    map(() => {
      this.store.dispatch(new TodoActions.GetTodos());
    })
  );

  @Effect({
    dispatch: false
  })
  updateTodo = this.actions$.pipe(
    ofType(TodoActions.UPDATE_TODO),
    switchMap((updateTodoAction: TodoActions.UpdateTodo) => {
      console.log(updateTodoAction);
      return this.http.put(`https://localhost:44380/api/todos/${updateTodoAction.payload.id}`, {
        note: updateTodoAction.payload.note
      });
    }),
    map(() => {
      this.store.dispatch(new TodoActions.GetTodos());
    })
  );

  constructor(private actions$: Actions, private http: HttpClient, 
    private store: Store<fromApp.AppState>) {

  }
}